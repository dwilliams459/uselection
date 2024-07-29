using Microsoft.AspNetCore.Components;
using USElections.Data.Models;
using USElections.Shared.DTOs;
using USElections.WASM.Repos.USStates;

namespace USElections.WASM.Components;

public partial class USMap : ComponentBase
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

    private async Task HandleRefreshRequested()
    {
        // Trigger the redraw of ElectorTotals
        //await ElectorTotals.HandleRefreshRequested();
    }

    private void TriggerElectorTotalsRedraw(USStateDTO updatedState)
    {
        // StateHasChanged();
        USStates.FirstOrDefault(s => s.Name == updatedState.Name).Party = updatedState.Party;
    }

    private void HandleOnStateUpdated(USStateDTO updatedState)
    {
        // Your existing logic
        USStates.FirstOrDefault(s => s.Name == updatedState.Name).Party = updatedState.Party;
        //TriggerElectorTotalsRedraw(updatedState);
    }
}

