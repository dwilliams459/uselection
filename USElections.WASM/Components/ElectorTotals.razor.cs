using Microsoft.AspNetCore.Components;
using USElections.Shared;
using USElections.Shared.DTOs;
using USElections.WASM.Repos.USStates;

namespace USElections.WASM.Components
{
    public partial class ElectorTotals
    {
        [Parameter]
        public List<USStateDTO> USStates { get; set; }

        [Parameter]
        public EventCallback<USStateDTO> OnRefreshRequested { get; set; }

        public int RepublicanElectors()
        {
            return USStates.Where(s => s.Party == USStatePartyEnum.Republican).Sum(s => s.Electors);
        }

        public int DemocratElectors()
        {
            return USStates.Where(s => s.Party == USStatePartyEnum.Democrat).Sum(s => s.Electors);
        }

        public int UndecidedElectors()
        {
            return USStates.Where(s => s.Party == USStatePartyEnum.None).Sum(s => s.Electors);
        }

        public ElectorTotals()
        {
        }
    }
}
