using System.Threading.Tasks;
using Organize.Shared.Entities;

namespace Organize.Shared.Contracts
{
    public interface IUserManager
    {
        Task<User> TrySignInAndGetUserAsync(User user);
        Task InsertUserAsync(User user);
    }
}