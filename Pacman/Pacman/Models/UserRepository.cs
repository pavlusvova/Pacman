using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pacman.Models
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _appDbContext;

        public UserRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void AddUser(User user)
        {
            _appDbContext.Users.Add(user);
            _appDbContext.SaveChanges();
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _appDbContext.Users;
        }

        public User GetUserById(int userId)
        {
            return _appDbContext.Users.FirstOrDefault(p => p.Id == userId);
        }
    }
}
