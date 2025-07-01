using System.ComponentModel.DataAnnotations;
using WEB.Areas.Education.Models.Abstract;

namespace WEB.Areas.Admin.Models.CustomerManagerVM
{
    public class UpdateCustomerManagerVM : BasePersonVM
    {
        public Guid Id { get; set; }

        [Display(Name = "İşe Giriş Tarhi: ")]
        public DateOnly? HireDate { get; set; }


    }
}
