using Microsoft.AspNetCore.Components;
using USElections.Shared.DTOs;
using USElections.WASM.Repos.USStates;

namespace USElections.WASM.Components
{
    public partial class USMap
    {
        [Inject]
        private IUSStatesRepository _stateRepo { get; set; }

        [Parameter]
        public List<USStateDTO> USStates { get; set; }

        public USMap()
        {
            USStates = new List<USStateDTO>();
        }

        public async Task InitializeAsync()
        {
            USStates = await _stateRepo.GetUSStates();
        }

        protected override async Task OnInitializedAsync()
        {
            await InitializeAsync();
        }
    }
}
