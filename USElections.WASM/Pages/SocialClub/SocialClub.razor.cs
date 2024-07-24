using USElections.Shared.SocialClub;
using USElections.WASM.Repository.SocialClub;
using Microsoft.AspNetCore.Components;

namespace USElections.WASM.Pages.SocialClub
{
    public partial class SocialClub : ComponentBase
    {
        [Inject]
        private ISocialClubRepository SocialClubRepository { get; set; } = default!;

        private SocialClubPageData PageData { get; set; } = new();

        protected override async Task OnInitializedAsync()
        {

            this.PageData.Events = await SocialClubRepository.GetSocialClubEvents() ?? [];

            StateHasChanged();
        }
    }
}
