using Microsoft.AspNetCore.Components;
using Organize.Shared.Contracts;

namespace Organize.WASM.Shared;

public partial class MainLayout : LayoutComponentBase
{
    [Inject] public ICurrentUserService CurrentUserService { get; set; }
    protected void SignOut()
    {
        
    }
}