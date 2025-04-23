using Penzugyi_tervezo_WebApp.Models;
using System.Net.Http.Json;

namespace Penzugyi_tervezo_WebApp.Services
{
    public class UserService
    {
        private readonly HttpClient _http;

        public UserService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<User>> GetUsersAsync()
        {
            return await _http.GetFromJsonAsync<List<User>>("api/Users");
        }

        public async Task<User> GetUserAsync(int id)
        {
            return await _http.GetFromJsonAsync<User>($"api/Users/{id}");
        }

        public async Task<bool> UpdateUserAsync(User user)
        {
            var response = await _http.PutAsJsonAsync($"api/Users/{user.user_id}", user);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteUserAsync(int id)
        {
            var response = await _http.DeleteAsync($"api/Users/{id}");
            return response.IsSuccessStatusCode;
        }

        // New: Register a user
        public async Task<string?> RegisterAsync(UserRegisterDto registerDto)
        {
            var response = await _http.PostAsJsonAsync("api/Users/register", registerDto);
            if (response.IsSuccessStatusCode)
            {
                return "Registration successful.";
            }

            return await response.Content.ReadAsStringAsync();
        }

        // New: Login user
        public async Task<bool> LoginAsync(UserLoginDto loginDto)
        {
            try
            {
                // Debug: Check what's being sent
                Console.WriteLine($"Attempting login with: {loginDto.username}");

                var response = await _http.PostAsJsonAsync("api/Users/login", loginDto);

                // Debug: Check response status
                Console.WriteLine($"Login response: {response.StatusCode}");

                if (response.IsSuccessStatusCode)
                {
                    return true;
                }

                // Debug: Read error content if available
                var errorContent = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"Login error: {errorContent}");
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Login exception: {ex.Message}");
                return false;
            }
        }
    }
}
