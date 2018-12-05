using System.Threading.Tasks;
using CardsProfileApp.API.Models;

namespace CardsProfileApp.API.Data
{
    public interface IPSRepository
    {
         Task<PSProfile> GetProfile(int profileId);
         Task<bool> SaveAll();
    }
}