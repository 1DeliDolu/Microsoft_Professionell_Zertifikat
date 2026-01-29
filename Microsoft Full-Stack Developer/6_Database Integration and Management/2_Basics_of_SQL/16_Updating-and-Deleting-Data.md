## ✏️ Veri Güncelleme ve Silme

Büyük bir müşteri veritabanını yönettiğinizi ve birden fazla kayıtta bir hata keşfettiğinizi ya da bazı verilerin güncelliğini yitirip kaldırılması gerektiğini hayal edin. Tüm sistemi bozmadan bu değişiklikleri nasıl güvenle yaparsınız?

SQL’in `UPDATE` ve `DELETE` ifadeleri, mevcut kayıtları değiştirmek ve veriyi kaldırmak için güvenilir bir yol sağlar. Bu ifadeleri belirli koşullarla kullanarak kayıtlar doğru şekilde hedeflenebilir ve istenmeyen değişiklik riskini azaltırsınız.

Bu videoda, `UPDATE` ve `DELETE` ifadelerini kullanarak mevcut kayıtların nasıl güncelleneceğini ve kayıtların nasıl silineceğini göstereceğiz.

---

## 🧩 `UPDATE` İfadesi Ne Yapar?

SQL `UPDATE` ifadesi, bir veritabanı tablosundaki mevcut kayıtları değiştirir.

`UPDATE` ifadesi, bir veritabanı tablosunda bir veya daha fazla sütundaki veriyi değiştirmek için kullanılır. Geliştirme sürecinde, tüm kaydı değiştirmeden veriyi güncel tutmak için sıkça kullanılır.

---

## 🧱 `UPDATE` Sözdizimi

Sözdizimi `UPDATE` anahtar kelimesiyle başlar, ardından tablo adı gelir ve sonrasında `SET` yan tümcesi yer alır; bu kısım güncellenecek sütunu ve yeni değeri belirtir.

Son olarak, güncellemek istediğiniz belirli kaydı hedeflemek için bir `WHERE` yan tümcesi eklenir.

`WHERE` yan tümcesi olmadan, tablodaki tüm kayıtlar güncellenir; bu da genellikle istenen sonuç değildir.

---

## 1️⃣ Tek Bir Kaydı Güncelleme Örneği

Bir tabloda belirli bir kaydı güncellemek için `UPDATE` ifadesinin nasıl kullanılacağına dair bir örnek inceleyelim.

Bir müzik kataloğunda belirli bir şarkının türünü ( *genre* ) güncellemeniz gerektiğini varsayalım. Örneğin, **Hey Jude** şarkısı yanlış etiketlendiyse ve türünü **rock** olarak değiştirmeniz gerekiyorsa, bir `UPDATE` ifadesi kullanırsınız.

Bu ifade `UPDATE` ile başlar ve ardından tablo adı gelir; bu örnekte  *music catalog* .

Sonrasında `SET` kullanılır; güncellemek istediğimiz sütunu (`genre`) belirtir ve yeni değeri (`rock`) atarız.

Bu ifadenin önemli bir parçası `WHERE` yan tümcesidir. Bu yan tümce, hangi kayıtların güncelleneceğini belirtir. Bu örnekte koşul, şarkı başlığının **Hey Jude** olmasıdır.

`WHERE` yan tümcesi, yalnızca o başlığa sahip kaydın değiştirildiğinden ve başka hiçbir kaydın etkilenmediğinden emin olur.

---

## 2️⃣ Birden Fazla Kaydı Güncelleme

Peki, aynı anda birden fazla kaydı değiştirmek gerekirse?

Birden fazla kaydı güncellemek istediğiniz durumlarda benzer bir yaklaşım kullanırsınız; ancak `WHERE` yan tümcesindeki koşul birden fazla kaydı hedefleyecek şekilde yazılır.

Örneğin, haftalık dinleyicisi 1 milyondan fazla olan tüm şarkıları **viral** popülerlik durumuyla işaretlemek istediğinizi düşünün.

`UPDATE` ifadesi `UPDATE` ve tablo adı *music catalog* ile başlar.

Ardından, `SET` ile değiştirmek istediğiniz sütunu (`popularity`) belirtir ve yeni değer (`viral`) atarsınız.

Burada `WHERE` yan tümcesi kritiktir. Haftalık dinleyici sayısı 1 milyondan büyük olan kayıtların güncellenmesini sağlar.

Bu koşul, kriteri karşılayan birden fazla kaydı aynı anda değiştirmenize olanak tanır ve popülerlik alanlarını toplu şekilde günceller.

---

## 🗑️ `DELETE` İfadesi Ne Yapar?

`UPDATE` ile bir tablodaki veriyi nasıl değiştireceğimizi öğrendik; ancak bazen veriyi tamamen kaldırmanız gerekebilir.

Şimdi `DELETE` ifadesinin ne yaptığını ve kayıtların güvenli şekilde nasıl silineceğini inceleyelim.

`DELETE` ifadesi, tablo yapısını koruyarak istenmeyen veriyi kaldırmak için gereklidir. Bu; güncelliğini yitirmiş kayıtları, kopyaları veya artık iş gereksinimlerini karşılamayan verileri içerebilir.

---

## 🧱 `DELETE` Sözdizimi

Sözdizimi `DELETE FROM` ile başlar ve ardından tablo adı gelir.

Sonrasında, hangi verinin silineceğini belirlemek için `WHERE` yan tümcesi eklenir.

`WHERE` yan tümcesi olmadan tablodaki tüm veriler kaldırılacağı için, istem dışı veri kaybını önlemek adına bu koşulu eklemek önemlidir.

---

## 1️⃣ Belirli Bir Kaydı Silme Örneği

Kataloğunuzdan güncel olmayan veya alakasız bir şarkıyı silmeniz gerektiğini varsayalım.

Bu örnekte ifade `DELETE FROM` ile başlar, ardından tablo adı gelir;  *Music Catalog* .

`WHERE` yan tümcesi, yalnızca şarkı başlığı **Obsolete Song** olan kaydın silinmesini sağlar ve diğer kayıtları olduğu gibi bırakır.

---

## 2️⃣ Tablodaki Tüm Kayıtları Silme

Bazı durumlarda bir tablodaki tüm kayıtları silmek isteyebilirsiniz.

Müzik kataloğunuzun tamamen yeniden düzenlendiğini ve yeni girişlerle sıfırdan başlamak için tüm mevcut veriyi temizlemeniz gerektiğini varsayalım.

Bu durumda, `WHERE` yan tümcesi olmadan bir `DELETE` ifadesi kullanabilirsiniz.

İfade `DELETE FROM` ile başlar ve ardından tablo adı ( *Music Catalog* ) gelir.

`WHERE` yan tümcesi sağlanmadığı için, tablodaki tüm kayıtlar kaldırılır. Ancak tablonun yapısı korunur; böylece daha sonra yeni veri eklenebilir.

Bu yaklaşım, sistem sıfırlamalarında veya tüm veri kümesini değiştirmek istediğiniz durumlarda kullanışlıdır.

---

## 🛡️ Güvenlik Uygulamaları

İster veri güncelliyor olun ister siliyor olun, veritabanınızın güvenliğini sağlamak kritik öneme sahiptir. Şimdi, yanlışlıkla veri kaybını önlemek için bazı temel güvenlik uygulamalarını gözden geçirelim.

`UPDATE` veya `DELETE` ifadelerini kullandığınızda, belirli kayıtları hedeflemek için `WHERE` yan tümcesi eklemek çok önemlidir.

Bunu yapmamak, geniş kapsamlı değişikliklere veya silmelere neden olabilir ve verinizi tehlikeye atabilir.

Ayrıca iyi bir uygulama olarak, `UPDATE` veya `DELETE` ifadesini çalıştırmadan önce aynı `WHERE` koşuluyla bir `SELECT` sorgusu çalıştırmak ve hangi kayıtların etkileneceğini doğrulamak önerilir.

---

## ✅ Özet

Bu videoda, `UPDATE` ve `DELETE` ifadelerini kullanarak mevcut kayıtları nasıl güncelleyeceğinizi ve kayıtları nasıl sileceğinizi öğrendiniz.

Ayrıca, istenmeyen güncelleme veya silmeleri önlemek için bazı güvenlik uygulamalarını da öğrendiniz.

Bu uygulamalarla birlikte, veritabanınızın doğru ve güvenilir kalmasını sağlayacak ve tüm sisteminiz boyunca sorunsuz operasyonları destekleyeceksiniz.
