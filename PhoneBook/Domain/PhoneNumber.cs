using PhoneBook.Domain;
using PhoneBook.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Models
{
    public class PhoneNumber
    {
        public int Id { get; set; }

        public string Number { get; set; }

        public Species species { get; set; }

        public User user { get; set; }

        public string ShowNumber()
        {
            return $"{Number} : {species}";
        }
    }

}
