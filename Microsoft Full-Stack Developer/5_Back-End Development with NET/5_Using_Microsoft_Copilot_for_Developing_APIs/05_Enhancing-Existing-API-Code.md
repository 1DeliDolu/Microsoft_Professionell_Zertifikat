## 🛠️ Enhancing Existing API Code

AI araçları (Copilot gibi) kullanarak kodumuzu nasıl geliştirebileceğimizi inceleyelim. Copilot’un önerilerinden yararlanarak yaygın zorlukları ele alabilir, API’nizi iyileştirebilir ve iş akışınızı daha verimli hâle getirebilirsiniz. İster AI destekli kodlamaya aşina olun ister yeni başlıyor olun, bu oturum geliştirme sürecinizi pratik yollarla daha verimli kılmayı gösterecek. Bu videoda Copilot önerilerini kullanarak API kodunu iyileştireceğiz.

Başlangıç noktası olarak blog CRUD API’mizi kullanacağız. Hatırlatma olarak bu, `title` ve `body` alanlarına sahip blog’larla çalışan basit bir CRUD API’dir. Blog’ları basit bir listede saklar ve bu yüzden çok fazla error checking yapmak zorunda kalırız ve garip davranışlarla karşılaşırız; örneğin blog ID’lerinin, blog’ların listeye eklenme sırasına göre belirlenmesi gibi. Bu ideal değildir.

Blog’ları farklı bir şekilde saklamak çok daha faydalı olurdu. Bu yüzden burada Copilot’u kullanarak denemek istediğim ilk şey budur.

---

## 🌐 Copilot’tan Depolama Alternatifleri İstemek

Edge’de Copilot’u açalım. Yine buradan Copilot’a gelip, açık değilse açabilirsiniz. Burada şunu söyleyeceğim:

Mevcut kodda blog’ları saklama biçimimden hoşlanmıyorum. Listede tutmak sürekli out-of-bounds hatalarını düşünmeme neden oluyor ve ID’lerin listedeki konuma bağlı olması çok kısıtlayıcı. Başka hangi seçenekleri keşfedebilirim?

Elbette burada yazım hataları var, ama yazım hatalarının genellikle pek fark yaratmadığını da söyleyebilirim.

Son olarak kodu kopyalayıp yapıştıracağım. Ben, isteği yazıp ardından kodu eklediğinizde daha iyi sonuç aldığımı görüyorum; tersini yaptığınızda aynı kaliteyi alamayabiliyorsunuz. Bu belki modelin eğitimiyle ilgili olabilir ya da sadece gözleme dayalıdır, ama deneyimim bu şekilde daha etkili.

Gönderelim ve LLM’den ne geldiğine bakalım.

---

## 📚 Öneri: Dictionary Kullanmak

Beklediğim öneri geldi: **Dictionary** kullanmak.

Dictionary, bir `key` ile bir `value`’yu eşleştiren bir veri tipidir. Bu senaryoda `int` key, blog’a atadığımız ID olur. Örneğin:

* `1` → ilk blog
* `2` → ikinci blog

Bu sayede örneğin `199` ID’sine doğrudan blog ekleyebilirsiniz; öncesinde 198 blog olması gerekmez.

Copilot başka seçenekler de önerebilir:

* **Database** (bu bölüm için kapsam dışı olabilir)
* **In-memory cache** (veritabanına daha benzer davranışlar sunabilir ama yine in-memory sınırlamaları vardır)

Eğer Copilot gereğinden fazla bilgi üretiyorsa, yanıtı kısaltmasını isteyebilirsiniz:
“kısa cevapla”, “500 kelimeyi geçmesin” gibi.

---

## 🔁 Kod Entegrasyonu ve “Hallucination” Kontrolü

Burada iki seçenek vardır:

1. Orijinal kodda sadece ilgili kısımları tek tek değiştirmek
2. Copilot’un verdiği kodu topluca kopyalamak

Ama Copilot birden çok yerde değişiklik yapmışsa (depolama, erişim, endpoint mantığı vb.), tek tek yamalamak risklidir. Bu yüzden genelde komple kopyalamak daha güvenli olur.

Yine de  **çıktıyı mutlaka kontrol etmek gerekir** . Örneğin Copilot bazen class tanımını, `using`’leri ya da `app.Run()` gibi kritik kısımları eksik bırakabilir. Bu, AI’ın “kendinden emin ama eksik” ürettiği durumlara örnektir ve buna **hallucination** denir.

Böyle büyük değişikliklerde version control kullanıyorsanız, bu değişiklikten önce bir commit almak çok iyi bir pratiktir.

---

## 🧠 Dictionary Mantığını Anlamak

Dictionary’lere aşina değilseniz, Copilot’a şu tür sorular sorabilirsiniz:

* “Bu dictionary ne işe yarıyor?”
* “Bu key-value eşleşmesi nasıl çalışıyor?”

Dictionary’ler **hash map** olarak da bilinir.

Bu yapıda:

* `/blogs/{id}` gibi endpoint’te `TryGetValue(id, out blog)` kullanılır
* varsa blog döner, yoksa `NotFound`

Yeni blog eklerken Copilot örneğin `blogs.Keys.Max() + 1` ile yeni ID üretmiş olabilir. Bu yaklaşım kullanıcıya ID seçtirmez.

Eğer kullanıcı ID gönderebilsin istiyorsanız Copilot’a bunu da isteyebilirsiniz; ancak bu durumda “ID zaten varsa overwrite mi edilecek, yoksa hata mı dönecek?” gibi iş kuralları devreye girer.

---

## ✅ API Surface’ını Bozmadan Değişiklik Yapmak

Buradaki iyi haber: Copilot depolama yapısını değiştirmiş olsa da  **API interface’ini kırmamış** .

Eğer route’lara “ID’yi client belirlesin” gibi bir değişiklik ekleseydik, bu API surface’ını değiştirir ve mevcut request’ler çalışmazdı.

---

## 🧪 Çalıştırma ve Test

Uygulamayı çalıştırdığınızda port değişmiş olabilir (örneğin `5099`). Bu portu request dosyanızda güncellemeniz gerekir.

Ayrıca Copilot’un kodu root route’u kaldırmış olabilir; bu durumda `/` endpoint’ini geri eklemeniz gerekebilir.

Test sırasında bir fark ortaya çıkabilir:

Önceden ilk blog ID’si `0` iken, dictionary örneğinde blog’lar `1` ve `2` ile başlamış olabilir.

Bu yüzden:

* `/blogs/0` → artık `404`
* `/blogs/1` → doğru blog

Bu beklenen bir davranıştır.

POST, PUT, DELETE testleriyle CRUD’nin çalıştığı doğrulanır.

---

## 🔎 GET /blogs İçin Search Query Parametresi Eklemek

Şimdi ikinci geliştirme: `GET /blogs` endpoint’ine bir search query parametresi eklemek.

Burada Copilot’tan sadece ilgili endpoint kodunu istemek daha güvenlidir; komple kod değiştirip bir şeyleri “yanlışlıkla silme” riskini azaltır.

İstek:

* `search` query parametresi eklensin
* `title` veya `body` içinde bu terim geçen blog’lar filtrelensin
* depolama olarak **dictionary** yaklaşımı kullanılsın

Copilot bazen yanlışlıkla mem cache gibi başka bir yapıya kayabilir; o zaman “dictionary yaklaşımını kullan” diyerek düzeltirsiniz.

Önerilen yaklaşımda:

* `blogs.Values` ile blog listesi alınır
* `search` boşsa hepsi dönülür
* değilse `Contains(search)` ile filtrelenir

Sonra:

* `/blogs?search=first` → filtreli sonuç
* `/blogs?search=second` → filtreli sonuç
* `/blogs?search=post` → birden çok sonucu yakalayabilir

---

## ✅ Kapanış

Copilot sayesinde:

* Blog depolamasını listeden dictionary’ye taşıyarak daha yönetilebilir bir yapı kurdunuz.
* `GET /blogs` endpoint’ine arama desteği eklediniz.
* Bu süreçte dictionary ve LINQ ile filtreleme gibi yeni kavramlarla daha pratik şekilde tanıştınız.
* En önemlisi: değişiklikleri yaparken API interface’ini mümkün olduğunca kırmadan ilerlediniz.
