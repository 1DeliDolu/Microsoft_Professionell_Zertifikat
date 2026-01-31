## 🧩 Copilot ile İç İçe ve Karmaşık JSON Yapılarını Yönetme

Karmaşık JSON yapıları oluşturmanız gerektiğinde, işe başlamak biraz zorlayıcı olabilir. Bu yüzden  **Microsoft Copilot** ’u kullanarak önce temel bir JSON yapısı oluşturacağım, ardından bunu **C#** ile bir konsol uygulamasında kullanacağım.

Önce konsol uygulamasını oluşturacağım. Sonra da Copilot’tan JSON’un nasıl görünmesi gerektiğini belirlemekte yardım alacağız. Uygulamanın adını da **JSON structure app** koyacağım ve bunu ayrı bir örnekte açacağım.

Tamam, artık uygulamamız hazır. Şimdi Copilot’a gidip bu yapıyı oluşturmak için yardım isteyeceğim.

---

## 🧪 Copilot’tan JSON Yapısı Üretmesini İsteme

Visual Studio Code’da yeni bir konsol uygulamam olduğunu ve bir **vinyl record album collection** (plak albüm koleksiyonu) için temel bir yapı oluşturmak istediğimi anlatan bir prompt veriyorum. Ardından bu yapıyı benim için **C#** ile oluşturmasını istiyorum.

Copilot bana bir JSON yapısı döndürüyor. Bu yapıda:

* diziler (arrays) var,
* track’ler (parçalar),
* farklı albümler,
* ve JSON yapısında kullanabileceğimiz başka veriler bulunuyor.

Bu kodu alıp uygulamamda kullanabileceğim şekilde kopyalayıp yapıştıracağım.

---

## 🧱 Program.cs’e Kodu Yapıştırma ve Derleme Hatası

`Program.cs` dosyasında, template olarak gelen her şeyi sileceğim ve Copilot’un verdiği kodu yapıştıracağım.

İlk yapmak istediğim şey, kodun derlenip derlenmediğini görmek. Burada zaten bazı hatalar olabileceğini görüyorum. Bir terminal açıp build alacağım.

Build sonucu bir hata veriyor:

> vinyl collection member names cannot be the same as their enclosing type

Sorun şu: Sınıfın adı `VinylCollection`, ama içinde bir üye de `VinylCollection` adını taşıyor. Bunu farklı bir şeye çevirmem gerekiyor. Ben bunu `Albums` yapacağım.

Şimdi tekrar derlemeyi deneyeceğim.

Bu sefer daha fazla hata çıktı, çünkü sınıftaki adı değiştirdim ama kodun geri kalanında bu adı güncellemedim. Onları da düzeltiyorum.

Burada Copilot’u da kullanabilirdim: hatayı söyleyip debug etmesini isteyebilirdim. Ama basit bir düzeltme olduğu için kendim yaptım.

Artık Copilot’a bu isim değişikliğini bildirmem gerekiyor. Bu yüzden ilgili kısmı seçip kopyalayacağım. Copilot’u bir sonraki sefer kullandığımda, yeni kod üretirse property adını buna göre güncellesin diye bu bilgiyi prompt’a ekleyeceğim.

---

## ➕ Yeni Özellik İsteme ve Güncellenmiş Yapı

Copilot’tan yeni bir özellik eklemesini istiyorum. Karmaşık yapı için ne döndüreceğine bakacağız.

Copilot bu sefer bir **yeni album yapısı** veriyor; bir dizide birden fazla albüm eklenebiliyor. Burada artık bir **albums array** var ve isterseniz daha fazla albüm dizisi de ekleyebileceğinizi gösteriyor.

Bu, ileride daha rahat organize edebilmemiz için iyi.

Copilot ayrıca `VinylCollection.Albums` adını da doğru şekilde güncellemiş.

Bu kodu kopyalayıp programıma yapıştırıyorum, sonra tekrar build alıyorum.

Build başarılı. Şu ana kadar her şey iyi.

---

## ▶️ Uygulamayı Çalıştırma

Şimdi elimizde karmaşık bir JSON yapısı var. Copilot bunu oluşturdu:

* örnek veriler içeriyor,
* istersek daha fazla örnek veri ekleyebiliriz,
* deserialize edilen albümleri ihtiyacımıza göre yazdırabiliyoruz.

Bu çok basit bir uygulama; daha iyi bir arayüz oluşturabiliriz ama şimdilik çalıştırıyorum.

Çıktı, deserialize edilen albüm dizisini gösteriyor; şu an bir albüm dizisi deserialize edilmiş. İstersek daha fazla albüm ekleyebiliriz.

---

## 📁 JSON’u Koddan Ayırıp Ayrı Dosyada Yönetme

Bir şey daha yapmak istiyorum: Albüm koleksiyonunu kodun içinden çıkarıp ayrı bir dosyaya koymak. Bunun için Copilot’tan yardım isteyeceğim.

Veriyi ayrı bir JSON dosyasına taşıyacağız ve program içinde bu dosyayı okuyacağız.

Copilot bana `albums.json` dosyasının içeriğini veriyor. Onu kopyalayıp dosyaya yapıştıracağım.

Ardından `albums.json` dosyasını okumak için gerekli C# kodunu da veriyor.

Kod tarafına dönüyorum:

* önce `albums.json` dosyasını ekliyorum,
* JSON içeriğini yapıştırıyorum,
* sonra Copilot’un verdiği C# kodunu alıp uygulamaya yapıştırıyorum.

Artık kod çok daha basit, çünkü veriyi dosyadan okuyor. Dosyayı okumada hata olursa bunu da söylüyor. `albums.json` dosyasını `Program.cs` ile aynı dizinde okuyacak şekilde ayarlamış.

Tekrar çalıştırıyorum; aynı sonucu veriyor ve yine bir albüm dizisini deserialize ediyor.

---

## 🖨️ Konsolda Albüm İsimlerini Yazdırma

Şimdi küçük bir test daha yapalım: Albüm isimlerini konsola yazdırmak istiyorum. Copilot’tan bunun için kod istiyorum.

Copilot, deserialize işleminden sonra bir `foreach` döngüsü ekleyerek albüm adlarını konsola yazdıran bir kod veriyor.

Uygulama küçük olduğu için tüm kod bloğunu komple yapıştırıyorum ve tekrar çalıştırıyorum.

Koleksiyonumuzda iki albüm var: **Thriller** ve  **Back in Black** . Kod, iterate ederek ikisini de yazdırdı.

Bu yapı daha da genişletilebilir ve daha zengin hâle getirilebilir. Artık tüm albümlerimiz JSON verisi olarak ayrı bir dosyada duruyor. Program bu dosyayı okuyup farklı işlemler yapabiliyor.

---

## ✅ Kapanış

Copilot kullanarak karmaşık JSON yapıları oluşturabilir, bunları yönetebilir ve bir kullanıcı arayüzünde kullanacak şekilde uygulamanıza entegre edebilirsiniz.

## 🧩 Copilot ile İç İçe ve Karmaşık JSON Yapılarını Yönetme

Karmaşık JSON yapıları oluşturmanız gerektiğinde, işe başlamak biraz zorlayıcı olabilir. Bu yüzden  **Microsoft Copilot** ’u kullanarak önce temel bir JSON yapısı oluşturacağım, ardından bunu **C#** ile bir konsol uygulamasında kullanacağım.

Önce konsol uygulamasını oluşturacağım. Sonra da Copilot’tan JSON’un nasıl görünmesi gerektiğini belirlemekte yardım alacağız. Uygulamanın adını da **JSON structure app** koyacağım ve bunu ayrı bir örnekte açacağım.

Tamam, artık uygulamamız hazır. Şimdi Copilot’a gidip bu yapıyı oluşturmak için yardım isteyeceğim.

---

## 🧪 Copilot’tan JSON Yapısı Üretmesini İsteme

Visual Studio Code’da yeni bir konsol uygulamam olduğunu ve bir **vinyl record album collection** (plak albüm koleksiyonu) için temel bir yapı oluşturmak istediğimi anlatan bir prompt veriyorum. Ardından bu yapıyı benim için **C#** ile oluşturmasını istiyorum.

Copilot bana bir JSON yapısı döndürüyor. Bu yapıda:

* diziler (arrays) var,
* track’ler (parçalar),
* farklı albümler,
* ve JSON yapısında kullanabileceğimiz başka veriler bulunuyor.

Bu kodu alıp uygulamamda kullanabileceğim şekilde kopyalayıp yapıştıracağım.

---

## 🧱 Program.cs’e Kodu Yapıştırma ve Derleme Hatası

`Program.cs` dosyasında, template olarak gelen her şeyi sileceğim ve Copilot’un verdiği kodu yapıştıracağım.

İlk yapmak istediğim şey, kodun derlenip derlenmediğini görmek. Burada zaten bazı hatalar olabileceğini görüyorum. Bir terminal açıp build alacağım.

Build sonucu bir hata veriyor:

> vinyl collection member names cannot be the same as their enclosing type

Sorun şu: Sınıfın adı `VinylCollection`, ama içinde bir üye de `VinylCollection` adını taşıyor. Bunu farklı bir şeye çevirmem gerekiyor. Ben bunu `Albums` yapacağım.

Şimdi tekrar derlemeyi deneyeceğim.

Bu sefer daha fazla hata çıktı, çünkü sınıftaki adı değiştirdim ama kodun geri kalanında bu adı güncellemedim. Onları da düzeltiyorum.

Burada Copilot’u da kullanabilirdim: hatayı söyleyip debug etmesini isteyebilirdim. Ama basit bir düzeltme olduğu için kendim yaptım.

Artık Copilot’a bu isim değişikliğini bildirmem gerekiyor. Bu yüzden ilgili kısmı seçip kopyalayacağım. Copilot’u bir sonraki sefer kullandığımda, yeni kod üretirse property adını buna göre güncellesin diye bu bilgiyi prompt’a ekleyeceğim.

---

## ➕ Yeni Özellik İsteme ve Güncellenmiş Yapı

Copilot’tan yeni bir özellik eklemesini istiyorum. Karmaşık yapı için ne döndüreceğine bakacağız.

Copilot bu sefer bir **yeni album yapısı** veriyor; bir dizide birden fazla albüm eklenebiliyor. Burada artık bir **albums array** var ve isterseniz daha fazla albüm dizisi de ekleyebileceğinizi gösteriyor.

Bu, ileride daha rahat organize edebilmemiz için iyi.

Copilot ayrıca `VinylCollection.Albums` adını da doğru şekilde güncellemiş.

Bu kodu kopyalayıp programıma yapıştırıyorum, sonra tekrar build alıyorum.

Build başarılı. Şu ana kadar her şey iyi.

---

## ▶️ Uygulamayı Çalıştırma

Şimdi elimizde karmaşık bir JSON yapısı var. Copilot bunu oluşturdu:

* örnek veriler içeriyor,
* istersek daha fazla örnek veri ekleyebiliriz,
* deserialize edilen albümleri ihtiyacımıza göre yazdırabiliyoruz.

Bu çok basit bir uygulama; daha iyi bir arayüz oluşturabiliriz ama şimdilik çalıştırıyorum.

Çıktı, deserialize edilen albüm dizisini gösteriyor; şu an bir albüm dizisi deserialize edilmiş. İstersek daha fazla albüm ekleyebiliriz.

---

## 📁 JSON’u Koddan Ayırıp Ayrı Dosyada Yönetme

Bir şey daha yapmak istiyorum: Albüm koleksiyonunu kodun içinden çıkarıp ayrı bir dosyaya koymak. Bunun için Copilot’tan yardım isteyeceğim.

Veriyi ayrı bir JSON dosyasına taşıyacağız ve program içinde bu dosyayı okuyacağız.

Copilot bana `albums.json` dosyasının içeriğini veriyor. Onu kopyalayıp dosyaya yapıştıracağım.

Ardından `albums.json` dosyasını okumak için gerekli C# kodunu da veriyor.

Kod tarafına dönüyorum:

* önce `albums.json` dosyasını ekliyorum,
* JSON içeriğini yapıştırıyorum,
* sonra Copilot’un verdiği C# kodunu alıp uygulamaya yapıştırıyorum.

Artık kod çok daha basit, çünkü veriyi dosyadan okuyor. Dosyayı okumada hata olursa bunu da söylüyor. `albums.json` dosyasını `Program.cs` ile aynı dizinde okuyacak şekilde ayarlamış.

Tekrar çalıştırıyorum; aynı sonucu veriyor ve yine bir albüm dizisini deserialize ediyor.

---

## 🖨️ Konsolda Albüm İsimlerini Yazdırma

Şimdi küçük bir test daha yapalım: Albüm isimlerini konsola yazdırmak istiyorum. Copilot’tan bunun için kod istiyorum.

Copilot, deserialize işleminden sonra bir `foreach` döngüsü ekleyerek albüm adlarını konsola yazdıran bir kod veriyor.

Uygulama küçük olduğu için tüm kod bloğunu komple yapıştırıyorum ve tekrar çalıştırıyorum.

Koleksiyonumuzda iki albüm var: **Thriller** ve  **Back in Black** . Kod, iterate ederek ikisini de yazdırdı.

Bu yapı daha da genişletilebilir ve daha zengin hâle getirilebilir. Artık tüm albümlerimiz JSON verisi olarak ayrı bir dosyada duruyor. Program bu dosyayı okuyup farklı işlemler yapabiliyor.

---

## ✅ Kapanış

Copilot kullanarak karmaşık JSON yapıları oluşturabilir, bunları yönetebilir ve bir kullanıcı arayüzünde kullanacak şekilde uygulamanıza entegre edebilirsiniz.
