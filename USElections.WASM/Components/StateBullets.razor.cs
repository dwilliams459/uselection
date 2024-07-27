using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components;
using USElections.Shared.DTOs;
using USElections.Data.Models;
using USElections.Shared;

namespace USElections.WASM.Components
{


    public partial class USStateBullets
    {
        [Parameter]
        public USStateDTO State { get; set; }

        public string FillColor { get 
        {
            return StateParty switch
            {
                USStatePartyEnum.Republican => "red",
                USStatePartyEnum.Democrat => "blue",
                _ => "white"
            };
        } } 

        // public decimal TransformX { get; set; } = -306;
        // public decimal TransformY { get; set; } = -409;

        [Parameter]
        public USStatePartyEnum StateParty { get; set; } = USStatePartyEnum.None;

        // public decimal? TextLocationX() => (State.TextLocationX + TransformX);
        // public decimal? TextLocationY() => (State.TextLocationY + TransformY);

        public string mousePointerMessage = string.Empty;

        [Parameter]
        public EventCallback<string> OnStateClicked { get; set; }

        // public async Task OnStateClick(MouseEventArgs e)
        // {
        //     await OnStateClicked.InvokeAsync(State.Path);
        // }

        private void OnStateClick(MouseEventArgs e)
        {
            Console.WriteLine("OnStateClick");
            mousePointerMessage = $"Mouse coordinates: {e.ScreenX}:{e.ScreenY}";
            StateParty = (StateParty == USStatePartyEnum.Republican) ? USStatePartyEnum.Democrat : USStatePartyEnum.Republican;
        }
    }
}
