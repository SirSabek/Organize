using System.Collections.ObjectModel;

namespace Organize.Shared.Entities
{
    public class ParentItem : BaseItem
    {
        public ObservableCollection<ChildItem> ChildItems { get; set; }
    }
}