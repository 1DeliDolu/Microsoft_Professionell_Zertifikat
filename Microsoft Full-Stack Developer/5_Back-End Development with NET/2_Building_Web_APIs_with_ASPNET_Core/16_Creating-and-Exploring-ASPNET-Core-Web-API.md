## 🧪 ASP.NET Core Web API Oluşturma ve Keşfetme

Bu laboratuvarda,  *ASP.NET Core* ’da bir API kullanarak basit bir ürün kataloğu oluşturuyoruz. CRUD operasyonlarını kuracağız. CRUD,  *create* ,  *read* , *update* ve *delete* anlamına gelir. Ve *ASP.NET Web Core* kullanarak bu dört farklı komut türünü kullanarak ürün eklememize, güncellememize ve kaldırmamıza olanak tanıyacak API çağrıları yapacağız.

---

## 🧱 Adım 1: Template ile Temel Uygulamayı Kurma ve Tanımlama

İlk adımda, template’i kullanarak temel bir uygulama kurup tanımlıyoruz. Ben bu uygulamayı zaten kurdum. İlk adım sadece `*.NET New Web API*` template’ini kullanarak temel bir web API uygulaması oluşturmaktır.

---

## 🧩 Adım 2: Product Model’ini Tanımlama

İkinci adımda, product model’ini tanımlarız. Product model, ürün kataloğunu kullanırken veriyi saklamak, güncellemek ve geri almak için kullanacağımız class’tır.

İlk yaptığım şey, uygulamanın root’unda bir `*models*` klasörü oluşturmaktı. Ardından `*product.cs*` dosyasını oluşturdum. `product.cs` dosyasının içinde, API’yi kullanarak veri saklamak ve geri almak için nesnemiz olarak kullanacağımız basit bir product class’ı var.

Dört property’miz var: `ID`, `name`, `description` ve `price`; her biri kendi spesifik variable type’ına sahip. Bu da ihtiyaç duyduğumuzda veriyi saklamak için kullanılacak.

---

## 🔁 Adım 3: CRUD Endpoint’lerini API’ye Uygulama

Üçüncü adımda, CRUD endpoint’lerini API’mize uyguluyoruz. Bunun için bir product controllers folder oluşturdum.

Product catalog API projesinin root’unda bir `*controllers*` klasörü oluşturdum. Sonra `*product controller.cs*` dosyasını oluşturdum; bu dosya API’miz için endpoint’lerin her birini saklayacak.

Burada en üstte, API’miz için ihtiyaç duyacağımız çeşitli library’leri kullanmamızı sağlayacak bazı `using` statement’larını görüyorsunuz. Sonra route’u da görüyorsunuz. Route, API’ye ulaşmak için URL’nin ne içermesi gerektiğini tanımlar.

Route’umuz domain name olacak. Bizim durumumuzda bu `localhost` olacak. Ve sonra API’ye ulaşmak için `api/products` yazmamız gerekiyor.

Ardından, CRUD metotlarımızın hepsini içeren API controller’ımız var.

---

## 📥 Read: GET Metotları

En üstte iki tane `GET` metodu var. Bunlar CRUD içindeki read operasyonu, yani  **R** .

Bu `GET` metotlarında sadece veriyi geri alıyoruz.

İlk `GET` metodu tüm ürünleri alır. Katalogda olan her ürünü geri getirir. `get all` metodu tüm ürünleri alır ve bir `products` object’i içine koyar.

`ActionResult`, ASP.NET’in API içinde herhangi bir operasyonu gerçekleştirmek için kullandığı keyword, yani temel metottur.

İkinci `GET` metodunda, parantez ve curly bracket içinde bir `ID` görürsünüz. Bu, route’a şunu söyler: Bir sayı, bir `ID` numarası geçirdiğimizde belirli bir ürünü geri getirecek.

Burada `get by ID` adlı bir metot olduğunu görüyorsunuz.

Route içine girilen `ID`’yi, API call içine, bu metoda geçiriyoruz. Bu metot `ID`’ye göre belirli ürünü arayıp bulur.

Metodun içinde `first or the default` kullandığını görüyorsunuz; yani listede o belirli `ID` ile eşleşen ilk öğeyi bulur (ya da default döner). Sonra da ürünü döndürür.

Orada `not null` değilse diye bir error handling de var. Bulursa, product değeriyle birlikte `OK` döndürür.

Bunlar read operasyonlarımızdır.

---

## ➕ Create: HTTP POST

Create operasyonu, CRUD’un **C** kısmı, `HTTP POST`’tur.

Burada başka bir `ActionResult` metodu var, ama bu metot `create`.

Bir product object geçiriyoruz; bu `new product` değişkeninde tanımlanıyor.

Burada product ID’yi alıp bir artırıyoruz. Yani kataloğumuzda kaç ürün varsa, o sayıya bir ekliyoruz.

Sonra `products.add` çağrısını yapıyoruz; bu, `new product`’ı içeri alan bir method call.

Ve product’ı oluşturduğumuzda `ID`’yi ve product bilgilerini döndürüyoruz.

Bu, create operasyonumuzdur.

---

## ♻️ Update: HTTP PUT

Sonra `HTTP PUT` var; bu update operasyonu, CRUD operasyonlarının **U** kısmı.

Yine burada bir `ID` geçiriyoruz; çünkü bir product güncellediğimizde bunu tek tek, bir seferde bir ürün olarak güncelleyeceğiz.

Dolayısıyla API’nin hangi ürünü güncellemek istediğimizi bilmesi gerekiyor. Bu yüzden güncellemek istediğimiz ürünün `ID` numarasını geçiyoruz.

Sonra `ID`’yi ve oluşturduğumuz product object içindeki güncellenmiş product bilgilerini geçirerek `public ActionResult update` method call yapıyoruz.

Sonra kodun geri kalanı, gerekli güncellemeleri yaparak ilerliyor.

Product name için: Eğer `updated product.name` değeri varsa, product name’i o değerle değiştirir.

Description ve price için de aynı şeyi yapar.

Bu güncellemeler yapıldıktan sonra, `calling code`’a API’den geri dönen yeni değerlerle birlikte `OK` döndürür.

---

## 🗑️ Delete: HTTP DELETE

Delete çok benzer. Bu, CRUD operasyonlarının **D** kısmı, ve `HTTP DELETE` kullanıyoruz.

Route olarak yine `ID` geçiriyoruz; çünkü bir seferde sadece bir product sileceğiz.

Bu metotta, `ActionResult delete` metodunda, `ID` ile eşleşen product’ı arıyoruz.

Bulunmazsa error handling olarak `not found` döndürüyoruz.

Bulunursa, o product’ı kaldırıyoruz ve `no content` döndürüyoruz.

Yani boş döndürüyoruz.

Bu class, tüm route’larımızı ve `calling code` API’ye karşı o spesifik route’u çağırdığında hangi action’ları yapmak istediğimizi tanımlar.

Bu da üçüncü adımdır.

---

## 🧪 Adım 4: Postman ile Route’ları Test Etme

Dördüncü adımda, bu route’ların her birini Postman ile test edeceğiz.

Test etmek için bu uygulamayı çalıştıracağım.

Uygulama çalıştığında bir URL alacağız: base domain, base URL. Bu da `localhost 5107`.

Postman’a gidip `localhost` ve port adını yazacağız.

Sonra route heading altında API’de tanımladığımız route’u yazmamız gerekiyor.

Şimdi `GET` operasyonunu kullanıyoruz.

Bu bizim read operasyonumuz ve `ID` geçmediğimiz için tüm ürünleri alacağız.

`Send`’e tıkladığımda, API’yi sorunsuz bulduğunu görüyorsunuz.

`200` döndü, ama boş olduğunu görüyorsunuz; çünkü henüz içine veri geçmedik.

Bir katalog öğesi oluşturmak için `POST` kullanacağız.

Bu bizim create operasyonumuz ve biraz JSON data geçmemiz gerekiyor.

JSON data geçtiğimizde, API’de tanımladığımız class’taki her property’yi tanımlayacağız.

`ID` olarak bir, `name` olarak product one, bir description, `this is a product description` ve `price` olarak `$9.99` vereceğiz.

Şimdi `POST` call kullanıyoruz.

Bu, kullandığımız route.

`Send`’e tıkladığımızda, body içinde o datayı geçirir ve product bilgilerini döndürür.

Bunu test edebiliriz.

Buraya geçeceğim ki daha az karışık olsun.

`GET` metodumuzu tekrar çağırıp tüm ürünleri geri alacağız.

Şimdi `Send`’e tıkladığımızda, product’ımızı döndürmesi gerekir.

Ve döndürüyor.

Şimdi product ID’miz bir, name, description ve price var.

---

## 🧾 Ürünü Güncelleme ve Tekil GET ile Doğrulama

Şimdi diyelim ki bu product’ı güncellemek istiyoruz.

`PUT` kullanıyoruz.

Bir body de geçmemiz gerekiyor.

API’ye geçirdiğimiz datayı update için aldığını hatırlayalım.

`This is an updated product description` diyeceğim.

Güncellemek istediğimiz product’ı da geçmemiz gerekiyor çünkü `ID` geçmemiz şart.

Dolayısıyla product one’ı güncelleyeceğiz.

`Send`’e tıkladığımızda, API içinde bilgiyi günceller.

Güncellenmiş bir product döndürdüğünü görüyorsunuz.

Sonra tekrar `GET` çağrısına döneceğiz.

Ve orada `/1` kısmını bırakacağım ki `GET` statement, ikinci `GET` statement’ı test etsin ve product one’ı retrieve etsin.

`Send`’e tıkladığımızda, tekil bilgiyi geri alacağız.

Bu, güncellediğimiz product.

Ve `PUT` statement’ımızdan kullandığımız güncellenmiş bilgiyi içerdiğini görebilirsiniz.

Ve bu, *ASP.NET Core* kullanarak çok temel, lightweight bir product catalog’tur.
