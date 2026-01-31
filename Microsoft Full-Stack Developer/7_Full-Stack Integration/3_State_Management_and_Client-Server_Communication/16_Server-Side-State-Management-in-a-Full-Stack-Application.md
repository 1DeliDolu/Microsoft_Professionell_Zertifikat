## 🧩 Full-Stack Uygulamada Sunucu Tarafı Durum Yönetimi

Bu laboratuvarda, oturum yönetimi ( *session handling* ) ve önbellekleme ( *caching* ) dahil olmak üzere sunucu tarafı durum yönetimi stratejilerini bir full-stack uygulama içinde uygulayacağız.

---

## 🧱 Adım 1: Uygulamayı Oluşturma

Birinci adımda uygulamayı oluşturuyoruz. `Blazor Server App` adlı bir Blazor uygulaması oluşturacağız.

Bunu yapmak için normal Blazor şablonunu kullanıyoruz ve ardından `Blazor Server App` klasörüne geçeceksiniz; `cd Blazor Server App` kullanarak.

Sonra, çalıştığını test etmek ve çalışıp çalışmadığını görmek için uygulamayı çalıştıracaksınız.

```bash
cd Blazor Server App
```

```bash
dotnet run
```

---

## 🕒 Adım 2: Oturum Yönetimini Yapılandırma

Bir sonraki adım oturum yönetimini yapılandırmak. Middleware’i ve `Program.cs` dosyasını yapılandıracaksınız.

Burada, oturum için seçeneklerdeki ( *options* ) *idle timeout* ayarını belirlemek üzere bir zamanlayıcı ( *timer* ) kullanacağız.

İlk satırda, `options.IdleTimeout` içinde, `TimeSpan.FromMinutes` ile kullanacağımız zaman aralığını ayarlayacaksınız.

Zamanı **30 dakika** olarak ayarlayacağız.

Bu, oturumun 30 dakika boyunca aktif kalmasını sağlar. Bundan sonra oturumun süresi dolacaktır.

Ardından, güvenlik nedenleriyle çerezi ( *cookie* ) `HttpOnly` yapacağız ve bu özelliği `true` olarak ayarlayacağız.

Ve bu şekilde bu uygulama için oturumunuzu kurmuş olacaksınız.

---

## 🚀 Adım 3: Cache Service Kurulumu

Yapacağınız bir sonraki şey, bir cache service kurmak.

Bu, verinin sunucu tarafında önbelleğe alınmasına veya kaydedilmesine olanak tanır; böylece tekrar kullanılabilir.

Dolayısıyla birden fazla istemci aynı bilgiyi isterse, veritabanından okumak ya da bir API’ye gitmek zorunda kalmadan, yalnızca sınırlı bir süre için bu bilgi cache’ten gelecektir.

Cache service’i kurmak için, `IMemoryCache` nesnesini kullanarak bir `readonly` değişken oluşturacaksınız.

Bunu `using` ifademizden alıyoruz: `Microsoft.Extensions.Caching.Memory`.

Bu, `IMemoryCache` kullanmamıza izin verir.

`_cache` adlı bir değişkeni bu türle ayarlayacağız.

Ardından `public CacheService` metodumuzda da yine aynı `IMemoryCache`’i kullanacağız; böylece `cache` değişkenini bunun içine aktarabilir ve `_cache` değişkenini o `cache` değerine eşitleyebiliriz.

Sonra, cache’ten öğe almak veya cache’e öğe set etmek için kullanacağımız bir `GetOrCreate` metodumuz var.

Bu metotta cache’imizin sona erme süresini ( *expiration* ) ayarlayacağız.

Bunu `new MemoryCacheEntryOptions` olarak ayarlıyoruz, `AbsoluteExpirationRelativeToNow` kullanıyoruz ve ardından bunu, içeri parametre olarak geçirdiğimiz `expiration` değeri ne ise ona ayarlayacağız.

Bu sona erme süresini ayarlamak için `Set` metodunu kullanıyoruz.

Şimdi dikkat edin, `MemoryCacheEntryOptions`, `Caching.Memory` kütüphanesinin bir parçasıdır ve cache’i, geçerli zamana göre ( *relative to the current time* ) içeri verdiğimiz `expiration` süresine ayarlıyoruz.

Bu, cache daha önce kurulmamışsa sona erme süresini değiştirme fırsatı sağlar ve bunu o metotta bu şekilde yapıyoruz.

---

## ✅ Kapanış

Bunlar, bu laboratuvar için doldurmanız gereken kod alanlarıdır.
