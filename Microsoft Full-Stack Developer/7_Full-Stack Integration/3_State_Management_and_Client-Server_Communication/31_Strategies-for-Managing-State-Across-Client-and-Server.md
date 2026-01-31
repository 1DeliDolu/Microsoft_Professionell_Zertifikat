## 🔄 İstemci ve Sunucu Arasında Durumu Yönetme Stratejileri

İstemci-sunucu uygulamalarıyla çalışırken, çoğu durumda istemci ile sunucunun senkronize kalması gerçekten çok önemlidir. Bugün bu ekran kaydında göstereceğimiz bir sohbet uygulaması gibi, tüm istemcilerin mesajları aynı anda almasının çok önemli olduğu birçok gerçek zamanlı senaryo vardır.

E-posta uygulamalarının da buna benzer bir senaryo olabileceğini düşünebilirsiniz ve senkronizasyonun tutarlı ve güvenilir şekilde gerçekleşmesini istediğiniz birçok durum vardır.

Bu yüzden bu ekran kaydında, istemci ve sunucu arasında durumu yönetmek için stratejileri göstereceğim; böylece uygulamanın istediğimiz şekilde tutarlı olduğundan emin olacağız.

---

## 🧱 Çözüm Yapısı ve Genel Akış

Burada üç farklı projenin yüklü olduğu bir .NET çözümüm var.

Bir istemci tarafım, bir sunucu tarafım ve hem istemcinin hem de sunucunun kullanabildiği bir paylaşılan ( *shared* ) projem var.

Bu, önceki bir ekran kaydı için oluşturduğum bir çözüm; bu yüzden biraz tanıdık görünebilir.

Sunucu tarafı, “dinleyici” olacak. Mesajları dinleyen taraf bu. Bu, farklı istemcilerle sohbet edip mesaj gönderip alabileceğiniz küçük bir uygulama.

Sunucu bu mesajları dinleyecek.

Bunu yapmak için SignalR kullanıyor.

SignalR, bir servise abone olan tüm istemcilerin gerçek zamanlı güncellemeleri almasını sağlamak için geliştiricilerin kullanabileceği bir gerçek zamanlı kütüphanedir.

Dolayısıyla bu mesajları yönetmek için SignalR kullanacak.

İstemci tarafında ise, mesaj göndermek ve almak için oluşturduğum servisle birlikte kullandığımız arayüz var; yani kullanıcılara mesaj göndermek ve bu mesajları almak.

Çok basit bir uygulama ama umarım anlatmak istediğimi gösterir.

Paylaşılan kütüphane şimdilik sadece bir sınıf dosyasına sahip; bu sınıf, mesajların ne içermesi gerektiğini belirliyor.

Kullanıcı ( *user* ), mesaj ( *message* ) ve bir zaman damgası ( *timestamp* ) var.

Ve bunlar, istemci ve sunucu arasında gidip gelen şeyler.

---

## 🧪 Çalışma Şeklinin Gösterimi

Bunu daha sağlam ( *robust* ) hâle getirmek için uygulamayı biraz değiştireceğiz; senkronizasyonun ve entegrasyonun nasıl yönetildiğini iyileştirebileceğimizi göstermek için bir “en iyi uygulama” olarak.

Bunu yapmadan önce, bunun nasıl çalıştığını göstereceğim.

İstemci ve sunucu çalışıyor.

Burada iki terminal pencerem var ve iki uygulamayı da başlattım.

Şimdi iki farklı tarayıcı penceresine gideceğim.

Bir tarafta Google Chrome var, diğer tarafta Microsoft Edge var.

Yani iki farklı istemci ve aynı sohbet arayüzü.

Bu, istemci tarafında bulunan ve gösterdiğim `razor` dosyası.

Bu istemci uygulaması ve iki farklı tarayıcı penceresine, hatta iki farklı tarayıcıya yükledim ki nasıl çalıştığını görebilesiniz.

Bu istemcilerin açıkçası dünyanın herhangi bir yerinde olabileceğini düşünebilirsiniz.

Tam olarak aynı şekilde çalışırdı.

Dolayısıyla kullanıcı 1’den bir mesaj gönderdiğimde, şu anda içinde olduğum Microsoft Edge penceresinde görünecek.

SignalR kullandığımız için, o mesajı gösterdiğim sunucu uygulamasına gönderecek ve istemci uygulamasında şu anda oturum açmış ve o servise abone olan tüm istemcilere yayınlayacak.

Mesajın burada Microsoft Edge penceresinde göründüğünü ve aynı zamanda Google Chrome penceresinde de göründüğünü görmemiz gerekir.

Mesajı yazdığımda senkronize olduğunu görebilirsiniz.

Kullanıcı 1’den mesaj gönderildi.

Kullanıcı 1 penceresinde göründü ve kullanıcı 2 penceresinde de göründü.

Şimdi kullanıcı 2’den farklı bir mesaj yazacağım ve o mesaj kullanıcı 2 penceresinde görünecek, ama aynı zamanda kullanıcı 1 penceresinde de görünecek.

Dolayısıyla SignalR ve bu uygulama ile, `localhost 5132/chat`’e bağlı olan herkese bu mesajları yayınlayabiliyoruz ve o kişiler bu mesajları alacak.

---

## 🛠️ Uygulamayı İyileştirme İçin Değişiklikler

Şimdi uygulamamıza geri dönelim.

Her iki servisi de durduracağım.

İstemciyi durduracağım ve sunucuyu durduracağım.

Ve şimdi uygulamamızı biraz değiştirebiliriz.

Uygulamayı iyileştirmenin bir yolu, gönderilen mesajlara bir `version` özelliği eklemektir.

Bir `version`, gönderilen mesajların belirli bir türde olduğunu ve belirli bir istemciden geldiğini bilmemize yardımcı olur.

Ve bu, mesaj gönderirken uygulayabileceğimiz ekstra bir kontrol sağlar; böylece kopya mesaj göndermediğimizden veya senkron dışına çıkmadığımızdan emin oluruz.

`SendMessage` metoduma bir `version` özelliği ekleyeceğim.

Önce bu özelliği `int` olarak ekleyeceğim; yani bariz şekilde bir sayı.

Bunu sınıf dosyamın en üstüne koyacağım.

`GetExistingVersion` adlı bir metot çağıracağım; bu metot kullanıcı sınıfından bir mesajın mevcut sürümünü alacak.

Bunu `existingVersion` değişkenine koyacağım.

`GetExistingVersion` metodumu oluşturacağım.

Tam olarak uygulamayacağım.

Sadece nasıl çalıştığını göstermek için kullanacağım.

Bu metodu sınıf dosyamın en altına ekleyeceğim.

Şu anda sadece `1` döndürüyorum.

Gerçek dünya senaryosunda, bir kullanıcı aynı mesajı birden fazla kez göndermeye çalışırsa, istemciler o mesajı birden fazla kez alabilir.

Bunun olmasını istemiyoruz.

Dolayısıyla burada yapacağımız şey, mesaj gönderilmeden önce mesajın mevcut sürümünü almak ve sadece en güncel olanı, mevcut olanı, şu anki olanı göndermek olur.

Burada ise bunun ilk mesaj olacağını varsaydığımız için sadece `1` döndürüyorum.

Şimdi biraz mantık eklemek istiyorum.

Özetle şöyle diyeceğim: Eğer mesajın sürümü mevcut sürümse, yani mevcut sürüm “mevcut olan” sürümse, o zaman return etmek istiyorum.

Uygun olmayan bir mesaj gönderilmesini istemiyorum.

Bunu `SendMessage` metoduma ekleyeceğim.

Yani `message.Version` değerinin `existingVersion` değerinden küçük veya eşit olup olmadığını kontrol edecek.

Eğer öyleyse, bir çakışma ( *conflict* ) var demektir ve metottan döneceğiz; çünkü mesajı göndermek istemiyoruz.

Sadece örnek amaçlı olarak `return` satırını yorum satırı yaptım.

Sonra bir timestamp ekleyeceğiz ve mesajı tüm istemcilere göndereceğiz.

Bu, bize sadece ekstra bir kontrol sağlamış oldu.

SignalR mesajları yönetmede ve çakışma olmamasını sağlamada çok iyidir, ama bu bize biraz daha kontrol veriyor; böylece mesaj gönderirken gerçekten göndermek istediğimiz doğru mesajlar olduğundan emin olabiliyoruz.

Hub’a bu yeni `version` özelliğini ekledik ve şimdi istemci tarafında bir değişiklik yapmak istiyorum.

İstemci, doğal olarak sunucuya bağlanan taraftır ve bu bağlantı, istemcilerin tüm veriyi alması için gerçekten önemlidir.

SignalR bir bağlantı koparsa istemcileri bağlı tutma konusunda çok iyidir.

SignalR her şeyin sağlam kalmasını sağlamak konusunda çok iyidir.

Ama ben buna biraz mantık eklemek istiyorum.

İstemci herhangi bir nedenle kapanırsa ve bu event algılanırsa, küçük bir gecikme vermek ve yeniden bağlanmayı denemek istiyorum.

Yeniden bağlanmayı istemcinin yönetmesini istiyorum.

Bağlantıyı oluşturan, kuran bir `ChatService` metodum var.

Bu, sunucumuzdaki 5137 portundaki `chat hub` endpoint’ini çağırıyor.

Bağlantıyı oluşturuyor, ama ben bu bağlantıyı oluşturan değişkene başka bir özellik, yani bir event ekleyeceğim.

Eğer bağlantının kapandığını algılarsa, hata bilgisi event’e geçilecek; sonra birkaç şey yapacağım.

Yaklaşık beş saniye bekleteceğim.

Sonra yeniden bağlanmayı deneyeceğim.

Bu kodu bu özelliğe ekleyeceğim ve bu, kapalı event’i (`hubConnection.Closed`) algılayacak.

Ardından tarayıcı konsoluna, bağlantının kaybolduğunu ve yeniden bağlanıldığını yazacak.

Yaklaşık beş saniye bekleyecek ve sonra bağlantıyı yeniden deneyecek.

`StartAsync`, sunucuya bağlanmayı denediğimiz metot.

Bunu aşağıda görebilirsiniz; hub’a bağlantıyı oluşturduğu yer.

Bu kodu ekleyerek uygulamayı biraz daha sağlam hâle getirmiş olduk.

Bu iyi bir en iyi uygulama.

Biraz daha kontrol verir.

Gerçek dünyada bağlantı koparsa, SignalR bağlantıyı yeniden kurabiliyor olsa bile, bu event’i yakalayarak kullanıcıya mesajlar gösterebilirsiniz; “bağlantı koptu, yeniden bağlanmaya çalışıyoruz” gibi küçük bir pop-up.

Böylece kullanıcıya biraz daha bilgi verebilirsiniz.

Dolayısıyla bu, istemci ve sunucu ortamınıza uygulamanızı daha sağlam hâle getirmek için uygulanabilecek iyi bir pratiktir.

Bunlar, SignalR’ı istemci-sunucu ortamında kullanarak daha sağlam istemci-sunucu etkileşimlerini yönetmenin, durumun senkronize kalmasını sağlamanın ve bu ortamı daha kullanılabilir ve daha kullanıcı dostu hâle getirmek için kullanabileceğiniz mekanizmaların yollarıdır.

Bu kodu uygulamamıza ekleyerek bu durumları çok daha zarif şekilde yönetebiliriz.

Uygulama bu kod olmadan da çalışıyordu, ama bunu ekleyerek kullanıcılarımız için uygulamayı ve deneyimi iyileştirebiliriz.
