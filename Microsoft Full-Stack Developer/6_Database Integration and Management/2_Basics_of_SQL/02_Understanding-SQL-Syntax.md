## 🧠 SQL Sözdizimini Anlamak

*Structured Query Language* ya da  **SQL** , ilişkisel veritabanlarının tüm potansiyelini ortaya çıkarmanın anahtarıdır. **Entity Framework Core** gibi araçlar, veritabanlarıyla *C#* kodu üzerinden etkileşim kurmanıza olanak tanıyarak ham SQL yazma ihtiyacını azaltır; ancak SQL’i anlamak, doğrudan veritabanı yönetimi ve daha karmaşık senaryolarla başa çıkmak için hâlâ önemlidir.

Bu videoda, SQL sorgularının temel yapısını ve sözdizimini tanımlayacağız.

---

## 🗄️ SQL Nedir?

*Structured Query Language* ya da  **SQL** , ilişkisel veritabanlarıyla iletişim kurmak ve onları yönetmek için kullanılan bir bilgisayar dilidir. SQL, ilişkisel bir veritabanı sistemi içinde depolanan verilerle etkileşim kurmanın ve bu verileri manipüle etmenin bir yolunu sağlar.

Daha spesifik olarak, kullanıcıların bir veritabanı içinde veri  **sorgulamasını** ,  **eklemesini** , **güncellemesini** ve **silmesini** mümkün kılar. Temelde SQL, bir  **sorgudur** .

---

## ❓ Sorgu (Query) Nedir?

Bir  **sorgu** , veritabanına veri  **getirmek** ,  **eklemek** , **güncellemek** veya **silmek** için yapılan bir istektir.

Bir kütüphane veritabanındaki kitaplar hakkında bilgi almak istediğimizi hayal edelim. Bir sorgu; kitaplar tablosundan başlık veya yazar gibi belirli detayları seçmek için talimatlar içerir ve yalnızca 2020’den sonra yayımlanan kitapları göstermek gibi koşullar da uygulayabilir.

Şimdi, SQL sorgularını daha ayrıntılı inceleyelim ve önce nasıl yapılandırıldıklarıyla başlayalım.

---

## 🧱 SQL Sorgularının Yapısı

SQL sorgularının yapısı;  **anahtar kelimeler** , **yan tümceler (clauses)** ve **ifadelerden (expressions)** oluşur.

---

## 🔑 Anahtar Kelimeler (Keywords)

Anahtar kelimeler, SQL’de belirli işlevleri yerine getiren ayrılmış kelimelerdir; örneğin bir tablodan veri seçmek veya yeni bilgi eklemek gibi. Bunlara **statements** ya da **commands** da denebilir.

Örneğin, kitap başlıklarını almak istediğimizde, veritabanına belirli bilgiyi istediğimizi söylemek için **SELECT** anahtar kelimesini kullanırız. Bu durumda sorgumuz `SELECT book title` ile başlardı.

---

## 🧩 Yan Tümceler (Clauses)

Yan tümceler, sorgunun içinde işlemleri veya koşulları belirten bölümlerdir. Veriyi filtrelemeye veya sorgunun hangi tablolarla etkileşeceğini belirlemeye yardımcı olurlar.

Kütüphane örneğimizde, yalnızca *books* adlı belirli bir tablodan sonuç istiyorsak, bunu belirtmek için **FROM** yan tümcesini kullanırız. Oluşturduğumuz sorguyu devam ettirerek, `SELECT` ifademizden sonra `FROM books` ekleriz.

---

## 🧮 İfadeler (Expressions)

İfadeler, sorgu yapısının son parçasıdır.

İfadeler; tek bir değere değerlendirilən değerler, operatörler ve fonksiyonların birleşimleridir. Bunlar genellikle koşullar uygulamak veya hesaplama yapmak için kullanılır.

Örneğin, kütüphanede 2020’den sonra yayımlanan kitapları bulmak için **WHERE** yan tümcesini kullanır ve bir ifade ekleriz. Bu ifadede, yayım yılının **2020’ye büyük veya eşit** olması koşulunu belirtiriz. Bunu, yayım yılı ile 2020’yi karşılaştırmak için **büyük/eşit** operatörlerini kullanarak yaparız.

---

## 🛠️ Yaygın SQL Anahtar Kelimeleri ve Komutları

Şimdi, en sık kullanılan SQL anahtar kelimelerinden ya da komutlarından bazılarını inceleyelim. Bu komutlar, veritabanlarını yönetirken sıkça gerçekleştireceğiniz temel işlemleri temsil eder.

---

## 📥 `SELECT`

`SELECT`, bir tablodan veri alır. Örneğimizde bu komut, kütüphane veritabanından kitap başlığı veya yazar gibi belirli kitap bilgilerini getirir.

---

## ➕ `INSERT INTO`

`INSERT INTO`, bir tabloya yeni veri ekler. Örneğin, kütüphane yeni bir kitap satın aldığında; kitap başlığını, yazarı ve yayımlanma yılını *books* tablosuna eklemek için `INSERT INTO` kullanırız.

---

## 🧾 `UPDATE`

`UPDATE`, bir tablodaki mevcut veriyi değiştirmek için kullanılır. Bir kitabın detaylarının güncellenmesi gerekiyorsa, ilgili veriyi değiştirmek için bu komutla başlanır.

---

## 🗑️ `DELETE`

`DELETE`, bir tablodan veri kaldırmak için kullanılır. Eğer bir kitap artık kütüphanede mevcut değilse, bu komut onun kaydını veritabanından siler.

---

## 🎯 `WHERE` Yan Tümcesi

Bu anahtar kelimelere ek olarak, **WHERE** yan tümcesi; sorgunun hangi satırları etkileyeceğini veya döndüreceğini filtreleyen bir koşul belirtir.

Örneğin, sorgunun yalnızca belirli bir yazara ait kitapları döndürmesini istiyorsak, **WHERE** yan tümcesi bu koşulu uygular.

---

## ✅ Özet

Bu videoda, SQL sorgularının temel yapısını ve sözdizimini; bazı yaygın SQL anahtar kelimelerinin kullanımını ve **WHERE** yan tümcesini öğrendiniz.

Veritabanı etkileşimlerinizin çoğunu **EF Core** gibi araçlara bıraksanız bile, SQL sorgularının yapısını ve sözdizimini anlamak; veriyi daha etkili yönetmenize ve ileri düzey senaryolarda çalışmanıza yardımcı olacaktır.
