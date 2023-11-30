using PhoneBook.Domain.Enums;
using PhoneBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Services
{
    public class PhoneNumberService : IService<PhoneNumber>
    {
        public PhoneNumber Create(string value, int number)
        {
            var phoneNumber = new PhoneNumber()
            {
                Number = value,

                species = (Species)number
            };
            return phoneNumber;
        }

        public PhoneNumber Get(string value, IQueryable<PhoneNumber> queryable)
        {
             var result=queryable.FirstOrDefault(p=>p.Number==value);
            return result;
        }
        public void ShowNumber(PhoneNumber phoneNumber)
        {
            Console.WriteLine($"{phoneNumber.Number} : {phoneNumber.species}");
        }
     
    }
}
