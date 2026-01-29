## 🔁 SQL’de Eşzamanlılık Kontrolü

Veritabanında işlemler ( *transactions* ) sürekli çalışır; çoğu zaman aynı anda ve her biri aynı verilere erişmek isteyebilir. Birden fazla işlem çakıştığında, çatışabilir ve tutarsızlıklara yol açabilir. Peki, tüm bu hareketlilik içinde veritabanı her şeyi doğru ve güvenilir nasıl tutar?

İşte burada eşzamanlılık kontrolü ( *concurrency control* ) devreye girer; bu eşzamanlı işlemleri yöneterek çatışmaları önler ve veriyi tutarlı tutar. Bu videoda, eşzamanlılık kontrol mekanizmalarını ve çok kullanıcılı ortamlardaki önemlerini açıklayacağız.

---

## 🧠 Concurrency Control Nedir?

Eşzamanlılık kontrolü, bir veritabanında aynı anda yapılan veri erişimini yönetme sürecidir; amacı çatışmayı önlemek ve veri doğruluğunu sağlamaktır.

Eşzamanlılık kontrol mekanizmaları, SQL veritabanlarında işlemleri yönetmek için gereklidir; verinin doğru kalmasını ve çatışmaların en aza indirilmesini sağlar.

---

## ⚠️ Eşzamanlı Erişimde Yaygın Sorunlar

Birden fazla kullanıcı aynı veri üzerinde eşzamanlı çalıştığında bazı yaygın sorunlar ortaya çıkabilir.

Eşzamanlılık sorunları, bir kullanıcının eylemleri veya bir işlemin başka bir işlemi bozması durumunda oluşur. En yaygın sorunlar şunlardır:

* *dirty reads*
* *non-repeatable reads*
* *phantom reads*

Bu sorunların her biri veri doğruluğunu ve güvenilirliğini etkileyebilir. Şimdi bunları tek tek ele alalım; dirty reads ile başlayalım.

---

## 🧪 Dirty Reads

Dirty reads, bir işlemin başka bir işlem tarafından değiştirilmiş ancak henüz `COMMIT` edilmemiş veriyi okuması durumunda ortaya çıkar.

Eğer diğer işlem `ROLLBACK` ederse, okunan veri geçersiz hâle gelir ve potansiyel hatalara yol açabilir.

Örneğin, User A bir sipariş durumunu Pending’den Shipped’e değiştiriyor ve User B bu güncellemeyi `COMMIT` edilmeden önce görüyor olsun. Eğer User A’nın işlemi daha sonra `ROLLBACK` edilirse, sipariş durumu tekrar Pending’e döner; ancak User B zaten durumun Shipped olduğunu öğrenmiştir. Bu kafa karışıklığı yaratır ve yanlış veriye dayalı kararlar alınmasına neden olabilir.

---

## 🔁 Non-Repeatable Reads

Non-repeatable reads, bir işlemin aynı veriyi birden fazla kez okumasına rağmen, arada başka bir işlemin veriyi değiştirmesi nedeniyle farklı sonuçlar döndürmesi durumudur.

Örneğin, User A bir ürün fiyatını okur ve User B fiyatı güncelledikten sonra User A aynı fiyatı tekrar okursa, iki okuma farklı fiyat döndürür; bu da User A’nın işlemi içinde tutarsızlık yaratır.

Bu durum, zaman içinde fiyat takibi veya denetim ( *auditing* ) gibi tutarlılığın önemli olduğu senaryoları etkileyebilir.

---

## 👻 Phantom Reads

Phantom reads, bir işlemin bir koşula uyan satır kümesini okuması, ancak daha sonra başka bir işlem tarafından eklenen ve aynı koşula uyan ek satırları fark etmesi durumudur.

Diyelim ki User A bugün verilen siparişlerin listesini inceliyor. Eğer User B kısa süre sonra yeni siparişler eklerse, User A’nın bir sonraki okuması daha fazla kayıt içerecek ve aynı işlem içinde veri görünümü değişecektir.

Bu, zaman içinde sabit bir veri anlık görüntüsü ( *stable data snapshot* ) yansıtması gereken raporları bozabilir.

---

## 🧱 Isolation Levels ile Sorunları Yönetmek

Yaygın eşzamanlılık sorunlarını ele aldığımıza göre, SQL’in bu sorunları farklı isolation levels (yalıtım seviyeleri) ile nasıl yönettiğini inceleyelim.

Isolation levels, işlemlerin birbirleriyle nasıl etkileşime girdiğini kontrol eder ve eşzamanlılık sorunlarına karşı farklı seviyelerde koruma sağlar.

Her seviye, veri koruması ile performans arasında farklı bir denge sunar. En az kısıtlayıcı seviye olan read-uncommitted ile başlayıp en koruyucu seviyeye doğru ilerleyeceğiz.

---

## 🏎️ Read-Uncommitted

Read-uncommitted seviyesi, işlemlerin `COMMIT` edilmemiş veriyi okumasına izin verir; bu da üç sorunun tamamına yol açabilir: dirty reads, non-repeatable reads ve phantom reads.

Minimum veri koruması ama maksimum hız sunar. Bu yüzden veri doğruluğunun kritik olmadığı durumlarda kullanılır. Örneğin hızlı ürün stok raporları veya yaklaşık sipariş özetleri üretmek için uygun olabilir.

---

## ⚖️ Read-Committed

Read-uncommitted seviyesinden sonra, read-committed seviyesi işlemlerin yalnızca `COMMIT` edilmiş veriyi okumasına izin vererek daha fazla kontrol sağlar.

Bu, dirty reads’i önler.

Bu seviye veri doğruluğu ile performans arasında denge kurar ve birçok uygulama için uygun bir seçimdir.

Bir e-ticaret platformunda kullanıcıların ürün detaylarını incelediğini düşünün. Read-committed, arka planda küçük güncellemeler olsa bile kullanıcıların `COMMIT` edilmiş fiyatları görmesini sağlar.

---

## 🧾 Repeatable Read

Daha ileri giderek, repeatable read daha fazla koruma sağlar: işlemlerin `COMMIT` edilmiş veriyi okumasına izin verir ve bir işlem içinde bir kez okunan verinin tekrar okunduğunda değişmemesini garanti eder.

Bu, dirty reads’i ve non-repeatable reads’i önler.

Bir işlem içinde veri stabilitesinin önemli olduğu durumlarda kullanışlıdır. Örneğin, tutarlı bir ürün fiyat setiyle eşleşmesi gereken faturalar ( *invoices* ) üretilirken, repeatable read işlemler boyunca veriyi sabit tutar.

---

## 🧱 Serializable

Serializable en katı seviyedir; her işlemi sanki tek başına gerçekleşiyormuş gibi ele alarak tam yalıtım sağlar.

Bu seviye üç sorunun tamamını önler: dirty reads, non-repeatable reads ve phantom reads.

En yüksek doğruluk seviyesini sağlasa da, kısıtlayıcı yapısı nedeniyle veritabanını yavaşlatabilir.

Bu yalıtım seviyesi, gün sonu bakiyeleri gibi kritik finansal hesaplamalar için idealdir; doğruluk, daha yavaş işlem pahasına bile önceliklidir.

---

## 🔐 Locking Mechanisms ile Destekleme

Bu isolation levels’ı desteklemek için, veritabanı yönetim sistemleri veri çatışmalarını önlemek adına kilitleme mekanizmaları ( *locking mechanisms* ) uygular.

Kilitler, veriye erişimi kısıtlayarak aynı anda yalnızca belirli türde işlemlerin gerçekleşmesine izin verir ve eşzamanlılık sorunlarının olasılığını azaltır.

Üç ana kilitleme türü vardır:

* shared locks
* exclusive locks
* update locks

Her kilit türü, işlemleri izole tutmak ve çatışmaları önlemek için erişimi farklı şekilde yönetir.

---

## 👥 Shared Locks

Shared locks, birden fazla işlemin aynı veriyi okumasına izin verir; ancak kilit bırakılana kadar hiçbirinin veriyi değiştirmesine izin vermez.

Bu kilit türü, dirty reads riskini azaltmak için kullanılır.

Örneğin, günlük satış raporu oluştururken sipariş verilerinden toplam satış hesaplanıyor olsun. Shared locks kullanıldığında, birden fazla rapor aynı veriye erişebilir; ancak veriyi değiştirme riski olmadığı için her rapor için tutarlılık sağlanır.

---

## ⛔ Exclusive Locks

Exclusive locks, kilit bırakılana kadar diğer işlemlerin veriyi okumasını veya değiştirmesini engeller; böylece aynı anda yalnızca tek bir işlem değişiklik yapabilir.

Bu, non-repeatable reads’i önlemeye yardımcı olur ve veri bütünlüğünün kritik olduğu güncellemelerde sık kullanılır.

Bir envanter sisteminde bir yöneticinin stok seviyelerini güncellediğini düşünün. Exclusive lock, yönetici stok miktarlarını güncellerken başka hiçbir işlemin o veriye erişememesini veya değiştirememesini sağlar; stok seviyelerinde tutarsızlıkları önler.

---

## 🔄 Update Locks

Update locks, hibrit bir yaklaşımdır: birden fazla işlem veriyi değiştirmeyi “niyet” olarak belirtebilir, ancak değişiklikleri gerçekten aynı anda yapmalarını birbirlerine karşı engeller.

Bu kilit türü, birden fazla işlemin güncellemeleri sıralı şekilde yapması gerektiğinde ve çatışma oluşmaması istendiğinde kullanışlıdır.

Örneğin, birden fazla satış temsilcisinin sipariş ve faturaları güncellediği bir sistemde, update locks aynı kaydı aynı anda yalnızca tek bir temsilcinin düzenleyebilmesini sağlar.

---

## ✅ Kapanış

Bu videoda, eşzamanlılık kontrol mekanizmalarını ve çok kullanıcılı ortamlardaki önemlerini öğrendiniz.

Eşzamanlılık sorunlarını, isolation levels’ı ve kilitleme mekanizmalarını anlamak, çok kullanıcılı veritabanı ortamlarını daha iyi yönetmenizi sağlar.

Eşzamanlılık kontrolü, çok sayıda kullanıcı tarafından erişildiğinde bile verinin güvenilir ve doğru kalmasını sağlayarak, karmaşık ve paylaşımlı sistemlerde veri bütünlüğünü destekler.
