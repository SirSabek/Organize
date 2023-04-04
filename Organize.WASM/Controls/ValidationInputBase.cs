using Microsoft.AspNetCore.Components;

namespace Organize.WASM.Controls;

public class ValidationInputBase : ComponentBase
{
    [Parameter]
    public EventCallback<string> ValueChanged { get; set; }
    
    [Parameter]
    public string Value { get; set; }
    
    [Parameter]
    public string Error { get; set; }
    
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string,object> InputAttributes { get; set; }
    
    protected async void OnValueChanged(ChangeEventArgs e)
    {
       await ValueChanged.InvokeAsync(e.Value.ToString());
    }
}