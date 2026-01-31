
## 🧪 Blazor’da İstemci Tarafı Durum Yönetimini Uygulamak

Bu laboratuvarda, bir Blazor Web Assembly uygulamasında  *local storage* , *session storage* ve depolamayı programatik olarak temizleme kullanarak istemci tarafı durum yönetimi tekniklerini uygulamayı öğreneceksiniz.

---

## 🧱 Adım 1: Yeni Bir Blazor Uygulaması Kurulumu

Birinci adımda, Blazor Wasm şablonunu kullanarak yeni bir Blazor uygulaması kuruyorsunuz ve uygulamanıza `client-state-app` adını vereceksiniz; ardından `client-state-app` dizinine geçecek ve uygulamayı çalıştıracaksınız.

```bash
cd client-state-app
```

```bash
dotnet run
```

---

## 💾 Adım 2: Local Storage Uygulaması

İkinci adımda,  *local storage* ’ı uygulayacağız ve bunun için `Home.razor` sayfasına gideceğiz. Bu sayfada, *local storage* kütüphanesini, yani `Blazored.LocalStorage.ILocalStorageService` servisini enjekte edeceksiniz.

Bu servis, uygulamaya değişkenleri ve bilgileri yerel olarak depolamak için erişim sağlar.

Ardından, `@code` yönergesinde bu kütüphaneden yararlanacaksınız ve şöyle bir satırınız olacak: `await local storage`, ve öğeyi `user theme` olarak ayarlayacaksınız.

Bu, *local storage* için vereceğimiz bir isimdir; yani `await localStorage.SetItemAsync` kullanacaksınız: `user theme` verdiğimiz isimdir ve bunu `theme` değişkeninde ne varsa ona ayarlayacağız.

Bu işlemin yapacağı şey, tema değiştirildiğinde, `theme` değerinin ne olduğuna bağlı olarak bu değeri  *local storage* ’a kaydetmektir. Böylece uygulama kapanıp yeniden başladığında, o değeri  *local storage* ’dan çekebilir ve yeniden kullanabilir.

Sonra görev, `OnInitializedAsync` içindeki `override async task` üzerinde başlatıldığında, `theme` değişkenini `user theme` değişkeninde ne varsa onunla dolduracaktır.

Dolayısıyla bir değer varsa, o değerle dolduracaktır; aksi hâlde `light` değeriyle dolduracaktır.

Bu senaryoda,  *local storage* ’dan değeri kaydetmemizi ve  *local storage* ’dan geri almamızı sağlar.

---

## 🕒 Adım 3: Session Storage Kullanımı

Şimdi üçüncü adımda *session storage* kullanacağız ve bunun için `Cart.razor` dosyasına geçeceğiz.

Burada, `session storage` adlı *session storage* kütüphanemizi enjekte ettiğimizi görebilirsiniz ve bu, bu kod boyunca o kütüphaneyi kullanmamıza izin verir.

Sayfamıza `cart` adını vereceğiz ve bu da uygulamayı başlattığımızda sayfaya gitmek için kullanacağımız route olacaktır.

Ardından *session storage* değerini uygulamaya enjekte edeceğiz.

`@code` yönergesinde, `AddItem` metodunda `cart` adlı bir *session storage* değişkeni oluşturacağız ve bu *session storage* değişkenini `cart items` ile dolduracağız.

 *Session storage* , oturum hâlâ aktifken bilgiyi tutmanıza izin verir.

Yani tarayıcı sayfası kapatılmadığı sürece, sayfayı yenileseniz bile bu veri aktif kalır.

Tarayıcı sayfası kapatıldığında *session storage* silinir.

Dolayısıyla *session storage* içindeki `cart` değişkenini, `cart items` içinde ne varsa onunla dolduracağız.

Ve  *local storage* ’a benzer şekilde, uygulamayı `OnInitializedAsync` içinde başlattığımızda, `cart` değişkeninden de çekeceğiz.

Yani `cart` değişkeni *session storage* içinde varsa, onu içindeki ne varsa onunla dolduracağız.

Aksi hâlde, sepette ne varsa saklamak için kullanabileceğimiz yeni bir `string` liste değişkeni oluşturacağız.

 *Local storage* ’a benzer biçimde, *session storage* da öğeleri içine eklememize ve herhangi bir değerle doldurulmuşsa içinden öğeleri geri almamıza izin verecektir.
