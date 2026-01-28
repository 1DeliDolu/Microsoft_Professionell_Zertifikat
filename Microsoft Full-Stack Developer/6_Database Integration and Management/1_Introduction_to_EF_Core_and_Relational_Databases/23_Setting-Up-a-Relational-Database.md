## 🧱 İlişkisel Bir Veritabanı Kurma

Bu laboratuvarda, ilişkisel bir veritabanını kurmak ve yapılandırmak için **SQL ifadelerini** kullanacağız. Bu örnekte bir **MySQL** veritabanı kullanacağız.

Geliştirme ortamını kuracağız, SQL komutlarını kullanarak veritabanı tablolarını oluşturacak ve değiştireceğiz.  **Primary key** ’ler, **constraints** ve  **foreign key** ’ler dâhil olmak üzere bir tablo yapısı tanımlayacağız; ardından bu tablolar arasındaki veri bütünlüğünü sağlamak için tablolar arasında ilişkileri zorunlu kılacağız. Ve son olarak, kurulumu sorgularla test edeceğiz.

---

## 🛠️ Adım 1: Geliştirme Ortamını Kurma

İlk adım geliştirme ortamını kurmak.  **MySQL shell** ’e giriş yapmamız gerekiyor, bu yüzden bunu **MySQL komutunu** kullanarak yapacağım.

Artık MySQL shell’in içindeyim ve veritabanının kendisiyle çalışmaya hazırım.

---

## 🗃️ Adım 2: Veritabanını Oluşturma ve Seçme

Yapmak istediğim ilk şey veritabanını oluşturmak ve bunu yapmak için `create database` komutunu kullanacağım.

Veritabanımıza **techcorpdb** adını vereceğiz.

Bu, veritabanını oluşturdu. `query OK` mesajını görüyorsunuz ve *one row affected* var; bu sadece veritabanının oluşturulduğu anlamına geliyor.

Şimdi, alıştırmanın geri kalanında doğru veritabanını kullandığımızdan emin olmak için `use` komutunu kullanacağım.

Veritabanı bana veritabanının değiştiğini bildirdi ve artık veritabanımızla çalışmaya devam etmeye hazırız.

---

## 🏢 Departmanlar Tablosunu Oluşturma

İlk yapmak istediğimiz şey **departments** adında bir tablo oluşturmak.

Bu tabloda yapacağımız birkaç şey var. `ID`’nin `auto-increment` olduğunu fark edeceksiniz; bu, her yeni satır oluşturulduğunda otomatik olarak oluşturulacağı anlamına gelir ve bu bizim  **primary key** ’imiz olacak.

Departman adının benzersiz olmasını istiyoruz. Veritabanı, benzersiz değilse kullanıcıların yeni bir departman adı eklemesine izin vermeyecek ve bu alan tabloya veri yazılırken `null` olamaz.

**departments** tablomuz oluşturuldu ve şimdi bir **employees** tablosu oluşturacağız.

Aynı komutu, `create table` komutunu kullanacağız ve bu alanlar üzerinde de bazı özellikler ayarlayacağız.

---

## 👥 Employees Tablosunu Oluşturma

Şimdi iki tablo da oluşturuldu. MySQL bize `query OK` mesajıyla ikisinin de bu sorguyla oluşturulduğunu söylüyor.

**employees** tablosu için bir `employee ID`’miz var; bu bir `int` değeridir. Aynı zamanda `auto-increment` ve bu **primary key** olarak hizmet edecek.

İlk adla departman adında olduğu gibi, bu alan `null` olamaz ve `unique` olmak zorunda.

Ardından `department ID`’yi de `int` olarak ekliyoruz ve bu, departments tablosuyla bir **foreign key** oluşturmamıza izin verecek; böylece bu tablolar arasındaki veri bütünlüğünü sağlayabileceğiz.

---

## ➕ Adım 3: Sütun Ekleme

Üçüncü adımda bir sütun ekleyeceğiz.

Bu alıştırmada, `alter table` komutunu kullanarak employees tablosunu değiştireceğiz. Devam edin ve bunu çalıştırın.

Bu, `last name` adında bir sütun ekledi; **50’lik bir bar chart** ile ve ayrıca `null` olamaz.

Bu alıştırmayı ilerletirken tabloya veri ekleyebileceğiz ve artık employees tablosunda bir `last name` var.

---

## 🔗 Adım 4: Foreign Key Ekleme

Şimdi dördüncü adımda veritabanımıza bir **foreign key** ekleyeceğiz ve bu, employees tablosundaki bir alanı departments tablosundaki bir alanla ilişkilendirmemize olanak tanıyacak; böylece iki tablo arasındaki veri bütünlüğünü sağlayabileceğiz.

Yine `alter table` komutunu kullanacağız ve o tabloya `department ID` için bir `constraint` ekleyeceğiz.

`constraint F key underscore department` ekliyoruz; bu, `department ID` üzerinde bir foreign key oluşturur ve departments tablosundaki `department ID`’ye referans verir.

Artık bu iki anahtar ilişkilendirilecek ve departments tablosu için bir `department ID` eklemeden employees tablosuna bir kayıt ekleyemeyiz.

---

## ✅ Adım 5: Kurulumu Test Etme

Beşinci adımda kurulumu test edeceğiz; bu yüzden **departments** tablomuzu sorgulayacağız.

Tablonun nasıl göründüğünü görmek için `describe` ifadesini kullanacağım. Ve alanlarımızı orada görebiliyoruz.

Bir `department ID` ve bir `department name` var; bu iyi.

Şimdi, employees tablomuzda referans verebileceğimiz belirli departmanlara sahip olması için departments tablosuna bazı değerler ekleyeceğiz.

Bunun için `insert into` komutunu çalıştıracağım.

Üç kayıt ekledik. Departments tablosuna değer olarak  **HR** , **engineering** ve **marketing** ekledik.

Artık bunlar departments tablosunun bir parçası ve her birinin birden üçe kadar benzersiz bir ID’si olacak.

Şimdi employees tablosuna bazı kayıtlar ekleyeceğiz ki onları referans verebilelim.

Employees tablosuna altı kayıt ekledik. Artık bir foreign key constraint olduğu için bir `department ID` eklemek zorunda olduğumuza dikkat edin.

`department ID`’ye referans verdik ve sadece  **1** , **2** ve **3** değerlerini kullanıyoruz; çünkü departments tablosuna kayıtları eklediğimizde oluşturulan değerlerin bunlar olduğunu biliyoruz.

---

## 🔎 JOIN ile Veriyi Doğrulama

Şimdi bunu test edelim. Employees tablosundaki kayıtları görebildiğimizden emin olalım ve departments tablosundaki foreign key üzerinden `join` yapacağız.

`join` ifademiz, employees `department ID`’sinin departments `department ID`’sine eşit olduğu yerde employees `department ID` üzerinden departments tablosunu birleştiriyor.

Yani, employees tablosundaki bu foreign key’i kullanarak iki tabloyu bu şekilde eşleştiriyoruz.

Bu da bize employees için `first` ve `last name`’i veriyor.

Ve ardından, employees tablosundaki foreign key’i kullanarak departments tablosundan `department name`’i çekiyor.

Yani veriyi veritabanından bu şekilde alabiliyoruz.

Çıktı tek bir tablo gibi görünüyor, ama bu ilişkiyi ikisi arasında kurmak için foreign key’i kullanıyoruz.

Bu, SQL ifadelerini yalnızca bir veritabanını kurmak, oluşturmak ve doldurmak için değil; aynı zamanda sorgulamak ve bazı kısıtlar oluşturmak için foreign key’leri kullanarak veri bütünlüğünü sağlamak amacıyla da nasıl kullanabileceğinizdir.
