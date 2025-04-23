namespace Penzugyi_tervezo_WebApp.Services
{
    public class UserSessionService
    {
        public bool IsLoggedIn { get; private set; }

        public void Login() => IsLoggedIn = true;
        public void Logout() => IsLoggedIn = false;
    }

}
