using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Enums
{
    public enum StudentStatus
    {
        [Display(Name ="Mezun")]
        Success =1,

        [Display(Name = "Devam Ediyor")]
        Continue,

        [Display(Name = "Kaldı")]
        Failed
    }
}
