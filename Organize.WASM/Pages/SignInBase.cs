using System.Linq.Expressions;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Organize.Shared.Entities;

namespace Organize.WASM.Pages;

public class SignInBase : ComponentBase
{
   protected string DayOfWeek { get;} = DateTime.Now.DayOfWeek.ToString();
   protected string Username { get; set; } = "ben";
   protected User User { get; set; }
   protected EditContext EditContext { get; set; }

   public SignInBase()
   {
       User = new User();
   }

   protected override void OnInitialized()
   {
       base.OnInitialized();
       EditContext = new EditContext(User);
   }

   protected void HandleUserNameChanged(ChangeEventArgs e)
   {
        Username = e.Value.ToString();
   }
   
   protected void HandelUserNameValueChanged(string value)
   {
        Username = value;
   }

   public string GetError(Expression<Func<object>> fu)
   {
        return EditContext == null ? null : EditContext.GetValidationMessages(fu).FirstOrDefault();
   }
}