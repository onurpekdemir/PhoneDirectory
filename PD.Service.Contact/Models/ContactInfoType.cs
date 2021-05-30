using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PD.Service.Contact.Models
{
    public enum ContactInfoType
    {
        [Display(Name = "Phone number")]
        PhoneNumber = 1,

        [Display(Name = "E-mail address")]
        EmailAddress = 2,

        [Display(Name = "Location")]
        Location = 3
    }
}
