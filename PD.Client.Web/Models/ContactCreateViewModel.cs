using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PD.Client.Web.Models
{
    public class ContactCreateViewModel
    {
        [Required(ErrorMessage ="Contact name field is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Contact last name field is required")]
        public string LastName { get; set; }

        public string Firm { get; set; }
    }
}
