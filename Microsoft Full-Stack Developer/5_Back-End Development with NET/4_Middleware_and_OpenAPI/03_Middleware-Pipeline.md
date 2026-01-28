## 🧱 Middleware Pipeline

Bir web sitesini her ziyaret ettiğinizde, isteğinizi karşılamak için arka planda birçok işlem gerçekleşir. Bu adımlar, örneğin bilgilerinizi güvende tutmak gibi, her şeyin sorunsuz çalışmasını sağlar. Tüm bunların arkasında, bunu yönetmeye yardımcı olan *middleware pipeline* adı verilen bir yapı vardır.

Bu  *pipeline* ’ın nasıl çalıştığını öğrenerek, güvenli ve verimli çalışan uygulamalar geliştirebileceksiniz. Bu videoda, ASP.NET Core’da  *middleware pipeline* ’ı açıklayacağız.

---

## 🧠 Middleware Pipeline Kavramı

Bir  *middleware pipeline* , bir istemcinin (örneğin bir web tarayıcısı veya mobil uygulama) sunucuya yaptığı her isteği ele alan bir dizi adım, yani bir dizi *middleware* parçasıdır.

Her adımın bir görevi vardır; örneğin:

* istekleri kaydetmek ( *logging requests* )
* güvenliği kontrol etmek ( *checking security* )
* hataları yönetmek ( *handling errors* )

Bir adım işini bitirdiğinde, istek bir sonraki adıma geçer. Bu süreç, istek tamamen yönetilene ve kullanıcıya bir *response* döndürülene kadar devam eder.

---

## 🔄 İsteklerin Pipeline İçindeki Akışı

Artık *middleware pipeline* kavramını anladığınıza göre, isteklerin bunun içinden nasıl aktığını parçalayalım.

1. İlk olarak kullanıcı gelen bir istek yapar; örneğin bir web sayfasını yükler.
2. Bu istek, pipeline’a ilk *middleware* üzerinden girer.
3. İkinci olarak istek, kullanıcı etkinliği ve erişilen kaynak gibi ayrıntıları kaydeden  *logging middleware* ’e aktarılır. *Logging* tamamlandıktan sonra istek üçüncü adıma, yani  *authentication* ’a geçer.
4. *Authentication middleware* , kullanıcının uygulamada oturum açıp açmadığını kontrol eder. Eğer değilse, isteği durdurur ve kullanıcıyı giriş sayfasına yönlendirir. Aksi hâlde bir sonraki adıma geçer. Bu, web sitenizin önemli bölümlerini yetkisiz kullanıcılardan korumaya yardımcı olur.
5. Yetkiliyse istek, dördüncü adım olan  *application logic middleware* ’e geçer; burada veri alınır veya işlenir.
6. Son olarak beşinci adımda, istek bir *response* üretir ve bu yanıt kullanıcıya geri gönderilir.

Örneğin, *static file middleware* bir dosya isteğini (bir görsel veya bir CSS dosyası gibi) işlediğinde, dosyayı sunucudan alır ve kullanıcıya gönderir.

Dosya mevcut değilse, pipeline uygun bir yanıt üretmek için *error handling* gibi diğer  *middleware* ’lere geçer; örneğin *404 not found* sayfası.

---

## 🧭 Middleware Sırasının Önemi

 *Middleware* ’i hangi sırada çağırdığınızın önemli olduğunu not etmek gerekir. Örneğin, *authentication* hassas veri alındıktan sonra çalışırsa, yetkisiz kullanıcılar bu verilere erişebilir.

---

## 🏪 Örnek Akış: Groove Echo

Bunu bir örnekle gösterelim: Groove Echo adında hayali bir şirket kullanalım; sürdürülebilir yaşam ürünlerini çevrim içi satan, Echo-dostu bir startup.

Yeniden kullanılabilir çantalar ( *reusable bags* ) ürün sayfasını yüklemek için yapılan bir isteğin *middleware pipeline* içindeki akışı şu şekildedir:

Groove Echo web sitesinde yeniden kullanılabilir çantaları görüntülemek için tıkladığınızda, tarayıcınız sunucuya bir istek gönderir. Bu gelen istek, sürecin ilk adımıdır.

Ardından istek, ziyaret ettiğiniz sayfa, sitedeki etkinliğiniz ve izleme amaçlı ilgili veriler gibi ayrıntıları kaydeden  *logging middleware* ’den geçer.

Sonra sunucu, oturum açıp açmadığınızı kontrol etmek için *authentication middleware* kullanır. Kimliğiniz doğrulanmamışsa, sisteme belirli özelliklere (örneğin ürünleri sepetinize eklemek gibi) erişmeden önce giriş yapmanız istenir.

Kimlik doğrulandıktan sonra sunucu, isteği işlemek için  *application logic middleware* ’i kullanır ve Groove Echo’nun veritabanından gerekli ürün bilgilerini alır. Bu, yeniden kullanılabilir çantalar için ürün detaylarını, fiyatları ve stok durumunu içerir.

Son olarak sunucu, ürün verisini içeren bir *response* üretir ve bunu tarayıcınıza geri gönderir. Yeniden kullanılabilir çantalar sayfası görüntülenir ve siz sayfada gezinebilir ve etkileşim kurabilirsiniz.

---

## ✅ Özet

Bu videoda  *middleware* , *pipeline* ve ASP.NET Core’un nasıl çalıştığını öğrendiniz; özellikle de  *middleware* ’in, etkinliklerin ilk etapta *logging* ile kaydedilmesinden uygulamaların *authentication* ile güvence altına alınmasına kadar istemci isteklerini yönetmedeki temel rolünü gördünüz.

Bu  *pipeline* , her isteğin doğru biçimde yönetilmesini sağlayan; güvenli, verimli ve iyi yapılandırılmış web uygulamaları oluşturmak için kritik bir yapıdır.
