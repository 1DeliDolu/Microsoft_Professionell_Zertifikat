## 🏗️ Sınıflar ve Nesneler Oluşturma

Elinizde bir planla ( *blueprint* ) dolaşan bir mimar olduğunuzu hayal edin. Bu plan, inşa etmek üzere olduğunuz evin oda sayısından pencere yerleşimine kadar her ayrıntısını belirtir. Ancak siz gerçekten inşa etmeye başlayana kadar, o ev yalnızca kâğıt üzerinde bir fikir olarak kalır.

Programlamada C#’taki sınıflar da buna çok benzer şekilde çalışır. Nesnelerin nasıl görüneceğini ve nasıl davranacağını tanımlayan planlardır; ancak kullanılabilmeleri için inşa edilmeleri gerekir. Bu videoda, C#’ta sınıfları ve nesneleri nasıl uygulayacağınızı öğreneceksiniz.

Önce bir sınıfın ne olduğunu ve neler içerdiğini kısaca gözden geçirelim.

---

## 🧩 Sınıf Nedir ve Neler İçerir?

Sınıf, ilişkili nesneler grubunun paylaşılan özelliklerini ve davranışlarını tanımlayan bir plan ( *blueprint* ) veya şablondur ( *template* ).

Sınıflar:

* Özellikleri ( *properties* ) içerir. Bunlar bir nesnenin tuttuğu veri parçalarıdır; örneğin bir kişinin adı veya yaşı gibi.
* Metotları ( *methods* ) içerir. Bunlar bir nesnenin gerçekleştirebileceği eylemlerdir; örneğin bilgileri görüntülemek gibi.
* Ve son olarak, nesne oluşturulduğunda onu başlatan özel metotlar olan  *constructor* ’ları içerir.

Bu temel öğeler tanımlandıktan sonra, şimdi C#’ta bir sınıfı tanımlamak için kullanılan belirli söz dizimine ( *syntax* ) geçelim.

---

## 🧱 C#’ta Sınıf Tanımlama Sözdizimi

C#’ta bir sınıf tanımlamak için net bir adım sırası izlersiniz.

Önce, sınıfı *public* veya *protected* gibi bir erişim belirleyicisi ( *access modifier* ) ile bildirerek başlayın. Bu, C#’a sınıfa kimlerin erişebileceğini söyler.

Sonra *class* anahtar sözcüğünü ve ardından sınıf adını kullanırsınız. Bu, sınıfı kodunuz içinde tanımlama şeklinizdir.

Ardından sınıf gövdesini ( *class body* ) süslü parantezlerle ( *curly braces* ) açarsınız.

Bu parantezlerin içinde sınıfınızın temel bileşenlerini tanımlarsınız: veriyi saklayan özellikler, sınıfı hazırlayan constructor’lar ve sınıfın ne yapabileceğini açıklayan metotlar.

---

## 👤 Örnek: Person Sınıfı

Bir geliştiricinin, *name* ve *age* özelliklerine sahip bir *person* sınıfı tanımlamak istediğini; bu özellikleri başlatmak için bir constructor ve kişinin bilgilerini göstermek için bir metot eklemek istediğini varsayalım.

Bu sınıfı C#’ta tanımlamak için, önce *public* erişim belirleyicisiyle, ardından *class* anahtar sözcüğü ve *person* adıyla bildirirsiniz.

Sonra sınıf gövdesini bir süslü parantez ile açar ve en sonda başka bir süslü parantez ile kapatırsınız.

Bu gövdenin içinde, *name* adlı bir *string* özelliği ve *h* adlı bir *integer* özelliği eklenir.

Ayrıca sınıf, sınıfla aynı ada sahip bir constructor metodu içerir; bu metot iki parametre kullanarak özellikleri başlatır: *name* adlı bir *string* ve *age* adlı bir  *integer* .

Özellik ile parametreyi ayırt etmek için, özellik adları büyük harfle başlatılır; giriş parametreleri ise olduğu gibi kalır.

Son olarak, sınıfın *DisplayInfo* adlı bir metodu vardır; bu metot adı ve yaşı konsola yazar.

---

## 🧱 Sınıflar Tek Başına Yeterli Değildir

Nesne yönelimli programlamada sınıflar kendi başına çok fazla iş yapamaz.

Bir programcı veri işleyemez, kullanıcıyla etkileşime giremez veya API çağrıları gönderemez; bir sınıfın iş yapabilmesi için ondan bir nesne oluşturmanız gerekir.

Bu sürece *örnekleme (instantiation)* denir. Şimdi bu sürecin C#’ta nasıl çalıştığına bakalım.

---

## 🏗️ Örnekleme

Örnekleme kelimesi *instance* kelimesinden gelir ve bir sınıfı “canlandırma” sürecini, yani onun çalışan bir sürümünü oluşturmayı ifade eder.

Bunu bir kurabiye kalıbı gibi düşünebilirsiniz. Sınıf kalıptır, oluşturduğunuz her kurabiye bir nesnedir.

Bu çalışan sürüme nesne ( *object* ) deriz.

Bu yaklaşımla, tek bir sınıftan ihtiyaç duyduğunuz kadar nesne oluşturabilirsiniz; tıpkı aynı kalıpla birden fazla kurabiye yapmanız gibi.

---

## 👤 Person Sınıfının Örneğini Oluşturmak

Şimdi *person* sınıfının bir örneğini nasıl oluşturabileceğinizi ve onunla nasıl çalışmaya başlayacağınızı görelim.

*Person* sınıfını örneklerken, geliştirici önce *person* türünde bir değişken bildirir ve bu değişkene *neighbor* adını verir.

C#, tür güvenli ( *type safe* ) bir dildir; bu, tüm değişkenlerin belirli bir türle bildirilmesi gerektiği anlamına gelir ve değişkenlerin ne saklayabileceği konusunda açıklık sağlar.

*Neighbor* değişkeni yalnızca *person* nesnelerini tutabilir.

Geliştirici değişkeni bildirdikten sonra bir *person* nesnesi oluşturup değişkene atayabilir.

Bunun için *new* anahtar sözcüğünü ve ardından sınıf constructor’ını kullanır; constructor bir metot olduğu için parantezle ( *parentheses* ) çağrılır.

Constructor, *name* için *string* türünde bir parametre ve *age* için *int* türünde bir parametre ister.

Bu örnekte, geliştirici constructor’a parametre olarak *John Doe* (isim) ve *30* (yaş) değerlerini gönderir.

Böylece *neighbor* değişkeni, *person* sınıfının bir örneğini ya da bir *person* nesnesini içerir.

---

## 🔗 Dot Notation

*Person* sınıfının *name* ve *age* özelliklerini içerdiğini hatırlayın. Bu özellikler *public* erişim belirleyicisiyle tanımlanmıştı.

Bu da, sınıf *instantiation* yoluyla oluşturulduktan sonra nesne üzerinden kodla erişilebilir oldukları anlamına gelir; bunun için *dot notation* kullanılır.

Şimdi dot notation’ın ne olduğunu ve C#’ta nasıl kullanılacağını öğreneceksiniz.

Dot notation, özellikler, metotlar ve alanlar ( *fields* ) gibi bir nesnenin üyelerine erişmek için kullanılan söz dizimidir.

Bir nesne örneklendikten sonra, geliştiriciler *public* üyelerine bir nokta ( *dot* ) ve ardından özellik ya da metot adını yazarak erişebilir.

Bu sözdizimini *person* nesnesine uygulayalım.

*Neighbor* değişkeni örneklenmiş *person* nesnesini tuttuğu için, geliştirici bu nesnenin üyelerine dot notation ile erişebilir.

Örneğin nesne örneklendikten sonra geliştirici kişinin yaşını güncellemek isterse, *neighbor age* kullanarak *person* nesnesinin yaş değerini 30’dan 31’e değiştirebilir.

Geliştirici ayrıca dot notation kullanarak nesnenin *public* metotlarını da çağırabilir.

Örneğin nesnenin *DisplayInfo* metodunu çağırmak için, geliştirici *neighbor displayinfo* yazar ve ardından boş parantez kullanır.

---

## ✅ Sonuç

C#’ta sınıflar, geliştiriciye kodla çalışırken büyük esneklik sağlar ve tekrarları önlemeye yardımcı olur. Nesne yönelimli bir dil olarak sınıflar, C#’ın temel bir parçasıdır.

Bu videoda, C#’ta sınıfları ve nesneleri nasıl uygulayacağınızı öğrendiniz. Özellikler, constructor’lar ve metotlarla bir sınıf tanımladık ve bu sınıftan nesneler örnekledik.

Sınıfları kullanmak, nesne yönelimli programlama inşa etmenin önemli bir ilk adımıdır.
