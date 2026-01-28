## 🧩 CRUD API’ler

Şimdi, bilgisayar bilimindeki en önemli ve en yaygın API kavramlarından birini, yani  *CRUD API* ’yi göstereceksiniz. CRUD prensipleri; bloglardan ve sosyal medyadan tıbbi kayıtlara ve uydu takibine kadar dünyadaki her türlü içerik API’sine güç verir.

CRUD API’ler tamamen veriyi manipüle etmekle ilgilidir ve bazen bu verilere *kayıtlar* ( *records* ) deriz. Bu videoda, CRUD API pattern’ini uygulayacağız.

---

## 🧠 CRUD Nedir?

CRUD,  *create* ,  *read* , *update* ve *delete* kelimelerinin kısaltmasıdır. Bunlar veri üzerinde gerçekleştirdiğimiz temel işlemlerdir.

* *Create* , adından da anlaşılacağı gibi yeni bir kayıt oluşturmak demektir. Bir kayıt sadece veridir; yani yeni bir veri parçası oluşturmak demektir.
* *Read* , veriyi almak demektir; çoğu zaman tek bir öğe olarak, bazen de bir öğe koleksiyonu olarak alınır. Belirli bir türün tüm öğeleri olabilir, filtrelenmiş öğeler olabilir ya da yine yalnızca tek bir öğe olabilir.
* *Update* , veride değişiklik yapmak demektir.
* Ve tahmin ettiğiniz gibi  *delete* , veriyi kaldırmaktır.

Yani veri oluşturabiliriz, veriyi okuyabiliriz, veriyi güncelleyebiliriz ve veriyi silebiliriz.

---

## 📝 Blog Post’larıyla Basit Bir API

Bu adımlardan geçeceğiz ve bunu, blog post’larıyla çalışmak için basit bir API yaparak gerçekleştireceğiz.

Blog nesnem burada. Bu class’ın iki özelliği var. İkisi de *required* ve bunlar `title` ve `body`. İkisi de `string`, burada süslü bir şey yok.

Ayrıca verimi bir *blog listesi* içinde saklıyorum ve burada iki blog oluşturuyorum. Birincisi “my first post”. İkincisi “my second post”. Yine, burada pek yaratıcı ya da ilginç bir şey yok.

Burada özellikle vurgulamak istediğim şey şu: Bu, normalde böyle bir API’de veriyi saklayacağınız yöntem değildir.

Bu, burada demonstrasyon için harika; çünkü burada öğreneceğiniz şey, bunu bir veritabanıyla, dosyalarla veya başka bir yerde saklayarak yapmaya çok iyi şekilde soyutlanır.

Temelde yaptığınız şey şudur: Tam teşekküllü bir API’de, bir listeye yeni bir giriş eklemek yerine, bir veritabanına yeni bir giriş eklersiniz.

Yani bu tür bir metodolojiyle dayanıklı bir API oluşturmak istiyorsanız, farklı bir veri yapısı kullanmak isteyeceksiniz; fakat temel kavramları gösterirken bunu burada uygulamak biraz karmaşık.

---

## ▶️ Uygulamayı Başlatma

Blog post’larımız var.

İlk yapacağım şey uygulamamı başlatmak. Tekrar `Control-Tilde`’a basacağım ve şunu yazacağım:

```bash
dotnet watch run
```

Ve yine, `watch` flag’i `run`’dan önce olduğunda değişiklik yaptığımızda güncellemesini sağlar ve sunucumuzu `Control-R` ile reset etmeyi çok kolaylaştırır; bunu burada çok yapacağım.

Burada root route’umuzu görüyoruz. Beklediğimiz string’i döndürüyor: “I am root”. Mükemmel.

Ben ayrıca request dosyama da geçmek istiyorum. Aynısı burada da var ve ona basacağım. Harika. Bu çalışıyor.

---

## 📥 Tüm Blog’ları Getirme

Şimdi tüm blog’larımızı alacağız.

Bir saniye durun ve düşünün: Bunu nasıl yaparsınız?

Bir `GET` request yapacağız. Bu mantıklı.

Bir path’e ihtiyacı olacak. Genelde böyle bir API’de tüm blog’ları almak için `/blogs` gibi bir şey kullanırız. Mantıklı bir adı var.

Peki bu fonksiyonda ne yapmak istiyoruz?

Eğer tüm blog’ları döndürmek istiyorsak ne yaparız? İşte onu yaparız: `blogs`’u döndürürüz.

Bunu kaydedebilirim.

Ve HTTP dosyamıza geri dönersek, bu `GET`’i kopyalayabilirim ve sonuna `/blogs` ekleyebilirim.

Ve yine, takip ediyorsanız port’u, uygulamanızın gerçekten çalıştığı port ile değiştirdiğinizden emin olun.

Burada `5127` üzerinde çalışıyorum.

Ve bunu ayırmak için üç tane `#` eklemem gerekiyor.

Bunu çalıştırıyorum ve `404 not found` alıyorum.

Neden? Çünkü muhtemelen sunucumu restart etmedim ya da ismi yanlış yazdım. O zaman deneyelim.

Bu çözdü.

Harika. İşte iki blog post’um. Tam olarak beklediğim şey.

Sadece sunucumu restart etmemiştim.

Bu çok olur.

`watch`, string gibi basit değişiklikleri izler. Ama route ekliyorsanız, servis ekliyorsanız, middleware ekliyorsanız, onları yakalamaz.

Manuel olarak restart etmeniz gerekir.

---

## 📥 Tek Bir Blog Getirme

Bu, tüm blog’ları getirir.

Peki tek bir blog almak isteseydik?

`app.map get` yazalım.

Tek bir blog almak için ne bilmemiz gerekir?

Hangi blog’u istediklerini bilmemiz gerekir. Yani parametre alan bir fonksiyona ihtiyacımız var.

Bu durumda bu bir `int` olacak ve adına `ID` diyeceğiz.

Şimdi biraz düşünün: Bir listemiz var ve içinden bir blog almak istiyoruz. Bunu nasıl yapacağız?

`blogs` listesinden o `ID`’deki blog’u döndüreceğiz.

Ve bu tamamen çalışır… umarım. Hadi bakalım.

Şimdi aşağı geliyoruz.

Ve burada yaptığımız şeylerden biri bu route parameter’ı eklemek oldu.

Ve ben aslında burada hata yaptım. Oraya `ID` eklemem gerekiyor.

Ve yine, ihtimale karşı sunucumu restart edeceğim.

Şimdi, bir `ID`’yi parametre olarak geçiriyor, bir `ID` alıyor ve sonra o `ID`’deki blog’u vermesi gerekiyor.

Bu request’i göndereyim; ama bunun `blogs/1` olması gerekiyor.

Evet, bu çalıştı.

`blog/0` denersem, bu benim ilk post’um olmalı.

Harika, bu çalışıyor.

---

## ⚠️ Geçersiz ID ve Koruma Eklemek

Şimdi burada bir problem var.

`3` yazacağım.

Listede iki blog var. Sizce ne olacak?

Hata fırlatacak.

Dolayısıyla bunun etrafına bazı korumalar eklememiz gerekiyor.

Bu, burada veriyi saklama biçimimiz yüzünden.

Eğer veritabanı kullanıyor olsaydınız, bu tür bir durumu farklı şekilde ele alırdınız.

İstedikleri item orada değilse ne yapacaksınız?

Şöyle diyeceğiz: Eğer `0`’ın altında bir index’e erişmeye çalışırlarsa ya da index `blogs.Count` değerine eşit veya büyükse…

Bunu yapmaya çalışırlarsa `Results.NotFound` döndüreceğiz.

Bu, `404` hatası göndermenin kolay bir yolu.

Sonra bir `else` istiyoruz.

`else` içine bunu koyacağız; çünkü bu, geçerli bir blog olduğu anlamına gelir ve onu döndürebiliriz.

Şimdi burada bir hata alıyorum.

Hızlıca bakayım ne yaptım.

Uyarı ne?

Muhtemelen bir karakter eksik.

“Parameter one is declared type int, but should be an HTTP context” çünkü `Results.OK` lazım.

İşte oldu.

Bu, onu düzeltti.

Context beklemiyor. Sadece bir `ID` bekliyor.

Yine, bunlar çok güzel helper metotlar.

Context alabilirsiniz, onu döndürebilirsiniz, sadece bir object döndürebilirsiniz.

`OK` kullanmak çok daha güzel, çünkü bu otomatik olarak status’u `OK` yapar.

Content type’ı da ayarlar; serialization’la ilgili hiçbir şeyle uğraşmanıza gerek kalmaz.

Şimdi tek bir `ID` döndüren bir blog’umuz var.

Geri dönelim.

Sunucumu restart ettikten sonra bunu bir kez daha test edelim.

`Send request` yazıp gönderiyoruz.

Ve şimdi `404` alıyorum.

Geri dönüp `2` denersek, yine `404 not found`.

Ve bunun nedeni `2`’nin de geçersiz olması; çünkü sadece `0` ve `1` geçerli değerler.

İşte oldu. Bu mükemmel çalışıyor.

Tamam.

Şimdi `GET` metotlarımız var.

Bu hepsini getiriyor, bu bir tanesini getiriyor.

Ayrıca deli bir şey yapıp bir filter route da ekleyebilirdiniz.

Bunlar CRUD içindeki  **R** ; yani *read* route’larımız.

---

## ➕ Create: Yeni Blog Oluşturma

Şimdi CRUD’un  **C** ’sine bakalım:  *create* .

Ve bunun için ilk düşünmeniz gereken şey şu olmalı: Hangi HTTP method’u kullanacağız?

Hatırlayın, almak için `map get` var.

Güncelleme gibi işler için genelde `put` kullanırız.

Silme gibi işler için genelde `delete` kullanırız.

Ve genelde bilgi gönderdiğimizde `post` kullanırız.

Dolayısıyla create için istediğimiz de bu.

`/blogs` path’ine bir `POST` route göndereceğiz.

Ve yine, bunların büyük ölçüde aynı path’e sahip olduğuna dikkat edin.

Bu zorunlu değil.

Bu sadece konvansiyon gereği.

Aynı tür veriyle çalışırken aynı path’i kullanmak yaygındır.

End user için şunu çok net yapar: “Blog’ları böyle manipüle ederim. Alırım. Eklerim. Güncellerim.” Aynı path’i kullanarak.

Bu metotta, onların bir blog’u güncellemesine izin vermek için ne yapmamız gerekiyor?

Bize bir blog göndermeleri gerekiyor.

Bir `blog` alacağız ve adına da `blog` diyeceğiz; gerçekten orijinal bir isim.

Peki orada ne yapmak isteyeceğiz?

Bir listemiz var, dolayısıyla o listeye eklemek istiyoruz.

`blogs.Add` yapalım ve `blog`’u ekleyelim.

Sonra `Results` döndürelim.

Sanırım `Created` route’u var.

Evet, kesinlikle `Created` var.

Bu, bir şeyin oluşturulduğunu göstermek için doğru response’u verir.

Bu bir string bekler ve ayrıca döndüreceğimiz şeyi bekler.

String, kullanışlı bir mesaj olmalı.

`blogs/` döndürelim ve sonra `blogs.Count - 1` koyalım; bu, blog’un oluşturulduğu index olacak.

Bu ilk parametre olacak.

Sonra da `blog`’u geri göndermek istiyoruz.

Yani yine, burada yaptığım tek şey bir string döndürmek.

Bu herhangi bir string olabilir; geçerli olur.

---



HTTP standardına göre ne yapmanız gerektiği ya da yapmamanız gerektiği konusunda teknik olarak bazı spesifikasyonlar vardır. Bunlara en iyi ihtimalle gevşek şekilde uyulur. Dünya genelde pratik olanı yapar.

Birisi bir blog oluştururken, onlara bir blog’u geri göndermek ya da bir şekilde bir blog oluşturduklarını bildirmek faydalıdır. O yüzden bunu deneyeceğiz.

Şimdi buraya geldiğimizde, bu sefer `GET` yerine `POST` yapmamız gerekiyor. `HTTP://localhost` ve `5217` yapacağız ve bu da yine `blogs` olacak.

Ama artık bir request yapıyoruz.

İlk yapacağımız şey content type’ı ayarlamak olacak ve `HTTP file` kullandığımız için kendisi zaten `application/json` ile yeterince akıllı.

REST client’ın IntelliSense’i mükemmel. Bu extension’ı gerçekten seviyorum.

Sonra bir `title` olacak ve title’ı… of, bunu tırnak içine alayım… `my third blog` yapalım, çok yaratıcı.

Ve sonra `body` diyeceğiz ve bunun içeriği `this is my third blog`, vay canına, büyük gerilim.

Hadi bunu restart edelim. Evet, uygulamamı restart etmek istiyorum. Ve bunu `send` etmeyi deneyelim.

`415 unsupported media type`.

Ne yapıyorum ben? Bir `P` kaçırmışım. Tekrar deneyelim.

Mükemmel. `201 created`.

Tam olarak aradığımız şey buydu.

Burada test etmek isteyebileceğimiz başka bir şey de şudur: Yukarı çıkıp `get all`’ı tekrar yapabiliriz ve gerçekten de listemize üçüncü bir blog eklediğimizi görürsünüz.

Harika. Bayıldım.

---

Şimdi yapacağım bir sonraki şey, bir `delete` route’u oluşturmak.

`delete` için bu listeden bir şey sileceğiz.

Ve yine biraz düşünün: Bu nasıl çalışacak?

Silecekleri şeyin `ID`’sini (ya da başka bir arama kriterini) bilmemiz gerekecek. Şimdilik `ID` kullanacağız.

Ve bir listeden belirli bir `ID`’deki şeyi sileceğimiz için, yine aynı kontrolleri kullanmamız gerekecek.

Ben bu route’u `delete` route’u için aşağıya kopyalayacağım.

Ama yine, `map get` istemiyorum. `map delete` istiyorum.

Bu burada semantik olarak doğru metottur.

Diğer route’ları da kullanabilirsiniz. Teknik olarak bir şeyi bozmaz ama insanları biraz karıştırır.

İnsanların genelde bu API’leri yazma konvansiyonlarına ters düşer.

Şimdi biri `blog/{id}` path’ine bir `DELETE` request gönderirse, onu silecek.

Bir `GET` request gönderirse, onu getirecek.

Şimdi biraz düşünün: Ne yapmak istiyoruz?

Bu yine aynı mantık.

Eğer geçerli bir `ID` değilse, `NotFound` döndür.

Ama geçerliyse, şunu yapalım… `blogs.RemoveAt`… evet, istediğim buydu.

`RemoveAt`. Bir index alacak ve bu index olarak `ID` vereceğiz.

Genelde, silmeden önce onun bir kopyasını almak da faydalıdır. `= blogs[id]` gibi.

Sonra burada onunla bir şey yapabilirsiniz. Bazen silinen şeyi kullanıcıya geri göndermek faydalı olur.

Bu örnekte, `Results.NoContent` döndüreceğiz; yani geri döndürülecek bir içerik yok.

Ve bunu comment’leyeceğim.

Sadece, böyle bir durumda genelde silmeden önce kopyasını almak isteyebileceğinizi bilmenizi istedim.

Şimdi geri gelelim.

Uygulamamızı restart edeceğiz.

Ve tekrar, uygulamamızı reset ettik.

Burada üç item görüyoruz. Aslında üç item artık yok. Orijinal iki item’a geri döndük.

Yani bu resetlendi.

Hadi onu görelim. İşte iki item.

Şimdi denemek istediğimiz şey bir `delete` çalıştırmak.

Yine, tek bir item’ı almak gibidir.

Buraya ineceğiz ve `get` yerine `delete` yapacağız.

`204 no content`.

Boş görünüyor, bir an korkutuyor ama `404` dönmedi; bu da “bulunamadı” olmadığı anlamına geliyor.

`204` başarılı demektir. Sadece geri gönderilecek içerik yoktur.

Eğer burada `500` görseydik, bu bir server error demek olurdu.

`400` türü bir hata ise istekte bir hata olduğunu gösterir.

Şimdi blog’larımızı tekrar `get` edebiliriz.

Sizce ne göreceğiz?

İki blog vardı.

Birini sildik.

Ne görmemiz gerekir?

Bam, tek bir blog.

Eğer `blogs/1` için bir blog request’i göndermeye çalışırsak `404 not found` alırız; çünkü artık sadece index `0` var.

Bunu `0` yapıp request’i gönderirsek, şimdi tamamen çalışır.

Yani `delete` route’umuz artık çalışıyor.

CRUD’un dörtte üçünü bitirdik:

 *create* , *read* ve  *delete* .

Peki geriye ne kaldı?

*update* kaldı.

---

Update biraz garip bir tanesi.

Bu gerçekten çok garip.

Geçerli, sürekli karşımıza çıkar, ama bu bir `map put`.

`PUT`, genelde bilgi göndermek için kullanılan metottur.

Bunu `POST` ile de kesinlikle yapabilirsiniz.

Bazı uygulamalar gerçekten öyle yapar.

Ama `PUT` kullanmak daha semantik olarak doğrudur; yani metot, “yapacağını söylediği şeyi” yapar.

Bunun için, bu aslında bizim… neydi… `POST`’umuza biraz benzeyecek.

Hadi bunu yapalım.

Bu bir hibrit gibi.

O yüzden aslında `delete`’i alalım; çünkü ne yapmamız gerekecek?

Güncellemek istediğimiz blog’u tanımlamamız gerekecek, sonra da güncellemeleri göndermemiz gerekecek.

Yani muhtemelen bir `ID` alacak ve muhtemelen bir `blog object` alacak.

Bu bizi en yakınına getiriyor; çünkü tüm o kontroller biraz iş.

Onu tekrar yapacağız.

Bunu `map put` yapacağız.

Ve bu sefer hem bir `ID` alacak hem de bir `blog` alacak.

Harika. Bu artık geçerli bir kod.

Bu çalışır.

Ama problem ne?

Bu `RemoveAt` yapacak.

Biz onu istemiyoruz.

O yüzden bu mantığın hepsini kaldırıyoruz.

Aslında yapmak istediğimiz şey şu:

Verilen `ID`’deki blog, gönderilen blog’a eşit olsun.

Yani `blogs[id] = blog`.

Sonra bir şey döndürelim.

`Results.Ok` ve yeni blog’u döndürelim.

Ve burada şunu hatırlayın: `Results.Ok`, `Results.NotFound` kullanmak zorunda değilsiniz.

Aynı şeyi sadece değeri döndürerek de yapabilirsiniz; sonra application type’ı ya da content type’ı doğru ayarlayarak ve status code’u ayarlayarak aynı sonuca gidersiniz.

Bu sadece çok daha temiz.

Ne zaman yapabiliyorsanız bunu kullanmanızı şiddetle öneririm.

---

Son olarak geri dönebiliriz.

Blog’larımızı restart edebiliriz.

Ve bunun gerçekten çalıştığını göstermek istiyorum.

İlk yapacağım şey, yukarı çıkıp blog’larımızı `get` etmek.

İki blog’umuz olduğunu göreceksiniz.

Şimdi diyeceğim ki bu bir `PUT` request’i.

Ve ilk blog’umuza şu değişikliği koyacağız ve yalan söyleyip bunun artık üçüncü blog olduğunu söyleyeceğiz.

Bunu `send` edelim.

Ve blog post’u geri geldi.

Şimdi yukarı çıkıp tekrar `get` edersem, üç blog değil… iki blog görürüm, çünkü yeni eklemedim, güncelledim.

Ve şimdi ilk blog’umun üçüncü blog’a dönüştüğünü görebilirsiniz.

İşte bu kadar.

Tamamen çalışan bir CRUD API oluşturduk.

 *Create* ,  *read* , *update* ve *delete* yapabiliyoruz.

Bu, veriyi manipüle etmemizi sağlar ve bu veri her türden olabilir.

Bunlar blog post’ları olabilir.

Bunlar tıbbi kayıtlar olabilir.

Bunlar uçuşlar olabilir.

Bunlar herhangi bir şey olabilir.

İnterneti düşünmeye başladığınızda, işte bu şekilde çalışır.

Bu, şeylerin nasıl inşa edildiğinin en alttaki, en temel kavramlarından biridir.

Bunu anlarsanız, buna bir kullanıcı sistemi eklersiniz, bazı izinler eklersiniz, bazı resimler eklersiniz ve internette neredeyse her şeyi inşa edebilirsiniz.

CRUD kullanarak yapabileceklerimizin bir sınırı yoktur.
