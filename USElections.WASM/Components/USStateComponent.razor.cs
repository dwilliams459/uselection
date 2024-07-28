using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components;
using USElections.Shared.DTOs;
using USElections.Data.Models;
using USElections.Shared;
using System.Text;

namespace USElections.WASM.Components
{
    public partial class USStateComponent
    {
        [Parameter]
        public USStateDTO State { get; set; }

        public string FillColor
        {
            get
            {
                return State.Party switch
                {
                    USStatePartyEnum.Republican => "#ff4d4d",
                    USStatePartyEnum.Democrat => "#6666ff",
                    _ => "#88a4bc"
                };
            }
        }

        [Parameter]
        public EventCallback<string> OnStateClicked { get; set; }

        [Parameter]
        public EventCallback<USStateDTO> OnStateUpdated { get; set; }

        public static object StatePartyEnum { get; private set; } = USStatePartyEnum.None;

        private void OnStateClick(MouseEventArgs e)
        {
            State.Party = State.Party switch
                {
                    USStatePartyEnum.Republican => USStatePartyEnum.Democrat,
                    USStatePartyEnum.Democrat => USStatePartyEnum.None,
                    _ => USStatePartyEnum.Republican
                };
            State.Party = State.Party;

            OnStateUpdated.InvokeAsync(State);
        }

        public MarkupString BulletText()
        {
            StringBuilder bulletText = new StringBuilder();

            bulletText.AppendLine($"<text x='{State.TextX}' y='{State.TextY}' text-anchor='middle' font='10px &quot;Arial&quot;' stroke='none' fill='#d5ddec' style='-webkit-tap-highlight-color: rgba(0, 0, 0, 0); text-anchor: middle; font: bold 22px Arial; cursor: pointer; opacity: 1;' stroke-width='0' font-size='22px' font-weight='bold' font-family='Arial' opacity='1' transform='matrix(1,0,0,1,0,0)' class='sm_label sm_label_{State.Name}'>");
            bulletText.AppendLine($"    <tspan dy='7.5' style='-webkit-tap-highlight-color: rgba(0, 0, 0, 0);'>{State.Name}</tspan>");
            bulletText.AppendLine("</text>");

            return new MarkupString(bulletText.ToString());

        }
    }
}
