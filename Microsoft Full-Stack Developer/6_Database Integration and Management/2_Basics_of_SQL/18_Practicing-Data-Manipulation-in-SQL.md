## 🧪 SQL’de Veri Manipülasyonu Pratiği

Bu laboratuvarda, veriler üzerinde  **insert** , **update** ve **delete** işlemleri yapmak için SQL sorgu dilini kullanıyoruz. Yeni kayıtlar ekleyebilecek, kayıtları değiştirebilecek, tablodan bazı kayıtları kaldırabilecek ve istemediğimiz verileri kaldırmayı ya da silmeyi önleyecek bazı güvenlik tekniklerine bakacağız.

---

## 1️⃣ Adım 1: `users` Tablosunu Oluşturma

İlk olarak **users** tablosunu oluşturacağız. **EmployeesDB** adlı bir veritabanım var ve henüz içinde hiç tablo yok. Bu yüzden ilk adımda `create table` komutunu kullanarak **users** tablosunu oluşturacağız.

Bu tabloda bazı alanlar olacak: `user ID`, `first name`, `last name`, `email` ve `age`. Her birinin kendi veri tipi olacak.

Artık tabloyu oluşturduğumuza göre, veri eklemeye ve manipüle etmeye başlayabiliriz.

Her alan için, üzerinde çalışmak istediğimiz belirli alanları eklediğimize dikkat edin. Bunlar, üzerinde çalıştığınız veriye bağlı olarak herhangi bir şey olabilir. Burada, kullanıcı tipi verilerle ilişkili olanları seçtik.

---

## 2️⃣ Adım 2: Tabloya Veri Ekleme

İkinci adımda tabloya veri ekleyeceğiz ve burada `insert` özelliğini, `insert` fonksiyonunu kullanıyoruz.

`insert` kullanarak veriyi burada yaptığımız gibi manuel olarak doldurabilirsiniz ya da bir dosyadan içeri okuyabilirsiniz.

Burada, kullanıcı veritabanımıza üç kullanıcı ekliyoruz ve `query okay, three rows affected` şeklinde bir dönüş değeri görüyoruz; bu da sorgunun çalıştığı ve veritabanımıza üç satır eklediği anlamına gelir.

`insert into` kullanırken, tablo adını belirtmemiz gerekir; bu örnekte `users`. Sonra SQL’e hangi alanları ekleyeceğimizi söyleriz ve `values` kısmı da eklemek istediğimiz belirli verileri belirtir.

---

## 3️⃣ Adım 3: Belirli Bir Kaydı Güncelleme

Üçüncü adımda, belirli bir ismi güncellemek için `update` fonksiyonunu kullanacağız.

İlk adı **May** olan kullanıcıyı güncelleyeceğiz ve yaşını **26** yapacağız. Verinin yanlış girildiği ve şimdi bunu güncellemeniz gereken bir senaryo hayal edebilirsiniz.

Bunu `update` ifadesiyle yapacağız. Bu komutu çalıştırdığımızda, bir satırın güncellendiğini ve bir kaydın değiştirildiğini görebilirsiniz.

`age` değerini 26’ya eşitleyeceğiz ve hangi kaydı güncellemek istediğimizi belirtmek için bir `where` yan tümcesi kullanacağız. Buradaki `first name` değeri **May** olacak.

Gerçek dünyada, muhtemelen bir **ID** gibi bir şey kullanmak istersiniz; özellikle yüzlerce veya binlerce kaydınız olduğunda, belirli bir ID genellikle benzersizdir. Bu daha hatasız olur ve yanlışlık yapmamanızı sağlar.

Ama bu örnekte veri kümesi çok küçük olduğu için `first name` de kullanılabilir.

---

## 4️⃣ Adım 4: Bir Kullanıcıyı Silme

Dördüncü adımda, **Aisha Khan** adlı kullanıcıyı veritabanından kaldıracağız.

Bunu yapmak için `delete from` komutunu kullanacağız ve `users` tablosundan `last name` değeri **Khan** olan kullanıcıyı sileceğim:

`delete from the users table where the last name equals Khan`.

Bana bir satırın etkilendiğini söylüyor, yani veri kaldırıldı.

Burada `where` yan tümcesinde `last name equals Khan` koşulunu kullanıyoruz. Gerçek dünyada, yine kullanıcılar arasında benzersiz olan bir ID kullanmak istersiniz; ancak veri kümesi küçük olduğu için soyadı kullanabiliyoruz.

---

## 🛡️ Silmeden Önce Güvenlik Kontrolü

Bazı senaryolarda, silme işleminden önce dikkatli olmak isteriz. Bu yüzden önce bir `select` sorgusu çalıştırabiliriz.

`users` tablosundan soyadı **Garcia** olan her kullanıcıyı seçeceğiz. Bir kaydı sileceğimiz zaman, doğru kaydı sildiğimizden emin olmak isteriz.

Burada bir kullanıcı görüyoruz:  **Carlos Garcia** , veritabanımızdaki tek kayıt ve Carlos Garcia kaydını kaldırmamız gerektiğini biliyoruz.

Şimdi, soyadı **Garcia** olan kişinin kaydını kaldıracağımız bir sonraki komutu güvenle çalıştırabiliriz. Veritabanında başka Garcia olmadığı için doğru kaydı sileceğiz.

Bu sorguyu çalıştırdığımızda, kayıt veritabanından kaldırılır. Tekrar `select` yaptığımızda artık soyadı Garcia olan hiçbir kullanıcı olmadığını görürüz. Veri kaldırıldığı için boş bir sonuç kümesi görürüz.

---

## ✅ Kapanış

SQL sorgu dili kullanarak birçok işlem gerçekleştirebilirsiniz. Bunlar, bir veritabanı mühendisinin günde birçok kez uyguladığı çok temel işlemlerdir.

Bunlar, bir MySQL veritabanında veriyle etkileşime geçmenin standart yollarıdır.
