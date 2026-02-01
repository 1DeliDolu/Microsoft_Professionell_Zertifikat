## 🔐 JWT Kimlik Doğrulamasını Uygulama

Tamam, artık .NET kodumuzla birlikte bazı JWT’leri devreye alma zamanı. JWT’leri kullanarak bir .NET uygulamasında temel kimlik doğrulamasını uygulama sürecini adım adım göstereceğim. Burada gerçekten basit bir uygulamamız var ve çok fazla şey olmuyor. Kimlik doğrulama ( *authentication* ) var, yetkilendirme ( *authorization* ) var, ardından kök ( *root* ) route ve güvenli ( *secure* ) route var. Peki JWT’leri nasıl ekleriz?

İlk olarak, authentication tarafına gelip burada bir metod kullanmak isteyeceğiz:  **add JWT bearer** . JWT bearer’a erişebilmek için de paketi ekleyeceğiz. Yani `.NET add package` diyeceğiz ve bu paket **microsoft.aspnetcore.authentication.jwtbearer** olacak. *authentication* kelimesini doğru yazdığımdan emin oluyorum. Doğru görünüyor. Hadi deneyelim.

Şimdi her şeyin doğru şekilde kurulduğu görünüyor. İçeri girip çıktığınızda bunun kaybolduğunu görmelisiniz. Bekleyebileceğiniz gibi, burada ayarlamamız gereken bazı ayarlar olacak. Örneğin JWT, hangi key’i kullanacağını nereden bilecek?

Bu yüzden yine bazı options ayarlayacağız ve bu, her zamanki gibi options parametresi alan bir fonksiyon olacak. Şimdi `options.tokenvalidationparameters` diyelim. Ve bu da yeni bir **token validation parameters** olacak.

Burada sadece bir şeye odaklanacağım:  **issuer signing key** . Bu, bir token’ın geçerli olduğundan emin olmak için kontrol edeceğimiz gizli koddur. JWT’leri üreten issuer’ın da JWT’leri imzalamak için aynı koda sahip olması gerekir; aksi durumda hepsini reddederiz çünkü güvenli ve sağlam olduklarını bilemeyiz.

Bunu oluşturma yolu şöyle: `new symmetric security key` diyeceğiz. Bu bir parametre alacak; `encoding.utf8.getbytes` diyerek parola olarak kullanmak istediğimiz metin parçasını geçeceğiz.

Bu metin en az 32 karakter uzunluğunda olmalı ve bunu asla doğrudan kodun içine böyle yazmak istemezsiniz. Her zaman app settings içine koyup oradan çekmek, user settings kullanmak ya da bunu saklamak için harici bir yazılım kullanmak istersiniz. Bunun nedeni; bu tür önemli gizli güvenlik bilgilerinin yanlışlıkla kodla birlikte bir repoya commit edilmesini istememenizdir. Birinin hem kodunuza hem de secret key’inize aynı anda ulaşmasını istemezsiniz. İkisini aynı yerde, herkese açık biçimde tutmak istemezsiniz.

Ama burada, ne olduğunu çok net göstermek için yazacağım. Anlamayı zorlaştıracak hiçbir şeyin araya girmesini istemiyorum: Yaptığımız tek şey, JWT token’ımızın doğru olduğunu kontrol etmek için bir metin parçası kullanmak.

O yüzden “bunu asla böyle bırakma” diyerek yazacağım: 1, 2, 3, 4, 5, 6, 7, 8, 9 ve yeterince uzun olması için birkaç rakam daha.

Şimdi burada ayarlayacağım birkaç bilgi daha var. Normalde bunu yapmak istemezsiniz ama bu konuları daha sonra ele almak istiyorum. `validate issuer = false` diyelim. Sonra `validate audience = false`. Sonra da `validate lifetime = false`.

Buradan çok basit başlamak istiyorum. Ve tekrar: Bunu pratikte asla istemezsiniz. Bunlar genellikle çok iyi uygulamalardır. Issuer’ı doğrulamak istersiniz, audience’ı doğrulamak istersiniz ve lifetime’ı doğrulamak istersiniz. Normal bir senaryoda bu üçünün de **true** olması gerekir.

Ama bu, token üretmeyi ve ilk başta neler olduğunu net şekilde görmeyi biraz daha kolaylaştıracak.

Artık uygulamamızda JWT tabanlı authentication çalışsın diye gereken her şeyi yaptık. Bunu kaydedebiliriz, aşağı inip `.NET Watch` diyebiliriz ve uygulamamızı çalıştırabiliriz.

Requests dosyamıza gelirsek, root route’u vurup sonucu alabilmeliyim. Sonra secure route’un engellendiğini görmeliyim. Şimdi bir JWT’ye ihtiyacım var.

Kendi JWT’lerinizi üretebilirsiniz. Bir kullanıcının giriş yapmasını sağlayan ve sonra JWT veren .NET kodu yazabiliriz. İnsanların yaptığı bir şeydir bu.

Ama çoğu zaman harici issuer’larla çalışırız. Bu issuer Microsoft olabilir, Auth0 olabilir ya da JWT’leri üreten başka bir servis olabilir. Nereden geldikleri önemli değil. Bu key ile imzalanmış herhangi bir JWT, kullanıcıyı uygulamamıza alır.

Bunu kanıtlamak için bir tarayıcı açacağım ve *JWT.io* kullanarak yoktan bir JWT üreteceğim. Şimdi burada bazı veriler var. Secret’ımızı ekleyeceğim.

Artık bu token’ı alabilmeliyim; bu token şimdi bu key ile imzalanmış geçerli bir JWT. Bu token’ın içinde ne olduğu önemli değil çünkü herhangi bir role, claim ya da bilgi kontrol etmiyoruz. Sadece geçerli imzalı bir token’a ihtiyacımız var ki kullanıcının authenticated olduğunu göstersin.

Şimdi geri gelirsek, bu token’ları bir istekle birlikte gönderme şeklimiz: **authorization header** kullanırız ve **bearer** kelimesiyle başlarız, ardından token gelir. Bunun daha kolay görünmesi için WordRap’i açayım.

Bu isteği gönderirsem, artık **200 OK** alıyorum ve “this is a secure route” diyor. Ve unutmayın: Eğer signature’ı değiştirirsem bir anda geçersiz olur.

Payload’u değiştirsem de aynı şey. Artık geçersiz. Yani bu, secret key kullanılarak oluşturulmuş kurcalamaya dayanıklı ( *tamper proof* ) bir token’dır.

Tekrar: Bunlar herhangi bir issuer’dan gelebilir; kendi uygulamanız ya da başka biri. Önemli olan şeyler: Token, uygulamamızın kullandığı key ile imzalanmış olmalı. Uygulamamız header’a ve payload’a bakacak, key’imizi signature ve veriyle birlikte kontrol edecek. Üçü de birlikte mantıklıysa, bu geçerli bir token’dır.

Ve artık kullanıcı giriş yaptığı için, route içinde istediğiniz veriyi buradan çekebilirsiniz ve imzalandığı için ona güvenebileceğinizi bilirsiniz. Eğer “bu kullanıcı ID’sine sahip” diyorsa, “bu e-postaya sahip” diyorsa, “şu roller/claim’ler/izinlere sahip” diyorsa; issuer’a güveniyorsanız, yani key’i verdiğiniz kişiye/uygulamaya güveniyorsanız, bu veriyi uygun şekilde yorumlamak güvenlidir.

Son olarak hızlı bir özet: Uygulamamızda JWT authentication kurmak için gereken tek şey authentication’a JWT bearer eklemek ve bu symmetric security key’i ayarlamaktı. Issuer, audience ve lifetime konularını biraz sonra konuşacağız; biz şimdilik bunları false yaptık. Normalde bunu istemezsiniz ve bu key’i mutlaka app development settings veya end user settings gibi bir yere taşımalısınız.

Sonra bir JSON token alıp kullanabiliyoruz; bunları **authorization header** ile geçirirsiniz ve **bearer** kelimesiyle başlayıp ardından token’ın tam değerini gönderirsiniz. İşte secret key’inizle, herhangi bir issuer’dan gelebilen stateless JWT token’larını bu şekilde kullanırsınız.
