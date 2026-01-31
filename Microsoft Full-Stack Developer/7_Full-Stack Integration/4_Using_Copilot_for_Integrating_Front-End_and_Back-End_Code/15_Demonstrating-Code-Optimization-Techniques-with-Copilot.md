## ⚡ Copilot ile Kod Optimizasyon Tekniklerini Göstermek

Arka uç veya ön yüz kodu yazarken, kodunuzun mümkün olduğunca verimli olması önemlidir. Hangi alanların daha verimli hâle getirilebileceğini bulmak zordur; ancak **Microsoft Copilot** gibi araçlarla kodunuzu analiz edip verimliliği artıracak değişiklikler önermeniz mümkündür.

Bu ekran kaydında Copilot’u kullanarak çok basit bir uygulamada verimlilikleri, tekrarları ve optimizasyon yollarını arayacağım.

---

## 🧪 Başlangıç Senaryosu: 3 API Çağrısı Yapan Basit Uygulama

Elimde çok basit bir uygulama var: Üç API çağrısı yapan bir konsol uygulaması. Gerçek dünyada, üç farklı endpoint’ten veri aldığınızı, sonra bu verileri birleştirdiğinizi veya farklı işlemler yaptığınızı düşünebilirsiniz.

Burada üç farklı endpoint çağırıyorum ve bu endpoint’lerden veri alıyorum. Bunu biraz daha verimli hâle getirmenin bir yolu olmalı. Çağrıları sırayla yapmak uygulamayı yavaşlatabilir ve pek verimli görünmüyor. Bu yüzden Copilot’u kullanarak değişiklikler yapacağım.

---

## 🛠️ 1) Copilot ile Paralel Çağrılar (Task.WhenAll)

İlk olarak Copilot’a, elimdeki kodu daha verimli hâle getirmesini isteyen bir prompt vereceğim.

Prompt’umu ayarlıyorum; temel olarak ne yapmak istediğimi söylüyorum. Sonra kodumu Copilot’a kopyalayıp yapıştırıp ne döndüreceğini göreceğim.

Bu noktada uygulamam hakkında çok fazla bilgiye ihtiyacı yok. Kodu göstereceğim çünkü daha verimli hâle getirmesi için çok spesifik bir talimat verdim. Fazla bağlam vermeden de daha verimli bir yaklaşım üretebilir.

Copilot’un döndürdüğü çözümde tek bir `tasks` dizisi var ve bu çağrıları `Task.WhenAll` ile toplu olarak çalıştırıyor.

Bu yaklaşım, aynı hedefi farklı bir şekilde gerçekleştiriyor:

* Her çağrının tek tek dönmesini beklemek yerine
* Hepsini bir blok hâlinde çağırıyor
* Sonuçları `results` değişkeninde topluyor

Sonra isterseniz `results` içinden geçip her sonucu konsola yazdırabilirsiniz.

Bu kodu kopyalayıp uygulamama yapıştırıyorum. Copilot’un sağladığı kod daha verimli; çünkü `Task.WhenAll` yaklaşımı API çağrılarının yapılma biçimini iyileştiriyor.

---

## 🗃️ 2) Cache Stratejisi Uygulama

Bir sonraki yapmak istediğim şey, bir cache stratejisi uygulamak.

Cache, verinin yalnızca cihazda/cache’te yoksa sunucudan alınmasını sağlar. Bu:

* sunucu yükünü azaltır
* uygulamanın her seferinde sunucuya gidip veri çekmesini engeller

Copilot’a tekrar prompt vereceğim ve cache için yardımcı bir yöntem oluşturmasını isteyeceğim.

Bu sefer prompt’um çok basit: Artık Copilot kodu biliyor; sadece “API response’ları için bir caching stratejisi uygula” diyebilirim.

Copilot, tepesinde yeni bir `cache` değişkeni oluşturuyor. Sonra cache’i kontrol ediyor:

* cache’te değer varsa cached response’u döndürüyor
* yoksa endpoint’lere gidip veriyi çekiyor

Yani mantık öncekiyle benzer; ama artık cache özelliği eklenmiş. Ayrıca `Task.WhenAll` yaklaşımını da korumuş.

Bu kodu da alıp uygulamaya yapıştırıyorum. Kod basit olduğu için tüm bloğu komple yapıştırıyorum.

Artık cache stratejimiz var:

* Veri cache’te varsa cache kullanılıyor
* Yoksa endpoint’lere gidilip veri alınıyor

---

## 🧼 3) Okunabilirlik İçin Refactor

Son olarak, kodu biraz daha net ve yönetilebilir kılmak için refactor yapmak istiyorum. Uygulama çok basit olduğu için Copilot’un yapacağı şeyler sınırlı olabilir ama yine de iteratif şekilde geliştirmek mümkün.

Bu iteratif yaklaşım önemli; çünkü kodu parça parça geliştirirken her adımda verimliliği artırmak, daha sonra büyümüş bir kod tabanına dönüp performans düzeltmesi yapmaktan daha kolaydır.

Copilot’a çok basit bir prompt veriyorum: “Kodu okunabilirlik için refactor et.”

Copilot kodu biraz daha kısa hâle getiriyor ve `Console.WriteLine` ile neler olduğunu daha görünür kılan geri bildirimler ekliyor. Cache mantığını ayrı bir metoda çıkarıyor ve kodun temel kısımlarını açıklamak için yorumlar eklediğini söylüyor.

Fakat dikkat: “Yorum ekledim” dediği hâlde yorumlar gerçekten yok.

Bu yüzden Copilot’a tekrar söylüyorum: Yorumlar kodda görünmüyor, lütfen ekle.

Bu sefer orijinal değişiklikleri koruyarak yorumları da ekliyor. Ayrıca tüm uygulamayı baştan komple veriyor.

Ben de `select all` yapıp bunu uygulamama yapıştırıyorum. Artık:

* gereken `using` ifadeleri var,
* istediğimiz yorumlar var,
* kod daha okunabilir,
* endpoint’lerden veri almak için `GetCachedDataAsync` gibi bir metod var,
* ve hâlâ `Task.WhenAll` kullanılıyor.

---

## ✅ Kapanış

Kodunuzu nasıl optimize edeceğinizden emin olmasanız bile, **Microsoft Copilot** gibi bir araçla kod tabanınızı analiz ettirip geri bildirim alabilirsiniz. Copilot’un yaptığı güncellemeleri izleyerek çok şey öğrenebilir ve bu öğrenimi gelecekte yazacağınız kodlara da taşıyabilirsiniz.
