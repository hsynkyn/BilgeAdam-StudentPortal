using Business.Manager.Concrete;
using Business.Manager.Interface;
using DTO.Concrete.RoleDTO;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace WEB.Areas.Admin.TagHelpers
{
    [HtmlTargetElement("td", Attributes = "user-role")]
    public class RoleTagHelper(IRoleManager roleManager, IUserManager userManager) : TagHelper
    {
        [HtmlAttributeName("user-role")]
        public string RoleId { get; set; }


        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            var role = await roleManager.GetRoleByIdAsync<GetRoleDTO>(Guid.Parse(RoleId));

            var userNames = await userManager.GetUserNamesHasRoleAsync(role!.Name);

            output.Content.SetContent
            (
                userNames.Count == 0
                    ? "Bu rolde hiçbir kullanıcı yoktur!!"
                    : userNames.Count > 3
                        ? string.Join(", ", userNames.Take(3)) + "..."
                        : string.Join(", ", userNames)
            );
        }


    }
}

