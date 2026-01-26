## 🔑 “You Try It!” Kontrol Yapıları ve Döngülerin Entegre Kullanımı — Yanıt Anahtarı

Aşağıdaki C# kodları **hiçbir ekleme/çıkarma yapılmadan** korunmuş; her satırın **Türkçe açıklaması** hemen altında verilmiştir.

---

## ✅ Adım 1: Döngülerle *If-Else* Entegrasyonu

```csharp
using System;
```

* `System` ad alanını ekler; `Console` gibi temel sınıfları kullanmayı sağlar.

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

* Programın başlangıç noktası olan `Main` metodunu tanımlar.

```csharp
    {
```

* `Main` bloğunu başlatır.

```csharp
        int input;
```

* `input` adlı bir tamsayı değişkeni tanımlar; kullanıcı girdisi burada tutulacaktır.

```csharp
		do {
```

* `do-while` döngüsünü başlatır; önce gövde çalışır, sonra koşul kontrol edilir. `{` döngü gövdesini açar.

```csharp
			Console.WriteLine("Enter an even number between 1 and 10:");
```

* Konsola kullanıcıdan 1 ile 10 arasında çift sayı girmesini isteyen mesajı yazar.

```csharp
			input = int.Parse(Console.ReadLine());
```

* `Console.ReadLine()` ile kullanıcıdan metin olarak girdi alır, `int.Parse` ile tamsayıya çevirir ve `input` değişkenine atar.

```csharp
			if (input >= 1 && input <= 10 && input % 2 == 0) {
```

* `input` değerinin 1 ile 10 arasında olup olmadığını (`input >= 1 && input <= 10`) ve çift olup olmadığını (`input % 2 == 0`) kontrol eder; koşul doğruysa `if` bloğuna girer.

```csharp
				Console.WriteLine("Valid input: " + input);
```

* Girdinin geçerli olduğunu ve girilen sayıyı konsola yazar.

```csharp
				break;
```

* Döngüyü anında sonlandırır ve `do-while` döngüsünden çıkar.

```csharp
			} else {
```

* `if` koşulu sağlanmadıysa `else` bloğuna geçer.

```csharp
				Console.WriteLine("Invalid input. Please try again.");
```

* Geçersiz giriş mesajını konsola yazar ve kullanıcının tekrar denemesini ister.

```csharp
			}
```

* `if-else` bloğunu kapatır.

```csharp
		} while (true);
```

* Döngü koşulunu kontrol eder; koşul `true` olduğu için döngü teorik olarak sonsuzdur, yalnızca `break` çalışınca biter.

```csharp
    }
```

* `Main` metodunu kapatır.

```csharp
}
```

* `Program` sınıfını kapatır.

---

## 🏫 Adım 2: Notları Değerlendirmek için *If-Else* Kullanma

```csharp
int[] grades = { 85, 92, 78, 64, 89 };
```

* `grades` adlı bir tamsayı dizisi tanımlar ve notları içine yerleştirir.

```csharp
for (int i = 0; i < grades.Length; i++) {
```

* `for` döngüsü başlatır; `i` 0’dan başlar, `i` dizi uzunluğundan küçük olduğu sürece döngü çalışır, her turda `i` bir artar.

```csharp
    int grade = grades[i];
```

* Dizinin o anki elemanını `grade` değişkenine atar.

```csharp
    string result;
```

* `result` adlı bir string değişkeni tanımlar; “Pass” veya “Fail” tutulacaktır.

```csharp
    if (grade >= 65) {
```

* Notun 65 veya üzeri olup olmadığını kontrol eder.

```csharp
        result = "Pass";
```

* Koşul doğruysa `result` değerini `"Pass"` yapar.

```csharp
    } else {
```

* Koşul yanlışsa `else` bloğuna geçer.

```csharp
        result = "Fail";
```

* Not 65’in altındaysa `result` değerini `"Fail"` yapar.

```csharp
    }
```

* `if-else` bloğunu kapatır.

```csharp
    Console.WriteLine($"Score: {grade} Result: {result}");
```

* String interpolasyonu ile notu ve sonucu aynı satırda yazdırır.

```csharp
}
```

* `for` döngüsünü kapatır.

---

## 🛒 Adım 3: Döngülerle *Switch* İfadelerini Entegre Etme

```csharp
using System;
```

* `System` ad alanını ekler.

```csharp
public class Program
```

* `Program` sınıfını tanımlar.

```csharp
{
```

* Sınıf bloğunu açar.

```csharp
    public static void Main()
```

* Program giriş metodu olan `Main` metodunu tanımlar.

```csharp
    {
```

* `Main` bloğunu açar.

```csharp
        string[] orderStatuses = { "Pending", "Shipped", "Delivered", "Cancelled" };
```

* Sipariş durumlarını tutan `orderStatuses` adlı string dizisini tanımlar.

```csharp
		for (int i = 0; i < orderStatuses.Length; i++) {
```

* Diziyi baştan sona dolaşmak için `for` döngüsü başlatır.

```csharp
			string status = orderStatuses[i];
```

* O anki durum değerini `status` değişkenine atar.

```csharp
			switch (status) {
```

* `status` değerine göre karar vermek için `switch` bloğunu başlatır.

```csharp
				case "Pending":
```

* Durum `"Pending"` ise bu `case` çalışır.

```csharp
					Console.WriteLine("Order is pending.");
```

* Konsola beklemede olduğunu yazar.

```csharp
					break;
```

* `switch` bloğunda bu durumdan çıkar.

```csharp
				case "Shipped":
```

* Durum `"Shipped"` ise bu `case` çalışır.

```csharp
					Console.WriteLine("Order has been shipped.");
```

* Konsola gönderildiğini yazar.

```csharp
					break;
```

* `switch` bloğundan çıkar.

```csharp
				case "Delivered":
```

* Durum `"Delivered"` ise bu `case` çalışır.

```csharp
					Console.WriteLine("Order has been delivered.");
```

* Konsola teslim edildiğini yazar.

```csharp
					break;
```

* `switch` bloğundan çıkar.

```csharp
				case "Cancelled":
```

* Durum `"Cancelled"` ise bu `case` çalışır.

```csharp
					Console.WriteLine("Order has been cancelled.");
```

* Konsola iptal edildiğini yazar.

```csharp
					break;
```

* `switch` bloğundan çıkar.

```csharp
				default:
```

* Hiçbir `case` eşleşmezse bu blok çalışır.

```csharp
					Console.WriteLine("Unknown status.");
```

* Bilinmeyen durum mesajını yazdırır.

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

---

## 🎓 Adım 4: Döngüler ve *Switch* ile Öğrenci Notlarını Değerlendirme

```csharp
using System;
```

* `System` ad alanını ekler.

```csharp
public class Program
```

* `Program` sınıfını tanımlar.

```csharp
{
```

* Sınıf bloğunu açar.

```csharp
    public static void Main()
```

* Programın çalışmaya başladığı `Main` metodunu tanımlar.

```csharp
    {
```

* `Main` bloğunu açar.

```csharp
        int[] scores = { 95, 82, 75, 63, 58 };
```

* `scores` adlı tamsayı dizisini tanımlar ve puanları içine ekler.

```csharp
		for (int i = 0; i < scores.Length; i++) {
```

* Diziyi dolaşmak için `for` döngüsü başlatır.

```csharp
			int score = scores[i];
```

* O anki puanı `score` değişkenine atar.

```csharp
			switch (score) {
```

* `score` değerine göre `switch` bloğunu başlatır.

```csharp
				case int n when (n >= 90):
```

* `score` değeri 90 veya üzerindeyse bu `case` eşleşir; `score` değeri `n` değişkenine bağlanır.

```csharp
					Console.WriteLine("Grade A: Excellent!");
```

* A notu ve geri bildirim mesajını yazdırır.

```csharp
					break;
```

* `switch` bloğundan çıkar.

```csharp
				case int n when (n >= 80):
```

* `score` 80 veya üzerindeyse (ve önceki case’e girmediyse) bu `case` eşleşir.

```csharp
					Console.WriteLine("Grade B: Good job!");
```

* B notu mesajını yazdırır.

```csharp
					break;
```

* `switch` bloğundan çıkar.

```csharp
				case int n when (n >= 70):
```

* `score` 70 veya üzerindeyse bu `case` eşleşir.

```csharp
					Console.WriteLine("Grade C: Fair.");
```

* C notu mesajını yazdırır.

```csharp
					break;
```

* `switch` bloğundan çıkar.

```csharp
				case int n when (n >= 60):
```

* `score` 60 veya üzerindeyse bu `case` eşleşir.

```csharp
					Console.WriteLine("Grade D: Needs improvement.");
```

* D notu mesajını yazdırır.

```csharp
					break;
```

* `switch` bloğundan çıkar.

```csharp
				default:
```

* Yukarıdaki koşulların hiçbiri sağlanmazsa bu blok çalışır (yani 60’ın altı).

```csharp
					Console.WriteLine("Grade F: Fail.");
```

* F notu mesajını yazdırır.

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
