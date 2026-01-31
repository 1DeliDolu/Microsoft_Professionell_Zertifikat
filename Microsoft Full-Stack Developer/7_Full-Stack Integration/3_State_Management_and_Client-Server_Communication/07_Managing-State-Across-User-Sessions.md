## 🧠 Kullanıcı Oturumları Arasında Durumu Yönetmek

Bir Blazor uygulamasında oturumlar arasında ve hatta uygulama yeniden başlatmaları arasında durumu kaydedebilmek, kalıcılığı olan bir uygulama geliştirmede ve daha iyi bir kullanıcı deneyimi oluşturmada önemli bir parçadır.

Bu ekran kaydında, iki farklı depolama türüne bakacağız: *local storage* ve  *session storage* .  *Local storage* , uygulama yüklemeleri arasında kullanıcı bilgisini kaydetmenize olanak tanır ve *session storage* ise oturumlar arasında kullanıcı bilgisini kaydetmenizi sağlar.

Bu yüzden, bunların her birine sırayla bakacağız.

---

## 🧩 Proje Kurulumu ve Kütüphaneler

Burada, her iki depolama türünü de gösterecek birkaç sayfası olan bir Blazor uygulamam var. Bu servisleri aslında Blazor uygulamamıza ekledim.

Yani burada `program.cs` dosyasının en üstünde `blazored.localstorage` ve `blazored.sessionstorage` kullandığımı görebilirsiniz.

Bu kütüphaneleri kullanabilmek için bunları `using` ifadeleri olarak ekledim. Ardından, uygulamamın başka yerlerinde de bu kütüphaneleri kullanabildiğimden emin olmak için bunları `builder services` içine ekliyorum.

---

## 💾 Local Storage Kullanımı

İlk göstermek istediğim şey,  *local storage* ’ın nasıl kullanılacağı.  *Local storage* , aslında veriyi kullanıcının yerel makinesine kaydeder.

Dolayısıyla uygulama yeniden başlarsa, bu depolama kütüphanesinden okur ve kullanıcıya veriyi geri döndürebilir; kullanıcı tarayıcıyı veya uygulamayı kapatsa bile.

`home.razor` sayfasını güncelledik. Burada hem *local storage* hem de *session storage* eklediğimi görebilirsiniz.

Bu örnek için aslında yalnızca  *local storage* ’a ihtiyacımız var, ancak bunun nasıl yapılabileceğini göstermek için ikisini de ekledim.

Bu kütüphaneleri sayfanın en üstünde, HTML’in altında sayfaya enjekte ediyoruz.

HTML oldukça basit butonlardan oluşuyor. Bir **toggle theme** var; bu, bir değişkeni *light* ve *dark* arasında değiştirerek verinin uygulama başlatmaları arasında nasıl kalıcı olduğunu göstermemizi sağlayacak.

Bir de **clear storage** var; bu da kullanıcının  *local storage* ’ındaki tüm veriyi kaldıracak ve baştan başlatacak.

**Toggle theme** içinde, sadece o değişkeni, yani `theme` değişkenini `string light`’tan `string dark`’a çeviriyoruz.

Gerçek dünya uygulamasında, muhtemelen uygulamanın gerçek ayarlarını veya daha anlamlı başka bir veri türünü kalıcı hâle getirirdiniz.

Burada ise sadece bu `theme` string değişkenini başka bir string’e ayarlıyoruz ve bunu nasıl kalıcı hâle getirebildiğimizi gösteriyoruz.

Uygulama yüklendiğinde ise,  *local storage* ’daki kullanıcı teması verisinin içinde herhangi bir veri olup olmadığını kontrol edeceğiz.

Eğer yoksa, string’imizi *light* ile dolduracağız. Aksi hâlde, depolamada ne varsa onunla dolduracağız.

Ve **clear storage** metodu, **clear storage** butonuyla ilişkilendirilen metottur. Burada üstteki **clear all storage** butonuna bağlıdır.

Bu, *local storage* içindeki herhangi bir veriyi kaldırmak için `clear async` metodunu kullanır; ayrıca burada *session storage* da var.

---

## ▶️ Local Storage Davranışının Gösterimi

Bu oldukça basit bir sayfa, ama bunun nasıl çalıştığını size göstereceğim.

Uygulamayı çalıştıracağız ve sayfaya gideceğim. Kendi sayfamız olduğu için doğrudan sayfaya gidebiliriz.

İşte tema değiştiricimiz var. Kullanıcı depolaması boş olduğu için varsayılan olarak *light* geliyor.

Temayı değiştiriyorum ve *dark* oluyor.

Şimdi sayfayı, oturumu yenileyebilirim ve geri geldiğimde hâlâ *dark* olacaktır.

Ama tarayıcımı kapatacağım ve sonra o sayfaya geri geleceğim.

Ve *dark theme* olduğunu koruduğunu fark edeceksiniz.

Bunu, burada yerel makineye kaydedildiği için yaptı.

Sayfa yüklendiğinde, `OnInitializedSync` içinde o veriyi aldı.

`user theme` depolama kütüphanesinden veriyi aldı; elinde ne varsa onu geri getirdi ve bu durumda *dark* idi.

Tüm depolamayı temizleyebilirim ve sonra yenilediğimde  *light* ’a döner; çünkü o depolamayı temizledim ve kodumuz her zaman varsayılanın *light theme* olması gerektiğini söylüyor.

Bu, veriyi kalıcı hâle getirmenin bir yolu; ve tekrar, bu uygulama yeniden başlatmaları arasında kalıcıdır.

---

## 🕒 Session Storage Kullanımı

Bir diğer tür ise, sadece oturum aktifken bilgiyi tutacak olan  *session storage* ’dır; bu da tarayıcı sayfası açık olduğu süre demektir.

Tarayıcı sayfasını kapattığım anda, veri silinecektir.

Burada basit bir sayfam var: ürün ekleyebileceğiniz bir alışveriş sepeti.

 **Add** ’e tıkladığımda, bu `sessionStorage.setItemAsync` metodunu kullanarak öğeyi  *session storage* ’a ekleyecek.

Bu öğeyi, veriyi tutacak olan `cart` nesnesine ekleyecek.

Buradaki alışveriş sepetinde, input elemanına yazdığım herhangi bir öğeyi ekleyecek.

Bu kod ayrıca, sepetime eklediğim öğeleri listeleyecek.

Sayfayı yenilediğimde, `OnInitializedSync` çalışacak.

Bu bir async task’tır ve oluşturduğumuz `cart` nesnesindeki  *session storage* ’dan herhangi bir öğeyi alacaktır.

Eğer oturum için `cart` nesnesi varsa, o sepetin içindeki öğeleri getirecek.

Aksi hâlde, sadece boş bir string listeleyecek.

Şimdi bunu çalıştıracağız.

Uygulama zaten çalışıyor, bu yüzden sadece **cart** sayfasına gideceğim.

Alışveriş sepetim var. Bir öğe ekleyeceğim.

Şimdi alışveriş sepetimde bir öğe olduğunu gösteriyor.

Sayfayı yenilersem, o öğe kalmalı.

İkinci bir öğe ekleyeceğim ve sayfayı yenileyeceğim.

Oturumlar arasında, bu veriyi tutacaktır.

Tarayıcıyı kapatırsam ve sonra sepetime geri dönersem, bilginin kaybolduğunu göreceksiniz; çünkü artık oturumlar arasındayız.

Ne yapacağını bilmiyor.

Bu veriyi kaydetmiyor.

Bu veriyi kalıcı hâle getirmiyor.

Bu tür bir davranış için *local storage* kullanmamız gerekirdi.

---

## ✅ Kapanış

Bunlar, bir Blazor uygulamasında kullanıcı için veri kalıcı hâle getirmenin iki yoludur.

Ya veriyi yerel makineye kalıcı hâle getirirsiniz; böylece uygulama yeniden başlatmaları arasında korunur.

Ya da veriyi oturumda kaydedersiniz; böylece kullanıcı hâlâ o sayfadayken veya uygulama açıkken veri korunur.
