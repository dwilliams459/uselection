using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components;
using USElections.Shared.DTOs;
using USElections.Data.Models;

namespace USElections.WASM.Components
{
    public partial class USStateComponent
    {
        [Parameter]
        public USStateDTO State { get; set; }

        [Parameter]
        public EventCallback<string> OnStateClicked { get; set; }

        public async Task OnStateClick(MouseEventArgs e)
        {
            await OnStateClicked.InvokeAsync(State.Path);
        }
    }
}
