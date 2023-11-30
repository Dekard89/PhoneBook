using PhoneBook.Domain;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Models
{
    public interface IRepository<T>
    {
        void Add(T entity);

        IQueryable<T> GetAll();

        void Delete(T entity);

        T Update(T entity); 
    }
}
