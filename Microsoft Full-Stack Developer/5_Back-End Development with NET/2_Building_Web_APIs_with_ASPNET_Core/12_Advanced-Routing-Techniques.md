## 🧭 Gelişmiş Routing Teknikleri

*ASP.NET Core* ile bir uygulamayı adım adım oluşturalım ve uygulamanızı esnek ve dinamik hâle getirmek için route template’lerini kullanmanın farklı yollarını gözden geçirelim.

İlerledikçe  *route parameters* , *query parameters* ve *constraints* gibi temel özellikleri konuşacağız ve sağlam (robust) bir web API oluştururken bu öğelerin neden önemli olduğunu açıklayacağız.

Bu videoda,  *ASP.NET Core* ’da route constraints ve route templates kullanımını içeren gelişmiş routing tekniklerini inceleyecek ve bu teknikleri göstermek için örnekler sunacağız.

---

## 🧩 Route Template Nedir?

Bir *route template* (route pattern olarak da bilinir), bir request path’in ne zaman belirli bir route handler’a yönlendirileceğini belirlemek için kullanılan bir string’dir.

Route’lar statik olabilir; yani belirli bir string ile eşleşmeleri gerekir. Ancak route template’lerinin önemli bir kullanım alanı, birden fazla path üzerinde kullanılabilen dinamik template’ler oluşturmaktır.

Burada gerçekten basit bir route template örneği görebilirsiniz: sadece `/` var. Bunu `/users` da yapabiliriz. Bunların hepsi statik route’lardır.

---

## 🧷 Route Parameter Kullanımı

Şimdi bir route parameter kullanma örneği gösterelim.

İlk yapacağım şey `app.map.get` eklemek ve burada statik yerine dinamik bir route eklemek.

Bir `users` route’u yapacağız ve diyelim ki belirli bir user ID almak istiyoruz; bunu string içinde parametreyi *curly braces* `{}` içine yazarak yapıyoruz.

Bu, string olarak geçilecek bir değer olacak; ama parse edilip fonksiyonumuza, request handler’ımıza, request delegate’imize aktarılacak.

Diyelim ki onların post’unu istiyoruz; çünkü aslında o post’ta birden fazla parametre alabiliyoruz.

Bir `slug` alacağız. *Slug* genelde sadece bir metin parçasıdır ve burada çalışır.

`int user ID` diyeceğiz; böylece bu fonksiyona, az önce oluşturduğumuz parametreleri alması gerektiğini söylemiş oluruz.

Bunlar `user ID` olacak ve ayrıca bir `string slug` olacak.

Artık elimizde bu iki değer var ve onlarla istediğimiz her şeyi yapabiliriz. Herhangi bir değer gibi içeri aktarılıyorlar.

Bu örnekte, bir string template kullanalım ve `user ID`’yi döndürelim; bunu parantez içine yazarak yapacağım.

Bunların üstteki `{}` ile hiçbir ilgisi yok. Bu, *string literal* ya da *string template* denilen şeyle string içine veri yerleştirme yöntemidir.

`post ID` ve sonra `slug` diyeceğiz.

Böylece bu iki değeri döndürmesi gerekir.

---

## 🧪 Test İçin `.net watch run` ve `requests.http`

Bunu kaydedeyim, terminalimi açayım ve şunu çalıştırayım:

```bash
.net watch run
```

Sonra yeni bir `requests.http` dosyası oluşturalım. Hayatımı kolaylaştırmak için o slug’ı kopyalayacağım.

Uygulamamız başladı ve request’lere gideceğiz.

`get local host` diyeceğim; ama `HTTP colon slash slash local host` yazmam gerekiyor.

Ve sonra bu, `slash user slash user ID` olacak; bunu bir sayı ile değiştireceğiz ve `slug` da bir metin olacak.

Tamam, bu artık geçerli.

Şimdi bunu gönderelim ve ne döndüğüne bakalım.

*Connection rejected* alıyorum; çünkü port’u yazmadım.

Ve yine, port orada aşağıda. Tamam, işte oldu ve `user ID` ile `post ID` döndü.

Bu büyük bir şey gibi görünmeyebilir, ama işlevsel olarak bunun sağladığı şey şu: Client tarafında istek gönderirken, sadece URL üzerinden API’ye veri gönderebiliyoruz.

Bunu bir POST request’in body’si olarak falan göndermiyoruz; sadece belirli bir route path ile birlikte yolluyoruz.

Gerçekten kullanışlı, sürekli kullanılıyor.

Bunu değiştirip “tamam, user 10 istiyorum” diyebiliriz ve bu da `Buffalo` olsun, tekrar gönderelim.

Şimdi farklı veri gönderdik; dolayısıyla eğer birinin gönderdiğiniz şeye göre bir veritabanını güncellemesini isteseydiniz ya da farklı bir kaynağı almak isteseydi, bu parametrelerle `GET` kullanarak bu tür şeyler yapabilirsiniz.

Bu route artık dinamik oldu.

Burada `int user ID` ve `string slug` kullanarak, bunların ne olması gerektiğini tanımladığımıza dikkat edin.

Eğer `user ID` olarak `Buffalo` ve `post` olarak `10` göndermeye çalışsaydım, `10` muhtemelen çalışır çünkü string olarak parse edilebilir; ama `Buffalo` integer’a parse edilemez.

Ve şöyle bir hata alacağız:  *bad request* ,  *failed to bind parameter int user ID from string Buffalo* .

Mükemmel. Beklediğimiz şey bu.

Bunları tekrar daha mantıklı bir şeye çevirelim.

Bu bir route parameter’dır.

Ve tekrar vurgulamak istiyorum: bir `slug` kullanıyoruz; bu, okunabilirlik için genelde içerikleri tanımlamada kullanılan kullanıcı dostu bir string’dir.

---

## ⛔ Route Constraint Örneği

Devam ederek, route constraint içeren bir route göstereceğim.

Bu, tıpkı önceki gibi bir parametre olacak ama adına uygun şekilde, geçirilebilecek değer türlerini kısıtlayacak bazı constraints ekleyeceğiz.

Bu sefer `products` route’u diyeceğim ve product’ın bir `ID` parametresi olacak.

Bu `ID`’yi yine bu `{}` içinde geçiriyoruz.

Constraints eklemek için, parametreden sonra iki nokta `:` ve eklemek istediğimiz şeyi yazarız.

IntelliSense ile bir liste görürsünüz. Ben burada `int` eklemek istiyorum ve ayrıca bunun sıfırdan büyük olması için bir `min` de eklemek istiyorum.

`-1` gibi bir product ID istemiyorum. Çok mantıklı değil. Tipik olarak bir ID, sayı kullanıyorsa pozitif bir integer’dır.

Yine, bu değeri alabilecek bir route handler’a ihtiyacım olacak.

Bu da `int ID` olacak.

Ve tekrar bir string template döndürüp `product ID` diyelim ve o `ID`’yi içine yazalım.

Request’imize gidersek yeni bir request ekleyeceğim; bunu `product` yapacağız ve `product 10` yazıp onu geri alabilmeliyiz.

Yeni bir route eklediğimiz için sunucumu restart etmem gerekiyor.

Request’i gönderiyorum ve `product 10` geri geliyor.

Ama şimdi tekrar `Buffalo` denersem, bundan hoşlanmayacak.

Burada `int constraint` kullandığımızı görüyorsunuz.

Diğer route’umuz da `int` beklediği için bu da bir tür “soft” ...

Bu tür bir mantık gerçekten faydalı olabilir: Bu route’un birebir aynısı olan bir kopyasını oluşturup sadece `string` diyebilirdim.

Belki bu route’a `int` ile giderdim; ama bir product, `int` parçası olabilecek bir şeyle gelirse, bu route’a giderdi ve şimdi `ID`’yi string olarak kullanabilirdim.

Çok yaygın yapılmaz ama bunu yapmak isteyebileceğiniz nedenler vardır. Bazı edge case’ler olduğuna eminim.

Route’lara geri dönersek, test etmek istediğim başka bir şey de şu: `-1` deneyelim.

Bu çok daha esnek bir constraint. Request’i gönderebilmeliyiz ve *not found* alırız.

Son olarak şunu yapmak istiyorum: `Buffalo` ile çalışmadığını gördünüz.

Ayrıca `10` girince çalıştığını da görüyoruz.

Ama `-10` girersem, `-10` çalışmaz çünkü bu constraint’i karşılayan bir route yok.

`0` için bir `min` olması gerekiyor.

Bu, bir route constraint’tir.

---

## ❓ Optional Parameter Örneği

Burada faydalı bir başka şey: optional parameter içeren bir route’a bakalım.

Diyelim ki `app.mapget` ve bunu bir `report` yapalım.

`report`, bir `year` parametresi alacak ve bu yıl bir integer olacak.

Ama optional olmasını istiyoruz; bu yüzden birçok dil kısmında olduğu gibi sonuna bir `?` ekleyebiliriz.

Bunu ayrıca `int year` yapacağız ve varsayılan değeri `2016` olacak.

Optional olduğu için burada da optional olarak işaretlemek istiyoruz.

Fonksiyonu tamamlayalım.

Şimdi burada, diyelim ki `return report for year` ve sonra `year` değerimizi buraya ekleyelim.

Request’lere gidersek bunu tekrar kopyalayabiliriz ve `report` diyeceğiz.

Bu sefer `2024` ile gönderelim. Send.

`404` alacağız çünkü restart etmedim.

Şimdi `report for year 2024` alacağız.

Peki bunu kaldırırsanız ne olur? Çünkü artık optional.

`report for 2016` alırsınız çünkü varsayılan yıl olarak onu ayarladık.

Onu kaldırırsanız burada göreceksiniz: Send.

Bu değişiklik yansımadığı için sunucumu restart etmem gerekiyor.

Gördüğünüz gibi hiçbir şey gelmiyor. Sadece boş.

Dolayısıyla o parametre yoksa varsayılan davranışın ne olacağını ele almak ya da en azından düşünmek istersiniz.

---

## 🧲 Catch-All Route’e Giriş

Gösterilecek bir başka şey de  *catch-all route* .

Diyelim ki `app.map.get` ve bunu bir catch-all route yapalım.

`files` diyelim; çünkü bu, file system’lerle çalışırken sıkça kullanılır.

Ve bu attribute `file path` olarak adlandırılacak.

Şimdi bunu catch-all route yapmak için, onu önceye alacağız.

---



## ⭐ Catch-All Route’ta `*` Kullanımı

Bunun hemen önüne bir yıldız işareti `*` koyun. Böylece `files`’tan sonra gelen her şey bu değişkende görünecek.

Sadece burada tek bir değeri almayacak; `files`’tan sonra gelen her şeyi alacak.

Bu, `file path` adını vereceğimiz bir string bekleyecek.

Ve sadece o `file path`’i döndürelim; ama orada bir string istemiyorum. Sadece `file path`’in kendisini döndürmek istiyorum.

Şimdi geri gelirsem, bunu kopyalayalım; `localhost` ve `files/` ardından bir sürü karakter yazalım.

Boşluk olamaz. `404 not found`. Sunucuyu restart ediyorum.

Buraya tıklarsam, işte oldu. Onu döndürüyor.

Bu çok kullanışlı olabilir; örneğin bir sunucuda bir sürü dosya servis ediyorsanız ve bunu bir dosya yapısı gibi gezmek istiyorsanız.

Mesela `/images/cat/cat_1.jpg` gibi.

Ve sonra bu veriyle bir şey yapmak istersiniz.

Belki file system’e gidip onu gerçekten getirirsiniz.

Burada tüm string’in geldiğini görebilirsiniz.

Yani bu karmaşık file path’in tamamı wildcard kullanarak gelebilir.

---

## 🔎 Query Parameter Eklemek

Bir diğer çok yaygın gereksinim, query parameter eklemek istemektir.

Query parameter’lar burada biraz daha ilginç.

Yine bir `map get` yapabiliriz ve diyelim ki `/search` route’umuz var.

Bu, belki Google gibi bir site yapıyor olmalı.

Burada hiç parametre yok. Bunu yine dinamik yapacağız ama bunu yapmak için route parameter kullanmamıza gerek yok.

Bir fonksiyon alacağız ve fonksiyonumuzda, path içinde parametre olarak tanımlanmayan birkaç argüman tanımlayacağız.

Optional bir string olacak ve adı `Q` olacak; bir de `int` olacak ve `page = 1` olacak.

Bu default page olacak.

Bu çok yaygın bir pattern.

Bir web aramasında (örneğin Bing gibi) muhtemelen bir `Q` parametresi olur; bu “query string” demektir.

Yani aradığınız terim budur.

Ve muhtemelen sayfalarca sonuç olur. Bu da “bana birinci sayfayı ver” demek gibi.

Şimdi burada diyelim ki `searching for Q on page page` döndürelim. Bunu sevdim.

Ve şimdi burada bir argümanımız olmadığı için, bunu nasıl aktaracağımızı merak ediyor olabilirsiniz.

---

## ❓ Query Parameter Nasıl Gönderilir?

İlk yapacağım şey, yine bu route’u kopyalamak ve bunu `search` yapmak.

Muhtemelen şunu merak ediyorsunuz: Bu query parameter’lar nasıl geçirilir?

İlk yapacağınız şey, bir `?` koymak.

Client buraya `?` koyarak şunu der: “Bu URL, ve bunun diğer tarafındaki her şey query parameter.”

Query parameter’lar bir isim veya identifier ile tanımlanır. Biz zaten bunu yaptık.

`Q` bizim search term’imiz.

Diyelim ki `.net` arıyoruz ve `page=2`.

Bu key-value çiftlerini ayırma yolu `&` sembolüdür.

Aralarına onu koyarsınız.

Yani:

* `Q` anahtarı `.net`
* `page` anahtarı `2`

Bunu bu değere, bunu da şu değere map ediyoruz.

Sunucumu restart ettikten sonra bu request’i yapabilirim ve şunu görürsünüz: `.net` için `page 2` üzerinde arama.

Bu iki değer geçti.

---

## 🧩 Hepsini Birleştirmek

Ve bunları birleştirdiğinizde işler gerçekten çılgınlaşıyor.

Burada şöyle bir şey yapabiliriz: `app.map.get`.

Ve bu path, bize her şeyden biraz gösterecek.

Diyelim ki bir `store` istiyoruz.

Store’un insanların aradığı bir `category`’si olabilir.

Bu bir parametre.

Bir de `product ID` istiyoruz ve o `product ID` optional bir `int` olmalı.

Belki bunu eklemek zorunda değiller.

Sonra bunu ve bunu istiyorum.

Ve sonra diyelim ki burada bir wildcard da yapacağız.

Ve `extra path`’i alacağız.

Şimdi elimizde, farklı terminolojilerin bir sürüsünü kullanan bir route var:

* Route parameters
* Route arguments
* Optional parameter
* Wildcard

Ve şimdi bunları fonksiyonumuzda handle etmemiz gerekiyor.

Diyelim ki:

* `category` için bir `string`
* `product ID` için optional `int`
* `extra path` için optional `string`

Ve sadece “eğlencesine”, `in stock = true` diye bir query parameter da atalım.

Bu, o “undefined parameter”ın kullanılacağı yer olacak.

Şimdi elimizde tüm bunları birleştiren bir route var ve bu değerlerin hepsine burada erişebiliriz:

* `category`
* `product ID`

Şimdi bu bilgilerin hepsini birleştirebildiğimizi görüyorsunuz.

Burada fonksiyonu uygulamak için zaman ayırmayacağım çünkü biraz uzun sürerdi.

Ama artık bu route’a şu gibi bir request yapabiliriz:

`/store/electronics/123/sale`

Ve bunu kopyalayıp yeni path’te kullanabileceğimiz bir route’a çevirebiliriz.

Diyelim ki `/store/electronics/123/sale`.

Bu bize `category` olarak `electronics`, `product ID` olarak `123` ve `extra path` olarak `sale` verir.

Ama kullanıcı bunu `sale` olmadan ziyaret etmek isterse, bu da tamamen geçerli; çünkü sonda optional bir `sale` var.

Ayrıca query parameter olan `bool`’u da alabiliriz.

Query parameter’ımızın adı neydi?

`in stock` idi.

`in stock=true` diyelim.

Ve yine, optional oldukları için, onu kaldırabiliriz.

Bu da geçerli bir path.

---

## 🧪 Kendi Başınıza Deneyin

Her zaman olduğu gibi, bu kodu kendi başınıza çalışmanızı şiddetle tavsiye ederim.

Bunlarla oynayın.

Farklı parametreler eklemeyi deneyin, farklı constraint’ler eklemeyi deneyin, bunların nasıl çalıştığına dair bir his edinin.

Çünkü bu, client’ların API’nize bilgi geçmesinin büyük yollarından biridir ve siz de o bilginin nereye gönderilebileceğini tanımlarsınız.

Route parameters, constraints, query parameters, optional değerler ve catch-all route’lar gibi tüm bu routing tekniklerini birleştirerek, kullanıcı girdisine dinamik şekilde yanıt veren güçlü ve esnek API’ler oluşturabilirsiniz.

Ve bu routing esnekliği,  *ASP.NET Core* ’u sağlam ve ölçeklenebilir web uygulamaları oluşturmak için harika bir seçim hâline getirir; API’nizin geniş bir istek yelpazesini kolaylıkla ve hassasiyetle ele almasını sağlar.
