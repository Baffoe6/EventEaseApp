using System;

namespace EventEaseApp.Data
{
    public class UserSessionService
    {
        public string UserName { get; private set; }
        public bool IsLoggedIn { get; private set; }

        public void Login(string userName)
        {
            if (string.IsNullOrEmpty(userName))
            {
                throw new ArgumentException("User name cannot be null or empty", nameof(userName));
            }

            UserName = userName;
            IsLoggedIn = true;
        }

        public void Logout()
        {
            UserName = null!;
            IsLoggedIn = false;
        }
    }
}