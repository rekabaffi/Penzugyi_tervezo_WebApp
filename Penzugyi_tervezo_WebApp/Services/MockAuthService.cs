//using Penzugyi_tervezo_WebApp.Models;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Penzugyi_tervezo_WebApp.Models;

//namespace YourProjectName.Services
//{
//    public class MockAuthService : IAuthService
//    {
//        private List<User> _users = new()
//        {
//            new User { Id = 1, Email = "test@example.com", Password = "test123", Name = "Teszt Felhasználó" }
//        };

//        private User _currentUser = null;

//        public Task<bool> LoginAsync(string email, string password)
//        {
//            var user = _users.FirstOrDefault(u => u.Email == email && u.Password == password);
//            _currentUser = user;
//            return Task.FromResult(user != null);
//        }

//        public Task<bool> RegisterAsync(User user)
//        {
//            user.Id = _users.Max(u => u.Id) + 1;
//            _users.Add(user);
//            return Task.FromResult(true);
//        }

//        public Task<bool> ResetPasswordAsync(string email)
//        {
//            return Task.FromResult(_users.Any(u => u.Email == email));
//        }

//        public Task LogoutAsync()
//        {
//            _currentUser = null;
//            return Task.CompletedTask;
//        }

//        public Task<User> GetCurrentUserAsync()
//        {
//            return Task.FromResult(_currentUser);
//        }

//        public Task<bool> IsAuthenticatedAsync()
//        {
//            return Task.FromResult(_currentUser != null);
//        }
//    }
//}