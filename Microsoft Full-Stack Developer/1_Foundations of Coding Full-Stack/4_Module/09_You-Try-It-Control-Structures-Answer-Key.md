## 🎛️ You Try It! Control Structures – Answer Key

Aşağıda, paylaştığınız iki çözümdeki **her bir satırın** ne yaptığını **teker teker** açıklıyorum. (Hiçbir satır atlanmamıştır.)

---

## 🎫 Step 1: If-Else Statement for Ticket Pricing — Satır Satır Açıklama

```csharp
using System;
```

* `System` adlı ad alanını (namespace) projeye dahil eder.
* `Console` gibi temel sınıfları kullanabilmenizi sağlar.

```csharp
public class Program
```

* `Program` adlı bir sınıf tanımlar.
* C# konsol uygulamalarında giriş noktası genellikle bu sınıfta bulunur.

```csharp
{
```

* `Program` sınıfının kapsamını (bloğunu) başlatır.

```csharp
	public static void Main() {
```

* Programın çalışmaya başladığı ana metottur ( *entry point* ).
* `public`: Her yerden erişilebilir.
* `static`: Sınıf örneği oluşturmadan çalışır.
* `void`: Değer döndürmez.
* `Main()`: Uygulamanın başlangıç noktasıdır.

```csharp
		int age;
```

* `age` adlı bir **tamsayı (int)** değişkeni tanımlar.
* Henüz değer atanmamıştır (sadece deklarasyon).

```csharp
		Console.WriteLine("Enter your age: ");
```

* Konsola kullanıcıya yönelik bir mesaj yazdırır: `"Enter your age: "`
* Kullanıcıdan yaş girmesini ister.

```csharp
		age = int.Parse(Console.ReadLine());
```

* `Console.ReadLine()` kullanıcıdan bir satır veri alır (**string** döner).
* `int.Parse(...)` bu string’i tamsayıya çevirir.
* Sonuç `age` değişkenine atanır.

```csharp
		if (age < 12)
```

* Bir koşul kontrolü başlatır.
* Yaş `12`’den küçük mü diye bakar.

```csharp
		{
```

* `if` bloğunun başlangıcıdır.

```csharp
			Console.WriteLine("Half price ticket.");
```

* Koşul doğruysa (yaş < 12), konsola `"Half price ticket."` yazdırır.

```csharp
		}
```

* `if` bloğunu kapatır.

```csharp
		else if (age <= 65)
```

* İlk `if` koşulu **yanlışsa** bu koşulu kontrol eder.
* Yaş `65` veya daha küçük mü diye bakar.
* Bu, fiilen **12–65 aralığını** kapsar (çünkü `< 12` zaten elenmiştir).

```csharp
		{
```

* `else if` bloğunun başlangıcıdır.

```csharp
			Console.WriteLine("Full price ticket.");
```

* Yaş 12–65 aralığındaysa konsola `"Full price ticket."` yazdırır.

```csharp
		}
```

* `else if` bloğunu kapatır.

```csharp
		else
```

* Yukarıdaki koşulların hiçbiri sağlanmadıysa çalışır.
* Buraya gelen yaşlar pratikte **65’ten büyük** olanlardır.

```csharp
		{
```

* `else` bloğunun başlangıcıdır.

```csharp
			Console.WriteLine("Senior discount ticket.");
```

* Yaş 65’ten büyükse konsola `"Senior discount ticket."` yazdırır.

```csharp
		}
```

* `else` bloğunu kapatır.

```csharp
	}
```

* `Main` metodunu kapatır.

```csharp
}
```

* `Program` sınıfını kapatır.

---

## 🚌 Step 2: Switch Statement for Travel Mode Selection — Satır Satır Açıklama

```csharp
using System;
```

* `System` ad alanını ekler; `Console` kullanımını mümkün kılar.

```csharp
public class Program
```

* `Program` sınıfını tanımlar.

```csharp
{
```

* Sınıf bloğunu başlatır.

```csharp
	public static void Main() {
```

* Programın başlangıç metodu ( *entry point* ).

```csharp
		string mode;
```

* `mode` adlı bir **string** değişken tanımlar.
* Kullanıcının seçeceği ulaşım türünü tutacaktır.

```csharp
		Console.WriteLine("Select a travel mode: Bus, Train, Flight");
```

* Konsola kullanıcıdan seçim yapmasını isteyen mesajı yazar.

```csharp
		mode = Console.ReadLine();
```

* Kullanıcının girdiği satırı okur ve `mode` değişkenine atar.
* Bu değer `"Bus"`, `"Train"`, `"Flight"` veya başka bir şey olabilir.

```csharp
		switch (mode)
```

* `mode` değişkeninin değerine göre dallanmayı başlatır.
* Değere göre uygun `case` bloğu çalıştırılır.

```csharp
		{
```

* `switch` bloğunu başlatır.

```csharp
			case "Bus":
```

* `mode` değeri tam olarak `"Bus"` ise bu case seçilir.

```csharp
				Console.WriteLine("Booking a bus ticket.");
```

* `"Bus"` seçilmişse konsola `"Booking a bus ticket."` yazdırır.

```csharp
				break;
```

* Bu `case`’in çalışmasını bitirir ve `switch`’ten çıkar.
* `break` olmazsa bir sonraki `case`’e “düşme” (fall-through) davranışı risk oluşturur.

```csharp
			case "Train":
```

* `mode` değeri `"Train"` ise bu case seçilir.

```csharp
				Console.WriteLine("Booking a train ticket.");
```

* `"Train"` seçilmişse ilgili mesajı yazdırır.

```csharp
				break;
```

* `switch`’ten çıkar.

```csharp
			case "Flight":
```

* `mode` değeri `"Flight"` ise bu case seçilir.

```csharp
				Console.WriteLine("Booking a flight ticket.");
```

* `"Flight"` seçilmişse ilgili mesajı yazdırır.

```csharp
				break;
```

* `switch`’ten çıkar.

```csharp
			default:
```

* Hiçbir `case` eşleşmezse çalışır (geçersiz girişler).

```csharp
				Console.WriteLine("Invalid selection. Please choose Bus, Train, or Flight.");
```

* Geçersiz seçim yapıldığında kullanıcıyı uyarır.

```csharp
				break;
```

* `switch` bloğunu sonlandırır.

```csharp
		}
```

* `switch` bloğunu kapatır.

```csharp
	}
```

* `Main` metodunu kapatır.

```csharp
}
```

* `Program` sınıfını kapatır.

---
