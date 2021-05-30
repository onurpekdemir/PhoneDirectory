using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PD.Client.Web.Models
{
    public class ContactQueryWithInfoViewModel
    {
        public ContactQueryViewModel Contact { get; set; }
        public List<ContactQueryWithInfoViewModel> ContactInfoList { get; set; }
    }
}
