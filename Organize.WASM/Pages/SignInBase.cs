using Microsoft.AspNetCore.Components;
using Organize.Business;

namespace Organize.WASM.Pages;

public class SignInBase : SignBase
{
   protected string DayOfWeek { get;} = DateTime.Now.DayOfWeek.ToString();

    [Inject]
    private NavigationManager NavigationManager { get; set; }

   protected async void OnSubmit()
   {
       if (EditContext.Validate())
       {
           return;
           
       }

       var userManager = new UserManager();
       var user = await userManager.TrySignInAndGetUserAsync(User);
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