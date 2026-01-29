## 🤖 Microsoft Copilot’un İleri SQL Sorgu Yetenekleri

Büyük bir veritabanında birden fazla tabloyla çalışırken, tabloları join etmek, iç içe sorgular ( *nested queries* ) çalıştırmak ve karmaşık verileri çekmek gibi görevleri manuel yazmak zaman alıcı olabilir. Ancak Microsoft Copilot, ileri SQL sorgularını hızlı ve doğru şekilde üreterek bu süreci basitleştirebilir.

Bu videoda, Microsoft Copilot’un ileri SQL sorguları üretmek için nasıl kullanılacağını açıklayacağım. Hadi başlayalım.

---

## 🗃️ Tablo Yapısı ve İlişkiler

İşte tablolarımız:

* *Employees*
* *Departments*
* *Projects*
* *Employee Projects*

 *Employees* , *Departments* ve *Projects* ana tablolardır. *Employee Project* ise *employees* ve *projects* tablolarını *many-to-many* ilişkiyle birleştiren bir join tablosudur.

Bu, her çalışanın birden fazla projede olabileceği ve her projenin de birden fazla çalışan içerebileceği anlamına gelir. Mantıklı.

*Employees* tablosu şunları içerir:  *employee ID* ,  *first name* ,  *last name* ,  *department ID* , *hire date* ve  *salary* . Ayrıca *department ID* üzerinden *departments* tablosuna bir *foreign key* vardır.

*Departments* tablosunda: *department ID* ve *department name* vardır.

*Projects* tablosunda:  *project ID* ,  *project name* , *start date* ve *end date* vardır.

Şimdi Copilot’a bu bilgiler hakkında bazı sorular soracağız.

---

## 🪟 Copilot ile Join Türünü Belirleme

Şimdi elimde yeni açılmış bir Copilot penceresi var ve Copilot’tan benim için bir şey yapmasını isteyeceğim.

Diyelim ki, çekmek istediğim verilere göre hangi join türlerine ihtiyacım olacağını belirlemek için yardım istiyorum. Copilot, ihtiyacım olan verilere en uygun join türlerini seçmemde bana yardımcı olabilir.

Şöyle bir istem girelim: “Sen bir SQL uzmanısın” — bu, Copilot’a bir persona vermeye örnektir. Copilot’tan belirli bir rolü üstlenmesini istemek, daha iyi sonuçlar almamıza yardımcı olabilir. Bu durumda, bir SQL uzmanının vereceği türde bilgi istiyoruz; bazen faydalı olabilir. Her zaman gerekli değil, ama kesinlikle yapmaya değer.

Şimdi tablo tanımlarımızı alalım.

Diyelim ki, çalışanların ve departmanlarının listesini istiyorum. Çalışanların departmanı olmasa bile. Hangi join türünü kullanmalıyım?

Şimdi gerekli tablo bilgisini aldı. Yine, SQL’in ihtiyaç duyduğu bağlamın tamamına sahip olduğundan emin olmak istersiniz. Bu problemi çözmesi için başka bir insandan yardım isteseniz de tablo tanımlarını görmesi gerekirdi.

Bu örnekte, *left join* kullanmamız gerektiğini söylüyor; gerçekten de kullanmamız gereken budur.

Ve sadece “left join kullan” demekle kalmadı, aynı zamanda bize kod da verdi.

Bu, Copilot’u hangi join türünü kullanacağınızı belirlemek için kullanmaya bir örnektir.

---

## 🔗 Birden Fazla Tabloyu Join Etme

Şimdi birden fazla tabloyu join eden bir şey yapmak isteyelim.

Diyelim ki, *employee ID* ve çalışma yılı ( *years of employment* ) ile birlikte departman ve proje detaylarını çekmek istiyorum.

Aynı sohbet içinde şöyle bir istem gireceğim:

“Çalışan ID ve çalışma yılı ile birlikte çalışanın departman ve proje detaylarını getiren bir SQL sorgusu yaz.”

Ve şimdi daha büyük, daha karmaşık bir sorgu ürettiğini göreceksiniz.

 *department ID* ’leri join ediyoruz.  *employee ID* ’leri join ediyoruz.  *project ID* ’leri join ediyoruz.

Ve burada, *many-to-many* ilişkiyi kurmak için ihtiyaç duyduğumuz aradaki join tablosunu nasıl kullanacağını da çözmüş olduğunu görebilirsiniz.

Bu süreç hataya çok açıktır. Bu yüzden böyle bir araç kullanmak, bu tür daha karmaşık join’leri kurmayı gerçekten kolaylaştırır.

Yine, bu örnek kariyerinizin ilerleyen dönemlerinde karşılaşabileceğiniz bazı şeylere kıyasla nispeten basit bir join.

---

## 🧠 Nested Queries ve CTE Kullanımı

Join’lerden biraz bahsettikten sonra, Copilot’u nested queries ve common table expressions için kullanmayı konuşalım. Bunlara CTE de denir.

Karmaşık bir sorgu üzerinde çalışıyorsam ama bunun bir subquery mi yoksa CTE mi gerektirdiğinden emin değilsem, bunu Copilot’a sorarak çözebilirim.

Şöyle diyelim: “Sen bir SQL uzmanısın.” Yine, muhtemelen eklemem gerekmiyor çünkü zaten var, ama zarar da vermez.

“Her çalışan için proje saatlerini analiz etmem ve bunu departman ortalamasıyla karşılaştırmam gerekiyor. Subquery mi yoksa CTE mi kullanmalıyım?”

Burada, bu tür bir sorgu için daha okunabilir ve yönetilebilir olacağı için CTE kullanmamız gerektiğini söylüyor.

Sonra başka bilgiler de veriyor, ama bu durumda common table expression kullanmanın daha iyi çözüm olacağına ben de katılıyorum.

Ve burada nispeten karmaşık bir kod parçası ürettiğini görebilirsiniz.

Özellikle yeniyseniz, bu tür kodları yazmak uzun zaman alabilir. Ama böyle büyük ve karmaşık bir kod aldığınızda, mutlaka okuyup ne yaptığını anlamanızı öneririm.

Şu an satır satır gidip her şey doğru mu kontrol etmeye zaman ayırmayacağız, ama Copilot kullanırken şunu bilin: Kod büyüdükçe, geri aldığınız kodu daha fazla incelemelisiniz; çünkü küçük bir bug veya hata sızması için daha fazla fırsat vardır.

Bu da testlerin özellikle faydalı olduğu bir başka noktadır. Eğer elinizde test verisi varsa, bunu o veri üzerinde çalıştırarak doğru sonuç verip vermediğini kontrol edebilirsiniz. Bu çok yardımcı olabilir.

---

## 🧪 Özellikle Subquery Kullanma

Peki ya özellikle bir subquery kullanmak istediğimiz bir durum?

Diyelim ki şunu istiyorum:

“Her departmandaki en yüksek maaşı seçmek için bir subquery kullanan bir SQL ifadesi yaz.”

Burada Copilot’un subquery içeren bir sorgu geliştirdiğini görebiliriz.

Aşağıda, daha büyük sorgunun içinde iç içe geçmiş ( *nested* ) subquery var ve bunu anlamak nispeten kolay.

---

## 🧾 CTE ile Daha Karmaşık Bir Senaryo

Şimdi Copilot’a biraz daha karmaşık bir şey verelim ve bununla bize yardımcı olup olamayacağına bakalım.

Diyelim ki şunu istiyorum:

“Departmanlar genelinde ortalama proje süresini hesaplamam ve belirli bir eşik üstündeki departmanları filtrelemem gerekiyor. Departman başına ortalama proje süresini hesaplamak ve ortalama süre altı aydan fazlaysa departmanları filtrelemek için CTE kullanan bir SQL sorgusu yaz.”

Burada çok hızlı şekilde bir cevap oluşturduğunu görebilirsiniz.

*project duration as* ile bir CTE oluşturmuş ve ardından final sorguyu vermiş.

Yine, bu kadar büyük sorgularda her zaman kontrol edin; ama bu, muhtemelen doğru bir şey üretmiş gibi görünüyor.

---

## ✅ Kapanış

İleri sorgular ve karmaşık tablolarla gezinmek, özellikle yeni başlayanlar için gerçekten zorlayıcı olabilir.

Ancak Microsoft Copilot ile, çoklu tablo join’lerinden nested queries ve common table expressions’a kadar sofistike SQL sorguları üretebilirsiniz.

Bu yetenekler; veri analizi veya bir back-end için ihtiyaç duyduğunuz kodu hızlı yazmada çok değerlidir. Hızlı ve etkili içgörüler sağlar.

Karmaşık SQL görevlerini basitleştirerek, Copilot; bu sorguları yazmaya çok zaman harcamak yerine veri içgörülerini analiz etmeye ve uygulamaya odaklanmanızı sağlar; böylece analizlerinizi ve back-end’lerinizi daha hızlı bir araya getirebilirsiniz.
