using System.Collections.ObjectModel;
using Organize.Shared.Entities;
using Organize.Shared.Enums;

namespace Organize.Test
{
    public class TestData
    {
        public static User TestUser { get; set; }
        
        public static void CreateTestUser()
        {
            var user = new User
            {
                Id = 123,
                Username = "Ben",
                FirstName = "Benjamin",
                LastName = "Proft",
                Password = "test",
                Gender = GenderTypeEnum.Male,
                UserItems = new ObservableCollection<BaseItem>()
            };

            var textItem = new TextItem
            {
                ParentId = user.Id,
                Id = 1,
                Title = "Buy Apples",
                Subtitle = "Red | 5",
                Detail = "From New Zealand preferred",
                ItemTypeEnum = ItemTypeEnum.Text,
                Position = 1
            };
            user.UserItems.Add(textItem);

            var urlItem = new UrlItem
            {
                ParentId = user.Id,
                Id = 2,
                Title = "Buy Sunflowers",
                Url = "https://drive.google.com/file/d/1NXiNFLEUGUiNtkyzdHDtf-HDocFh3OJ0/view?usp=sharing",
                ItemTypeEnum = ItemTypeEnum.Url,
                Position = 2
            };
            user.UserItems.Add(urlItem);

            var parentItem = new ParentItem
            {
                ParentId = user.Id,
                Id = 3,
                Title = "Make Birthday Present",
                ItemTypeEnum = ItemTypeEnum.Parent,
                Position = 3,
                ChildItems = new ObservableCollection<ChildItem>()
            };
            user.UserItems.Add(parentItem);

            var childItem = new ChildItem
            {
                ParentId = parentItem.Id,
                Id = 4,
                Position = 1,
                Title = "Cut"
            };
            parentItem.ChildItems.Add(childItem);

            TestUser = user;
        }
    }
}