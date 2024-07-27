using System.Collections.Generic;
using System.Threading.Tasks;
using USElections.Shared.DTOs;

namespace USElections.Repos.Interfaces
{
    public interface IUSStateRepo
    {
        Task<List<USStateDTO>> GetUSStates();
        Task<List<StateBulletsDTO>> GetStateBullets();
    }
}
