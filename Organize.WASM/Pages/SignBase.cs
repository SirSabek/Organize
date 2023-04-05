using Microsoft.AspNetCore.Components;
using System.Linq.Expressions;
using Microsoft.AspNetCore.Components.Forms;
using Organize.Shared.Entities;

namespace Organize.WASM.Pages;

public class SignBase : ComponentBase
{
    protected User User { get; set; }
    protected EditContext EditContext { get; set; }

    public SignBase()
    {
        User = new User();
    }

    protected override void OnInitialized()
    {
        base.OnInitialized();
        EditContext = new EditContext(User);
    }
    
    public string GetError(Expression<Func<object>> fu)
    {
        return EditContext == null ? null : EditContext.GetValidationMessages(fu).FirstOrDefault();
    }
}