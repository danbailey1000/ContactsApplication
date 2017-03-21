using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactsApplication.Model
{
    public class ContactData
    {
        // ReSharper disable once InconsistentNaming
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TelNo { get; set; }
    }
}
