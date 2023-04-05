using Microsoft.AspNetCore.Components;

namespace Organize.WASM.Pages;

public class SignInBase : SignBase
{
   protected string DayOfWeek { get;} = DateTime.Now.DayOfWeek.ToString();
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