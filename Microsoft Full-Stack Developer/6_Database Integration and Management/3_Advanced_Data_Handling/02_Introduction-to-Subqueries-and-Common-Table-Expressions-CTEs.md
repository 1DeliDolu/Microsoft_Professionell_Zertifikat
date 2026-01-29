## 🧩 Alt Sorgular ve Common Table Expressions (CTE’ler): Giriş

SQL’de alt sorguların ( *subqueries* ) ve Common Table Expressions’ın ( *CTEs* ) kullanımı, karmaşık verileri yönetmek için yeni yollar açabilir ve size birden fazla kaynaktan gelen sonuçları hassasiyetle sorunsuz biçimde birleştirme ve filtreleme gücü verir.

Daha önce öğrendiğiniz SQL komutlarını birkaç yeni sorgu oluşturma stratejisiyle birleştirerek, bu teknikler temel SQL’i karmaşık veri zorluklarının üstesinden gelmek için güçlü araçlara dönüştürebilir. Bu videoda, SQL sorgularında alt sorguların ve CTE’lerin kullanımını açıklayacağız.

Alt sorgular ve Common Table Expressions ( *CTEs* ), karmaşık veri çekmeyi daha yönetilebilir hâle getiren gelişmiş sorgulama teknikleridir. SQL komutlarını iç içe geçirmenize ve düzenlemenize olanak tanıyarak güçlü, katmanlı sonuçlar üretirler.

---

## 🔎 Alt Sorgu Nedir?

Önce alt sorguların ne olduğunu tanımlayarak başlayalım ve ardından nasıl kullanıldıklarını açıklayalım.

Bir alt sorgu, başka bir sorgunun içine yerleştirilmiş bir sorgudur.

Alt sorgular genellikle veriyi filtrelemek, değerleri hesaplamak veya belirli kriterlere göre tabloları birleştirmek için kullanılır.

---

## ⚙️ Alt Sorgular Nasıl Çalışır?

SQL’de alt sorgu, *inner query* (iç sorgu) olarak da adlandırılır; önce çalışır ve bir dış sorgunun ( *outer query* ) veriyi daha fazla işlemek veya filtrelemek için kullandığı sonuçları döndürür.

Alt sorgular, bir SQL ifadesinin `SELECT`, `FROM` veya `WHERE` bölümlerinin farklı yerlerinde kullanılabilir. Ayrıca, bir sorgudan gelen sonuçların başka bir sorguya beslenmesi gerektiğinde `INSERT`, `UPDATE` veya `DELETE` gibi komutlarda da kullanılabilir.

Alt sorgular, bir ifadeyi başka bir sorgunun sonuçlarıyla karşılaştırmak için de yaygın olarak kullanılır; örneğin bir değerin bir alt sorgunun bulduğu bir şeye eşit, daha büyük veya daha küçük olup olmadığını kontrol etmek gibi. Ayrıca bir değerin sonuç listesinin içinde görünüp görünmediğini kontrol etmek için de kullanışlıdır.

Listelerle çalışırken `IN` gibi operatörler, bir değerin listede olup olmadığını kontrol etmenize olanak tanır; `ANY` ve `ALL` ise belirli karşılaştırmalar için faydalıdır.

---

## 🎵 Örnek: Müzik Kataloğu ile Alt Sorgu

Bir müzik kataloğu örneğini kullanalım. Diyelim ki 1 milyondan fazla takipçisi olan sanatçıların tüm şarkılarını bulmak istiyorsunuz.

Önce, bu takipçi eşiğini karşılayan sanatçıları belirlemek için bir alt sorgu oluşturursunuz. Bu sorguyu şöyle yazarsınız:

```sql
SELECT ARTIST ID
FROM THE ARTIST TABLE
WHERE FOLLOWERS IS GREATER THAN 1 MILLION
```

Ardından şarkıları bu sanatçılardan almak için ana sorgunun içinde bu alt sorguyu kullanırsınız. Tam sorgu `SELECT SONG TITLE FROM THE SONGS TABLE` ile başlar, sonra `WHERE ARTIST ID IS IN` koşulunu eklersiniz ve ardından parantez içinde alt sorguyu yerleştirirsiniz: `SELECT ARTIST ID FROM THE ARTIST TABLE WHERE FOLLOWERS IS GREATER THAN 1 MILLION`.

Sonra sorguyu bir noktalı virgülle bitirirsiniz.

---

## 🧠 İç ve Dış Sorgu Burada Ne Yapıyor?

İç sorgu, yani alt sorgu, önce çalışır ve 1 milyondan fazla takipçi eşiğini karşılayanların sanatçı kimliklerinden oluşan bir liste döndürür.

Dış sorgu daha sonra `THE SONGS TABLE` içinden `SONG TITLES` seçer; ancak yalnızca `artist ID` değeri alt sorgudan gelenlerle eşleşen sanatçılar için.

Bu katmanlı yapı, ilişkili tablolar arasında ilgili veriyi bulmayı basitleştirir.

---

## 🧾 Common Table Expressions (CTE’ler)

Artık alt sorguların SQL içinde mantığı nasıl katmanlandırabildiğini gördüğümüze göre, başka bir gelişmiş sorgulama tekniğini inceleyelim: Common Table Expressions, yani  *CTEs* .

Önce bir tanımla başlayalım.

Bir Common Table Expression (çoğunlukla CTE olarak kısaltılır), tek bir SQL ifadesi içinde birden çok kez referans verilebilen geçici bir sonuç kümesidir.

CTE’ler, sorgu süresince var olan geçici tablolar olarak düşünülebilir. Karmaşık sorguları daha küçük parçalara bölmenize izin vererek onları yönetmeyi kolaylaştırırlar.

CTE’ler özellikle aynı sonucu birden fazla kez referans vermeniz gerektiğinde faydalıdır; okunabilirliği artırır ve sorgu yapınızı daha net hâle getirir.

CTE’ler `WITH` ifadesi kullanılarak tanımlanır; ardından bir CTE adı ve `AS` anahtar sözcüğü gelir.

---

## 📊 Örnek: Popüler Sanatçılar için Ortalama Popülerlik

Önceki örneğimizin üzerine inşa edelim. Diyelim ki 1 milyondan fazla takipçisi olan sanatçıların şarkıları için ortalama popülerlik skorunu hesaplamak istiyorsunuz.

Sonra bu skoru kullanarak bu popülerlik eşiğinin altında kalan şarkıları sonuçlardan çıkarmak istiyorsunuz.

Popüler Sanatçı ( *Popular Artist* ) adında bir CTE oluşturmaya `WITH popular artists AS` sözdizimiyle başlayalım. Sonra parantezlerin içinde, şarkılar tablosundan sanatçıları seçerek `AVG` kullanıp her sanatçı için ortalama popülerlik skorunu hesaplayan sorguyu tanımlarız.

Bu ortalamaya `AVG popularity` adını veririz.

Son olarak, yalnızca 1 milyondan fazla takipçisi olan `artist ID` değerlerini dahil etmek istediğimizi belirtmek için bir `WHERE` ifadesi ekleriz. Bunu yapmak için bir alt sorgu kullanırız.

Bu iç sorgu, `IN` anahtar sözcüğüyle gösterilir ve takipçi sayısı 1 milyonu aşan sanatçıları `artists table` içinden seçer.

Bu koşulu karşılayan sanatçılar CTE’mize dahil edilir; böylece önemli takipçi sayılarına sahip olanlara odaklanabiliriz.

---

## 🔗 CTE’yi Ana Sorguda Kullanma

Artık *Popular Artist* CTE’sini ana sorguda kullanarak sonuçlarını `songs table` ile birleştirebilir ve sanatçının ortalama popülerlik eşiğinin altında kalan şarkıları hariç tutabilirsiniz.

`SELECT S.SONGID` ile şarkı kimliğini seçerek başlayabilirsiniz. `FROM` bölümünde tablo adının hemen ardından `S` takma adını ( *alias* ) ekleyerek şarkı tablosuna bir takma ad verirsiniz.

Sonra CTE’miz olan *Popular Artist* ile `JOIN` kullanırsınız. Tablolar arasında eşleşme anahtarı olarak `artist ID` kullanılır.

Bu `JOIN`, yeterli takipçisi olan sanatçıları ve onların ortalama popülerlik skorlarını getirir.

`WHERE` bölümünde, popülerlik değeri kendi sanatçısının ortalama popülerliğini karşılayan veya aşan şarkıları seçersiniz.

---

## 🧭 Ne Zaman Alt Sorgu, Ne Zaman CTE?

Artık alt sorguların ve CTE’lerin kullanımına giriş yaptığınıza göre, ne zaman kullanılmaları gerektiğini inceleyelim.

Alt sorgular ile CTE’ler arasındaki temel fark, karmaşıklığı ele alma yetenekleridir.

Alt sorgular daha basit veya tek seferlik sorgular için iyi çalışırken, CTE’ler bir sorguyu yeniden kullanmanız gerektiğinde, karmaşık bir sorguyu daha küçük parçalara ayırmak istediğinizde veya okunabilirliği artırmak istediğinizde öne çıkar.

---

## ✅ Özet

Bu videoda, SQL sorgularında alt sorguların ve CTE’lerin kullanımını öğrendiniz.

Bu gelişmiş sorgulama tekniklerinde ustalaşmak, SQL becerilerinizi bir üst seviyeye taşıyabilir ve verimli, sürdürülebilir SQL sorguları yazma yeteneğinizi geliştirebilir.
