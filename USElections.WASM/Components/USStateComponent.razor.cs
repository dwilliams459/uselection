using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components;
using USElections.Shared.DTOs;

namespace USElections.WASM.Components
{
    public partial class USStateComponent
    {
        [Parameter]
        public string SvgPath { get; set; }

        [Parameter]
        public string StateName { get; set; }

        [Parameter]
        public int? GID { get; set; }

        [Parameter]
        public double? TranslateX { get; set; }

        [Parameter]
        public double? TranslateY { get; set; }

        [Parameter]
        public EventCallback<string> OnStateClicked { get; set; }

        public async Task OnStateClick(MouseEventArgs e)
        {
            await OnStateClicked.InvokeAsync(SvgPath);
        }
    }
}
