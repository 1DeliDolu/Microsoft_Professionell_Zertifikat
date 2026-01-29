## 🧪 EF Core ile Basit Bir Veritabanı Modelleme

Bu laboratuvarda bir dizi şey yapacağız. İlk olarak *EPCOR* ile çalışmak için geliştirme ortamımızı kuracağız ve veritabanı tablolarını temsil edecek entity sınıflarını oluşturup yapılandıracağız.

Veritabanı ilişkilerini bağlam ( *context* ) içinde yönetmek için *dbContext* kullanacağız. Veritabanında şemayı üretmek için migration’ları uygulayacağız ve ardından veritabanı modelini hem veri ekleyerek hem de veri sorgulayarak test edeceğiz.

---

## 🛠️ Adım 1: Uygulamayı Kurma

Birinci adımda, **EFCORModelApp** adında yeni bir uygulama kuracağız. Bu bir *console application* olacak ve ardından bazı bağımlılıklar ekleyeceğiz.

Klasöre geçeceğiz ve sonra, ihtiyaç duyduğumuz tüm çalışmaları yapabilmemiz için uygulamaya **SQLite** ve **Entity Framework Core tools** ekleyeceksiniz.

---

## 🧱 Adım 2: Entity Sınıflarını Oluşturma

İkinci adımda entity sınıflarını oluşturacağız. Burada oluşturduğum ilk sınıf  **Employee.cs** . Bu, Employee.cs dosyasındaki **Employee** class’ı.

Altı farklı property’miz olduğunu görebilirsiniz; **EmployeeID** ile başlayıp **Department** ile bitiyor.

Burada, ayarlayacağınız her property için tüm türleri eklemek isteyeceksiniz. Örneğin **EmployeeID** `Int`.

İkinci property olarak ekleyeceğimiz  **first name** , bir `string`.

Sonuncusu ise **Department** property’si. Bunun **Department** türünde olduğuna dikkat edin. Department, **Department** class’ını kullanır ve bunu bir sonraki adımda oluşturmamız gerekecek.

Bunu ikinci dosyada,  **Department.cs** ’de yapacağız. Employee class’ında referans verdiğimiz  **Department class** ’ını oluşturabiliriz ve bu, oradaki son property için bir tür oluşturur.

Department class’ında, son property olarak **Employee** class’ına da referans vereceğiz. **Employees** adında bir Employee nesneleri listesi oluşturacağız ve class’ı bu şekilde tamamlayacağız.

Artık iki class’ımız var ve bunlar hazır. Şimdi DB context’i yapılandırmaya geçebiliriz.

---

## 🧩 Adım 3: DB Context’i Yapılandırma

Burada, DB context’i kurduğumuz **CompanyContext.cs** adlı bir dosyam var.

Burada yaptığımız şey, iki farklı class’ımıza referans vermek: **Employee class** ve  **Department class** .

Sonra bir veritabanı türü olan  **SQLite** ’ı kullanacağız ve kaynağı ( *source* ) **CompanyDB** olarak ayarlıyoruz.

Henüz bu veritabanını oluşturmadık. Bunu bizim için Entity Framework yapacak.

`useSQLite` metodunda `dataSource equals CompanyDB` kullanacağız.

---

## 🧬 Adım 4: Migration’ları Uygulama

Dördüncü adımda migration’ları uygulayacağız. Önce Entity Framework’ü migration’ları oluşturmak için kullanacağız, sonra veritabanını güncellemek için Entity Framework’ü kullanacağız; bu da veritabanını bizim için oluşturacak.

Önce `.NET EF migrations` kullanarak migration’ları oluşturacağız. `add` yapacağız ve ardından *initial create* property’sini kullanacağız.

Artık migration’larımız var.

Bir **migrations** klasörü oluşturulduğunu görebilirsiniz ve migration’lar hazır.

Şimdi bunu veritabanını oluşturmak için kullanabiliriz ve bunun için `database update` komutunu kullanacağım.

Bu tamamlandıktan sonra, klasör yapımızda artık  **CompanyDB** ’yi görebilirsiniz.

Entity Framework ve bu migration’ları kullanarak, neyin oluşturulacağını anlamak için class’ları kullandık.

Migration’ları oluşturdu ve ardından migration’ları kullanarak veritabanını güncelledi ve oluşturdu.

Ve yine, bu modelimizde tanımlanmıştı. Entity Framework’ün neyi oluşturacağını bilmesinin yolu bu.

Bunu burada tanımlıyoruz:  **Company.db** .

---

## ✅ Adım 5: Veritabanını Test Etme

Beşinci adımda veritabanımızı test edeceğiz.

**program.cs** içinde birkaç şey oluşturdum.

Yeni bir department oluşturacağız. Departmanın adı **Engineering** olacak ve bu departmana birkaç employee ekleyeceğiz.

Sonra değişiklikleri kaydetmek için veritabanı context’ini kullanıyoruz.

Ardından, veritabanımızda gerçekte kaç employee olduğunu console’a yazdıracağız.

**employees** değişkenini yine bu veritabanı context’ini kullanarak dolduracağız ve veritabanına karşı bir sorgu çalıştırarak employee sayısını alacağız.

Bunu console’a döndürmek için `employees.count` kullanacağız.

Uygulamayı çalıştıracağım ve görebilirsiniz; artık **employees** ve **engineering** iki.

Bu iki employee’yi veritabanımıza ekledik.

Veritabanını sorguladık ve count değerini geri aldık.

EF Core ve C Sharp class’ları kullanarak, birçok veritabanı operasyonunu sizin için yönetebilen güçlü kodlar oluşturabilirsiniz.
