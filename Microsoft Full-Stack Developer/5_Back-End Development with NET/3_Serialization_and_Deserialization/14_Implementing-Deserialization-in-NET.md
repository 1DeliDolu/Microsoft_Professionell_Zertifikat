## 🔄 .NET’te Deserialization Uygulamak

Adım adım veriyi nesnelere deserialize etme sürecini inceleyelim. Buradaki odak, *JSON* veya form verisi gibi gelen verilerin otomatik ya da manuel şekilde, kodumuzda kullanabileceğimiz C# nesnelerine nasıl dönüştürüldüğüdür. Bu videoda, .NET’te deserialization tekniklerini uygulayacağız.

---

## 👤 Hedef Nesne: Person

Bu API, bu *Person* nesnesini deserialize etmek için tasarlanmış olacak.

Ve daha önce baktığımız *Person* nesnesinden farklı olarak, burada *required* bir string *UserName* ve *optional* bir int *UserAge* var. Yani biri zorunlu, biri isteğe bağlı.

Burada dikkat edeceğiniz şey, yeni bir kullanıcı oluşturmuyor olmamız; çünkü biz serialize etmiyoruz, deserialize ediyoruz.

Serialize ettiğimizde veri gönderiyoruz.

Deserialize ettiğimizde ise bize veri gönderildiğinde olan şeydir.

Bir *GET* metodumuz var; ama veriyi deserialize ettiğimiz şey, genellikle *POST* gibi bir metodla veri aldığımızda olur.

---

## ✅ En Basit Yol: Otomatik Deserialization

.NET’te veriyi deserialize etmenin en basit yolunu göstereyim.

Yeni bir route oluşturacağım ve `app.MapPost` yapacağım; bu route’a `"auto"` diyeceğiz.

Serialize ederken gördüğümüz gibi, common sense defaults ile verinin deserialize edilmesini sağlayan çok basit bir yol var ve isterseniz daha karmaşık yöntemlere geçebilirsiniz.

Yapmamız gereken tek şey şu:

Bu POST route’unun `"Person"` tipinde bir nesne aldığını varsayacağız; buna `"personFromClient"` diyeceğiz ve sonra `"Results.Ok"` ile `"personFromClient"` döndüreceğiz.

Bu `"personFromClient"`, bize gönderilen payload’dur ve biz onu burada argüman olarak geçtiğimiz için, .NET otomatik olarak bunun request body’sinde bir *Person* beklendiğini anlar ve onu bu şekilde deserialize etmeye çalışır.

Biraz sonra, bu contract sağlanmazsa ne olduğuna da bakacağız.

Ve bununla istediğimiz şeyi yapabiliriz.

Bir `Console.WriteLine` yapabilirim ve `"personFromClient"` yazdırabilirim.

İstediğim her şeyi yapabilirim.

`personFromClient.UserName = "Tyler"` diyebilirim.

Bu noktada artık sadece bir nesne.

Deserialize edilmiştir.

Ağ üzerinden gönderilmiştir ve .NET onu artık kullanabileceğimiz bir şeye dönüştürmüştür.

Burada özel bir şey yok.

Yine, bu artık sadece bir nesne.

Bu, deserialization’ın en temel hâliyle nasıl yapıldığıdır.

Ve yine, *Results* yerine *TypedResults* kullanırdım; çünkü daha iyi bir pratik.

Bu, deserialize etmenin en basit yolu.

---

## 🧩 Bir Üst Seviye: JSON’u Request’ten Açıkça Okumak

Şimdi varsayılan davranışlardan biraz daha açık şekilde uzaklaşmak istersek bir sonraki karmaşıklık seviyesine geçelim.

Tekrar `MapPost` yapalım ve buna `"JSON"` diyelim.

Ve şimdi bir *Person* almak yerine, `"async"` yapacağız ve bir `HttpContext` alacağız. Buna `"context"` diyeceğiz.

Sonra fonksiyonumuzu açıp request delegate’imizi oluşturacağız.

İlk yapmak istediğimiz şey, context’ten person’ı çekmek.

`person = await context.Request.ReadFromJsonAsync<Person>()` diyeceğiz.

Bu bir generic; yani burada *Person* bekleyeceğiz.

Ve bu metodu çağırınca, istemciden gelen request’in payload body’sini okuyup, body’yi *Person* olduğunu varsayarak çeker.

Yani onu *Person* olarak deserialize eder.

Sonra yine döndürebiliriz; `TypedResults.Json(person)` diyebiliriz.

Bu iki yöntem neredeyse tamamen aynı şeyi yapıyor; fark şu: artık bunu otomatik olarak olmasına bırakmak yerine request’ten açıkça okuyoruz.

Burada *JSON* kullandığımıza dikkat edin.

Bu route’ları kullanmaya çalışırsak, JSON olarak ele alındıkları için; async kullanımıyla ilgili bir uyarı aldım, onu çıkaralım, bakalım bu warning düzeliyor mu.

Warning, error değil aslında.

Tamam, düzeldi gibi.

Async yaptığım hâlde gerek yoktu.

Şimdi bakınca, bunu await etmeliyim; çünkü bu async gerçekleşiyor ve şimdi tekrar akıllıca güncelliyor.

Harika.

Şimdi async/await yapısını kullanıyoruz ve request’imiz var.

---

## 🧪 JSON Route Üzerinden Testler ve Edge Case’ler

JSON route’umuza bu JSON nesnesini göndermek için birkaç request oluşturdum. Bu gayet iyi çalışıyor.

Şimdi JSON route’umuza karşı bu request’lerin neler yapabildiğine bakalım.

Bu, auto route ile aynı, ama JSON’a karşı çalıştırabileceğimiz bazı request’ler oluşturdum.

Önce basit bir JSON nesnesi gönderelim ve bam, çalışıyor.

Peki XML gönderirsek? Çalışmıyor.

Content-Type’ı `"application/json"` yapıp yine XML gönderirsek? O da çalışmıyor.

JSON aldığını sanıyor; deserializer JSON aldığını sanıyor, ama aslında XML geliyor.

Başka şeyler de deneyebiliriz.

Bir *Person* gönderip *UserAge* alanını göndermezsek ne olur?

Bu tamamen çalışır; çünkü sınıfımıza bakarsanız *UserAge* optional.

Hiç sorun değil.

Ama *UserName* eksik olursa ne olur?

Bu bir error döndürür. Neden?

 *UserAge* ’i çıkarabiliriz ama  *UserName* ’i çıkaramayız.

Çünkü *UserName* required, ama *UserAge* değil.

*UserAge* optional.

Ekstra bir alan gönderirsek ne olur?

Bu request’te aşağıda ekstra alan var.

Önemli değil. Ignore eder.

Yanlış tipte bir age gönderirsek?

Bu bir error fırlatır; çünkü deserializer bu *Person* tipinde bir nesne bekliyor ve  *UserAge* ’in integer olmasını bekliyor, string değil.

Bu örnekte onu *buffalo* yaptık.

Çalışmıyor.

Şimdi görebilirsiniz: Bu deserializer’ları kullanırken, sadece bir class tanımlayıp bununla deserialize edeceğimizi söylediğimizde (gösterdiğimiz bu iki yöntemden biriyle), daha en baştan birçok edge case’i bizim için hallediyor.

---

## 🎛️ Custom Options: Daha Fazla Kontrol

`ReadFromJsonAsync` kullanmanızın en önemli nedenlerinden biri, custom options oluşturmak.

Yeni bir route oluşturalım; buna `"custom-options"` diyelim.

Bu sefer serializer’da yaptığımız gibi custom options oluşturacağız.

`var options = new JsonSerializerOptions()` diyeceğim.

Dikkat edin, bu *deserializer options* değil.

Serializer ve deserializer’larla çalışırken çoğu zaman sadece serializer’larla çalışırsınız.

.NET’te ikisi genellikle aynı namespace’ler ve metotlar altında ele alınır.

Şimdi birkaç option verelim.

`UnmappedMemberHandling = JsonUnmappedMemberHandling.Disallow` demek istiyorum.

Şimdi bu biraz sorun çıkarıyor; çünkü bunun için *using* statement eklemem gerekiyor; bu da `System.Text.Json.Serialization` ile geliyor.

Şimdi tamamlandı.

Bu ne yapacak?

Daha önce yaptığım gibi, sınıfta olmayan bir member gönderirsem, bunu *disallow* edecek.

Yani kullanıcıların herhangi bir nedenle ekstra alanlı nesneler göndermesini istemiyorsanız, bu çok iyi bir örnek.

Şimdi yine önceki gibi `ReadFromJsonAsync` yapacağız, ama bu sefer options’ları geçeceğiz.

Öncekiyle tamamen aynı; tek fark options oluşturup geçiriyoruz ve artık deserializer’a açıkça seçenekler göndermiş oluyoruz.

Request’lerimize geri dönelim; aşağıda custom options için bir request olmalı.

Şimdi server’ımı reset edeceğim—her şeyin yüklendiğinden emin olmak için—ve sonra bu ekstra alanla göndermeyi deneyeceğim.

Send request butonuna basınca, artık bunu reddettiğini görmelisiniz.

Daha önce JSON route bunu kabul ediyordu, ama yeni custom options route kabul etmiyor.

Fonksiyonellik aynı, sadece birinde *unmapped member handling* seçeneği *disallow* olarak set edilmiş.

Bu, custom options kullanmak isteyeceğiniz yer için çok iyi bir örnek.

---

## 🧱 XML Deserialization: Neden Daha Zor

Bir kez daha çok fazla JSON gösterdik; çünkü bugünlerde HTTP ile çalışırken JSON baskın veri değişim formatı.

Öyle, gerçekten.

Ve serialization’da olduğu gibi, XML çok karmaşık.

Haydi örneği geçelim.

`app.MapPost` diyebilirim ve bu route’u `"/xml"` yaparız.

Yine bir fonksiyon oluşturacağım ve yine `HttpContext` almak zorundayız.

`HttpContext context` diye yeni bir argüman oluşturacağız.

İlk yapmak istediğimiz şey: `var reader = new StreamReader(context.Request.Body)`.

Sonra yeni bir değişken oluşturacağız, adına `"body"` diyeceğiz ve `body = await reader.ReadToEndAsync()` diyeceğiz.

Yani bu stream reader’ı oluşturduk ve ardından okuyacağız.

Sonra bir XML serializer oluşturacağız: `var xmlSerializer = new XmlSerializer(typeof(Person))`.

Bu büyük ihtimalle yeni bir using statement isteyecek.

`typeof(Person)` diyeceğiz ve zaten XML serialization’ı bir noktada import etmişim gibi görünüyor.

Bir noktada bunu içeri çekmişim; belki otomatik ekledi.

Şimdi XML serializer’ı alıyoruz.

Öteki request response’u kapatayım.

Şimdi bir serializer var.

Body’yi okuyan ve içeri alan bir stream reader var.

Şimdi `var stringReader = new StringReader(body)` diyeceğiz.

Yani okuduğumuz string’i alıyoruz ve stringReader’a geçiriyoruz.

Sonra en sonunda `var person` diyeceğiz ve deserialize edeceğiz: `xmlSerializer.Deserialize(stringReader)`.

Pardon,  *xmlSerializer.deserialize* ; yanlış yaptığım buydu.

Şimdi `stringReader`’ı geçeceğim.

Artık deserialize edilmiş person’ım var.

Ve önceki davranışı tekrarlamak istersem, `return TypedResults.Ok(person)` diyeceğim.

Bunu burada `Ok` yapacağım.

Şimdi bu, yukarıdakinin eşdeğeri; tek fark JSON yerine XML kullanıyor.

Gördüğünüz gibi burada yine çok daha fazla adım var.

Tekrar üzerinden geçersek:

Yeni bir stream reader oluşturuyoruz.

Sonuna kadar okuyoruz.

Yeni bir string reader oluşturuyoruz ve okunan stream’i string reader’a geçiriyoruz.

Sonra bunu `xmlSerializer.Deserialize`’a veriyoruz.

Bunun çok olduğunu biliyorum.

Yine, gerçekten ihtiyacınız yoksa XML ile çalışmayı önermiyorum.

Evet, XML ile çalışmanız gereken zamanlar var.

Ama JSON’a sadık kalın.

Şu an .NET’te “happy path” bu.

“Happy path”, programcıların kullandığı bir terim; çok fazla boilerplate ve ekstra adımlara girmeden güçlü şekilde işi en kolay yapabildiğiniz yoldur.

JSON’u ele almak için çok güzel varsayılanlar var; ama XML için yok.

---

## ✅ Kapanış

Şimdi en son yapabileceğimiz şey bunu kaydetmek.

Server’ımı reset edeceğim.

Request’lerime geri döneceğim ve aşağıda birkaç seçenek olmalı.

Şimdi JSON göndermeye çalışırsam, reddedileceğini görebilirsiniz.

Ve XML gönderirsem, mükemmel çalışır.

İşte XML deserialization böyle yapılır.

Ve bununla birlikte, ASP.NET Core’da deserialization’ın temellerini keşfetmiş oldunuz.

Bu, API konularının anlaşılması en zor olanlarından biri olabilir; bu yüzden videonun bazı kısımlarını yeniden izlemeniz veya sonra tekrar dönmeniz gerekiyorsa çekinmeyin.

Bir şeyler mantıklı gelmiyorsa sorun değil.

Ben de bunu ilk seferimde anlamadım.

Siz de anlamayabilirsiniz.

Ama burada hatırlanması gereken önemli şey şu: bu “happy path”.

Ne beklediğinizin tipini yazın, argüman olarak alın ve sonra onunla istediğiniz şeyi yapın.

Karmaşık deserialization yapmaya çalışmayın.

Eskiden bunun çok daha fazlasını yapmak zorundaydınız ve şanslıyız ki .NET, common sense standartlarına doğru ilerleyerek bundan uzaklaştı.
