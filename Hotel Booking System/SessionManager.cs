namespace Hotel_Booking_System
{
    public class UserAccount
    {
        public int Id { get; set; }
        public string FullName { get; set; } = "";
        public string Email { get; set; } = "";
        public string Phone { get; set; } = "";
        public string Password { get; set; } = "";
        public string Role { get; set; } = "Customer"; // "Customer" or "Admin"
    }

    public static class SessionManager
    {
        public static bool IsLoggedIn { get; private set; } = false;
        public static int CurrentUserId { get; private set; } = 0;
        public static string CurrentUserName { get; private set; } = "";
        public static string CurrentUserEmail { get; private set; } = "";
        public static string CurrentUserRole { get; private set; } = ""; // "Customer" or "Admin"

        public static event Action? OnSessionChanged;

        // In-memory user database (Ready for database integration in Step 3)
        private static readonly List<UserAccount> registeredUsers = new List<UserAccount>
        {
            new UserAccount
            {
                Id = 1,
                FullName = "John Doe",
                Email = "john@example.com",
                Phone = "+855 12 345 678",
                Password = "123456",
                Role = "Customer"
            },
            new UserAccount
            {
                Id = 2,
                FullName = "Master Administrator",
                Email = "admin@grandstay.com",
                Phone = "+855 23 999 888",
                Password = "admin123",
                Role = "Admin"
            }
        };

        public static bool Register(string fullName, string email, string phone, string password, out string errorMessage)
        {
            errorMessage = "";

            // Try MySQL database registration first
            if (DatabaseHelper.RegisterUser(fullName, email, phone, password, out int newId, out string dbError))
            {
                Login(newId, fullName, email, "Customer");
                return true;
            }

            // If database reported a duplicate or specific validation error, return it
            if (dbError.Contains("already registered", StringComparison.OrdinalIgnoreCase))
            {
                errorMessage = dbError;
                return false;
            }

            // Fallback to in-memory registration if database is offline
            if (registeredUsers.Any(u => u.Email.Equals(email, StringComparison.OrdinalIgnoreCase)))
            {
                errorMessage = "An account with this email address already exists.";
                return false;
            }

            int nextId = registeredUsers.Count > 0 ? registeredUsers.Max(u => u.Id) + 1 : 1;
            var newUser = new UserAccount
            {
                Id = nextId,
                FullName = fullName,
                Email = email,
                Phone = phone,
                Password = password,
                Role = "Customer"
            };

            registeredUsers.Add(newUser);
            Login(newUser.Id, newUser.FullName, newUser.Email, newUser.Role);
            return true;
        }

        public static bool Authenticate(string email, string password, string expectedRole, out UserAccount? user, out string errorMessage)
        {
            errorMessage = "";
            user = null;

            // Try MySQL database authentication first
            if (DatabaseHelper.AuthenticateUser(email, password, expectedRole, out user, out string dbError))
            {
                if (user != null)
                {
                    Login(user.Id, user.FullName, user.Email, user.Role);
                    return true;
                }
            }

            // If account was found in DB but wrong password/role, surface that error
            if (!string.IsNullOrEmpty(dbError) && !dbError.StartsWith("Database error") && !dbError.Contains("Account not found"))
            {
                errorMessage = dbError;
                return false;
            }

            // Fallback to in-memory list if offline or local demo
            user = registeredUsers.FirstOrDefault(u =>
                u.Email.Equals(email, StringComparison.OrdinalIgnoreCase) &&
                u.Password == password);

            if (user == null)
            {
                errorMessage = "Invalid email or password. Please verify your credentials.";
                return false;
            }

            if (!string.IsNullOrEmpty(expectedRole) && !user.Role.Equals(expectedRole, StringComparison.OrdinalIgnoreCase))
            {
                errorMessage = $"Access denied. This account does not have {expectedRole} privileges.";
                return false;
            }

            Login(user.Id, user.FullName, user.Email, user.Role);
            return true;
        }

        public static void Login(int userId, string fullName, string email, string role)
        {
            IsLoggedIn = true;
            CurrentUserId = userId;
            CurrentUserName = fullName;
            CurrentUserEmail = email;
            CurrentUserRole = role;

            OnSessionChanged?.Invoke();
        }

        public static void Logout()
        {
            IsLoggedIn = false;
            CurrentUserId = 0;
            CurrentUserName = "";
            CurrentUserEmail = "";
            CurrentUserRole = "";

            OnSessionChanged?.Invoke();
        }

        public static IReadOnlyList<UserAccount> GetAllUsers() => registeredUsers.AsReadOnly();
    }
}
