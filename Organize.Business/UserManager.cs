using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Organize.Shared.Entities;

namespace Organize.Business
{
    public class UserManager
    {
        public async Task<User> TrySignInAndGetUserAsync(User user)
        {
            return await Task.FromResult(new User());
        }

        public async Task InsertUserAsync(User user)
        {
            await Task.FromResult(true);
        }
    }
}
