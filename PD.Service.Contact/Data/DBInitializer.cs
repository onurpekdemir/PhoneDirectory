using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PD.Service.Contact.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ContactContext context)
        {
            context.Database.EnsureCreated();

            if (context.Contacts.Any())
            {
                return;   
            }

            var contacts = new Models.Contact[]
            {
                new Models.Contact
                {
                    Name="Onur",
                    LastName="PEKDEMIR",
                    Firm = "OBSS",
                    ContactInfos = new List<Models.ContactInfo>{
                        new Models.ContactInfo { ContactInfoType = Models.ContactInfoType.EmailAddress,ContactInfoContent = "onurpekdemir@obss.com.tr" },
                        new Models.ContactInfo { ContactInfoType = Models.ContactInfoType.Location,ContactInfoContent = "Ankara" },
                        new Models.ContactInfo { ContactInfoType = Models.ContactInfoType.Location,ContactInfoContent = "İstanbul" },
                        new Models.ContactInfo { ContactInfoType = Models.ContactInfoType.PhoneNumber,ContactInfoContent = "+901111111" }
                    }
                },

                new Models.Contact
                {
                    Name="Orhan",
                    LastName="GECEN",
                    Firm = "OBSS",
                    ContactInfos = new List<Models.ContactInfo>{
                        new Models.ContactInfo { ContactInfoType = Models.ContactInfoType.EmailAddress,ContactInfoContent = "orhangecen@obss.com.tr" },
                        new Models.ContactInfo { ContactInfoType = Models.ContactInfoType.Location,ContactInfoContent = "Ankara" },
                        new Models.ContactInfo { ContactInfoType = Models.ContactInfoType.PhoneNumber,ContactInfoContent = "+902222222" }
                    }
                },

                new Models.Contact
                {
                    Name="Fatih",
                    LastName="ULUS",
                    Firm = "OBSS",
                    ContactInfos = new List<Models.ContactInfo>{
                        new Models.ContactInfo { ContactInfoType = Models.ContactInfoType.PhoneNumber,ContactInfoContent = "+901111111" }
                    }
                },

                new Models.Contact
                {
                    Name="Murat",
                    LastName="UNLUONEY",
                    Firm = "BuyBase",
                    ContactInfos = new List<Models.ContactInfo>{
                        new Models.ContactInfo { ContactInfoType = Models.ContactInfoType.EmailAddress,ContactInfoContent = "muratunluoney@buybase.com" },
                        new Models.ContactInfo { ContactInfoType = Models.ContactInfoType.Location,ContactInfoContent = "İstanbul" },
                        new Models.ContactInfo { ContactInfoType = Models.ContactInfoType.PhoneNumber,ContactInfoContent = "+901111111" }
                    }
                },

            };

            foreach (var c in contacts)
            {
                context.Contacts.Add(c);
            }

            context.SaveChanges();


        }
    }
}
