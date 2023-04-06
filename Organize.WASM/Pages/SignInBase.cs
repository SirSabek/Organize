using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Organize.Business;
using Organize.Shared.Contracts;
using Organize.Shared.Entities;

namespace Organize.WASM.Pages;

public class SignInBase : SignBase
{
    protected string DayOfWeek { get;} = DateTime.Now.DayOfWeek.ToString();

    [Inject]
    private NavigationManager NavigationManager { get; set; }

    [Inject] 
    private IUserManager UserManager { get; set; }

    protected override void OnInitialized()
    {
        base.OnInitialized();
        User = new User
        {
            FirstName = "test",
            LastName = "test",
            PhoneNumber = "123456"
        };

        EditContext = new EditContext(User);
    }

    protected async void OnSubmit()
   {
       if (!EditContext.Validate())
       {
           return;
       }

       var user = await UserManager.TrySignInAndGetUserAsync(User);
       if (user != null)
       {
            NavigationManager.NavigateTo("item");
       }
   }
   
   // protected string Username { get; set; } = "ben";
   //
   //
   // protected void HandleUserNameChanged(ChangeEventArgs e)
   // {
   //      Username = e.Value.ToString();
   // }
   //
   // protected void HandelUserNameValueChanged(string value)
   // {
   //      Username = value;
   // }
}