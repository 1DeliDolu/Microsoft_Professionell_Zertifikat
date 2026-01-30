
## 🔌 Creating APIs for Front-End Applications

API’ler, back-end verisini kullanıcı arayüzüne bağlayarak modern uygulamaları güçlendirir. Front-end uygulamalar için API oluşturmak; gerekli veriyi verimli şekilde sunmak üzere endpoint’leri tasarlamayı, uygulamayı ve güvenli hâle getirmeyi içerir.

Bu videoda, front-end uygulamalara hizmet eden API’leri, gerekli veriyi açığa çıkararak (exposing) nasıl oluşturacağımız sürecini açıklayacağız.

---

## 🧭 1) Front-End İhtiyaçlarını Tanımlama

API oluşturmanın ilk adımı, front-end ihtiyaçlarını tanımlamaktır.

Geliştiriciler, kullanıcı arayüzünün her bir bölümünün veri gereksinimlerini belirlemelidir; böylece API, front-end’in sorunsuz biçimde görüntülemesi ve etkileşime girmesi için doğru veriyi sağlar.

Örneğin bir online mağaza için API oluştururken, front-end kullanıcıya ürün adını, ürün açıklamasını, fiyat ve stok durumunu (availability) ve müşteri yorumları alanını gösterebilir. API’nin bu veriyi sağlaması gerekir ki front-end eksiksiz bir ürün sayfası görüntüleyebilsin.

Bu gereksinimleri net biçimde tanımlayarak, API sorunsuz bir kullanıcı deneyimi oluşturmak için doğru bilgiyi sunar.

---

## 📍 2) Endpoints Tanımlama

Front-end’in hangi veriye ihtiyaç duyduğunu bildiğimize göre, endpoint’leri tanımlama zamanı.

Endpoint’lerin; API’lerin istek aldığı ve yanıt döndürdüğü URL’ler olduğunu hatırlayın. Endpoint’ler, front-end’in back-end’den bilgi talep etmesine ve almasına olanak tanır.

Örneğin bir online mağaza, ürün bilgisini almak için bir endpoint ve müşteri yorumlarını getirmek için ayrı bir endpoint kullanabilir.

Her endpoint, front-end’in belirli veriye erişmesi için doğrudan bir yol sağlar.

---

## 🧾 3) Yanıtları (Responses) Yapılandırma

Endpoint’ler hazır olduğunda, geliştiricilerin front-end’in bu yanıtları verimli biçimde yorumlayabilmesi için response’ları yapılandırması gerekir.

API’ler XML veya YAML gibi farklı formatlar kullanabilse de, günümüzde en yaygın format  **JSON** ’dur.

JSON, veriyi key-value (anahtar-değer) biçiminde organize ederek back-end ile front-end arasında net bir iletişim yapısı kurar.

Örneğin bir ürünün adı, fiyatı ve availability/stock status gibi özellikleri key olur; detaylar ise value olur.

Bu yapı, JSON’u API response’ları için verimli ve güvenilir bir format hâline getirir.

---

## 📐 4) Tutarlı (Consistent) Veri Formatı Belirleme

API’nin döndürdüğü veri için tutarlı bir yapı belirleyeceğiz; böylece yanıtlar öngörülebilir olur.

Tutarlı bir format, front-end’in hangi veriyi bekleyeceğini bilmesini ve veriyi kolayca işlemesini sağlar.

Bir ürün gibi, her veri öğesi name, price ve category gibi bir özellik setiyle temsil edilir.

Bu tutarlılık, front-end’in bilgiyi doğru biçimde görüntülemesine yardımcı olur.

---

## ⚡ 5) Gereksiz Veriyi Kaldırma

Yanıtların verimli olması için gereksiz verileri kaldıracağız.

Örneğin front-end yalnızca ürün adları ve fiyatları istiyorsa, ek alanları kaldırarak response’u daha verimli hâle getiririz.

Bu, aktarılan veri miktarını azaltır ve yanıtların hızlı kalmasını sağlar.

---

## 🛡️ 6) CORS ile Güvenli Bağlantı Sağlama

API response’larını yapılandırdıktan sonra, front-end ile back-end’i güvenli biçimde bağlamak için **CORS (cross-origin resource sharing)** uygulamasına geçelim.

CORS, bir domain üzerinde barındırılan bir front-end uygulamasının, başka bir domain üzerinde barındırılan bir API ile etkileşime girip giremeyeceğini belirleyen bir güvenlik mekanizmasıdır.

Front-end çoğu zaman API’den farklı bir domain üzerinde çalıştığı için, aralarında güvenli veri isteklerine izin verecek bir yönteme ihtiyaç vardır.

CORS bunu erişimi kısıtlayarak yönetir; yalnızca güvenilir kaynakların API’ye ulaşmasını sağlar.

CORS uygulamak, front-end uygulamanız gibi onaylı kaynaklardan gelen isteklere izin verecek header’ları yapılandırmayı içerir.

Bu adım, erişimi güvenilir domain’lerle sınırlar ve API’nizi yetkisiz kullanıma karşı korur.

Güvenliği daha da artırmak için, front-end’lerin yapabileceği istek türlerini kısıtlayabiliriz. Örneğin istekleri salt okunur (read-only) işlemlerle sınırlamak, yetkisiz sunucu veri değişikliklerini engeller.

---

## ✅ Kapanış

Bu videoda, gerekli veriyi açığa çıkararak front-end uygulamalara hizmet eden API’leri oluşturma sürecini öğrendiniz.

Veriyi ve kullanıcı deneyimini bir araya getiren API’ler tasarlarken bu prensipleri aklınızda tutun; böylece bilgi, front-end uygulamalar için kolayca erişilebilir hâle gelir.
