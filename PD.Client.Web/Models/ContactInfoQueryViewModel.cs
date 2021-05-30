using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PD.Client.Web.Models
{
    public class ContactInfoQueryViewModel
    {
        public int ID { get; set; }
        public string ContactInfoType { get; set; }
        public string ContactInfoContent { get; set; }
    }
}
