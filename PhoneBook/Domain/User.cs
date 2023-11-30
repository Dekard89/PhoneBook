using PhoneBook.Domain.Enums;
using PhoneBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Domain
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<PhoneNumber>? phoneNumbers = new List<PhoneNumber>();

        public Category Category { get; set; }

        public void ShowAllNumber()
        {
            foreach(var phone in phoneNumbers)
            {
                phone.ShowNumber();
            }
        }

        public void Showuser()
        {
            Console.WriteLine($"{Name} -  {Category} : {ShowAllNumber}");
        }
    }
}
