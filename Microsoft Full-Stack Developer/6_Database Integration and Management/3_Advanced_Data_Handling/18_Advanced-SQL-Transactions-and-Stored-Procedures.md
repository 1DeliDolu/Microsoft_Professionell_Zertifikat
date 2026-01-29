## 🧪 İleri SQL, İşlemler ve Saklı Yordamlar

Bu laboratuvarda, *EmployeeDB* adlı örnek bir veritabanında işlemler ( *transactions* ) ve saklı yordamlar ( *stored procedures* ) oluşturmak için SQL sorgu dilini kullanacağız.

---

## 🗄️ Adım 1: Veritabanını ve Tabloyu Kurma

Birinci adımda veritabanını kuracağım; fakat bunu yapmadan önce MySQL istemine ( *prompt* ) girmem gerekiyor. Bu yüzden şu komutu kullanacağım, parolamı gireceğim ve artık MySQL istemindeyim; böylece veritabanını ve tabloyu oluşturmaya başlayabilirim.

İlk yapacağım şey, *EmployeeDB* adlı veritabanını oluşturmak ve ardından bu veritabanını kullandığımdan emin olmak.

Tamam, artık veritabanının içindeyiz ve ihtiyaç duyduğumuz tabloyu oluşturmaya başlayabiliriz. Bunu yapmak için *create table* komutunu kullanacağız ve belirli sütunlar ekleyeceğiz.

Tamam, farklı veri tipleriyle  *employee ID* ,  *first name* ,  *last name* ,  *department* , *salary* ve *hire date* alanlarına sahip *Employees* tablomuzu oluşturduk.

Şimdi bu tabloyu bazı örnek verilerle dolduracağız ve tablomuzdaki her sütun için öğeler içerecek örnek veriler ekleyeceğiz.

Tamam, burada beş satır oluşturduk; yani tablomuzda beş kayıt var ve artık onlarla etkileşime geçebiliriz.

---

## 🔒 Adım 2: Transaction ve Concurrency Seviyelerini Ayarlama

İkinci adımda bazı işlem ( *transaction* ) ve eşzamanlılık ( *concurrency* ) seviyeleri ayarlayacağız.

İlk kullanacağım komut, işlem yalıtım seviyesini ( *transaction isolation level* ) *serializable* olarak ayarlamak olacak. Tamam, *query OK* ifadesi, bunun sorunsuz çalıştığını söylüyor.

Şimdi çalışanın kaydını güncelleyeceğim ve bunu yapmak için bir işlem ( *transaction* ) kullanacağım. İşlem, bir süreci başlatmamıza ama `commit` seçeneğini seçene kadar tamamlamamamıza izin verir.

Bu yüzden ilk adım olarak işlemi başlatacağım ve şimdi *marketing* için maaşı mevcut maaştan 5.000 çıkaracak şekilde güncelleyeceğim.

Şunu fark edeceksiniz: *update employees* dedim ve maaşı mevcut maaş eksi 5.000 olacak şekilde ayarladım; *department equals marketing* koşuluyla.

Bu değişiklik henüz `commit` edilmedi. Güncellemiş olmamıza rağmen henüz commit edilmedi; çünkü `commit` komutunu kullanmadık.

Aynı şeyi *finance* için de yapacağım, fakat onların maaşını 5.000 artıracağım.

Şimdi iki değişikliğimiz var. Bu değişiklikler veritabanında değil.

Şimdi bu değişiklikleri `commit` komutunu kullanarak commit edeceğim. Ve artık veritabanına commit edildiler. Veri kümesinin bir parçası oldular.

Bu, veritabanınızda değişiklikleri dikkatli şekilde yaptığınızdan emin olmak istediğinizde çok faydalıdır ve ardından bu değişiklikleri işlemsel ( *transactional* ) bir biçimde yapmanıza olanak tanır.

Tablolarımın kilidini kaldıracağım ( *unlock my tables* ). Değişikliklerimi veritabanına commit ettim.

---

## 🧮 Adım 3: SELECT ile Gelişmiş Hesaplamalar ve Alt Sorgu

Veritabanından veri almak için `select` ifadelerini kullanabiliriz; fakat `select` ifademizin içinde, ihtiyacımız olan veriyi özellikle almak için bazı gelişmiş hesaplamalar da kullanabiliriz.

Bu ifadede, *employees* tablosundan seçeceğiz;  *first name* , *last name* ve *salary* alanlarını alacağız ve maaşı, tüm çalışanların ortalama maaşından daha büyük olan çalışanları seçeceğiz.

Bir `select` ifadesinin içinde bir `select` ifademiz var.

Parantez içinde *select average salary from employees* var ve maaşı bu ortalamadan daha büyük olan çalışanları seçeceğiz.

Ve bu da bize şunu veriyor: Tüm çalışanların ortalamasından daha büyük olan üç isim ve onların maaşları.

---

## 🧾 Adım 4: Common Table Expression (CTE) ile Çalışma

Dördüncü adımda bir common table expression, yani bir CTE ile çalışıyoruz ve bu, özünde geçici bir tablo oluşturmamıza ve ardından o geçici tabloya karşı `select` ifadeleri çalıştırmamıza izin veriyor.

Çıktının kendisi bir tablo olacak; fakat burada seçme işlemi, bu tür bir SQL komutuyla oluşturduğumuz tablodan yapılıyor.

Bu ifadede,  *department salaries* ’i geçici bir tablo olarak kullanıyoruz ve bu geçici tablo, *employees* tablosundan departmanı ve bazı salary değerlerini toplam maaş ( *total salary* ) olarak seçmekten oluşuyor; ardından departmana göre gruplanıyor ( *group it by department* ).

Sonrasında, oluşturduğumuz *department salaries* tablosundaki tüm kayıtları seçiyoruz.

Ve bize şunu veriyor: tüm departmanlar —  *finance* ,  *IT* ,  *marketing* , *HR* — ve bu departmanların her biri için toplam maaş; departmana göre gruplanmış şekilde.

Bu tür bir sorgu, geçici tabloyu kullanarak verinin çok belirli bir görünümünü görmemizi sağlar; doğru adıyla bu, verileri hesaplamak için kullanılan bir common table expression’dır.

---

## 🧰 Adım 5: Stored Procedure Oluşturma

Beşinci adımda aslında bir stored procedure oluşturacağız.

SQL’de stored procedure’ler, veri geçirip veri geri alabileceğiniz küçük uygulamalar, küçük programlar gibidir.

Burada veritabanımdaki hangi varlıkların ( *entities* ) olduğunu gösteren küçük bir aracım var. *employee DB* veritabanımı ve *employees* tablomu göreceksiniz.

 *procedures* ’a tıklayacağım ve orada hiçbir şeyin görünmediğini göreceksiniz. Henüz prosedürlerimiz yok.

Bu yüzden, bir stored procedure oluşturmak için bu SQL komutunu kullanacağız. O prosedürü oluşturduğumuzda, onu iş yapmak için kullanabileceğiz.

O halde prosedürü bu komutu kullanarak oluşturayım.

Artık *adjusted salary* adlı prosedüre sahibiz ve departman adını ve departman tutarını ( *department amount* ) geçebiliyoruz.

Ardından, esasen bir SQL ifadesi çalıştıracak:  *update employees salary equals the salary plus the adjustment amount where the department equals the department name that we passed in* .

Yani bu küçük bir rutin, küçük bir fonksiyon; sonra da o fonksiyonun sonuçlarını döndürecek.

Şimdi veritabanımızı yenilersek ( *refresh* ), *procedures* altında  *adjusted salary* ’i görürsünüz ve artık bunu kullanabiliriz.

Diğer SQL ifadelerinden  *adjusted salary* ’i çağırarak, bu stored procedure’ün içindeki işi yaptırabiliriz.

---

## 🧪 Adım 6: Function Oluşturma

Altıncı adımda bir fonksiyon oluşturacağız; bu, bir stored procedure fonksiyonuna çok benzer.

Veri geçebilirsiniz ve stored procedure’lerde veri geri alırsınız.

Bu fonksiyonda ise esasen bir sonuç kümesi ( *result set* ) geri almak yerine tek bir değer geri alıyorsunuz.

Geçtiğimiz şeye göre bir bonus hesaplayacağız; maaşı geçeceğiz ve sonra bunu belirli bir sayı ile çarpacağız ve bir değer geri alacağız.

O prosedürü oluşturacağız.

*functions* altında, henüz hiçbir fonksiyonumuz olmadığını göreceksiniz.

Bu yüzden SQL komutunu çalıştıracağız. *query OK* ifadesi, sorgunun sorunsuz çalıştığını söylüyor.

Ve şimdi yenilediğimde ( *refresh* ), artık *calculate bonus* fonksiyonuna sahip olmalıyız; bunu artık kullanabiliriz.

Bir maaş değeri geçebiliriz. Ve bunu 1%’in 10’da 1’i ile çarpacağız ve ardından bu bonusun değerini döndürecek.

İşte MySQL’de fonksiyonları bu şekilde kullanabiliriz.

---

## 🏁 Amaç ve Kapanış

Bu laboratuvarın amacı, SQL ifadelerini kullanarak tüm bu işleri nasıl yapabileceğinizi göstermekti.

Fonksiyonlar oluşturabilirsiniz, stored procedure’ler oluşturabilirsiniz, bu fonksiyonları ve stored procedure’leri SQL ifadelerinden çağırabilirsiniz, tablo oluşturabilir ve verileri kaldırabilirsiniz ( *remove data* ) da.

SQL sorgu dili, tüm bunları yapmak için çok ama çok güçlüdür.
