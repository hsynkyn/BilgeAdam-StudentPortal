using System.ComponentModel.DataAnnotations;
using WEB.Areas.Education.Models.Abstract;

namespace WEB.Areas.Admin.Models.CustomerManagerVM
{
    public class GetCustomerManagerVM : BasePersonVM
    {
        public required Guid Id { get; set; }

        public required DateOnly HireDate { get; set; }

        public required DateTime CreatedDate { get; set; }

        public required string UpdatedDate { get; set; }
        public required string Status { get; set; }
    }
}
