## 🧩 Entegre Kodlama Uygulaması

Programlama dünyasını keşfediyordunuz; değişkenler, döngüler ve metotlar gibi yeni kavramlar öğreniyordunuz. Ancak merak ediyor olabilirsiniz: Tüm bunları her gün gerçekten nasıl kullanırım? Bir geliştirici olarak bunu bir yapboz inşa etmek gibi düşünün. Her parça; ister bir değişken tanımlamak ister bir kontrol yapısı içinde mantığı yönetmek olsun, önemli bir rol oynar.

Birleştirildiklerinde, bu beceriler sorunları çözmenize, yeni özellikler oluşturmanıza, kodunuzu optimize etmenize ve uygulamalarınızın sorunsuz çalışmasını sağlamanıza yardımcı olur. Bu videoda,  *veri türleri* ,  *değişkenler* ,  *kontrol yapıları* , *döngüler* ve *metotları* entegre kodlama alıştırmalarında uygulayacağız.

---

## 🧱 C# Kodunu İnceleme ve Kavramların Birlikte Kullanımı

C# kodunun bir parçasını gözden geçirelim ve bu kavramların birlikte nasıl kullanıldığını keşfedelim.

---

## 🧾 Metotlarda Kullanılacak Veri Türü

Metotlarımızda kullanacağımız veri türüyle başlayalım. İlk kod satırımız şudur:

`public string calculate pass fail (int studentScore).`

Burada, `studentScore` değişkenini bir tam sayı yani `int` olarak tanımlıyoruz. `int`’in, tam sayıları saklamamız gerektiğinde kullanıldığını hatırlayın. Bu örnekte, öğrenci puanını tutacaktır.

Ayrıca dönüş türünü `string` olarak tanımlarız; bu da `"Pass"` ve `"Fail"` gibi metin değerlerini tutacaktır.

---

## 🧮 Değişkenleri Gözden Geçirme

Kod içindeki değişkenleri inceleyelim.

`CalculatePassFail` ve `CalculateGrade` metotlarında, `studentScore` parametresi öğrenci puanını temsil etmek için kullanılır. `PrintPassFail with grades` metodunun içinde ise, iki metodun çıktısını yazdırmadan önce saklamak için `PassFailResults` ve `grade` gibi değişkenleri kullanırız.

---

## 🛠️ CalculatePassFail Metodu

Şimdi `CalculatePassFail` metodunu inceleyelim.

Bir metot, belirli bir görevi gerçekleştiren bir kod bloğudur — bu örnekte, öğrencinin puanına göre geçip geçmediğini belirlemek. Metot, öğrencinin puanını parametre olarak alır.

Metodun içinde bir kontrol yapısı bulunur: basit bir `if` ifadesi. Eğer puan `60`’tan büyük veya eşitse, metot `"Pass"` döndürür.

Eğer `60`’tan küçükse, metot `"Fail"` döndürür. Bu tür kontrol yapıları, kodumuzun koşullara göre karar vermesini sağlar.

---

## 🔀 Switch İfadesiyle Not Aralığını Belirleme

Sonra bir `switch` ifadesine sahibiz. Bunu, öğrencinin not aralığını belirlemek için kullanacağız.

`studentScore` değerini `10`’a bölerek, puanın `60–69`, `70–79` aralığında olup olmadığını ve benzeri aralıkları kontrol edebiliriz. Bu da başka bir kontrol yapısı türüdür ve farklı durumları ele almak için daha fazla esneklik sağlar.

Değere bağlı olarak `"A"` ile `"F"` arasında bir not döndürür.

---

## 🔁 Döngü Kullanımı

Sonraki adımda bir döngü kullanırız.

Burada beş kez çalışan basit bir `for` döngüsü vardır ve farklı puanlar için `CalculatePassFail` metodunun sonucunu yazdırır. Döngüler, bir kod bloğunu birden fazla kez çalıştırmamızı sağlar; bu da belirli görevleri tekrar etmek istediğinizde faydalıdır.

Döngü, metodumuzu çağırır ve her yineleme için sonucu yazdırır; böylece öğrencinin geçip geçmediğini görüntüler. Bu, metotları ve döngüleri birleştirerek veriyi verimli biçimde nasıl işleyebileceğimizi gösterir.

---

## 🧩 Kodun Baştan Sona Akışı

Şimdi tüm kodu baştan sona inceleyelim.

Önce öğrencinin puanı için bir değişken tanımlar ve değer atarız.

Ardından puanın geçme mi kalma mı olduğunu kontrol eden `CalculatePassFail` metodu gelir. Sonra, farklı puan aralıklarını ele almak için `switch` ifadesi kullanan `CalculateGrade` metodu vardır.

Son olarak, döngüyü kullanarak sonuçları yazdıran `Print PassFailWithGrades` metoduna sahibiz.

Bu süreç, değişkenlerin, veri türlerinin, metotların, kontrol yapılarının ve döngülerin bir problemi çözmek için birlikte nasıl çalıştığını gösterir.

Bu kodu çalıştırırsak, döngümüze göre farklı puanlar için metot çıktıları elde edilir. Sonuç; puanı, `"Pass"` veya `"Fail"` sonucunu ve öğrencinin puanına bağlı olarak notunu yazdırır.

---

## ✅ Kapanış

Bu videoda, bir C# programında  *veri türlerini* ,  *değişkenleri* ,  *kontrol yapılarını* , *döngüleri* ve *metotları* birlikte nasıl uygulayacağınızı öğrendiniz.

Kodu satır satır inceledik ve her kavramı çalışırken gösterdik. Bu temel kavramları pratik etmeye devam edin; böylece onları kendi programlarınızda birleştirirken daha rahat olacaksınız.
