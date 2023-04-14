using Organize.Shared.Entities;

namespace Organize.WASM.Components
{
    public partial class ItemEdit
    {
        private BaseItem Item { get; set; } = new BaseItem();
        private int TotalNumber { get; set; }
    }
}
