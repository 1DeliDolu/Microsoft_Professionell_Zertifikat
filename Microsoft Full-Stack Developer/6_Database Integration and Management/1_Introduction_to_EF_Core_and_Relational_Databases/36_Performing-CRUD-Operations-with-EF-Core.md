## 🧩 EF Core ile CRUD İşlemleri Gerçekleştirme

CRUD işlemleri;  **Create** ,  **Read** , **Update** ve **Delete** anlamına gelir ve veri üzerinde yapılan bu işlemler, bir veritabanıyla etkileşimin temelini oluşturur.

Bu videoda, temel CRUD işlemlerini ve EF Core’da nasıl uygulandıklarını açıklayacağız.

---

## 🧠 dbContext Bileşenleri: CRUD’un Temeli

Önce *dbContext* bileşenlerini inceleyelim; çünkü  *dbContext* , CRUD işlemlerini verimli şekilde gerçekleştirmek için gerekli araçları sağlar.

Metotların yanında, CRUD işlemlerini uygularken  *dbContext* ’in iki temel bileşeni olan **dbSet** ve  **Save Changes** ’i kullanırsınız.

---

## 🗂️ dbSet

Bir  **dbSet** , veritabanınızdaki bir tabloyu temsil eder.

**Employee** gibi her entity class’ı, belirli bir dbSet’e eşlenir. Bu dbSet, sorgulayabileceğiniz, ekleyebileceğiniz, güncelleyebileceğiniz veya silebileceğiniz entity’lerden oluşan bir koleksiyon gibi davranır.

Örneğin, **Employee** türünde bir dbSet, **Employees** tablosunu temsil eder ve Employees üzerinde CRUD işlemleri yapmanızı sağlar.

---

## 💾 Save Changes

 **Save Changes** , dbContext içinde yapılan değişiklikleri veritabanına işler ( *commit* ).

İster ekleme, ister güncelleme, ister silme yapıyor olun; **Save Changes** çağrısı işlemi tamamlar ve yaptığınız değişiklikleri kaydeder.

Bu metot olmadan, yaptığınız işlemler gerçek veritabanına yansımaz.

---

## 🔄 CRUD Nedir?

CRUD,  **Create** ,  **Read** , **Update** ve **Delete** anlamına gelir.

Bunlar, bir veritabanındaki veri üzerinde yapabileceğiniz dört temel işlemdir.

Şimdi her bir işlemin ne yaptığını ve EF Core’da nasıl uygulanacağını daha ayrıntılı inceleyelim.

---

## ➕ Create

 **Create** , veritabanınıza yeni kayıtlar eklemenizi sağlayan işlemdir.

dbContext içinde yeni kayıt oluşturmak için **add** metodunu kullanabilirsiniz.

Yeni veri eklemek için önce bir entity’nin yeni bir örneğini oluşturur ve properties’ini doldurursunuz.

Sonra **add** metodunu kullanarak bunu dbSet’e eklersiniz.

Son olarak, yeni kaydı veritabanında kalıcı hâle getirmek için **Save Changes** çağırırsınız.

Bu metot, veritabanındaki bir entity’ye yeni bir kayıt (ör. bir employee) eklemenizi sağlar.

---

## 📖 Read

**Read** işlemi, veritabanınızdaki mevcut veriyi geri almanızı sağlar.

Bu işlem genellikle veriyi görüntülemek veya daha ileri işlem yapmak için sorgulama yoluyla yapılır.

Veritabanından veri almak için `find` gibi tek bir kaydı getiren metotları, eşleşen ilk kaydı almak için `firstOrDefault`’u veya birden fazla kaydı almak için `toList`’i kullanarak dbSet üzerinde sorgu çalıştırabilirsiniz.

Bu metotlar, veritabanında saklanan veriyi sorgulayarak Read işlemini yapmanıza yardımcı olur.

---

## ✏️ Update

 **Update** , mevcut kayıtları değiştirmenizi sağlar.

Bir şey değiştiğinde, veritabanınızda yeni bilgiyi yansıtmak için update işlemi yaparsınız.

dbContext içinde mevcut kayıtları değiştirmek için **update** metodu kullanılır.

Veriyi güncellerken önce `find` veya `toList` ile dbSet’ten entity’yi alırsınız, sonra properties’ini değiştirir ve **Save Changes** çağırırsınız.

EF Core bu değişiklikleri izler ( *tracks* ) ve siz kaydettiğinizde entity veritabanında güncellenir.

---

## 🗑️ Delete

 **Delete** , veritabanınızdan kayıtları kaldırmak için kullanılan CRUD işlemidir.

Bir kayıt artık gerekli değilse, yer açmak veya veriyi temizlemek için silebilirsiniz.

dbContext içinde bir entity’yi silmek, silmek istediğiniz kaydı `find` veya `toList` ile almayı, bunu **remove** metoduna vermeyi ve ardından **Save Changes** çağırmayı içerir.

**remove** metodu, bir entity’yi veritabanından silmenizi sağlar.

Entity silinmek üzere işaretlendikten sonra, değişiklikler kaydedildiğinde veritabanından kaldırılır.

---

## 🧾 Kapanış

Bu videoda, temel CRUD işlemlerini ve EF Core’da nasıl uygulandıklarını öğrendiniz.

EF Core’da bu temel işlemlere hâkim olarak, herhangi bir uygulamada veriyi yönetme potansiyelinin kilidini açarsınız.
