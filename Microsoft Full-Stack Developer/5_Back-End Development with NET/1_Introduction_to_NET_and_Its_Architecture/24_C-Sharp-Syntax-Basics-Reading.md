## 💻 C# Söz Dizimi Temelleri

---

## 🧭 Giriş

Bu kılavuz, temel C# söz dizimini anlamak ve kullanmak için adım adım bir yaklaşım sunar. .NET uygulamaları oluşturmanıza yardımcı olmak için veri türleri, operatörler, program yapısı ve kontrol yapıları dahil olmak üzere temel bileşenleri kapsar.

---

## 🧾 Veri Türlerini ve Değişkenleri Tanımlama

Bir veri türü seçin: `int` (tamsayılar), `string` (metin), `double` (ondalık sayılar) veya `bool` (true/false değerleri) gibi bir veri türü seçerek başlayın.

Bir değişken tanımlayın: `dataType variableName = value;` söz dizimini takip edin. Örnek: `int age = 25;` ifadesi, 25 değerine sahip `age` adlı bir integer değişken tanımlar.

```csharp
int age = 25;
```

---

## ➕ Operatörleri Kullanma ve İfadeler Oluşturma

Aritmetik operatörler: `+` (toplama), `-` (çıkarma), `*` (çarpma) ve `/` (bölme) kullanarak hesaplamalar yapın. Örnek: `int total = 5 + 3;` sonucu (8) `total` değişkeninde saklar.

```csharp
int total = 5 + 3;
```

Mantıksal operatörler: Birden fazla gereksinimi birleştirmek için koşullarda `&&` (AND) ve `||` (OR) kullanın. Örnek: `if (isMember && hasCoupon)` her iki koşulun da doğru olup olmadığını kontrol eder.

```csharp
if (isMember && hasCoupon)
{
}
```

Atama operatörü: Değişkenlere değer atamak için `=` kullanın. Örnek: `int score = 10;`

```csharp
int score = 10;
```

---

## 🧱 Dil Yapısı ile Kodu Düzenleme

Bir namespace oluşturun: Kodu kapsüllemek için bir namespace ile başlayın ve programınızı içermek için `{}` parantezlerini kullanın.

Örnek:

```csharp
namespace MyFirstApp { /* code here */ }
```

Bir class tanımlayın: Namespace içinde, programınızın kodunu düzenlemek için bir class tanımlayın.

Örnek:

```csharp
class Program { /* methods go here */ }
```

Main ile giriş noktasını belirleyin: Programın çalışmaya başlayacağı yer olarak `static void Main(string[] args) { /* code */ }` ekleyin.

```csharp
static void Main(string[] args) { /* code */ }
```

---

## 🧭 Kontrol Yapıları Yazma

If-Else ifadeleri: `if` ve `else` kullanarak koşullara göre yapılacak işlemleri belirleyin.

```csharp
if (userInput == "password") { access = true; } else { access = false; }
```

Switch ifadeleri: `switch` kullanarak karmaşık koşulları sadeleştirin.

```csharp
switch (option) { case "home": page = "Home"; break; default: page = "Not found"; break; }
```

---

## ✅ Sonuç

Bu kılavuz, C#’ta kod yazmaya başlamak için temel bilgileri sağlar. İyi yapılandırılmış, işlevsel C# uygulamaları oluşturmak için bu adımları temel olarak takip edin. Pratik yaptıkça, bu adımlar kod yazma sürecinizin doğal bir parçası hâline gelecektir.
