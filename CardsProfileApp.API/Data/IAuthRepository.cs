using System.Threading.Tasks;
using CardsProfileApp.API.Models;

namespace CardsProfileApp.API.Data
{
    public interface IAuthRepository
    {
        Task<User>  Register(User user, string password);
        Task<User> Login(string username, string password);
        Task<bool> UserExist(string username);
    }
}

