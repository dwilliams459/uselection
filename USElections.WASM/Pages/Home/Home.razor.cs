using USElections.Shared.DTOs;
//using USElections.WASM.Repository;
//using USElections.WASM.Repository.SocialClub;
using Microsoft.AspNetCore.Components;

namespace USElections.WASM.Pages.Home
{
    public partial class Home
    {
        //[Inject]
        //private IHomeRepository HomeRepository { get; set; } = default!;
        //private IEnumerable<EventDTO> Events { get; set; } = Enumerable.Empty<EventDTO>();

        protected override async Task OnInitializedAsync()
        {

            //this.Events = await HomeRepository.GetEvents() ?? [];

            StateHasChanged();
        }
    }
}
