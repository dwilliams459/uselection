using Microsoft.AspNetCore.Components;
using USElections.Shared.DTOs;
using USElections.WASM.Repos;

namespace USElections.WASM.Components
{
    public partial class USMap
    {
        private IUSStatesRepository _stateRepo;

        [Parameter]
        public List<USStateDTO> USStates { get; set; }

        public USMap(IUSStatesRepository stateRepo)
        {
            _stateRepo = stateRepo;
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
