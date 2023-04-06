using System;
using System.Threading.Tasks;
using Organize.Shared.Contracts;
using Organize.Shared.Entities;

namespace Organize.Test
{
    public class UserManagerTest: IUserManager
    {
        public Task<User> TrySignInAndGetUserAsync(User user)
        {
            Console.WriteLine("UserManagerTest.InsertUserAsync");
            return Task.FromResult(new User());
        }

        public Task InsertUserAsync(User user)
        {
            return Task.FromResult(true);
        }
    }
}