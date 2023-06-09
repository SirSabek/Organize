﻿using Microsoft.AspNetCore.Components;
using Organize.Shared.Entities;

namespace Organize.WASM.Components;

public class ItemCheckBoxBase  : ComponentBase
{
    [Parameter] public BaseItem Item { get; set; }
    [CascadingParameter] public string ColorPrefix { get; set; }
}