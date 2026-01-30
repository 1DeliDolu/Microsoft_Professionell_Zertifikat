## 🔗 Integrating APIs in Blazor Applications

API’ler, modern web uygulamalarını çalıştıran görünmez motorlardır ve güçlü back-end sistemleriyle etkileşime girmelerini sağlar. Blazor uygulamalarında API entegrasyonu, dinamik ve veri odaklı kullanıcı deneyimleri oluşturmanıza imkân tanır.

Bu videoda, Blazor uygulamalarında API’leri oluşturma ve tüketme sürecini; özellikle  **HttpClient** ’tan yararlanma ve **API verisini UI bileşenlerine bağlama (binding)** odağıyla açıklayacağız.

---

## 🧰 1) HTTP Client Kurulumu ve API Çağrılarını Etkinleştirme

Blazor uygulamalarında API entegrasyonunun adımlarını, uygulamada API çağrılarını mümkün kılmak için  **HttpClient** ’ı kurarak başlatalım.

 **HttpClient** , Blazor’da API çağrıları yapmak için kullanılan bir bileşendir.

Öncelikle, dış API’lerle iletişimi etkinleştirmek için projede HttpClient’ı register ederiz. Register edildikten sonra, HttpClient bir Blazor component içine **inject** edilerek veri çekmek için kullanılabilir.

Örneğin bir hava durumu uygulamasında HttpClient kullanımı, bir API çağrısıyla JSON verisini almanızı sağlar. Bu veri, dış bir servisten mevcut sıcaklık gibi bilgileri döndürebilir.

Bu, uygulamanızın görüntülemesi için bilgiyi alıp geri getiren bir haberci (messenger) gibi çalışır.

---

## 🧾 2) JSON: Çekilen Verinin Formatı

HttpClient API çağrısı yapmaya hazır olduğuna göre, aldığı verinin uygulamanızın kullanabilmesi için **JSON** formatında nasıl düzenlendiğine bakalım.

JSON, veriyi okunabilir bir formatta organize eder; bu da uygulamanızın veriyi işlemesini kolaylaştırır.

Örneğin bir hava durumu servisi, `temperature` anahtarına `72 degrees Fahrenheit` değerini atayan bir veri gönderebilir.

Bu örnekte `temperature` anahtardır; yani veriyi tutan konteynerdır. `72 degrees Fahrenheit` ise bu anahtara atanan değerdir.

JSON’da anahtar ve değer, aralarındaki ilişkiyi temsil eden iki nokta üst üste (`:`) ile ayrılır.

Ve bu, JSON verisinin temel yapısıdır.

---

## 📍 3) API Endpoints: Veri Gönderme ve Alma Kapıları

Sonraki adımda JSON, bilgi gönderip almanın kapıları olan API endpoint’leri üzerinden iletilir.

API endpoint’leri, API’lerin istek aldığı ve response döndürdüğü URL’lerdir.

API endpoint’leri oluşturmak, UI güncellemeleri için gereken veriyi çekmek üzere endpoint’leri tanımlamayı içerir.

Back-end tarafında endpoint’ler, **GET** veya **POST** gibi HTTP isteklerini işleyen method’lara route edilir.

Örneğin `mydomain.com/weather` URL endpoint’i, hava durumu API’si için sıcaklık verisini getiren bir GET method’una route edebilir.

---

## 🧩 4) Binding: API Verisini UI Bileşenlerine Bağlamak

Veri API endpoint’leri üzerinden alındıktan sonra, bir sonraki adım bu veriyi görüntülemek için uygulamanın component’lerine bağlamaktır.

Bileşenlere veri bağlamak, API verisini Blazor component’lerinde dinamik şekilde görüntülemek anlamına gelir.

Veri client’a JSON formatında döner. Client daha sonra JSON’u, uygulamanın kullanabileceği bir nesneye **deserialize** eder. Ardından Blazor, bu nesnenin property’lerine referans verebilir.

Bir hava durumu uygulamasında client’ın, JSON hava durumu verisini `forecast` adlı bir nesneye deserialize ettiğini varsayalım.

Blazor, `@` sembolünü kullanarak `forecast` nesnesini belirli UI elemanlarına bind edebilir.

Bu örnekte `@forecast.summary`, `forecast` nesnesinin `summary` property’sine referans verir.

---

## 🧯 5) Error Handling: Hataları Yönetmek

Bazen API’ler erişilemez olabilir veya geçersiz veri döndürebilir; burada error handling devreye girer.

Blazor’da error handling, API hatalarını Blazor içinde “gracefully” yönetme tekniklerini içerir.

API çağrılarını `try-catch` bloklarıyla sarmalamak, uygulamanızın hataları düzgün şekilde ele almasını sağlar.

Örneğin, hava durumu servisi kapalıysa, uygulamanız çökmek yerine alternatif aksiyonlar alabilir.

Ayrıca kullanıcıları açıklamasız bırakmak yerine, “weather data is currently unavailable, please try again later” gibi bir geri bildirim mesajı gösterebilirsiniz.

Bu, kullanıcıların sorunu anlamasına yardımcı olur ve tekrar denemelerini teşvik eder.

---

## ✅ Kapanış

Bu videoda, Blazor uygulamalarında API’leri oluşturma ve tüketme sürecini; özellikle **HttpClient** kullanımı ve API verisini UI bileşenlerine **binding** etme odağıyla öğrendiniz.

Blazor’da API entegrasyonu sadece veri çekmek değildir. Kullanıcı arayüzleri ile onları güçlendiren veri arasındaki noktaları birleştirmektir.
