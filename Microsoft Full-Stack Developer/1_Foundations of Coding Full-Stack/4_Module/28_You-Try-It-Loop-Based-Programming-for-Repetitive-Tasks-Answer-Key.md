## 🔑 “You Try It!” Yanıt Anahtarı

Aşağıda verilen C# kodlarında **her bir satırın** Türkçe açıklaması yer almaktadır. Kod satırları, **hiçbir ekleme/çıkarma yapılmadan** birebir korunmuş; her satırın hemen altına açıklaması eklenmiştir.

---

## 🧩 Adım 1: *For* Döngüsü ile Toplam Puan Hesaplama

```csharp
using System;
```

* `System` ad alanını programa dahil eder; `Console` gibi temel sınıfları kullanabilmenizi sağlar.

```csharp
public class Program
```

* `Program` adlı herkese açık bir sınıf tanımlar.

```csharp
{
```

* Sınıf bloğunu başlatır.

```csharp
    public static void Main()
```

* Programın çalışmaya başladığı giriş noktası olan `Main` metodunu tanımlar.
* `static` olduğu için sınıf örneği oluşturmadan çağrılır.

```csharp
    {
```

* `Main` metodu bloğunu başlatır.

```csharp
        int[] scores = { 85, 90, 78, 92, 88 };
```

* `scores` adlı bir `int` dizisi tanımlar ve içine 85, 90, 78, 92, 88 değerlerini yerleştirir.

```csharp
		int total = 0;
```

* `total` adlı bir tamsayı değişkeni tanımlar ve başlangıç değerini 0 yapar; toplam puan burada biriktirilecektir.

```csharp
		for (int i = 0; i < scores.Length; i++) {
```

* `for` döngüsü başlatır.
* `int i = 0;` sayaç değişkenini 0’dan başlatır.
* `i < scores.Length` koşulu doğru oldukça döngü devam eder.
* `i++` her tur sonunda `i` değerini 1 artırır.
* `{` döngü gövdesini başlatır.

```csharp
			total += scores[i];
```

* `scores[i]` elemanını `total` değişkenine ekler; yani toplamı artırır.

```csharp
		}
```

* `for` döngüsünün gövdesini kapatır.

```csharp
		Console.WriteLine("Total score: " + total);
```

* Konsola `"Total score: "` metnini ve `total` değerini yazar.

```csharp

```

* Boş satırdır; okunabilirlik amaçlıdır.

```csharp
			}
```

* `Main` metodunu kapatır. (Girinti düzensiz olsa da anlam olarak kapatma parantezidir.)

```csharp
}
```

* `Program` sınıfını kapatır.

---

## 🧮 Adım 2: *While* Döngüsü ile Faktöriyel Hesaplama

```csharp
using System;
```

* `System` ad alanını dahil eder.

```csharp
public class Program
```

* `Program` sınıfını tanımlar.

```csharp
{
```

* Sınıf bloğunu başlatır.

```csharp
    public static void Main()
```

* Programın başlangıç metodu olan `Main` metodunu tanımlar.

```csharp
    {
```

* `Main` bloğunu başlatır.

```csharp
        	int number = 5;
```

* `number` adlı tamsayı değişkenini tanımlar ve değerini 5 yapar.

```csharp
		int factorial = 1;
```

* `factorial` adlı tamsayı değişkenini tanımlar ve 1 yapar; çarpım biriktirileceği için başlangıç 1’dir.

```csharp
		while (number > 0) {
```

* `while` döngüsü başlatır; `number` 0’dan büyük olduğu sürece döngü çalışır.
* `{` döngü gövdesini başlatır.

```csharp
			factorial *= number;
```

* `factorial` değerini `number` ile çarpar ve sonucu tekrar `factorial` içine yazar.

```csharp
			number--;
```

* `number` değerini 1 azaltır.

```csharp
		}
```

* `while` döngüsünü kapatır.

```csharp
		Console.WriteLine("Factorial: " + factorial);
```

* Konsola `"Factorial: "` metnini ve `factorial` değerini yazar.

```csharp
	}
```

* `Main` metodunu kapatır.

```csharp
}
```

* `Program` sınıfını kapatır.

---

## ✅ Adım 3: *For* + *If-Else* ile Geçti/Kaldı Belirleme

```csharp
using System;
```

* `System` ad alanını dahil eder.

```csharp
public class Program
```

* `Program` sınıfını tanımlar.

```csharp
{
```

* Sınıf bloğunu başlatır.

```csharp
    public static void Main()
```

* Programın giriş noktası olan `Main` metodunu tanımlar.

```csharp
    {
```

* `Main` bloğunu başlatır.

```csharp
        int[] studentScores = { 45, 60, 72, 38, 55 };
```

* `studentScores` adlı bir `int` dizisi tanımlar ve 45, 60, 72, 38, 55 değerlerini içine koyar.

```csharp
		for (int i = 0; i < studentScores.Length; i++) {
```

* `for` döngüsüyle dizinin tüm elemanlarını indeks üzerinden dolaşır.

```csharp
			if (studentScores[i] >= 50) {
```

* `studentScores[i]` değeri 50 veya üzerindeyse `if` bloğuna girer.

```csharp
				Console.WriteLine(studentScores[i] + " - Pass");
```

* Skoru ve yanına `" - Pass"` ekleyerek konsola yazar.

```csharp
			} else {
```

* `if` koşulu sağlanmazsa `else` bloğuna geçer.

```csharp
				Console.WriteLine(studentScores[i] + " - Fail");
```

* Skoru ve yanına `" - Fail"` ekleyerek konsola yazar.

```csharp
			}
```

* `if-else` yapısını kapatır.

```csharp
		}
```

* `for` döngüsünü kapatır.

```csharp
	}
```

* `Main` metodunu kapatır.

```csharp
}  
```

* `Program` sınıfını kapatır.

---

## 🗓️ Adım 4: *For* + *Switch* ile Haftalık Görev Planlama

```csharp
using System;
```

* `System` ad alanını dahil eder.

```csharp
public class Program
```

* `Program` sınıfını tanımlar.

```csharp
{
```

* Sınıf bloğunu başlatır.

```csharp
    public static void Main()
```

* Programın başlangıç metodu olan `Main` metodunu tanımlar.

```csharp
    {
```

* `Main` bloğunu başlatır.

```csharp
        string[] weekDays = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };
```

* `weekDays` adlı bir `string` dizisi tanımlar ve haftanın günlerini içine koyar.

```csharp
		for (int i = 0; i < weekDays.Length; i++) {
```

* `for` döngüsüyle `weekDays` dizisindeki her günü sırayla dolaşır.

```csharp
			switch (weekDays[i]) {
```

* `weekDays[i]` değerine göre `switch` yapısını başlatır.

```csharp
				case "Monday":
```

* Değer `"Monday"` ise bu `case` çalışır.

```csharp
					Console.WriteLine("Team Meeting");
```

* Konsola `"Team Meeting"` yazar.

```csharp
					break;
```

* Bu `case` bloğundan çıkar; sonraki `case`’lerin çalışmasını engeller.

```csharp
				case "Tuesday":
```

* Değer `"Tuesday"` ise bu `case` çalışır.

```csharp
					Console.WriteLine("Code Review");
```

* Konsola `"Code Review"` yazar.

```csharp
					break;
```

* `switch` içinde bu durumdan çıkar.

```csharp
				case "Wednesday":
```

* Değer `"Wednesday"` ise bu `case` çalışır.

```csharp
					Console.WriteLine("Development");
```

* Konsola `"Development"` yazar.

```csharp
					break;
```

* `switch` bloğundan çıkar.

```csharp
				case "Thursday":
```

* Değer `"Thursday"` ise bu `case` çalışır.

```csharp
					Console.WriteLine("Testing");
```

* Konsola `"Testing"` yazar.

```csharp
					break;
```

* `switch` içinde bu durumdan çıkar.

```csharp
				case "Friday":
```

* Değer `"Friday"` ise bu `case` çalışır.

```csharp
					Console.WriteLine("Deployment");
```

* Konsola `"Deployment"` yazar.

```csharp
					break;
```

* `switch` içinde bu durumdan çıkar.

```csharp
				default:
```

* Hiçbir `case` eşleşmezse bu blok çalışır.

```csharp
					Console.WriteLine("No task assigned.");
```

* Konsola `"No task assigned."` yazar.

```csharp
					break;
```

* `switch` bloğundan çıkar.

```csharp
			}
```

* `switch` bloğunu kapatır.

```csharp
		}
```

* `for` döngüsünü kapatır.

```csharp
	}
```

* `Main` metodunu kapatır.

```csharp
} 
```

* `Program` sınıfını kapatır.
