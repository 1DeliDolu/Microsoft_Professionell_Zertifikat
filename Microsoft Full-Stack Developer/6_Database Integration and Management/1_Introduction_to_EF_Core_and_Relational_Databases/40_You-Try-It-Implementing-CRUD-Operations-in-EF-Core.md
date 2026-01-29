## 🧪 EF Core’da CRUD İşlemlerini Uygulama

Bu laboratuvarda, EF Core kullanarak bir veritabanı context’i oluşturacağım ve ardından bir veritabanından okumak ve veritabanına yazmak için CRUD işlemlerini uygulayacağım.

---

## 🛠️ Adım 1: Ortamı Kurma

Birinci adımda ortamınızı kuruyorsunuz. **Product Management App** adlı yeni bir console application oluşturacaksınız ve ardından uygulamada EF Core’u etkinleştirmek için bazı .NET paketleri ekleyeceksiniz.

---

## 🧱 Adım 2: Uygulama için Veri Modelini Tanımlama

İkinci adımda uygulamamız için veri modelini tanımlayacağız.

Veritabanı zaten kurulu ve doldurulmuş durumda; bu yüzden bunu yapmamıza gerek yok.

Dolayısıyla esasen, veritabanından okuyacak ve veritabanına yazacak ürün için modeli oluşturacağız.

Veritabanından veri aldığımızda, onu saklayacağımız bir yere ihtiyacımız var.

Bu yüzden bu product class’ı, o veriyi saklamamıza izin verecek.

Product class’ını burada görebilirsiniz. Sadece üç property’si var:  **ID** , **name** ve  **price** .

Ve veritabanıyla etkileşim kurmak için bunu kullanacağız.

---

## 🧩 Adım 3: Database Context’i Kurma

Üçüncü adımda database context’i kuracağız.

**applicationdbcontext.cs** dosyama gideceğim.

Burada yaptığımız şey, **MySQL** kullanmak, **options builder** class’ını kullanmak ve EF Core’un veritabanıyla nasıl konuşacağını bilmesi için sunucu bilgilerini ayarlamak.

**productdb** adlı bir veritabanı kullanıyoruz, bir kullanıcı adı ve parola ayarlıyoruz ve bunun için SQL sürümünü ayarlıyoruz.

Burada ayrıca daha önce oluşturduğumuz **products** class’ını kullanarak bir **dbset** class’ı kurduğumuzu da görebilirsiniz.

Bu, daha önce konuştuğumuz gibi products class’ına yazmamıza ve oradan okumamıza izin verir.

Burada ayrıca **dbcontextoptionsbuilder** kullandığımıza da dikkat edin.

Bu, options builder örneğini oluşturmak için kullanmak istediğimiz class.

Böylece veritabanına yazarken ve okurken MySQL kullanabiliyoruz.

---

## 🧬 Adım 4: Migration’ı Uygulama

Dördüncü adımda migration’ı uygulayacağız.

Bu noktada EF Core’u veritabanıyla etkileşim kurmak için kullanmaya başlıyoruz.

Ve bu migration’ları uygulamak için terminalde bir `dotnet` komutu kullanacağız ve EF uygulamasını çağıracağız.

Terminalde bunları çalıştıracağım ve `dotnet ef` kullanacağız; bu, Entity Framework uygulamasını kullanır.

Migration’ı çağıracağım; `migrations` bayrağını kullanacağız.

Veritabanımıza bir **initial migration** ekleyeceğiz.

Bunu çalıştırdığımda, görünecek; bir **migrations** klasörü ortaya çıkacak ve veritabanına aktarabilmek için migration’lar hazır olacak.

Bu komutu çalıştıracağım.

Migration çalıştı; Entity Framework kullanarak migration’ları oluşturduk ve komutu çalıştırdıktan sonra migrations klasörü içinde migration’ların var olduğunu görebilirsiniz.

Bir komut daha çalıştıracağım ve bu, az önce oluşturduğumuz Entity Framework migration’larını kullanarak veritabanını güncellemek.

Yine Entity Framework uygulamasını kullanacağım ve üzerinde çalıştığımız veritabanını güncellemesini söyleyeceğim.

Ve yine, options builder içindeki `use MySQL` ifadesinde belirttiğimiz veritabanı bilgilerini kullanacak; böylece hangi veritabanıyla etkileşim kuracağını bilecek.

Tamam, veritabanı update çalıştı ve artık veritabanımızda o **products** tablosu olacak ve verilerle etkileşim kurmak için bunu kullanabiliriz.

---

## 🔄 Adım 5: CRUD İşlemlerini Uygulama

Bir sonraki adımda, beşinci adımda CRUD işlemlerimizi uygulayacağız.

Bunu yapmak için **program.cs** dosyasına gideceğiz ve burada farklı işlemler olduğunu göreceksiniz:  **create** ,  **read** , **update** ve  **delete** .

Bunlar, veritabanına karşı gerçekleştirebileceğimiz dört işlemdir.

Bu örnekte bunu çalıştıracağım.

Uygulama çalıştığında, aslında veritabanına veri yazacak ve ardından migration’larla oluşturduğumuz veritabanıyla etkileşim kurduğunu bize göstermek için console’a çıktı verecek.

Uygulamayı çalıştıracağım ve console’da veritabanını gerçekten güncellediğini göreceksiniz.

Bunu yapmadan önce, bu öğelerden birkaçını hızlıca açıklayacağım.

Laptop price altında, buraya bir fiyat gireceğim. Bu, product’ı oluştururken kullanılacak bir sayı olacak.

Ve tüm context’lerde, `context.saveChanges` metodunu kullanacağız; bu, değişiklikleri yaptıktan sonra değişiklikleri veritabanına zorla uygular.

Bu, hangi işlem olursa olsun bu değişiklikleri işlemek ( *commit* ) için kullanacağımız komut, yani metottur.

Uygulamayı çalıştıracağım.

Ve şimdi görebilirsiniz; veritabanında products var.

Product laptop ve fiyat $99.99.

Bunu burada görebiliyoruz.

Bu, uygulamayı çalıştırdığımızda veritabanına o yeni product’ı eklemek için yaptığımız şeydi.

Entity Framework kullanarak bir migration oluşturabilir, o migration ile veritabanını güncelleyebilir ve ardından Entity Framework kullanarak oluşturduğumuz bu tabloyla etkileşim kurmak için CRUD işlemlerini kullanabiliriz.
