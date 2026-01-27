## 🧪 .NET Kütüphanelerinin Uygulamalı Kullanımı

Bu lab’de, JSON verisini serialize ve deserialize etmek için kullanacağımız çok basit bir console uygulaması oluşturuyoruz.

---

## 🥇 Adım 1: Yeni Bir Console Uygulaması Oluşturma

Birinci adımda, template’i kullanarak yeni bir console uygulaması kuruyoruz. Bunun için `.NET new console` komutunu kullanıyoruz ve bu, .NET Core’daki template’i kullanarak çok temel bir console uygulaması oluşturuyor.

```bash
.NET new console
```

---

## ▶️ Adım 2: Console Uygulamasını Çalıştırma

İkinci adımda console uygulamasını çalıştırıyoruz. Burada bunu yapmayacağız, ancak template bilgileriyle console uygulamasını çalıştırırsanız, terminalde console kısmında **hello world** yazan bir çıktı alırsınız.

Uygulamayı yükledikten ve oluşturduktan sonra bunu test edebilirsiniz. Dosyamızda zaten başka kodlar olduğu için bunu burada yapmayacağız, ancak template ile uygulamayı çalıştırırsanız adım 2’de olacak şey budur.

---

## 📦 Adım 3: Newtonsoft JSON Kütüphanesini Yükleme

Üçüncü adımda **Newtonsoft JSON** kütüphanesini yüklüyoruz.

Visual Studio Code’da işinizi yapmak için kullanabileceğiniz çeşitli kütüphaneler vardır; yoksa kodu kendiniz yazmanız gerekir. Bu kütüphaneleri yüklemek için `.NET add package` komutunu kullanabilirsiniz.

`.NET add package`, dahili olarak bakımı yapılan bir katalog kullanır; internete gider, belirttiğiniz paket adını bulur ve bunu indirip sizin için kurar.

Bu, internete gidip paketi kendimizin bulmasına, bir installer çalıştırmasına ve sonra Visual Studio Code’u yeniden başlatmasına gerek bırakmaz. `.NET add package` komutu bunu bizim yerimize yapar.

```bash
.NET add package Newtonsoft.json
```

Paket yüklendikten sonra, csproj dosyamızı kontrol ederek referenced edildiğinden emin olabiliriz. Oraya gittiğimizde, `ItemGroup` altında `PackageReference` içinde `Newtonsoft.json`’ın yer aldığını görürüz.

Bu, kütüphanenin artık kullanılabilir olduğu anlamına gelir. Henüz tam olarak kullanamıyoruz ama mevcut olduğunu biliyoruz. Uygulama bunu available olarak görür, böylece artık bunu kullanma seçeneğimiz olur.

---

## 🔄 Adım 4: JSON Verisi Tanımlama ve Deserialization

Dördüncü adımda, temel bir JSON verisi tanımlıyoruz ve ardından bu JSON verisini serialize ve deserialize ediyoruz.

İlk olarak `using Newtonsoft.json` referansı oluşturuyorum. Bu using ifadesini kullandıktan sonra, artık o kütüphanenin özelliklerini kullanabiliriz. Önceki adımda sadece kütüphaneyi yüklemiştik.

Bu using, uygulamaya kütüphaneyi gerçekten kullanmasını ve ilgili method’lar ile property’leri referans almasını söyler.

Ardından `public class product` oluşturuyoruz. Bu adım 4 için.

Bu class içinde üç variable var: `name`, `price`, ve `tags`.

* `tags` string listesi
* `price` decimal value
* `name` string value

Bu class, JSON verisini serialize ve deserialize ederken kullanacağımız JSON verisini tutacak.

Bu, JSON verisiyle çalışırken kullanabileceğimiz C-sharp object’imizi oluşturur.

Sonraki oluşturduğumuz şey genel bir `Program` class’ıdır. Bu class içinde de bir `Main` method’u oluşturuyoruz. `Main` method’u, uygulama çalıştırıldığında çalıştırılan method’dur. Uygulama başladığında `Main` method’unu bulur ve içindeki kodu çalıştırır.

Sonra serialize/deserial işlemlerine geçiyoruz; bu adım 4, alt adım 4.

Bir JSON string oluşturuyoruz ve bunu Newtonsoft kütüphanesiyle deserialize ediyoruz. `json` adında bir string var ve bu string içinde, class’ta tanımladığımız property’lerin her birini içeren düzgün bir JSON oluşturuyoruz.

Yani JSON içinde `name`, `price`, ve `tags` var. Bu alanların her biri, product object’ine deserialize edeceğimiz JSON verisinin parçası.

Bunu bir sonraki adımda yapıyoruz. `product` adında bir variable oluşturuyoruz.

* variable adı: `product`
* type: `product`

Sonra `JsonConvert.DeserializeObject` kullanıyoruz. Bu, Newtonsoft.json kütüphanesinin bir parçası.

Type olarak `product` veriyoruz ve JSON verimizi parametre olarak geçiriyoruz.

Bu işlem JSON’u deconstruct eder ve bizim için product object’ine yerleştirir.

Yani tek bir satır kodla JSON bilgisini alıp product object’imizin içine koymuş oluyoruz.

Sonraki satırda, `Console.WriteLine` ile class içindeki data’lara `.notation` ile erişebiliyoruz.

* `product.name`
* `product.price`
* `product.tags`

JSON verisini product class’ımıza koyduk ve artık her bir parçaya `.notation` ile erişebiliyoruz.

---

## 🔁 Adım 5: Object’i JSON’a Serialization

Beşinci adımda, ters yönde ilerleyeceğiz.

Beşinci adımda bir object’i JSON’a serialize edeceğiz.

Bu yüzden bu kod bloğunu comment out edip, beşinci adımda kullandığımız diğer bloğu uncomment edeceğim.

Burada `newProduct` adında bir `product` variable’ı tanımlıyoruz ve sonra bu object’in property’lerini belirliyoruz.

* `name` = smartphone
* `price` = $699.99
* `tags` = electronics, mobile

Artık new product object’imiz var. Önceki adımda olduğu gibi, `.notation` ile bu object’in parçalarına erişebiliriz.

Örneğin `newProduct.name` dediğimizde smartphone döner.

Ama bu veriyi JSON gibi evrensel bir formata taşımak istiyorsak önce JSON’a çevirmemiz gerekir.

Bunu bir sonraki satırda yapıyoruz. Yeni bir JSON string’i oluşturuyoruz, çünkü JSON düz metindir; yani string değeridir.

Sonra `JsonConvert.SerializeObject` kullanıyoruz, object’imizi (new product object) geçiriyoruz ve formatting bilgisi veriyoruz.

Bu, girintili (indented) bir JSON döndürür.

Artık `newJson` adında bir JSON object’imiz var ve bunu bir sonraki satırda `Console.WriteLine` ile console’a yazdırıyoruz.

---

## ✅ Özet

Newtonsoft.JSON’u basit bir console app içinde JSON’u deserialize etmek ve object’i JSON’a serialize etmek için bu şekilde kullanıyoruz.
