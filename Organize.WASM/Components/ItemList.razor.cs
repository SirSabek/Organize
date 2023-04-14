using System.Collections.ObjectModel;
using System.Text.Json;
using Microsoft.AspNetCore.Components;
using Organize.Shared.Contracts;
using Organize.Shared.Entities;

namespace Organize.WASM.Components;

public partial class ItemList
{
    [Inject]
    private ICurrentUserService currentUserService { get; set; }
    protected ObservableCollection<BaseItem> UserItems { get; set; } = new ObservableCollection<BaseItem>();
    protected override void OnInitialized()
    {
        base.OnInitialized();
        UserItems = currentUserService.CurrentUser.UserItems;
        Console.WriteLine(JsonSerializer.Serialize(UserItems));
    }
}