using MauiApp2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp2.ViewModel
{
    public class PersonDetailViewModel
    {

        public List <PersonDetail> setData = new List<PersonDetail>
        {
           new PersonDetail{
            Surname ="P",
            Firstname ="T",
            PhoneNumber="080",
            Address ="No 8A",
            },

            new PersonDetail{
            Surname ="P2",
            Firstname ="T2",
            PhoneNumber="0801",
            Address ="No 8B",
            },
            new PersonDetail{
            Surname ="P3",
            Firstname ="T3",
            PhoneNumber="0803",
            Address ="No 8C",
            },
            new PersonDetail{
            Surname ="P4",
            Firstname ="T4",
            PhoneNumber="0804",
            Address ="No 8D",
            }

        };
      
            
    }

    
}
