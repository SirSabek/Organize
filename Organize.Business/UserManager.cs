using System;
using System.Threading.Tasks;
using Organize.Shared.Contracts;
using Organize.Shared.Entities;

namespace Organize.Business
{
    public class UserManager : IUserManager
    {
        public async Task<User> TrySignInAndGetUserAsync(User user)
        {
            Console.WriteLine("UserManager.TrySignInAndGetUserAsync");
            return await Task.FromResult(new User());
        }

        public async Task InsertUserAsync(User user)
        {
            await Task.FromResult(true);
        }
    }
}
