using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components;
using USElections.Shared.DTOs;
using USElections.Data.Models;
using USElections.Shared;
using System.Text;
using System;

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
                    _ => "#ccc"
                };
            }
        }

        public string FillClass
        {
            get
            {
                return State.Party switch
                {
                    USStatePartyEnum.Republican => "state-republican",
                    USStatePartyEnum.Democrat => "state-democrat",
                    _ => "state-none"
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

        public MarkupString LabelText()
        {
            StringBuilder bulletText = new StringBuilder();

            bulletText.AppendLine(LabelTextState(State.LabelX, State.LabelY, FillClass, State.Name));

            if(State.Name == "ME")
            {
                bulletText.AppendLine(LabelTextState(893, 85, FillClass, "ME"));
            }
            else if (State.Name == "NE")
            {
                bulletText.AppendLine(LabelTextState(420, 225, FillClass, "NE"));
            }

            return new MarkupString(bulletText.ToString());
        }

        private string LabelTextState(decimal? labelX, decimal? labelY, string fillClass, string stateName)
        {
            StringBuilder bulletText = new StringBuilder();

            bulletText.Append($"<text x='{labelX ?? 0}' y='{(labelY ?? 0) - 3}' text-anchor='middle' font='10px &quot;Arial&quot;' stroke='none' class='sm_label {fillClass}-label' ");
            bulletText.AppendLine($" stroke-width='0' opacity='1'  transform='matrix(1,0,0,1,0,0)'  >");
            bulletText.AppendLine($"    <tspan dy='7.5' style='-webkit-tap-highlight-color: rgba(0, 0, 0, 0);'>{stateName}</tspan>");
            bulletText.AppendLine("</text>");

            return bulletText.ToString();
        }
    }
}
