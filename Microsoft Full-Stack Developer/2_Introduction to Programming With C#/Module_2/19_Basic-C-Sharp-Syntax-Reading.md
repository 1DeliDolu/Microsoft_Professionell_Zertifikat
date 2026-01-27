## 🧱 Temel C# Sözdizimi

### 🧾 Giriş

Bu özet, basit C# programları yazmanın temellerini inceler ve  *sözdizimi (syntax)* ,  *değişkenler* , *kontrol yapıları* ve *metotlar* gibi temel kavramlara odaklanır. Bu öğeler, tüm C# uygulamalarının temelini oluşturur ve işlevsel, yeniden kullanılabilir kod yazmak için gereklidir.

---

## 🏗️ Program Yapısı

Bir C# programı bir *class (sınıf)* tanımıyla başlar ve programın giriş noktası olan `Main` metodunu içerir. Örneğin:

```csharp
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}
```

`Console.WriteLine()` metodu, metni konsola yazdırır ve temel sözdizimini gösterir.

---

## 🧺 Değişkenler ve Veri Türleri

C#’ta değişkenler veriyi tutar ve belirli türlerle tanımlanır. Örnekler:

```csharp
int age = 25;
string name = "John";
var count = 10;
```

`var` anahtar sözcüğü, tür çıkarımı ( *type inference* ) sağlar; derleyici değişkenin türünü, atanan değere göre belirler.

---

## 🔀 Kontrol Yapıları

Kontrol yapıları, bir programın akışını yönetir.

### ✅ if-else İfadeleri

Koşullara göre kod çalıştırır:

```csharp
if (age >= 18) 
{
    Console.WriteLine("You're an adult.");
}
else 
{
    Console.WriteLine("You're a minor.");
}
```

### 🔁 Döngüler

Örneğin sayıları yazdırmak gibi eylemleri tekrarlar:

```csharp
for (int i = 0; i < 5; i++) 
{
    Console.WriteLine(i);
}
```

---

## 🧩 Metotlar

Metotlar, yeniden kullanılabilir kod blokları oluşturmayı sağlar. Örneğin, iki girdi alıp toplamı döndüren bir toplama metodu:

```csharp
public static int Add(int a, int b)
{
    return a + b;
}
```

Metotları sınıfların içine dahil etmek, işlevselliği düzenler ve kodun yeniden kullanılabilirliğini artırır.

---

## 🧮 Pratik Örnek: Basit Hesap Makinesi

Temel bir hesap makinesi programı şöyle görünebilir:

```csharp
public class Calculator
{
    static void Main(string[] args)
    {
        int num1 = 5;
        int num2 = 10;
        int result = Add(num1, num2);
        Console.WriteLine("The sum is: " + result);
    }

    public static int Add(int a, int b)
    {
        return a + b;
    }
}
```

Bu program iki tamsayıyı toplar ve sonucu konsola yazdırır.

---

## ⌨️ Kullanıcı Girdisi Alma

C#, `Console.ReadLine()` metoduyla kullanıcı girdisi alabilir. Örneğin:

```csharp
Console.WriteLine("Enter your name:");
string name = Console.ReadLine();
Console.WriteLine("Hello, " + name + "!");
```

Bu, programların kullanıcılarla dinamik şekilde etkileşime girmesini sağlar.

---

## ✅ Sonuç

Bu temel kavramlara —  *sözdizimi* ,  *değişkenler* , *kontrol yapıları* ve *metotlar* — hakim olarak, hesap makineleri ve etkileşimli kullanıcı uygulamaları gibi basit ama etkili C# programları oluşturabilirsiniz. Bu temeller, C#’ta daha ileri seviye programlama için zemin hazırlar.
