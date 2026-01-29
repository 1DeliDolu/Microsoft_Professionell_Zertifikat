## 🧪 SQL Fonksiyonları ve Toplu ( *Aggregate* ) Fonksiyonları Uygulama

Bu laboratuvarda, SQL fonksiyonlarını uygulamayı ve toplu ( *aggregate* ) fonksiyonları kullanmayı pratik etmek için **EmployeeDB** adlı bir veritabanı kullanacağız. Böylece veriyi manipüle edebilecek ve SQL sorgularıyla analiz edebileceğiz.

İlk olarak, MySQL istemindeyim. Yapacağımız ilk şey veritabanını oluşturmak. Bu yüzden  **EmployeesDB** ’yi oluşturacağım; bu bizim örnek veritabanımız olacak ve ardından bu veritabanını kullandığımdan emin olacağım.

Artık veritabanındayız ve veriyi manipüle etmeye ve veritabanını bazı verilerle doldurmaya başlayabiliriz.

---

## 2️⃣ Adım 2: `employees` Tablosunu Kurma ve Veriyle Doldurma

İlk yapacağım şey bir **employees** tablosu oluşturmak; bu artık ikinci adım.

İkinci adımda, employees tablomuzu kuracağız ve ardından onu veriyle dolduracağız.

Bu sorguda `create table` komutunu kullanıyoruz. Burada alanlar var: `employee ID`, `first name`, `last name`, `department`, `salary` ve `hire date`. Her birinin kendi veri tipi var.

`employee ID`’nin `auto increment` olarak ayarlandığını ve aynı zamanda `primary key` olduğunu fark edeceksiniz.

Bu alana veri göndermek zorunda değiliz; otomatik olarak oluşturulacak ve önceki oluşturulan kaydın numarasını bir artırarak devam edecek. Diğer verileri ise bizim girip doldurmamız gerekecek.

Şimdi bunu yapalım.

Employees tablosuna, ileride daha fazla sorgu çalıştırmak için kullanabileceğimiz örnek verileri ekleyeceğiz.

Artık yedi kayıt oluşturduk: ad ve soyad, hangi departmanda oldukları, maaşlarının ne kadar olduğu ve işe giriş tarihleri.

ID alanını girmek zorunda olmadığımıza dikkat edin; bunu SQL oluşturuyor.

---

## 🔧 `SELECT` ile Fonksiyon Kullanarak Veri Sorgulama

Şimdi veriyi içine eklediğimize göre, bazı `select` ifadeleriyle sorgulayacağız ve `select` ifadelerimizle birlikte çeşitli fonksiyonlar kullanabileceğiz.

İlk olarak, ad ve soyadı birleştirerek sorgudan tam ad döndürmek istiyoruz.

Bunun için `concat` kullanacağız; ad ve soyad arasına bir boşluk koyacağız ve sonucu tam ad olarak alacağız.

Böylece veritabanındaki her kullanıcıyı, her çalışanı alırız ve ad ile soyadı arada boşluk olacak şekilde görürüz.

Departmanları veritabanına eklerken departman adlarının büyük harf olmadığını, cümle biçiminde yazıldığını hatırlayın.

Bu fonksiyon olan `upper`, departman adlarını büyük harfe çevirir ve employees veritabanından tüm departman adları büyük harfe çevrilmiş bir tablo döndürür.

Bu, tüm isimleri büyük harfe çevirmemizi sağlayan basit bir fonksiyondur.

Son olarak, bu komutu kullanacağız; bu komut yalnızca adın uzunluğunu verir.

Yüzeyde çok pratik bir sorgu gibi görünmeyebilir; ancak bazen bir şeyin uzunluğunu bilmeniz gerekir.

Veriyi taşıdığınız hedef veritabanı, belirli bir alan için yalnızca belirli bir uzunluğu kabul ediyorsa, bu uzunluğu test etmek ve hedef veritabanına sığması için nerede birleştirmeniz veya boyutu azaltmanız gerektiğini belirlemek isteyebilirsiniz.

---

## 3️⃣ Adım 3: Toplu ( *Aggregate* ) Fonksiyonları Kullanma

Üçüncü adımda, toplu ( *aggregate* ) fonksiyonları kullanacağız.

Bu fonksiyonlar; sayma, ortalama alma, maksimumu bulma gibi işlemleri yapmamızı sağlar.

Bu sorgularla, SQL sorgu dilinin daha ileri özelliklerini kullanarak verinizi daha derin inceleyebileceğinizi ve tam olarak ihtiyacınız olan veriyi elde edebileceğinizi göstereceğiz.

İlk sorgu, veritabanındaki tüm çalışanları sayar.

Her şeyi sayıp, `total employees` olarak döndürüyoruz ve bu çıktıyı employees tablosundaki veriden alıyoruz.

Bu, birçok senaryoda çok faydalı olabilir.

Bu çok basit bir veri kümesi, ancak bu tür toplu işlemlerin ne kadar kullanışlı olabileceğini hayal edebilirsiniz.

Şimdi tüm çalışanlar için ortalama maaşı alacağız.

Sonuç 74.000 çıkıyor.

Bu, büyük sayılarla çalışırken kullanması güzel bir fonksiyondur.

`max salary`, veritabanındaki tüm çalışanlar arasında en yüksek maaşı bulur ve en yüksek olanı seçer.

Ve bir sonraki sorgu da en düşük olanı bulur.

Bu veritabanında en yüksek kazanan 93.000 ve en düşük kazanan 60.000.

`min` ve `max`, her satırı manuel olarak incelemek zorunda kalmanızı engeller.

Bu yöntemle, bu fonksiyonla tek bir veri noktası sağlar.

---

## 4️⃣ Adım 4: `GROUP BY` Kullanma

Dördüncü adımda, SQL sorgu dilinde `group by` özelliğini veya fonksiyonunu kullanacağız.

İlk sorgumuzda maaşları seçeceğiz, ancak bunları departmana göre gruplayacağız.

Burada departmanı seçiyoruz.

`sum` ile maaşları `total salary` olarak topluyoruz; bunun sağ taraftaki sütun olduğunu görebilirsiniz.

Bunu employees tablosundan alıyoruz ve `group by department` kullanıyoruz.

Artık engineering departmanının toplam maaşının 178.000, marketing’in 149.000 olduğunu vb. biliyoruz.

Bu, `group by` kullanarak departmana göre gruplamamızı sağlar.

Şimdi aynı şeyi yapacağız; ancak bu kez her departmanda kaç çalışan olduğunu sayacağız.

Yine departmana göre grupluyoruz ve maaş yerine `employee count` alıyoruz.

---

## 🧩 Son Adım: Birden Fazla Fonksiyonu Birleştirme

Son adımda, `concatenation` fonksiyonunu `average` ve `where` yan tümcesiyle birlikte kullanacağız.

Burada, tek bir dönüş değeri üretmek için birden fazla fonksiyonu birleştiriyoruz.

SQL ifadeleriniz çok karmaşık hâle gelebilir; ancak aynı zamanda çok güçlüdür.

Burada ad ve soyadı birleştirerek `full name` olarak döndürüyoruz; bu ilk sütunumuz oluyor.

Maaşı ortalıyoruz; bu da ikinci sütunda ortalama maaşı veriyor.

Ayrıca işe giriş tarihinin 1 Ocak 2020’den büyük olduğu koşuluna bakıyoruz.

Bu bize tek bir isim döndürüyor.

Bu kişi yıllık ortalama 69.000 maaşa sahip.

Bunu alabiliyoruz çünkü tek bir `select` ifadesinde birden fazla fonksiyonu birlikte kullanabiliyoruz.

Bu işi yapmak için birden fazla ifade yazmak yerine, bunu tek bir ifadede yazabiliriz; bu konsolide olur ve çok güçlü olabilir.

---

## ✅ Kapanış

SQL ifadelerini kullanarak veriye karşı çok fazla iş yapabilirsiniz.

Bu çok basit bir veritabanı şeması ve çok basit bir veri; ancak SQL sorgu dilini bu bağlamda kullanarak verinizi manipüle etmek ve analiz etmek için çok güçlü sorgular üretebileceğinizi hayal edebilirsiniz.
