using PhoneBook.Domain;
using PhoneBook.Domain.Enums;
using PhoneBook.Models;

namespace PhoneBook.Services
{
    public class UserService : IService<User>
    {
       public UserRepository userRepository {  get; set; }

       
        public User Create(string value, int number)
        {
            User user = new User()
            {
                Name = value,
                Category = (Category)number
            };
            return user;
        }
        public User? Get(string name, IQueryable<User> users)
        {
            var result=users.FirstOrDefault(x => x.Name == name);
            return result;
        }
        public IEnumerable<User> GetAllCategory(Category category,IQueryable<User> users)
        {
           return users.Where(x => x.Category == category).ToList();
        }
        public IEnumerable<User?> GetForString(string str,IQueryable<User> users)
        {
            return users.Where(x=>x.Name.Contains(str)).ToList();
        }
        public void ShowAllUser(IQueryable<User> users)
        {
            foreach(var user in users)
            {
                user.Showuser();
            }
        }

        
    }
}
