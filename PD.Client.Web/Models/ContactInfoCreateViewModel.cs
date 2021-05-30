using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PD.Client.Web.Models
{
    public class ContactInfoCreateViewModel
    {
        public ContactInfoType ContactInfoType { get; set; }
        public string ContactInfoContent { get; set; }
        public int ContactId { get; set; }
    }
}
