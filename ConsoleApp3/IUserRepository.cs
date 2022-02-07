using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public interface IUserRepository

    {
        Task AddUser(User user);
        Task<User> GetUser(int UserId);
        Task<List<User>> GetOrderedUsers();
    }
}
