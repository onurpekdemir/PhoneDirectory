using System.ComponentModel.DataAnnotations;

namespace PD.Client.Web.Models
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