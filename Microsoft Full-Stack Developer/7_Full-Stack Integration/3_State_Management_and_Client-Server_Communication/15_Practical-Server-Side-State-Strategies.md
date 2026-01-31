## 🧩 Pratik Sunucu Tarafı Durum Stratejileri

Blazor uygulamalarıyla çalışırken bazen kullanıcı verisini istemci makinesine kaydetmeniz gerekir, ancak diğer zamanlarda o kullanıcı verisini gerçekten sunucuya kaydetmek istersiniz; böylece kullanıcılar verilerine hem mobil telefonlarından hem masaüstlerinden hem de uygulama içinden erişebilir ve her şey senkronize olur.

Dolayısıyla *session storage* ve bir *cache service* kullanarak, istemci tarafı önbelleğe alma veya istemci tarafı  *session storage* ’a güvenmek zorunda kalmadan veriyi sunucu tarafında tutabilir ve sunucu tarafında sürdürebilirsiniz.

Sunucu tarafı tabanlı önbelleklemenin ve sunucu tarafı tabanlı  *session storage* ’ın nasıl çalıştığını göstereceğim. Bunu bir Blazor uygulamasında kullanacağım.

---

## 🧱 Basit Blazor Uygulaması ve Sayfalar

Blazor şablonunu kullanarak basit bir Blazor uygulaması oluşturdum. Yani burada çok temel ve oldukça ilkel bir uygulamamız var.

Aslında iki sayfa üzerine inşa ettim: `FetchData.razor` ve `Counter.razor`. Her bir sayfayı kullanarak her iki depolama türünü de göstereceğim.

---

## 🚀 Sunucu Tarafı Önbellek: Cache Service

Yaptığım ilk şey, bir *cache service* sınıfı oluşturmak oldu. Bu cache service sınıfı yalnızca bir  *in-memory storage* .

Gerçek dünya uygulamasında, veriyi bir veritabanına veya diske kaydetmek isteyebilirsiniz. Burada ise sadece örnek için belleğe kaydediyoruz.

Ama bu servis sunucuda çalışabilir ve veriyi bir kullanıcı ID’sine veya uygulama ID’sine bağlı şekilde bir veritabanında saklayabilirsiniz. Biz ise, bunun istemci tarafının daha sonra veri almak için kullanabileceği bir önbellek oluşturmayı nasıl sağlayabileceğini göstermek için bellekte tutuyoruz.

Bu servis, sadece `_cache` adlı `readonly` bir değişken oluşturuyor. `caching.memory` kütüphanesini kullanıyor; bu, Microsoft’in sağladığı bir `Microsoft.Extensions` kütüphanesi.

Önbelleği oluşturmak için `IMemoryCache` nesnesini kullanıyor.

Dolayısıyla .NET framework bu önbellekleme mantığının büyük bir bölümünü sizin için yönetir. Siz onu yazmak zorunda kalmazsınız; sadece `IMemoryCache` türünü bir değişkenle kullanırsınız ve .NET framework’ün ağır işi sizin için yapma gücünden yararlanırsınız.

Sonra `CacheService` adlı bir metodumuz var; bu, `_cache` değişkenini, içeri verdiğimiz önbellek ne ise ona ayarlıyor; bu da yine `IMemoryCache` türünde.

Yani `cache` değişkeninde bazı veriler geçiriyoruz ve ardından `readonly` `_cache` değişkenimizi o değere eşitliyoruz.

Ayrıca bir `GetOrCreate` metodumuz da var; bu metod `createItem` adlı bir değişken alıyor.

Ve önbellek, uygulamamızın ihtiyacına göre öğeyi ya alacak ya da oluşturacak.

Bu cache service çok basit, fakat Microsoft’in sağladığı bu `caching.memory` kütüphanesini kullanarak veriyi sunucu tarafında nasıl saklayabileceğimizi gösteriyor.

---

## 🌡️ FetchData.razor: Önbellekten Sahte Hava Durumu Verisi

`FetchData.razor` sayfama gideceğim; bu sayfa çok çok basit. Sahte bir hava durumu bilgisi, hava sıcaklığı sayfası.

Burada yaptığı tek şey, bir `p` etiketi içinde `weatherData` değişkeninde ne varsa onu yazdırmak.

`weatherData` değişkeni, sayfa yüklendiğinde çalışan `OnInitializedAsync` metodunda ayarlanıyor ve `weatherData` değişkeni bu cache service tarafından set ediliyor.

Yani yine, daha önce oluşturduğumuz cache service’i sayfaya enjekte ediyoruz.

Ardından daha önce gösterdiğim `GetOrCreate` metodunu kullanacağız.

Bir `weatherData` nesnesi geçiriyoruz ve bunu bu veriyle set ediyoruz.

Burada yaptığım tek şey, 1 ile 10 arasında yeni bir rastgele sayı oluşturmak. Sıcaklık, o rastgele sayıya göre görüntülenecek.

Burada önbellek açısından ilginç olan şey şu: `entry` bir cache süresi ayarlıyor.

Bu, bu değişkende set ettiğimiz verinin, ayarladığımız süre boyunca önbellekte kalacağı anlamına gelir.

Şu an, sadece 5 saniyeye ayarlıyoruz.

Gerçek dünya uygulamasında hava durumunun güncellendiğini ve bu servisin hava durumu güncellemeleri sağladığını hayal edebilirsiniz.

Ama bu havanın yalnızca her 15 dakikada bir veya 10 dakikada bir, uygulama için uygun olan aralıkta güncellenmesini isteyebilirsiniz.

Dolayısıyla sürekli sunucu çağrısı yapmak yerine, burada gerçek fetch mantığıyla değiştirdim.

Eğer başka bir API’ye çağrı yapıyor olsaydık ve hava durumu bilgisini almak isteseydik, bu önbellek, ancak süre dolduğunda o API’ye çağrı yapardı.

Aksi hâlde, daha önce aldığımız veri önbellekte kalırdı.

Süreyi 5 saniyeye ayarlıyoruz ki uygulama içinde gösterebileyim.

Ama bunun daha uzun bir zaman aralığına ayarlanabileceğini ve sadece cache süresi dolduğunda o API’ye çağrı yapılacağını hayal edebilirsiniz.

Dolayısıyla cache süresi dolana kadar veriyi önbellekten kullanacağız.

Ve sonra çağrımızı yapacağız ya da bu örnekte uygulamayı çalıştırdığımızda yeni bir rastgele sayı alacağız.

Şimdi bunu çalıştıracağım ve bu cache’in nasıl çalıştığını göstereceğim.

Uygulama çalışıyor. Şimdi web sitesine gideceğim.

Ve fetch sayfasına gideceğim.

Sıcaklığımızın 4 olduğunu görebilirsiniz.

Sayfayı yenilediğimizde, ya önbellekten çekecek ya da yeni bir sayı alacak.

Şu anda sadece 5 saniyeye ayarladık.

Dolayısıyla sayfayı yükleyeli 5 saniye geçtiyse yeni bir sayı, yeni bir rastgele sayı almamız gerekir.

Yenilemeye devam ediyorum, ama sayının değişmediğini fark edeceksiniz; çünkü yeni bir sayı üretmek yerine (veya gerçek dünya senaryosunda bir API’ye gidip hava durumu verisi almak yerine) cache’ten o 5’i çekiyor.

Şimdi 5 saniye geçti, tekrar yenileyeceğim ve yeni bir sayı verecek.

Yani bu, cache süresi dolana kadar veriyi saklamak için bu cache’i kullanmak.

Ayarladığımız süre geçtikten sonra, buna bağlı olarak yeni bir sayı üretebiliriz.

Bu, bilgiyi saklamanın bir yolu.

Ve bu, uygulamayla çalışırken sunucu aşırı yüklerini ve çok fazla API çağrısı yapılmasını engelleyebilir.

---

## 🧾 Counter.razor: Session Storage ile Oturum Boyunca Veriyi Korumak

Şimdi başka bir sayfaya geri döneceğiz, counter sayfamıza gideceğiz.

Ve size oturumlar arasında bilgiyi korumak için  *session storage* ’ı nasıl kullanacağınızı göstereceğim.

Bu da çok basit bir sayfa.

Sadece **Click Me** adlı bir butonu var.

Bu, her tıkladığımda `counterInc` değişkenini 1 artıran `IncrementCount` metoduna gidiyor.

Ama dikkat edin, aynı zamanda bilgiyi kaydediyor; yani `counterInc` değişkenini kaydediyor.

Bunu  *session storage* ’a kaydediyor; bu, tarayıcı penceresi açık olduğu sürece bilgiyi saklayan .NET içinde bir depolama türü.

Yani kullanıcı tarayıcı penceresini veya uygulama penceresini kapatmazsa veri tutulur.

Tarayıcı penceresi kapandığı anda veri silinir.

Bu  *session storage* , `Blazor Add SessionStorage` `ISessionStorageService` servisini kullanıyor.

Ve bu, .NET framework’e yerleşik.

Dolayısıyla sadece `sessionStorage.SetItemAsync` çağırmanız, bir isim vermeniz (istediğiniz herhangi bir isim olabilir) ve değişkeni o depolamaya kaydetmeniz gerekir.

Sayfayı yüklediğimizde, eğer `counterInc` *session storage* değişkeni doluysa, veriyi o depolamadan çekecek.

Aksi hâlde, yeni veri oluşturacak veya yeni veri alacak.

Şimdi sayfama geri döneceğim.

Ve counter öğesine tıklayacağım.

Bir kere tıklayacağım ve 6’ya yükseltecek.

Sayfayı yenilediğimde 0’a dönüyor.

Ve bunun nedeni, aslında sunucu uygulamasında istemci tarafı bir sayfa çalıştırıyor olmam, ama veri yine de tutulacak.

Dolayısıyla butona tekrar tıkladığımda 7’den başlayacak; çünkü veri  *session storage* ’da korunmuştu.

Şimdi yenile, 13’ten başlaması gerekir; çünkü  *session storage* ’dan o veriyi alıyor ve 1 artırıyor.

Şimdi tarayıcıyı kapatırsam ve sonra o sayfaya geri dönersem, 0’dan başladığını göreceksiniz.

Tıkladığımda tekrar 1’den başlayacak; çünkü sayfayı veya oturumu kapattığımda *session storage* silinmiş oldu.

---

## ✅ Kapanış

Bunlar, Blazor içinde bilgi tutmanın iki yoludur; hem oturumlar arasında hem de sunucuda, verinin nasıl yakalandığını, kaydedildiğini ve ardından kullanıcıya geri döndürüldüğünü yönetmeye çalışırken.

Bu veriyi ya sunucuda tutup yönetebilirsiniz, ya da veriyi oturum içinde kaydedip kullanıcı sayfadayken veya uygulama açıkken tutulmasını sağlayabilirsiniz.
