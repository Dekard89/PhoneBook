using PhoneBook.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Models
{
    public class PhoneNumbersRepository : IRepository<PhoneNumber>
    {
        public User user { get; set; }

        public PhoneNumbersRepository()
        {
            User user = null;
        }
       
        public void Add(PhoneNumber entity)
        {
            user.phoneNumbers.Add(entity);
        }

        public void Delete(PhoneNumber entity)
        {
            user.phoneNumbers.Remove(entity);
        }

        public IQueryable<PhoneNumber> GetAll()
        {
            return user.phoneNumbers.AsQueryable();
        }

        public PhoneNumber Update(PhoneNumber entity)
        {
            var result=user.phoneNumbers.FirstOrDefault(p=>p.Number==entity.Number);
            result = entity;
            return result;
        }
    }
}
