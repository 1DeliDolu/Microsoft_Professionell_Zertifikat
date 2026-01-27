## 🧩 Tasarım Desenlerini Tanımlama

Karmaşık bir projede çalıştığınızı ve sürekli aynı zorluklarla karşılaştığınızı hayal edin. Zamanla, işinizi daha kolay ve daha verimli hâle getiren akıllı, tekrarlanabilir çözümler geliştirirsiniz. Yazılım geliştirmede bu tekrarlanabilir çözümlere *tasarım desenleri (design patterns)* deriz. Bunlar, kodunuzu yapılandırmanın denenmiş ve test edilmiş yollarıdır; kodunuzu daha verimli ve ölçeklenebilir hâle getirir.

Bu videoda, yaygın tasarım desenlerini tanımayı ve açıklamayı öğreneceksiniz.

Tasarım desenleri, yazılım tasarımında yaygın problemlere yönelik yeniden kullanılabilir çözümler gibidir. Mimari zorluklarla başa çıkmanız için size standart bir yol sunarlar; böylece kodunuz daha güvenilir ve bakımı daha kolay olur.

Geliştiricilerin yazılımlarını tasarlamak için kullandığı birçok tasarım deseni vardır. En yaygın olanlardan birkaçını inceleyeceğiz.

---

## 🧱 Singleton Deseni

Önce,  *Singleton Pattern* ’ı ele alalım. Bu desen, bir sınıfın uygulamanız boyunca yalnızca tek bir örneğe ( *instance* ) sahip olmasını sağlar ve kodunuzun herhangi bir yerinden bu örneğe erişmek için tek bir erişim noktası ( *single point of access* ) sunar.

Geliştiriciler Singleton Pattern’ı paylaşılan kaynakları yönetmek için kullanır. Örneğin, bir veritabanı sınıfı, uygulama boyunca veritabanına yalnızca tek bir bağlantı olmasını sağlamak için Singleton Pattern’ı uygulayabilir.

Bunu C#’ta uygulamak için geliştirici *Database* adında *public* bir sınıf oluşturur. Veritabanı nesnesinin örneğini tutan bir *private* değişken ve çağrıldığında konsola *database connection established* yazdıran bir *private* constructor oluşturur.

Ardından geliştirici, *GetInstance* adlı *public* bir metot oluşturur; bu metot *private* değişkene yeni bir *database* nesnesi örneği atar ve bu örneği kendisini çağıran koda döndürür.

Ancak nesneyi *private* değişkene atamadan önce, değişkenin zaten dolu olup olmadığını kontrol eder. Eğer doluysa, zaten var olan örneği kullanır.

Bu, programda her zaman yalnızca tek bir *database* nesnesi örneği olacağı desenini zorlar ( *enforces* ).

*Database* constructor’ının erişim belirleyicisi *private* olduğu için, dışarıdan herhangi bir sınıf yeni bir *database* nesnesi örneği oluşturamaz. Bu, Singleton Pattern’ı zorlamak için kilit noktadır.

---

## 🏭 Factory Deseni

Artık Singleton Pattern’ın uygulama genelinde tek bir örneği yönetmedeki rolünü incelediğimize göre, şimdi bir başka temel desen olan  *Factory Pattern* ’a bakalım.

Bu desen yalnızca nesneler oluşturmaya yardımcı olmakla kalmaz, aynı zamanda değişiklikler yapılsa bile kodunuzun kararlı ve uyarlanabilir kalmasını sağlar.

Factory Pattern’da, bir nesneyi doğrudan oluşturmak yerine, kodunuz oluşturma işini sizin için yapan *Factory* adlı özel bir metot veya sınıf kullanır. Bu şekilde kodunuz ayrıntılarla ilgilenmek zorunda kalmaz. Factory bunu halleder; programınızı daha esnek ve yönetmesi daha kolay hâle getirir.

Factory, hangi tür nesneye ihtiyaç duyduğunu söyleyen bir girdi alır; örneğin bir parametre. Factory daha sonra bu girdiye bağlı olarak hangi spesifik nesne türünü oluşturacağına karar verir.

Factory kullanılarak nesne oluşturulduğunda, bir nesne isteyen kod ile nesneyi gerçekten oluşturan kod birbirinden ayrılmış olur. Bu ayrım, daha sonra yeni nesne türleri eklemeyi veya değiştirmeyi, nesneleri kullanan kodu etkilemeden kolaylaştırır.

C#’ta bir bildirim ( *notification* ) sistemi için Factory Pattern’ı uygulamak üzere, geliştirici önce *inotification* adlı bir *public interface* oluşturur. Bu interface, mesajı parametre olarak alan *send* adlı bir metot içerir.

Sonra geliştirici, *inotification* interface’inden miras alan iki türetilmiş sınıf oluşturur. Bu türetilmiş sınıflardan biri e-posta bildirimlerini, diğeri SMS bildirimlerini yönetir. Bu sınıfların her biri, bildirimi konsola yazdıran *send* metodunu uygular.

Son olarak geliştirici, e-posta bildirim ve SMS bildirim nesnelerini oluşturmaktan sorumlu *NotificationFactory* adlı yeni bir sınıf oluşturur.

Bu sınıfta, tür olarak *inotification* interface’ini kullanan *createNotification* adlı bir metot uygular. Bu metot ayrıca Factory’nin hangi tür bildirim nesnesi oluşturacağını belirleyen *channel* adlı bir girdi parametresi alır.

Bu desen kullanılarak geliştirici, e-posta ve SMS bildirim nesnelerinin nasıl tasarlandığını, onları isteyen kodu etkilemeden değiştirebilir.

Bu nesnelere ihtiyaç duyan kod, yalnızca *createNotification* metodunu çağırır, *channel* parametresini gönderir ve gerisini Factory halleder.

---

## 👀 Observer Deseni

Son olarak, karmaşık sistemlerde nesneler arasındaki iletişimi yönetmek için kritik bir davranışsal desen olan  *Observer Pattern* ’ı inceleyelim.

Alttaki veriler değiştiğinde bir kullanıcı arayüzünün gerçek zamanlı güncellenmesi gereken bir sistem geliştirdiğinizi hayal edin.

Observer Pattern burada öne çıkar. Sistemin değişikliklere dinamik olarak yanıt vermesini sağlar ve manuel müdahaleye gerek kalmadan her şeyin senkronize kalmasına yardımcı olur.

Observer Pattern, bir nesnenin durumu değiştiğinde, birden fazla başka nesneyi otomatik olarak bilgilendirmesini ve güncellemesini sağlar.

Bu desen, farklı bölümlerin değişikliklere tepki vermesi gereken sistemlerde özellikle kullanışlıdır; örneğin veri değiştiğinde bir kullanıcı arayüzünü güncellemek gibi.

Bu deseni bir hava durumu istasyonu ( *weather station* ) uygulaması için C#’ta nasıl uygulayabileceklerini inceleyelim.

Observer Pattern’ı uygulamak için, önce *iObserver* adlı bir *public interface* oluşturursunuz. Bu interface, sıcaklık parametresi alan *update* adlı tek bir metot içerir.

Bu adım, gözlemcilerin ( *observers* ) güncellemeleri nasıl alacağına dair temeli oluşturur.

Sonraki adım, özne ( *subject* ) olarak hareket eden *WeatherStation* sınıfını oluşturmaktır. Bu sınıf, *iObserver* örneklerinin bir listesini yönetir ve iç durumunda bir değişiklik olduğunda—örneğin bir sıcaklık güncellemesi—kayıtlı tüm gözlemcileri bilgilendirmekten sorumludur.

Bu sınıfın *Observers* adlı, *iObserver* interface nesnelerini tutabilen bir *private list* üyesi vardır.

Ayrıca sıcaklık değerlerini tutan *Temperature* adlı bir *private* üyesi vardır.

Geliştirici, *Observers* listesine nesne eklemek ve listeden nesne kaldırmak için metotlar oluşturur; ayrıca *NotifyObserver* adlı bir metot oluşturur.

Bu metot, *Observers* listesindeki her bir nesne üzerinde yineleme yapar ve ardından her biri için Observer interface’inden *update* metodunu çağırır.

Bu metot, *temperature* üyesinde ayarlanan değerleri *update* metoduna geçirir.

*Temperature* üyesi, bu sınıftaki son metot olan *SetTemperature* içinde ayarlanır.

Bu metot, *NewTemperature* adlı bir girdi parametresi içerir ve metot, *private temperature* üye değişkenini bu değere ayarlar.

Ardından *NotifyObserver* metodunu çağırır.

Daha sonra geliştirici, *PhoneDisplay* adlı somut ( *concrete* ), *public-derived* bir sınıf oluşturur. Bu sınıf, sıcaklık değişimlerini bir telefon arayüzüne bildirecektir.

Geliştirici bu mesajı dinlemek için bir uygulama veya telefona yerleşik bir araç kullanabilir.

Geliştirici ayrıca sıcaklıktaki değişimi masaüstü uygulamalarına veya araçlarına güncellemek için *DesktopDisplay* adlı somut, *public-derived* bir sınıf daha oluşturur.

Her sınıf, *iObserver* interface’inden türetilmiş bir sınıftır ve bu interface’ten *update* metodunu uygular.

*Update* metodu, sıcaklığı parametre olarak alır ve sıcaklığı bir mesaj içinde konsola yazar.

Observer’ı programda kullanmak için geliştirici,  *WeatherStation* , *PhoneDisplay* ve *DesktopDisplay* nesnelerinin yeni örneklerini oluşturur.

Ardından her bir nesne için yeni bir observer kaydetmek üzere *WeatherStation* nesnesinde *RegisterObserver* metodunu çağırır.

Bu metodu çağırırken *PhoneDisplay* ve *DesktopDisplay* nesnelerini parametre olarak geçirir.

Şimdi her ekranı güncellemek için, geliştirici yalnızca *WeatherStation* nesnesinde *SetTemperature* metodunu çağırır ve yeni bir sıcaklık gönderir.

*iObserver* interface’i, Subject sınıfıyla birlikte, tüm ekranları yeni sıcaklıkla günceller.

---

## ✅ Sonuç

Bu desenler, geliştiricilerin kodu basitleştirmesinin ve bakımını kolaylaştırmasının yollarıdır.

Tasarım desenleri, iyi biçimlendirilmiş, okunabilir ve genişletilebilir kod oluşturmak için geliştiricilere planlar ( *blueprints* ) sağlar.

Bu videoda, Singleton, Factory ve Observer gibi temel tasarım desenlerini tanımayı ve açıklamayı öğrendiniz.

Bu desenler, verimli, bakımı kolay ve uzun ömürlü olacak şekilde inşa edilmiş kod yazmanıza yardımcı olan temel araçlardır.
