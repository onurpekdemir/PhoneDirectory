using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PD.Client.Web.Models
{
    public class ContactQueryWithInfoViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Firm { get; set; }

        public List<ContactInfoQueryViewModel> ContactInfoList { get; set; }
    }
}
