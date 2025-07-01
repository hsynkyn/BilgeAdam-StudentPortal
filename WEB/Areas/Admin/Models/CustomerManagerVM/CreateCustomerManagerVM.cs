using System.ComponentModel.DataAnnotations;
using WEB.Areas.Education.Models.Abstract;

namespace WEB.Areas.Admin.Models.CustomerManagerVM
{
    public class CreateCustomerManagerVM : BasePersonVM
    {
        [Display(Name = "İşe Giriş Tarihi: ")]
        public DateOnly? HireDate { get; set; }


    }
}
