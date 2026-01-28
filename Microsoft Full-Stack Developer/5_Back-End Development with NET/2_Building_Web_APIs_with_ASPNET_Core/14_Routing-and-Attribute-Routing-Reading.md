## 🧭 Routing ve Attribute Routing

### 📝 Introduction

 *ASP.NET Core* ’da routing ve attribute routing, gelen HTTP isteklerini bir API’de uygun action’lara eşlemek için kullanılan temel tekniklerdir. Bu ders; route’ların yapılandırılmasının temelini, attribute routing’in sağladığı esnekliği ve constraints, query parameters ve catch-all routes gibi gelişmiş teknikleri kapsar. Tüm bunlar ölçeklenebilir, duyarlı web API’leri oluşturmayı destekler.

---

## 🧩 ASP.NET Core’da Routing’e Genel Bakış

### 🎯 Routing’in Amacı

Routing, *ASP.NET Core* uygulamalarının gelen HTTP isteklerini URL pattern’lerine göre doğru fonksiyonlara veya controller’lara yönlendirmesini sağlar. Route’lar tanımlayarak geliştiriciler istekleri doğru ve verimli şekilde ele alan API’ler oluşturabilir; bu da ölçeklenebilirlik için kritiktir.

---

### 🛠️ Temel Route Tanımı

Route’lar `app.MapGet`, `app.MapPost` ve diğer benzeri metotlarla tanımlanır; her biri belirli HTTP action’larına karşılık gelir.

Bu route’lar `Program.cs` içinde yapılandırılır ve `/users` veya `/products/{id}` gibi URL path’lerine göre istekleri yönlendirir.

Statik route’lar tam eşleşme gerektirirken, dinamik route’lar değişken girdileri kabul etmek için placeholder’lar (ör. `{id}`) kullanır.

---

### 🧱 Routing’in Temel Bileşenleri

* Route parameters: `{id}` gibi dinamik placeholder’lar route’ları esnek hâle getirir ve aynı route içinde farklı girdileri destekler.
* Optional parameters: `?` kullanımıyla optional parameter’lar, belirli veri olmadığında bile route’ların çalışmasını sağlar; bu da esnekliği artırır.
* Constraints: Constraints, bir route parameter’ın kabul edebileceği type veya değerleri sınırlandırarak veri geçerliliğini sağlar; örneğin bir ID’nin yalnızca pozitif integer olmasına izin vermek gibi.

---

## 🏷️ Attribute Routing ve Gelişmiş Teknikler

### 🧷 ASP.NET Core’da Attribute Routing

Attribute routing, geliştiricilerin route’ları doğrudan controller action’ları içinde tanımlamasına izin verir ve tek tek endpoint’ler üzerinde kontrol sağlar.

Bu yaklaşım, özellikle karmaşık uygulamalarda özelleştirilmiş path’ler oluşturmak için faydalıdır; çünkü route tanımları destekledikleri koda yakın kalır.

---

## 🧠 Gelişmiş Routing Teknikleri

### ⛔ Route Constraints

`int:min(0)` gibi constraints, parametreleri doğrular ve girdilerin belirtilen kriterlere uymasını sağlar (ör. pozitif integer’lar).

---

### ⭐ Catch-All Routes

`{*filePath}` sözdizimi, path içinde kalan tüm segmentleri yakalar; dosya veya içerik servis etmekte faydalıdır.

---

### 🔎 Query Parameters

Route dışında belirtilen parametreler; örneğin `/search?q=aspnet&page=2`, URL yapısını değiştirmeden isteklerin ek bilgi taşımasını sağlar.

---

### 🧩 Routing Bileşenlerini Birleştirme

 *ASP.NET Core* , statik path’leri, parameter’ları, optional değerleri ve constraint’leri birleştirerek karmaşık senaryoları dinamik biçimde ele almayı mümkün kılar; örneğin şu route’ta olduğu gibi:

`/store/{category}/{productId:int?}/{*extraPath}`

---

## ✅ Conclusion

 *ASP.NET Core* ’un routing ve attribute routing özellikleri, esnek ve sağlam API’ler oluşturmanın ayrılmaz parçalarıdır.

Constraints, query parameters ve catch-all routes gibi gelişmiş yapılandırmalarla geliştiriciler istekleri hassas şekilde ele almayı sağlayabilir; bu da  *ASP.NET Core* ’u ölçeklenebilir ve duyarlı web uygulamaları oluşturmak için mükemmel bir seçenek hâline getirir.
