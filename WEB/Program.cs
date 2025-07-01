using System.Reflection;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using DataAccess.Context;
using FluentValidation.AspNetCore;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using WEB.Autofac;
using Core.IdentityEntities;
using Microsoft.AspNetCore.Identity;
using WEB.ActionFilters;

var builder = WebApplication.CreateBuilder(args);

// Yaþam Döngüsünü Tanýmladýk (Life Cycle)
// AutofacServiceProviderFactory : Bu kodun çalýþmasý için Autofac.Extensions.DependencyInjection paketinin kurulmasý gerekir!! 
builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory()).ConfigureContainer<ContainerBuilder>(builder =>
{
    builder.RegisterModule(new AutofacModule());
});


// Eðer ki FluentValidation kullanmak isteniyorsa aþaðýdaki 3 methodu kullanmak zorundayýz!!!

// Abstract validator'dan miras almýþ validator'larý bulup otomatik olarak sisteme ekler. Örnek : CreateDepartmentValidator
builder.Services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

// FluentValidation'ý ASP .NET Core model binding sürecine entegre eder. Yani MVC Controller üzerinden gelen request'lerin otomatik olarak validasyonunu saðlar.
builder.Services.AddFluentValidationAutoValidation();

// FluentValidation'ýn Client-Side(Ön Yüz) validasyon desteðiniz saðlar. MVC View'lerde kullanýlýr.
builder.Services.AddFluentValidationClientsideAdapters();

// Add services to the container.
builder.Services.AddControllersWithViews(options =>
{
    options.Filters.Add<ValidateModelWithTempDataAttribute>();
});

var entitySQLConnection = builder.Configuration.GetConnectionString("EntityPostgreSQLConnection");

var identitySQLConnection = builder.Configuration.GetConnectionString("IdentityPostgreSQLConnection");

builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseNpgsql(entitySQLConnection);
});
builder.Services.AddDbContext<AppIdentityDbContext>(options =>
{
    options.UseNpgsql(identitySQLConnection);
});

builder.Services.AddIdentity<AppUser, AppRole>(x =>
{
    x.SignIn.RequireConfirmedPhoneNumber = false;
    x.SignIn.RequireConfirmedEmail = false;
    x.SignIn.RequireConfirmedAccount = false;
    x.User.RequireUniqueEmail = true;
    x.Password.RequiredLength = 3;
    x.Password.RequiredUniqueChars = 0;
    x.Password.RequireNonAlphanumeric = false;
    x.Password.RequireUppercase = false;
    x.Password.RequireLowercase = false;
    x.Lockout.MaxFailedAccessAttempts = 5; // Þifreyi 5 kere yanlýþ girerse
    x.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5); // 5 dakika boyunca hesabý dondur. 
}).AddEntityFrameworkStores<AppIdentityDbContext>()
.AddDefaultTokenProviders();

builder.Services.Configure<DataProtectionTokenProviderOptions>(options =>
{
    options.TokenLifespan = TimeSpan.FromMinutes(5);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
            name: "areas",
            pattern: "{area:exists}/{controller=Dashboard}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
