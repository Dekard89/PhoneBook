using PhoneBook.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PhoneBook.Services
{
    internal class JsonContext : IJSONContext
    {
        private readonly string _path="file.json";
        public void Export(List<User> users)
        {
            var json=JsonSerializer.Serialize<List<User>>(users);
            File.WriteAllText(_path, json);
        }

        public List<User> Import()
        {
            List<User> users;
            File.ReadAllText(_path);
            users=JsonSerializer.Deserialize<List<User>>(_path);
            return users;
        }
    }
}
