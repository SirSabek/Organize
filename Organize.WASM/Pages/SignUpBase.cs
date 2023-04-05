using GeneralUI.DropdownControl;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Primitives;
using Organize.Shared.Enums;

namespace Organize.WASM.Pages;

public class SignUpBase : SignBase
{
     [Inject]
     private NavigationManager NavigationManager { get; set; }
     protected IList<DropdownItem<GenderTypeEnum>> GenderTypeDropdownItems { get; } = new List<DropdownItem<GenderTypeEnum>>();
     protected DropdownItem<GenderTypeEnum> selectedGenderTypeDropdownItem { get; set; }

     protected override void OnInitialized()
     { 
         base.OnInitialized();

         var male = new DropdownItem<GenderTypeEnum>()
         { 
             itemObject = GenderTypeEnum.Male,
             DisplayText = "Male"
         };
         var female = new DropdownItem<GenderTypeEnum>()
         {
              itemObject = GenderTypeEnum.Female,
              DisplayText = "Female"
         };

         GenderTypeDropdownItems.Add(male);
         GenderTypeDropdownItems.Add(female);

         selectedGenderTypeDropdownItem = male;
         TryGetUsernameFromUri();
     }


     public void TryGetUsernameFromUri()
     {
         var uri = NavigationManager.ToAbsoluteUri(NavigationManager.Uri);
         StringValues sv;
         if (QueryHelpers.ParseQuery(uri.Query).TryGetValue("username", out sv))
         {
            User.Username = sv;
         }

     }
     public void OnValidSubmit()
     {
         NavigationManager.NavigateTo("signin");
     }
}