## 🔄 Durum Yönetimi ve API Veri Güncellemeleri

Önceki bir ekran kaydında, bir API’ye çağrı yapan ve bu API’den kullanıcı verisini alan basit bir uygulama oluşturmuştuk. Bu ekran kaydında, Blazor uygulamasındaki API çağrılarımızda durum (state) yönetimini ve API veri güncellemelerini nasıl yönetebileceğimizi göstermek için o uygulamanın üzerine inşa edeceğiz.

Yine, uzaktaki bir API’den kullanıcı verisini alan basit bir uygulamamız var. Bu uzak API, `jason placeholder.tipico.com/users`. Ve yalnızca, bir kullanıcı nesnesine koyduğumuz kullanıcı verisini getiriyor. Bu API’den dönen veriyle bir kullanıcı nesneleri listesi dolduruyoruz; üst tarafta da geri gelen veriyi göstermek için web sayfamızda doldurduğumuz bazı HTML’ler var.

Uygulamamızda, API çağrısı içinde durum yönetimini nasıl yapabileceğimizi göstermek için birkaç değişiklik yaptık.

---

## 🧯 Cancellation Token ile Çoklu İstekleri Kontrol Etme

Buraya bir *cancellation token* ekledim. Bu, çok fazla istek yapılırsa uygulamaya bildirim göndermemizi sağlar; böylece tüm istekleri aynı anda yapmayız. Sayfada bir butonumuz var; biri bu butona çok fazla kez tıklarsa bunu yakalamak ve çağrının yapılmasını engellemek istiyoruz.

Bu `async task`, yani `fetch users` metodunun *async* olması, bir kullanıcı bir butona art arda 10 kez tıklarsa 10 görevin kuyruğa alınacağı ve API’ye 10 kez çağrı yapılacağı anlamına gelir.

Çoğu zaman kullanıcılar, anında bir yanıt görmedikleri için butona tıklarlar. Ve çoğu zaman API’ye çağrı yapmaya devam etmek istemeyiz; çünkü bu kaynaklar üzerinde yük oluşturur. Tek bir kullanıcının butona 10 kez tıklaması büyük bir sorun değildir. Ama 100.000 kullanıcı bu butona birden fazla kez tıklarsa, internet üzerinden API’ye sürekli çağrılar yapılır ve bu kaynaklar üzerinde yük oluşturabilir.

Bu yüzden burada yapacağımız şey, API çağrımızın durumunu yönetmek ve kullanıcıların o butona sürekli tıklamasına izin verilmediğinden emin olmaktır. Kullanıcılar ara sıra çağrı yapabilir, ama birden fazla çağrıyı kuyruklayıp API’ye peş peşe göndermelerini istemiyoruz.

---

## 🧩 CancellationTokenSource ile State Yönetimi

Uygulamamızda bunları yönetebilmek için bazı değişiklikler yaptım. Bunu yapmanın bir yolu, bir *cancellation token source* değişkeni oluşturmak ve bunu `CTS` adlı değişkende tutmaktır; bu şekilde durumu yönetebileceğiz.

Başta sahip olduğumuz aynı değişkenler de var: `isLoading` ve `StateHasChanged` metodu, durum yönetimini yapmamıza yardımcı olacak.

Artık `FetchUsers` çağrıldığında `CTS.Cancel` metodumuz var. Bu, `FetchUsers` çağrılırken önceki herhangi bir isteği iptal eder. Yani çağrı henüz tamamlanmadıysa, o isteği iptal eder ve yeni bir istek başlatır.

Burada, bu süreci yönetmek için `CTS` değişkenindeki *cancellation token source* mekanizmasını kullandığımızı görebilirsiniz.

Ayrıca `token` adında bir değişken oluşturuyoruz. Bu da, *cancellation token source* ile oluşturduğumuz `CTS.Token`.

---

## 🐢 Gecikme Ekleyerek İptali Gözlemleme

Buraya bir gecikme (delay) ekledim; sadece API’ye yapılan çağrının yavaş olduğunu simüle etmek için, böylece iptalin nasıl çalıştığını görebilelim.

Bu uygulama çok basit ve API çağrısı o kadar hızlı gerçekleşiyor ki, bu gecikme olmadan iptali göremeyiz; çünkü çok hızlı çağrı yapıyor. Bu yüzden, yeni bir istek yapıldığında önceki isteği iptal edebilelim ve bunun çalıştığını görebilelim diye basit bir gecikme ekledim.

---

## 🌐 API Çağrısı ve Token Geçirme

Burada aynı çağrıyı görüyoruz: kullanıcılar değişkenimizi (kullanıcı listemizi) bu API’den dolduruyoruz: `https://json placeholder.typical.com/user` ve bununla birlikte çağrıya `token` da geçiriyoruz; böylece API çağrısının durumunu yönetebiliyoruz.

---

## 🧪 Hata Yakalama: TaskCanceledException ve Diğerleri

`try-catch` bloğumuz içinde birkaç `catch` bloğu var.

İlk olan `TaskCanceledException`. Yani görev iptal edilirse, başka bir nedenle oluşan hatadan farklı bir aksiyon alacağız. Bu noktada çoklu istekleri yönetebiliriz.

Örneğin, kullanıcı butona çok çok fazla basıyorsa, “önceki istek işleniyor, lütfen bekleyin” gibi bir mesaj gösterebileceğiniz bir senaryo düşünebilirsiniz.

Diğer taraftan, gerçekten bir hata oluştuğunda oluşan herhangi bir başka exception farklı bir mesaj üretecek. Bizim örneğimizde sadece konsola yazıyoruz. Ama exception türüne göre farklı aksiyonlar alabileceğiniz bir senaryo da düşünebilirsiniz.

---

## 🎲 Query String ile Değişken Veri Döndürme

Yaptığım bir diğer şey, `limit` adında bir query string eklemek oldu. Bu, `typical.com`’un desteklediği bir şey. Sadece 5 ile 10 arasında yeni bir rastgele sayı üretiyorum.

Yaptığım şey sadece şu: API’ye, her çağrıda 5 ile 10 kullanıcı arasında bir veri döndürmesini söylüyorum. Bu da API çağrıları yaptığımızda farklı veriler üretebildiğimizi göstermek için.

---

## ▶️ Uygulamayı Çalıştırma ve Sonuçları Görme

Şimdi `try-catch` bloğumuz var; yeni `TaskCanceledException` ile birlikte.

Ve `finally` bloğumuz var; bu da uygulamanın önceki sürümünde olduğu gibi sadece değişkenleri yönetiyor.

Hadi bunu çalıştıralım. Uygulamaya göz atalım.

Ben de `fetch users` route’una gideceğim. Butona bastığımda, dışarı çıkıp veriyi getirmesi gerekiyor. Ve bu sefer 5 kayıt aldığımızı görebilirsiniz.

Şimdi butona tekrar basacağım; bir süre sonra farklı bir sayı almamız gerekir. Şimdi 8 kayıt aldık. Bu, API çağrısında ayarladığım rastgele değişken; `limit` parametresi geçiriyorum, 5 ile 10 arasında kayıt istiyorum.

---

## 🧰 DevTools ile İptal Mesajlarını İzleme

Şimdi dev tools’u açacağım, üretilen hata mesajlarını görebiliriz. Konsolumdayım.

Şimdi butona aynı anda birden fazla kez basacağım.

Butona 5-6 kez bastığımı fark edin; “previous API call was canceled” mesajından 5 tane üretti.

Uygulamamızda, bu tam olarak burada yazdığımız mesaj. Yani butona çok fazla bastığımda, önceki çağrı tamamlanmadığı için `TaskCanceledException` üretti.

Önceki çağrı tamamlanmadığı için, “previous API call was canceled” exception’ı üretiyor.

Eğer butona tekrar basarsam, farklı sayıda kullanıcı getirmeli ve çağrıyı iptal etmemeli.

Yani iki saniye içinde çok fazla basarsam, bu exception’ın üretildiğini görebilirsiniz.

---

## ✅ Sonuç: API Çağrılarında State Yönetimi

*CancellationTokenSource* kullanarak API çağrılarımızın durumunu yönetebiliriz. Bu da kullanıcıların API’ye gereksiz yere çok fazla çağrı yapmadığından emin olmamızı sağlar.

Ve bunun nasıl olacağını, kullanıcıya bu durumlarda nasıl mesaj vereceğinizi yönetmenin birçok yolu var. Ama bu yaklaşım, API güncellemelerimizin makul bir şekilde ele alınması için durumu yönetmemizi sağlar.
