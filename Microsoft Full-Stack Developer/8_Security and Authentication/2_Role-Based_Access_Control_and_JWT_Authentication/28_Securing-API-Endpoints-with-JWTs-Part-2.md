## 🔐 JWT’lerle API Uç Noktalarını Güvenceye Alma

JWT’ler sadece kimlik doğrulamayla ( *authentication* ) ilgili değildir; aynı zamanda yetkilendirme ( *authorization* ) için de gerçekten kullanışlı araçlardır. Yani roller veya claim’ler gibi kimlik bilgilerini taşımak için kullanılabilirler; böylece içlerindeki bilgiyi yetkilendirme amacıyla kullanabiliriz. Bu yüzden hem authentication hem de authorization için işe yararlar.

Bu videoda, JWT’lerle kurduğumuz oldukça temel authentication düzenini, belirli route’lar için rol kontrolü yapacak şekilde biraz daha genişletmeyi konuşacağız. İlk olarak birkaç yeni route ekleyeceğiz. Bu, route’ları güvenceye alma konusunda daha önce yaptığımız çalışmalara çok benzer görünecek.

Bu route’lardan biri için “admin olmasını istiyoruz” diyeceğiz. Diğeri için yine bir “IT department claim” oluşturacağız. Yani bir tanesi  **admin role** , diğeri **IT claim** olacak. Metni de “bunun admin role’a ihtiyacı var” ve “bunun IT claim’e ihtiyacı var” diye güncelleyeceğiz.

Artık bu route’larımız var ve bir kullanıcı doğru role veya claim’e sahip değilse kilitli olacaklar. Peki bu rolleri nasıl ekleriz? `AddAuthorization` kısmını, tekrar `AddAuthorizationBuilder` kullanacak şekilde değiştireceğiz. Sonra da bazı policy’ler ekleyeceğiz.

İlk policy’yi `AddPolicy` ile ekleyeceğiz. Buna **admin** adını vereceğiz. Bu policy bazı options alacak ve sonra `options.RequireRole` diyeceğiz. Role olarak da **admin** vereceğiz. Yani admin rolünü bu şekilde zorunlu kılarız.

Sonra ikinci policy’yi ekleyeceğiz. Buna **IT department** diyeceğim. Yine options alacak ve bu sefer `options.RequireClaim` diyeceğiz. Bu iki değer alır: claim’in anahtarı ( *key* ) ve değeri ( *value* ). Burada key olarak  **department** , value olarak da **IT** diyeceğiz. Çünkü claim’ler key-value çiftleridir.

Böylece policy’leri oluşturmuş olduk. Artık bu policy’lerle korunacak route’lara sahip olmak için gereken her şeyi ekledik.

Şimdi değişecek olan şey, token’larımızın içinde nelerin olması gerektiği. Kaydedip uygulamayı başlatalım. Requests dosyamızı tekrar açacağım ve daha kolay görmek için wrap yapacağım. Root route’a istek gönderince yanıtı alabiliyoruz. Secure route’a da bu token ile istek atabiliyoruz.

Ama şimdi bu token’ı kopyalayıp **IT claim route** ve **admin role route** için çağrı yapmayı deneyelim. Bu isteği gönderirsem **403 Forbidden** alıyorum; diğerinde de yine **403 Forbidden** alıyorum. Yani burada “IT claim” ve “admin role” için engellendik.

Peki token’lara rol ve claim’ler nasıl eklenir? Bunu issuer yapar. Bir JWT’ye baktığımızda, taşınan bilgi burada durur ve biz bu bilgiye güvenebiliriz çünkü imzalıdır ( *signed* ). Yani JWT, roller önceden tanımlanmış şekilde gelebilir.

Şimdi payload’a bazı değerler ekleyeceğiz. Örneğin `role` diyip değer olarak `admin` vereceğiz. Böylece artık payload içinde **role=admin** var. Bu token’ı alıp tekrar buraya yapıştırıp istek gönderdiğimde yine **403** aldım.

Neden olduğunu kontrol edelim. Sanırım bunun `role` anahtarında küçük harf olması gerekiyor. Yine kopyalayıp tekrar deneyelim; şimdi geçiyor. İşte JWT’ye rol eklemek bu kadar: payload’a `role` anahtarını ve gerekli değeri yazarsınız. Sadece payload içine girer.

Ayrıca şunu da yapabilirsiniz: Rolleri backend’de stateful şekilde tutup JWT’yi sadece kullanıcının kim olduğunu doğrulamak için kullanabilirsiniz. Sonra o kullanıcıyı alır, backend’de rollerini kontrol eder ve bir şeyi yapıp yapamayacağına karar verirsiniz. Bu da bir seçenektir. Farklı güvenlik yöntemlerini birleştirebilirsiniz. Ama rollerin JWT içine gelmesini istiyorsanız, bu kesinlikle yapılabilir.

Şimdi rolü gördük, claim’e bakalım. IT department için bir claim gerekiyordu. Payload’a `department` yazıp değerini `IT` yapabiliriz. Şimdi bu token’ı tekrar alıp IT claim gereken yere koyup isteği gönderebilmeliyim.

Geri gelip IT department kontrol edelim: **department=IT** gerekiyor. Ben bunu küçük harf yaptım. Yeniden kaydedelim ve refresh edelim. Şimdi bir daha deneyince **200 OK** alıyoruz.

Burada olan şey şu: `IT`, “büyük I küçük T” yerine “büyük I büyük T” idi ve token’daki değerle policy’de aranan değer birbiriyle eşleşmiyordu. Yani bu değerler *case sensitive* eşleşmek zorunda.

İşte claim’i role’a eklemek için gereken tek şey bu. Artık elimizde hem `role` hem de `department` taşıyan bir token var. Bu tek token’ı iki yerde de kullanabilirim; hem admin role route’unda hem de IT claim route’unda.

Çünkü .NET’in yaptığı tek şey, ilgili policy içinde rol değerinin orada olup olmadığına ya da claim’in orada olup olmadığına bakmaktır. Payload’a başka herhangi bir bilgi koyabilirim; .NET, bu policy’leri doğrulamak için o belirli anahtarları ve değerleri arar.

Ve unutmayın: Bunlar, secret key’imize sahip olan herhangi bir issuer tarafından üretilebilir. Bu rollerin ve claim’lerin orada olması gerektiğine güveniyoruz çünkü JWT, o secret key kullanılarak doğru şekilde imzalanmış.

Böylece .NET uygulamamızda JWT’leri kullanarak iki farklı policy uygulamış olduk: biri **role** için, biri **claim** için.
