## 🧑‍💻 C# ile Basit Programlar Yazma

İlk adımda, toplama ve çıkarma gibi temel aritmetik işlemleri yapan basit bir hesap makinesi programı oluşturacağız. Bir sınıf tanımlayarak başlayacağız ve iki sayıyı toplayan bir metot yazacağız.

C#’ta bir  *class (sınıf)* , program kodunuz için bir kapsayıcı gibidir. Programın ne yapacağını söyleyen talimat setleri olan *metotları* içerir. Bir metodu, programın adım adım takip ettiği bir tarif gibi düşünün.

Burada `Add` adlı bir metot ekleyeceğiz; bu metot iki sayıyı toplayacak. `static` kelimesi, metodun sınıfın kendisine ait olduğu anlamına gelir ve `public` kelimesi, programın diğer bölümlerinden erişilebilir olduğunu ifade eder.

Bir  *değişken (variable)* , programın kullanabileceği veriyi tutan bir kap gibidir. Burada `number1` ve `number2` adlı iki değişkenimiz var; bunlar toplamak istediğimiz sayıları saklayacak.

Metot, sonucu `return` anahtar sözcüğünü kullanarak döndürecektir; bu da metodun cevabı onu çağıran kod bölümüne geri gönderdiği anlamına gelir.

---

## 🚪 Main Metodu ile Programı Çalıştırma

`Add` metodunu oluşturduğumuza göre, nasıl çalıştığını görme zamanı.

Bir C# programını çalıştırmak için `Main` metodunu yazmamız gerekir; bu metot programın giriş noktasıdır. Her şeyin bir araya geldiği yer burasıdır.

C#’ta her program, `Main` metodunu çalıştırarak başlar; bu, programın başlangıç noktası gibidir.

Bir C# programını çalıştırdığınızda, `Main` içindeki kod ilk olarak yürütülür. Bu örnekte `Main` içinde, `number1` ve `number2` değerlerini atayacağız, toplamı hesaplamak için `Add` metodunu çağıracağız ve sonucu ekrana yazdırmak için `Console.WriteLine` kullanacağız.

Bir metodu çağırmak, metodun içindeki kodu çalıştırmak ve sonucunu kullanmak anlamına gelir.

---

## 🔁 Döngü ile 1’den 10’a Kadar Sayıları Yazdırma

Sonraki adımda, bir döngü kullanarak `1`’den `10`’a kadar sayıları ekrana yazdıran bir program yazacağız.

Döngüler, bir eylemi birden fazla kez tekrarlamanıza izin veren kontrol yapılarıdır.  *For döngüsü* , bir kod bloğunu kaç kez tekrar etmek istediğimizi bildiğimiz durumlarda kullanılır.

Bu durumda, `1`’den `10`’a kadar sayıları yazdırmak istiyoruz.

Döngünün üç bölümü vardır:

* **Başlatma (Initialization)** : `int i = 1`
  Döngünün başlangıç noktasını belirler. Burada `i = 1` ile başlıyoruz.
* **Koşul (Condition)** : `i <= 10`
  Döngünün ne zaman duracağını söyler. `i` değeri `10`’dan küçük veya eşit olduğu sürece döngü çalışır. `i` değeri `11` olduğunda döngü durur.
* **Artırma (Increment)** : `i++`
  Her döngü turundan sonra `i` değerini 1 artırır, böylece bir sonraki sayı yazdırılır.

---

## ⌨️ Kullanıcıyla Etkileşim Kurma

Şimdi kullanıcıyla etkileşime giren bir program yazalım. Bu program kullanıcıdan adını isteyecek ve onu selamlayacaktır.

Kullanıcı girdisini ele almak, etkileşimli programlar oluşturmak için önemlidir. Bu adımda kullanıcıdan adını isteyerek etkileşim kuracağız.

Kullanıcının girdisini yakalamak için `Console.ReadLine` kullanırız. Bu metot, kullanıcı bir şey yazıp Enter’a basana kadar bekler ve ardından bu girdiyi bir *string* olarak saklar.  *String* , bir kelime veya cümle gibi karakter dizisidir.

Kullanıcının girdisini `name` adlı bir değişkende saklarız.

`name` değişkeninde kullanıcı adı saklandıktan sonra, `Console.WriteLine` ile kişiselleştirilmiş bir selamlama gösterebiliriz.

Dikkat edin: önce `Console.WriteLine` ile kullanıcıdan adını girmesini isteriz. Kullanıcı adını yazdıktan sonra, bu değer `Console.ReadLine` ile `name` değişkenine kaydedilir.

Sonra bu değişkeni kullanarak kullanıcıyı adıyla selamlarız; bu da girdinin dinamik şekilde nasıl kullanılabileceğini gösterir.

`Console.ReadLine` girdi yakalamak için kullanışlıdır; `Console.WriteLine` ise kullanıcıya mesaj göstermek için kullanılır.
