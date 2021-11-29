using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp2.Model
{
    public class PersonDetail
    {
        public string Surname { get; set; }
        public string Firstname { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public List<PersonDetail> Children { get;}

    }
}
