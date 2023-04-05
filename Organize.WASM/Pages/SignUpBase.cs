using GeneralUI.DropdownControl;
using Organize.Shared.Enums;

namespace Organize.WASM.Pages;

public class SignUpBase : SignBase
{
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
 }
}