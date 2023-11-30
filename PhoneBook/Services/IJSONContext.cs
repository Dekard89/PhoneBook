using PhoneBook.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Services
{
    public interface IJSONContext
    {
        void Export( List<User> users);

        List<User> Import();
    }
}
