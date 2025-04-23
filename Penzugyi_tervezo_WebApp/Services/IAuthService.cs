using System.Threading.Tasks;
using Penzugyi_tervezo_WebApp.Models;

namespace YourProjectName.Services
{
    public interface IAuthService
    {
        Task<bool> LoginAsync(string email, string password);
        Task<bool> RegisterAsync(User user);
        Task<bool> ResetPasswordAsync(string email);
        Task LogoutAsync();
        Task<User> GetCurrentUserAsync();
        Task<bool> IsAuthenticatedAsync();
    }
}
