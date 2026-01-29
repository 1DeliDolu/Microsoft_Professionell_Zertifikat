## 🔄 SQL İşlemlerine Giriş

Veritabanında değişiklik yaptığımızda, bunların sorunsuz ve doğru şekilde gerçekleşmesine güveniriz. SQL işlemleri ( *transactions* ), ne olursa olsun verinin tutarlı kalmasını sağlayarak güven oluşturur. Bu videoda, SQL’de işlemler kavramını ve veri bütünlüğünü ( *data integrity* ) korumadaki rollerini açıklayacağız.

---

## 📌 SQL Transaction Nedir?

Önce, bir SQL işleminin ne olduğunu tanımlayalım.

Veritabanlarında bir SQL işlemi, tek bir mantıksal iş birimi içinde gerçekleştirilen bir dizi işlemdir. Bunu, her bir parçası diğerlerinin başarılı olmasına bağlı olan bir değişiklik paketi gibi düşünebilirsiniz. Eğer bir parça başarısız olursa, tüm işlem geri alınır ( *rolled back* ) ve veri doğruluğu korunur.

---

## 🧱 ACID Özellikleri

Bu anlayışla birlikte, işlem güvenilirliğini garanti eden dört ilke olan ACID özelliklerini inceleyelim.

ACID,  *Atomicity* ,  *Consistency* , *Isolation* ve *Durability* kelimelerinin baş harflerinden oluşan bir kısaltmadır. Şimdi her birini, Atomicity ile başlayarak açıklayalım.

---

## ⚛️ Atomicity

Atomicity, bir işlemin tek, tam ve bölünemez bir eylem olması ilkesidir. İşlem içindeki her şey ya gerçekleşir ya da hiçbir şey gerçekleşmez. Bir işlemin tek bir parçası bile başarısız olursa, değişikliklerin hiçbiri uygulanmaz. Bu özellik, hatalara yol açabilecek kısmi güncellemeleri önler.

Bunu bir bankacılık sisteminde iki hesap arasında para transferi gibi düşünün. İki adım gerçekleşmelidir: bir hesaptan belirli bir tutarın düşülmesi ve diğerine eklenmesi.

---

## ✅ Consistency

Şimdi bir sonraki özellik olan Consistency’yi ele alalım.

Consistency, bir işlemin veritabanını tüm kuralları, kısıtlamaları ve veri bütünlüğü gereksinimlerini takip ederek bir geçerli durumdan başka bir geçerli duruma taşımasını sağlayan ilkedir.

Bu ilke, veritabanını hatalı hâle getirecek veya kurallarını bozacak değişiklikleri engeller. Her güncellemenin tüm veri gereksinimlerine uymasını sağlayarak doğruluğu korur.

Örneğin bir banka transferi işlerken, hesap bakiyesinin sıfırın altına düşmesine izin vermez; böylece hesap kayıtları geçerli kalır.

---

## 🔒 Isolation

Şimdi, aynı anda birden fazla işlemi yönetmek için kritik bir özellik olan Isolation’a odaklanalım.

Isolation, her işlemin bağımsız çalışmasını sağlayan ilkedir; böylece bir işlemin yaptığı değişiklikler, diğer işlemler tamamlanana kadar onları etkilemez.

Birden fazla işlem aynı anda gerçekleştiğinde, isolation onların birbirlerinin verilerine müdahale etmesini önler. Yani işlemler zaman olarak çakışsa bile, her biri sanki o anda tek işlemmiş gibi çalışır; veri uyuşmazlıkları veya yanlışlıkla üzerine yazma ( *accidental overwrites* ) gibi sorunlardan kaçınılır.

Örneğin, iki kullanıcı aynı anda aynı hesap bakiyesini güncellemeye çalışırsa, isolation her güncellemenin bağımsız şekilde gerçekleşmesini sağlar.

---

## 🧷 Durability

Son olarak, Durability özelliğini ele alalım.

Durability, sistem çökse bile tamamlanmış değişikliklerin kalıcı olarak kaydedilmesini sağlayan ilkedir.

Durability, commit edilmiş bir işlemin sonuçlarının kalıcı olmasını garanti eder ve veri depolama için güvenilirlik sağlar.

Örneğin, bir banka transferi tamamlandıktan sonra, durability güncellenmiş bakiyelerin kalıcı olarak kaydedilmesini sağlar; böylece sistem hemen ardından çökse bile bakiyeler doğru kalır.

---

## 🧾 İşlemleri Kontrol Eden SQL Komutları

ACID özelliklerini gözden geçirdiğimize göre, şimdi işlemleri kontrol etmek için kullanılan SQL komutlarını konuşalım.

SQL’de işlemlerle çalışmak için `BEGIN TRANSACTION`, `COMMIT` ve `ROLLBACK` gibi komutları kullanırız.

---

## ▶️ `BEGIN TRANSACTION`

`BEGIN TRANSACTION` komutu, herhangi bir işlemin başlangıcını işaret eder.

`BEGIN TRANSACTIONS`, işlemi başlatan ve ardından gelen eylemleri tek bir iş birimi olarak gruplayan komuttur. Bu komutu kullandıktan sonra, ondan sonra yapılan tüm işlemler, değişiklikleri ya `COMMIT` ya da `ROLLBACK` edene kadar tek bir işlemin parçası olur.

İki hesap arasında para transferi yapmanız gereken durumu hatırlayın. Bu transfer için TRANSACTION komutunu şöyle kullanırsınız: Önce, bundan sonra olacak her şeyin bu işlemin bir parçası olduğunu belirtmek için `BEGIN TRANSACTION` ile başlarsınız. Ardından gönderenin hesabından parayı düşer ve alıcının hesabına eklersiniz.

---

## ✅ `COMMIT`

İşlem başlatıldıktan sonra bir sonraki komut `COMMIT`’tir.

`COMMIT`, işlemi sonlandıran ve tüm değişiklikleri veritabanına kalıcı olarak kaydeden komuttur. İşlemin başarıyla tamamlandığını ve ACID özelliklerinin sağlandığını bildirir; böylece veri bütünlüğü korunur.

Banka transferi örneğinde, hem gönderen hesaptan düşme hem de alıcı hesaba ekleme işlemleri başarılı olursa, `COMMIT` bu değişiklikleri kalıcı olarak kaydeder ve işlemin tamamlanıp doğru şekilde gerçekleştiğini onaylar.

---

## ↩️ `ROLLBACK`

Bir işlem sırasında bir şeyler ters giderse, değişiklikleri geri almak için `ROLLBACK` komutunu kullanırız.

`ROLLBACK`, işlemi iptal eden ve işlem başladıktan sonra yapılan tüm değişiklikleri geri alan komuttur. Bir hata oluşursa veya işlemin herhangi bir parçası başarısız olursa, tamamlanmamış değişiklikleri iptal ederek veri doğruluğunu korumak için `ROLLBACK` kullanırız.

Para transferi örneğiyle devam edersek, yol boyunca herhangi bir şey başarısız olursa — örneğin gönderenin bakiyesi yetersizse — `ROLLBACK` her şeyi geri alır ve iki hesabı da işlem başlamadan önceki hâline döndürür.

Bu süreç, hesapların dengede kalmasını sağlar ve ACID özelliklerinin koruduğu veri bütünlüğünü garanti eder.

`BEGIN TRANSACTION`, `COMMIT` ve `ROLLBACK` komutlarını birlikte kullanmak, veritabanının güvenilir, tutarlı ve doğru kaldığını bilerek karmaşık işlemleri güvenle yönetmemizi sağlar.

---

## 🏁 Kapanış

Bu tür işlemler, veri tutarlılığının kritik olduğu uygulamalar için gereklidir.

Bu videoda, SQL’de işlemleri ve veri bütünlüğünü korumadaki rollerini öğrendiniz. İşlemler, karmaşık değişiklikler sırasında bile verinin sağlam ve güvenilir kalmasını sağlar.

İşlemleri anlayıp kullanarak, yalnızca veriyi yönetmekle kalmaz; aynı zamanda bir veritabanındaki her etkileşimi destekleyen güvenilirlik temeli de oluşturursunuz.
