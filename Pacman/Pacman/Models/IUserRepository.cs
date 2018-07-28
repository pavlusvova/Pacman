using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pacman.Models
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAllUsers();
        void AddUser(User user);
        User GetUserById(int userId);

    }
}
