using PhoneBook.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Services
{
    public interface IService<T>
    {
        T Create(string value, int number);

       

        T Get(string name, IQueryable<T> queryable);
    }
}
