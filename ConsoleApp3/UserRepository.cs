using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class UserRepository : IUserRepository
    {
        private UserContext Context;

        public UserRepository(UserContext Context)
        {
            this.Context = Context;
        }
        public async Task AddUser(User user)
        {
            Context.Users.Add(user);

            await Context.SaveChangesAsync();

        }

        public async Task<List<User>> GetOrderedUsers()
        {
            List<User> users = await Context.Users.OrderBy(x => x.userid).ToListAsync();
            return users;
        }

        public async Task<User> GetUser(int UserId)
        {
            User user = await Context.Users.FirstOrDefaultAsync(x => x.userid == UserId);
            return user;
        }
    }
}
