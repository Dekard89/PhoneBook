using PhoneBook.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Models
{
    public class UserRepository : IRepository<User>
    {
        private readonly ApplicationContext _context;

        public event Action<string> RepoEventHadler;

        public UserRepository(ApplicationContext applicationContext)
        {
            _context=applicationContext;
        }
        public void Add(User entity)
        {
            _context.Users.Add(entity);
            _context.SaveChanges();
            RepoEventHadler?.Invoke($"Контакт {entity.Name} добавлен");
        }

        public void Delete(User entity)
        {
            _context.Users.Remove(entity);
            _context.SaveChanges();
            RepoEventHadler?.Invoke($"Контакт {entity.Name} удален");
        }

        public IQueryable<User> GetAll()
        {
            return _context.Users;
            RepoEventHadler?.Invoke("Все контаксты получены");
        }

        public User Update(User entity)
        {
            _context.Users.Update(entity);
            _context.SaveChanges();
            RepoEventHadler?.Invoke($"Контакт {entity.Name} изменен");
            return entity;
        }
    }
}
