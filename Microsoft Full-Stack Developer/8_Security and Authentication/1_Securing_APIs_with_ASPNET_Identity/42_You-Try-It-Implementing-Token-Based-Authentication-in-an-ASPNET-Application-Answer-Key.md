## 🧪 You Try It! ASP.NET Uygulamasında Token Tabanlı Kimlik Doğrulama – Cevap Anahtarı

---

## 👤 Kullanıcı Sınıfı (`User.cs`)

```csharp
namespace SimpleTokenAuthApp
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Token { get; set; }
    }
}
```

---

## 🧩 Token Yönetici Sınıfı (`TokenManager.cs`)

```csharp
using System;
using System.Text;

namespace SimpleTokenAuthApp
{
    public class TokenManager
    {
        public string GenerateToken(string username)
        {
            var expiry = DateTime.UtcNow.AddMinutes(30).ToString();
            string tokenData = $"{username}:{expiry}";
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(tokenData));
        }
    }
}
```

---

## 🔐 Auth Manager Sınıfı (`AuthManager.cs`)

```csharp
using System;
using System.Collections.Generic;

namespace SimpleTokenAuthApp
{
    public class AuthManager
    {
        private readonly List<User> users = new List<User>();
        private readonly TokenManager tokenManager = new TokenManager();

        public void Register()
        {
            Console.Write("Enter a username: ");
            string username = Console.ReadLine();
            Console.Write("Enter a password: ");
            string password = Console.ReadLine();

            if (users.Exists(u => u.Username == username))
            {
                Console.WriteLine("Username already exists.");
                return;
            }

            users.Add(new User { Username = username, Password = password });
            Console.WriteLine("Registration successful.");
        }

        public void Login()
        {
            Console.Write("Enter your username: ");
            string username = Console.ReadLine();
            Console.Write("Enter your password: ");
            string password = Console.ReadLine();

            var user = users.Find(u => u.Username == username && u.Password == password);
            if (user == null)
            {
                Console.WriteLine("Invalid credentials.");
                return;
            }

            user.Token = tokenManager.GenerateToken(username);
            Console.WriteLine($"Login successful. Your token: {user.Token}");
        }

        public User GetUserByToken(string token)
        {
            return users.Find(u => u.Token == token);
        }
    }
}
```

---

## 🛡️ Güvenli İçerik Yönetici Sınıfı (`SecureContentManager.cs`)

```csharp
using System;

namespace SimpleTokenAuthApp
{
    public class SecureContentManager
    {
        private readonly AuthManager authManager;

        public SecureContentManager(AuthManager authManager)
        {
            this.authManager = authManager;
        }

        public void AccessSecureContent()
        {
            Console.Write("Enter your token: ");
            string token = Console.ReadLine();

            var user = authManager.GetUserByToken(token);
            if (user != null)
            {
                Console.WriteLine($"Access granted to secure content for user: {user.Username}");
            }
            else
            {
                Console.WriteLine("Access denied. Invalid token.");
            }
        }
    }
}
```

---

## ▶️ Ana Program (`Program.cs`)

```csharp
using System;

namespace SimpleTokenAuthApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var authManager = new AuthManager();
            var secureContentManager = new SecureContentManager(authManager);

            Console.WriteLine("Simple Token-Based Authentication App");
            while (true)
            {
                Console.WriteLine("\nChoose an option: 1. Register 2. Login 3. Access Secure Content 4. Exit");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        authManager.Register();
                        break;
                    case "2":
                        authManager.Login();
                        break;
                    case "3":
                        secureContentManager.AccessSecureContent();
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
    }
}
```

---

## ✅ Beklenen Çıktı

**Kullanıcı kaydı:**

Enter a username: alice
Enter a password: password123
Registration successful.

**Login:**

Enter your username: alice
Enter your password: password123
Login successful. Your token: `<base64_encoded_token>`

**Güvenli içeriğe erişim:**

Enter your token: `<base64_encoded_token>`
Access granted to secure content for user: alice
