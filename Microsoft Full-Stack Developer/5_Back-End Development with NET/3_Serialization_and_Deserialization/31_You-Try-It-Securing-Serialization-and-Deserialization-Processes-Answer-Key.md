## 🧪 You Try It! Serialization ve Deserialization Süreçlerini Güvenli Hâle Getirmek - Cevap Anahtarı

---

## ⚠️ Adım 2: Identify Serialization Risks

```csharp
public class User
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
}

public static string SerializeUserData(User user)
{
    return JsonSerializer.Serialize(user);
}
```

---

## ✅ Adım 3: Implement Input Validation for Serialization

Her property’yi serialization’dan önce doğrulamak için basit kontroller ekleyin.

```csharp
public static string SerializeUserData(User user)
{
    if (string.IsNullOrWhiteSpace(user.Name) || string.IsNullOrWhiteSpace(user.Email) || string.IsNullOrWhiteSpace(user.Password))
    {
        Console.WriteLine("Invalid data. Serialization aborted.");
        return string.Empty;
    }
    return JsonSerializer.Serialize(user);
}
```

---

## 🔐 Adım 4: Use a Secure Library for Serialization

Bu örnek `System.Text.Json` kullanır.

```csharp
public static string SerializeUserData(User user)
{
    user.EncryptData();
    return JsonSerializer.Serialize(user);
}
```

---

## 🚫 Adım 5: Prevent Deserialization of Untrusted Data

Deserialization sürecine bir kaynak doğrulama kontrolü ekleyin.

```csharp
public static User DeserializeUserData(string jsonData, bool isTrustedSource)
{
    if (!isTrustedSource)
    {
        Console.WriteLine("Deserialization blocked: Untrusted source.");
        return null;
    }
    return JsonSerializer.Deserialize<User>(jsonData);
}
```

---

## 🔒 Adım 6: Encrypt Sensitive Data Before Serialization

*User* sınıfında *Password* property’sini şifreleyin.

```csharp
public void EncryptData()
{
    Password = Convert.ToBase64String(Encoding.UTF8.GetBytes(Password));
}
```

---

## 🧾 Adım 7: Implement Data Integrity Checks

Veri bütünlüğünü korumak için hash üretin ve doğrulayın.

```csharp
public string GenerateHash()
{
    using (SHA256 sha256 = SHA256.Create())
    {
        byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(ToString()));
        return Convert.ToBase64String(hashBytes);
    }
}
```

---

## 🧩 Full Code Solution

Tüm adımlar entegre edilmiş tam çözüm kodu.

```csharp
using System;
using System.Text.Json;
using System.Security.Cryptography;
using System.Text;

public class User
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }

    public void EncryptData()
    {
        Password = Convert.ToBase64String(Encoding.UTF8.GetBytes(Password));
    }

    public string GenerateHash()
    {
        using (SHA256 sha256 = SHA256.Create())
        {
            byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(ToString()));
            return Convert.ToBase64String(hashBytes);
        }
    }

    public override string ToString() => JsonSerializer.Serialize(this);
}

public class Program
{
    public static void Main()
    {
        User user = new User { Name = "Alice", Email = "alice@example.com", Password = "SecureP@ss123" };

        // Step 2: Serialization risks
        string serializedData = SerializeUserData(user);
        Console.WriteLine("Serialized Data:\n" + serializedData);

        // Step 3: Input validation

        // Step 5: Deserialize only from trusted sources
        string trustedSourceData = serializedData; // Assume this is from a trusted source
        User deserializedUser = DeserializeUserData(trustedSourceData, isTrustedSource: true);

        if (deserializedUser != null)
        {
            Console.WriteLine("Deserialization successful for trusted source.");
        }
    }

    public static string SerializeUserData(User user)
    {
        user.EncryptData();
        return JsonSerializer.Serialize(user);
    }

    public static User DeserializeUserData(string jsonData, bool isTrustedSource)
    {
        if (!isTrustedSource)
        {
            Console.WriteLine("Deserialization blocked: Untrusted source.");
            return null;
        }
        return JsonSerializer.Deserialize<User>(jsonData);
    }
}
```
