using Organize.Shared.Entities;

namespace Organize.Shared.Contracts
{
    public interface ICurrentUserService
    {
        User CurrentUser { get; set; }
    }
}