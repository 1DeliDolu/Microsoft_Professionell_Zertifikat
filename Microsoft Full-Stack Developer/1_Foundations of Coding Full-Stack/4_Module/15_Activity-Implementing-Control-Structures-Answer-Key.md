
## 🏋️ Activity: Implementing Control Structures – Answer Key

Aşağıda **Problem 1** ve **Problem 2** kodlarının **her bir satırı teker teker** açıklanmıştır. (Kodda hiçbir değişiklik yapılmadan, satır satır yorumlanmıştır.)

---

# 🧾 Problem 1: Membership Fee Calculation System

```csharp
using System;
```

* `System` isim alanını projeye dahil eder; `Console`, `Convert` gibi temel .NET sınıflarını kullanabilmemizi sağlar.

```csharp
public class Program {
```

* `Program` adlı herkese açık (`public`) bir sınıf tanımlar.
* `{` sınıf gövdesinin başladığını belirtir.

```csharp
   public static void Main() {
```

* Programın çalışmaya başladığı ana giriş noktasıdır (`Main` metodu).
* `public`: Her yerden erişilebilir.
* `static`: Nesne oluşturmadan çağrılabilir.
* `void`: Geriye değer döndürmez.
* `{` metod gövdesini başlatır.

```csharp
        Console.WriteLine("Enter your age:");
```

* Konsola `"Enter your age:"` yazdırır ve kullanıcıdan yaş girmesini ister.

```csharp
        int age = Convert.ToInt32(Console.ReadLine());
```

* `Console.ReadLine()` kullanıcıdan bir satır metin (string) okur.
* `Convert.ToInt32(...)` bu string’i `int` (tam sayı) tipine çevirir.
* Sonuç `age` değişkenine atanır.

```csharp
        Console.WriteLine("Enter the type of membership (basic/premium):");
```

* Kullanıcıdan üyelik tipini (`basic` veya `premium`) girmesini ister.

```csharp
        string membershipType = Console.ReadLine().ToLower();
```

* `Console.ReadLine()` ile kullanıcı girdisi alınır.
* `.ToLower()` ile tüm harfler küçük harfe çevrilir (ör. `Basic` → `basic`).
* Sonuç `membershipType` string değişkenine atanır.

```csharp
        int fee = 0;
```

* Üyelik ücretini tutacak `fee` değişkenini oluşturur ve başlangıç değeri olarak `0` atar.

```csharp
   
        if (age < 18) {
```

* Eğer kullanıcının yaşı 18’den küçükse bu blok çalışır.
* `{` ilgili if bloğunu başlatır.

```csharp
            if (membershipType == "basic") {
```

* Eğer üyelik tipi `"basic"` ise bu blok çalışır.

```csharp
                fee = 15;
```

* `basic` üyelik ve 18 yaş altı için ücret `15` olarak atanır.

```csharp
            } else if (membershipType == "premium") {
```

* İlk koşul sağlanmadıysa ve üyelik tipi `"premium"` ise bu blok çalışır.

```csharp
                fee = 25;
```

* `premium` üyelik ve 18 yaş altı için ücret `25` olarak atanır.

```csharp
            }
```

* İçteki `if/else if` bloğunu kapatır.

```csharp
        } else if (age >= 18 && age <= 60) {
```

* Eğer `age < 18` değilse, şimdi yaşın 18 ile 60 arasında olup olmadığı kontrol edilir.
* `age >= 18`: yaş 18 veya daha büyük mü?
* `age <= 60`: yaş 60 veya daha küçük mü?
* `&&`: iki koşul da doğru olmalıdır.

```csharp
            if (membershipType == "basic") {
```

* Yaş 18–60 aralığındaysa ve üyelik tipi `"basic"` ise bu blok çalışır.

```csharp
                fee = 30;
```

* 18–60 yaş aralığı için `basic` ücret `30` olarak atanır.

```csharp
            } else if (membershipType == "premium") {
```

* Üyelik tipi `"basic"` değilse ve `"premium"` ise bu blok çalışır.

```csharp
                fee = 50;
```

* 18–60 yaş aralığı için `premium` ücret `50` olarak atanır.

```csharp
            }
```

* İçteki `if/else if` bloğunu kapatır.

```csharp
        } else if (age > 60) {
```

* Önceki koşullar sağlanmadıysa ve yaş 60’tan büyükse bu blok çalışır.

```csharp
            if (membershipType == "basic") {
```

* Yaş 60+ ve üyelik `"basic"` ise bu blok çalışır.

```csharp
                fee = 20;
```

* 60 yaş üstü için `basic` ücret `20` olarak atanır.

```csharp
            } else if (membershipType == "premium") {
```

* `basic` değilse ve üyelik `"premium"` ise bu blok çalışır.

```csharp
                fee = 35;
```

* 60 yaş üstü için `premium` ücret `35` olarak atanır.

```csharp
            }
```

* İçteki `if/else if` bloğunu kapatır.

```csharp
        }
```

* Dıştaki tüm `if / else if` zincirini kapatır.

```csharp
        Console.WriteLine("Your membership fee is: $" + fee);
```

* Ücreti ekrana yazdırır.
* String birleştirme (`+`) ile `fee` değeri metne eklenir.

```csharp
    }
```

* `Main` metodunu kapatır.

```csharp
}
```

* `Program` sınıfını kapatır.

---

# 🏦 Problem 2: Bank Account Management System

```csharp
using System;
```

* `System` isim alanını dahil eder; konsol ve dönüşüm işlemlerini kullanmamızı sağlar.

```csharp
public class Program {
```

* `Program` adlı public sınıf tanımlar.

```csharp
   public static void Main() {
```

* Programın başlangıç noktası olan `Main` metodunu tanımlar.

```csharp
        // Step 1: Prompt the user to enter the account type
```

* Yorum satırıdır; derlenmez/çalıştırılmaz. Kodun amacını açıklar.

```csharp
        Console.WriteLine("What type of account are you opening? (savings/checking/business):");
```

* Kullanıcıdan hesap türü girmesini ister.

```csharp
        string accountType = Console.ReadLine().ToLower();
```

* Kullanıcı girişini alır.
* `.ToLower()` ile küçük harfe çevirir.
* Sonucu `accountType` değişkenine atar.

```csharp
        // Step 2: Declare variables for interest rate and monthly fee
```

* Yorum satırı; değişken tanımlama adımını açıklar.

```csharp
        double interestRate = 0;
```

* Faiz oranını tutacak `interestRate` değişkenini tanımlar ve `0` ile başlatır.
* `double` ondalıklı sayıları tutabilir.

```csharp
        int monthlyFee = 0;
```

* Aylık ücreti tutacak `monthlyFee` değişkenini tanımlar ve `0` ile başlatır.

```csharp
        // Step 3: Use switch statement to determine account details based on account type
```

* Yorum satırı; switch kullanımı adımını açıklar.

```csharp
        switch (accountType) {
```

* `accountType` değişkeninin değerine göre farklı blokların çalışacağı `switch` yapısını başlatır.

```csharp
            case "savings":
```

* `accountType` değeri `"savings"` ise bu case çalışır.

```csharp
                // Handle savings account: Apply 2% interest rate
```

* Yorum satırı; savings hesabının davranışını açıklar.

```csharp
                interestRate = 0.02;
```

* Faiz oranını `%2` olacak şekilde atar (`0.02`).

```csharp
                Console.WriteLine("Interest rate is 2%");
```

* Konsola faiz oranı bilgisini yazdırır.

```csharp
                break;
```

* Switch yapısından çıkar; diğer case’lere “düşmeyi” engeller.

```csharp
            case "checking":
```

* `accountType` değeri `"checking"` ise bu case çalışır.

```csharp
                // Handle checking account: Apply $10 monthly fee
```

* Yorum satırı; checking hesabının davranışını açıklar.

```csharp
                monthlyFee = 10;
```

* Aylık ücreti `10` olarak atar.

```csharp
                Console.WriteLine("Monthly fee is $10");
```

* Konsola aylık ücret bilgisini yazdırır.

```csharp
                break;
```

* Switch’ten çıkar.

```csharp
            case "business":
```

* `accountType` değeri `"business"` ise bu case çalışır.

```csharp
                // Handle business account: Apply 1% interest rate and $20 monthly fee
```

* Yorum satırı; business hesabı için hem faiz hem ücret uygulanacağını açıklar.

```csharp
                interestRate = 0.01;
```

* Faiz oranını `%1` olacak şekilde atar (`0.01`).

```csharp
                monthlyFee = 20;
```

* Aylık ücreti `20` olarak atar.

```csharp
                Console.WriteLine("Interest rate is 1% and monthly fee is $20");
```

* Konsola hem faiz hem ücret bilgisini yazdırır.

```csharp
                break;
```

* Switch’ten çıkar.

```csharp
            default:
```

* Hiçbir case ile eşleşmeyen tüm durumlarda çalışır (fallback).

```csharp
                // Handle invalid account type
```

* Yorum satırı; geçersiz tür yönetimini açıklar.

```csharp
                Console.WriteLine("Invalid account type");
```

* Geçersiz hesap türü mesajını yazdırır.

```csharp
                break;
```

* Switch’ten çıkar.

```csharp
        }
```

* Switch bloğunu kapatır.

```csharp
    }
```

* `Main` metodunu kapatır.

```csharp
}
```

* `Program` sınıfını kapatır.
