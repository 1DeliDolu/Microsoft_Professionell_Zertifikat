## 🧰 Temel SQL Komutlarının İşlevlerini Tanımlama

Veritabanları, neredeyse her modern uygulamanın merkezindedir. Onlarla nasıl etkileşim kurulacağını anlamak, veriyi verimli biçimde yönetmek ve geri almak için критiktir. Kayıtları görüntülemek, güncellemek veya yeni veri eklemek gibi işlemler için SQL, bu görevleri yerine getirmede güçlü araçlar sunar.

Bu videoda, temel SQL komutlarının işlevlerini tanımlayacağız. `SELECT`, `INSERT INTO`, `UPDATE` ve `DELETE` gibi SQL’in temel komutlarına dair zaten temel bir anlayışa sahipsiniz. Şimdi bu bilgiyi daha ileri taşıyalım ve bu komutların farklı durumlarda veriyi etkin biçimde yönetmek ve manipüle etmek için nasıl çalıştığını inceleyelim.

---

## 🔎 `SELECT` Komutu ile Veri Getirme

`SELECT` komutu, tanımladığınız sütunlara veya koşullara göre bir tablodan belirli verileri getirir.

Bir çalışan veritabanıyla çalıştığınızı varsayalım. Öncelikle bir tablodaki tüm veriyi seçmeniz gerekir. `SELECT` kullanarak her satırı ve her sütunu içeren tüm veriyi geri alabilirsiniz.

Şimdi bunu daraltalım. Belki de tüm sütunlara ihtiyacınız yoktur, yalnızca belirli olanlara ihtiyacınız vardır. Pazarlama departmanında olan çalışanların bir listesini istediğinizi düşünün. Burada, departmana göre veriyi filtrelemek için `WHERE` ile birlikte `SELECT` kullanırsınız.

Son olarak, `SELECT` komutunu daha karmaşık sorgular için de kullanabilirsiniz; örneğin geri alınacak kayıt sayısını belirlemek gibi. *employees* tablosundan en yüksek maaş alan ilk 5 çalışanı getirmek istediğinizi hayal edin. Döndürülen satır sayısını sınırlamak için `SELECT TOP` kullanabilirsiniz.

Bu, yalnızca maaş gibi belirli kriterlere göre ilk birkaç sonuçla ilgilendiğinizde faydalıdır. Örneğin, `SELECT TOP 5` yalnızca ilk 5 satırı döndürür; genellikle `ORDER BY` yan tümcesiyle birleştirildiğinde maaşa göre sıralanmış olur. Bu, tüm veri kümesini işlemeye gerek kalmadan hızlı özetler üretmek için yardımcıdır.

---

## ➕ `INSERT INTO` Komutu ile Veri Ekleme

Bir tablodan veri almaktan daha fazlasını yapmak istiyorsanız; yani veri eklemek istiyorsanız, burada `INSERT INTO` komutu devreye girer.

`INSERT INTO`, bir tabloya yeni veri eklemeyi sağlar. Şirketinizde yeni bir çalışanın başladığını ve onun için veritabanına yeni bir kayıt eklemeniz gerektiğini varsayalım. Sütunları ve değerleri belirterek bir tabloya yeni bir veri satırı eklemek için `INSERT INTO` kullanabilirsiniz.

Bir başka senaryo, yeni bir stajyer grubunun aynı gün şirkete başlaması olabilir. `INSERT INTO` ile birden fazla kayıt da ekleyebilirsiniz.

Son olarak, ayrı bir *interns* tablonuz olduğunu ve yeni stajyer kayıtlarını *employees* tablosundan *interns* tablosuna kopyalamak istediğinizi düşünün. Kayıtları bir tablodan diğerine kopyalamak için `INSERT INTO` ve `SELECT` komutlarının bir kombinasyonunu kullanabilirsiniz.

---

## ✏️ `UPDATE` Komutu ile Mevcut Veriyi Güncelleme

Tablonuzda zaten var olan veriyi güncellemeniz gerekiyorsa, mevcut veriyi değiştirmek için `UPDATE` komutunu kullanabilirsiniz.

Diğer komutlarda olduğu gibi, `UPDATE` komutunu tek bir kaydı veya gerekirse birden fazla kaydı değiştirmek için kullanabilirsiniz. Örneğin, bir veya daha fazla çalışanın maaşını değiştirmek için `UPDATE` komutunu kullanabilirsiniz.

Ayrıca, başka bir tablodan gelen veriyi kullanarak, yan tümce içinde bir alt sorguya ( *subquery* ) dayalı olarak bir kaydı güncelleyebilirsiniz. Bu, güncellemeniz gereken verinin veritabanınızın başka bir yerinde depolanan bilgilere bağlı olduğu durumlarda özellikle kullanışlıdır.

Örneğin, *employees* tablosunda bir çalışanın departmanını güncellemek istediğinizi, ancak bu departman bilgisini ayrı bir *departments* tablosundan çekmeniz gerektiğini hayal edin. Bir alt sorgu kullanarak, *departments* tablosundaki bir departman kimliğini ( *ID* ) eşleştirip *employees* tablosundaki departmanı buna göre güncelleyebilirsiniz.

---

## 🗑️ `DELETE` Komutu ile Veri Silme

`DELETE` anahtar kelimesi, bir tablodan veri kaldırır. `UPDATE` komutuna benzer şekilde, `DELETE` komutunu tek bir kaydı silmek, birden fazla kaydı silmek veya bir alt sorguya ( *subquery* ) dayalı olarak kayıt silmek için kullanabilirsiniz.

Ayrıca, bir tablodaki tüm kayıtları da silebilirsiniz.

Geliştiriciler bu amaçla `DELETE` komutunu nadiren kullanır, çünkü bu işlem geri alınamaz. Ayrıca, bir tablodaki tüm kayıtları silmenin tabloyu silmediğini de belirtmek önemlidir; tablo yapısını ve şemasını korur.

Bir tabloyu silmek için `DROP` komutunu kullanabilirsiniz.

---

## ✅ Özet

Bu videoda, temel SQL komutlarının işlevlerini öğrendiniz. Bu temel SQL komutlarında ustalaşarak; veriyi geri alma, ekleme, güncelleme veya silme gibi çoğu veri yönetimi görevini etkili biçimde ele alabilecek duruma geleceksiniz.

SQL, veritabanı sistemlerinizi sürdürmek ve optimize etmek için güçlü bir araç seti sunar. Herhangi bir ilişkisel veritabanını yönetirken kendinize güven kazanmak için bu komutları pratik edin.
