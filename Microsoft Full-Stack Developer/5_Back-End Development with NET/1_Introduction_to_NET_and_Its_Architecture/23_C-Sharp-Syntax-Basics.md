## 💻 C# Söz Dizimi Temelleri

C# programlama dili, geliştiricilerin mobil uygulamalardan kurumsal sistemlere kadar geniş bir yelpazede uygulamalar oluşturmasını sağlar. Bu videoda C# programlama dilinin temel söz dizimini açıklayacağız.

C# söz dizimi temelleriyle ilgili üç ana alanı inceleyeceğiz:  **veri türleri ve değişkenler** ,  **operatörler ve ifadeler** , ve  **dil yapısı** .

---

## 🧾 Veri Türleri ve Değişkenler

C#’ta veri türleri, bir değişkenin tutabileceği veri türünü tanımlar; örneğin  *integer* , *string* ve *double* ile *float* gibi floating point sayı türleri.

Bir veri değerini saklamak için **değişken** kullanırız. Bu örnekte `age` adlı bir integer değişkeni tanımlarız ve ona 25 değerini atarız. Veri türü önce gelir; ardından değişken adı ve atanan değer yer alır.

```csharp
int age = 25;
```

---

## ➗ Operatörler ve İfadeler

C#’ta operatörler, değişkenler ve değerler üzerinde işlem yapmak için kullanılan sembollerdir. Birkaç farklı operatör türü vardır.

---

## 🧮 Aritmetik Operatörler

Aritmetik operatörler; toplama için artı, çıkarma için eksi, çarpma için yıldız işareti ve bölme için eğik çizgi içerir. Bu operatörler, iki sayının toplamını bulmak gibi temel matematik işlemlerini yapar.

---

## 🔎 Mantıksal Operatörler

Bir diğer operatör türü mantıksal operatörlerdir.

İki tane ampersand birlikte **AND** anlamına gelir. İki koşulun da doğru olup olmadığını kontrol etmek istediğinizde kullanılır. Örneğin, bir kullanıcının hem oturum açmış hem de admin yetkisine sahip olup olmadığını kontrol etmek istediğinizde iki ampersand kullanırsınız. Her iki koşul da doğruysa, genel ifade true olarak değerlendirilir.

Diğer mantıksal operatör **OR** anlamına gelir ve iki dikey çizgi ya da iki pipe ile yazılır. Bu operatör, iki koşuldan en az birinin doğru olup olmadığını kontrol eder. Koşullardan biri doğruysa, tüm ifade true olur. Yalnızca her iki koşul da yanlışsa false olur.

Örneğin, bir kullanıcının indirim almaya uygun olup olmadığını kontrol eden bir program yaptığınızı varsayalım. Kullanıcı, üye ise veya kuponu varsa indirim alır. Bu iki koşuldan herhangi birinin doğru olup olmadığını kontrol etmek için double pipe operatörünü kullanabilirsiniz. Kullanıcı üye ise veya geçerli bir kuponu varsa, program indirimi uygular. Koşulların hiçbiri sağlanmazsa indirim uygulanmaz. Bu, kullanıcılara promosyon sunmada esneklik sağlar.

---

## 🟰 Atama Operatörleri

Son olarak, eşittir işareti gibi atama operatörleri değişkenlere değer atar. Örneğin `int age = 25` yazdığımızda eşittir işareti 25 değerini `age` değişkenine atar.

---

## 🧠 İfadeler (Expressions)

İfadeler, bir sonuç üretmek için değerlendirilebilen değişkenleri, operatörleri ve değerleri bir araya getirir.

Örneğin:

```csharp
int sum = 5 + 3;
```

Bu ifade 5 ve 3 sayılarını toplar ve sonuç `sum` değişkeninde saklanır.

---

## 🧱 Dil Yapısı (Language Structure)

Verilerle nasıl çalışacağımızı konuştuktan sonra, bu öğelerin tamamının bir programda nasıl bir araya geldiğini düşünmeliyiz. İşte burada **dil yapısı** devreye girer ve kodunuzu verimli ve esnek biçimde düzenlemenize yardımcı olur.

Tipik bir C# programında:

* kodu düzenlemek için  **namespace** ’ler,
* nesneler için şablon olarak  **class** ’lar,
* belirli görevleri gerçekleştirmek için  **method** ’lar bulunur.

Önce, kodunuzu diğer kodlardan kapsüllemek için bir namespace içine alabilirsiniz. Bir namespace oluşturmak için `"namespace"` anahtar kelimesini ve ardından namespace adını kullanırsınız. Bu örnekte `MyFirstApp` adında bir namespace vardır.

Sonra, kodunuzu içeren bir class oluşturursunuz. Class’lar `"class"` anahtar kelimesiyle başlar, ardından sınıf adı gelir; bu örnekte adı `Program`dır.

Son olarak, class içinde `Main` adlı bir method oluşturmanız gerekir. Method kodu `"static"` kelimesiyle başlar; bu, Program class’ının belirli bir instance’ı üzerinde çağrılmasına gerek olmadığını belirtir. Ardından dönüş tipi olarak `"void"` gelir ve sonra method’un adı — bu durumda `Main`.

Method adının ardından parametreleri içeren açılış ve kapanış parantezleri gelir. Parametreler virgülle ayrılmış bir listeden oluşur. Her parametre, tür ile başlar ve ardından parametre adı gelir. Adın ardından eşittir işareti ve varsayılan bir değer de gelebilir.

Bu örnekte Main method’u, varsayılan değeri olmayan, `args` adlı bir string array parametresi alır. Bu, programı terminalden çağırırken argüman geçmenize olanak tanır.

```csharp
namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
```

---

## 🆕 Top-Level Statements

.NET 5’ten itibaren C# kodunuzu, namespace, wrapper class veya Main method kullanmadan da yazabilirsiniz; tıpkı gösterdiğimiz gibi. Buna **top level statements** denir.

Bunun bazı sınırlamaları vardır ancak basit durumlar için pratiktir ve .NET kodu oluştururken yaygın şekilde kullanılır.

---

## 🧭 Kontrol Yapıları (Control Structures)

Kodumuzun yapısını oluşturduğumuza göre, kontrol yapılarını konuşalım.

Yaygın kontrol yapılarından biri **if-else** ifadesidir. Bu örnekte, kod kullanıcının girdisinin doğru parolayla eşleşip eşleşmediğini kontrol eder. Eşleşiyorsa `access` değerini true yapmak erişim verir. Eşleşmiyorsa `access` değerini false yapmak erişimi reddeder.

Bir diğer yaygın kontrol yapısı ise karmaşık koşullu mantığı sadeleştiren **switch** ifadesidir. Bu örnekte program `menu option` adlı bir değişkeni kontrol eder ve değere göre doğru sayfayı gösterir. Hiçbir case eşleşmezse default sayfa gösterilir.

---

## ✅ Videonun Özeti

Bu videoda C# programlama dilinin temel söz dizimini öğrendiniz. Bu çekirdek öğeleri anlamak, geliştiricilerin iyi organize edilmiş ve sürdürülebilir kod yazmasını sağlar.
