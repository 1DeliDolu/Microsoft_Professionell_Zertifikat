## ⚙️ .NET SDK Kurulumu

Bugünkü videoda, *.NET SDK* kurulum sürecini adım adım ele alacağız.  *.NET SDK* ’yı kurmak, *.NET kodunu* çalıştırmamıza, *.NET kütüphanelerini* kullanmamıza ve *.NET komut satırı aracını* keşfetmemize olanak tanır.

Kurulumu Windows üzerinde göstereceğiz; ancak Mac’teki süreç oldukça benzerdir, Linux için de aynıdır. Bu videoda  *.NET SDK* ’nın nasıl kurulacağını inceleyeceğiz.

---

## 📥 Doğru Yükleyiciyi İndirme

İlk olarak, işletim sisteminize uygun yükleyiciyi indirmeniz gerekir. Yükleyiciyi şu adreste bulabilirsiniz:

```text
https://dotnet.microsoft.com/download
```

Bu sayfa işletim sisteminizi otomatik olarak algılamalıdır ve burada doğru yükleyiciyi listelenmiş olarak görmelisiniz.

Bu durumda, benim ihtiyacım olan *ARM64* yükleyicisidir. Ancak farklı bir yükleyiciye ihtiyacınız varsa, buradaki şu bağlantıya tıklayabilirsiniz:  *all .NET 8.0 downloads* ; bu size diğer seçenekleri sunacaktır.

Kurulumu başlatmak için buna tıklayacağım ve bu indirilmeye başlayacaktır. Burada daha önce indirmiş olduğumu görebilirsiniz, ancak dosyayı açacağız.

Eğer dosya burada açık değilse, dosya sisteminizde indirdiğiniz yere gidip oradan da açabilirsiniz.

---

## 🧩 Kurulumu Çalıştırma

 *Install* ’a tıklayacağız ve cihazınızda değişiklik yapmasına izin vermek için *yes* demek isteyeceksiniz. Ardından bunun kendi işlemini yapmasını bekleyeceksiniz.

Bu bazen, bilgisayarınızın hızına bağlı olarak birkaç dakika sürebilir.

Kurulum tamamlandığında, bu kaynak listesini görmelisiniz. Buradan  *.NET dokümantasyonu* ,  *SDK dokümantasyonu* , *release notes* ve *tutorials* gibi kaynaklara bakabilirsiniz.

Bunlardan herhangi biri ilginizi çekerse, bu notlara tıklayabilirsiniz; ancak bu materyalin çoğunu kursta ele alacağız. Siz sadece dinlemeye devam edebilirsiniz.

Burada  *close* ’a tıklayacağız.

---

## 🧪 .NET’in Kurulduğunu Doğrulama

Bir sonraki adım,  *.NET* ’in kurulduğundan emin olmaktır. Terminal uygulamasını açmanız gerekir.

Artık hemen hemen her işletim sisteminde bir terminal vardır. Uzun süre Windows’ta sadece *PowerShell* vardı; ancak artık burada gördüğünüz gibi *Windows Terminal* üzerinden PowerShell’e erişebilirsiniz.

Mac’te terminal vardır, Windows’ta terminal vardır, Linux’ların hepsinde terminal vardır.

Terminal, bilgisayarınızla etkileşim kurmanıza ve metin kodları kullanarak farklı uygulamalar çalıştırmanıza izin veren özel bir yazılımdır.

Bu durumda, buradaki komut istemine yazabilirsiniz ve burada yanıp sönen bir gösterge görmelisiniz. Eğer bunu görmüyorsanız, aslında terminale odaklı değilsiniz demektir.

Burada gördüğünüz gibi ben az önce dışarı tıkladım ve odaklı değilim.

Eğer yazarsam, hiçbir şey olmaz. Ama tekrar içeri tıklarsam, o gösterge yeniden gelir.

---

## ⌨️ `dotnet` Komutunu Çalıştırma

Yapacağınız tek şey, tek bir kelime yazmak; büyük harf yok:

```bash
dotnet
```

Bundan farklı herhangi bir şey yazarsanız, bu doğru çalışmayacaktır. Ardından  *Enter* ’a basın ve bu *usage* mesajını görmelisiniz.

Bu mesaj, komutun nasıl kullanılacağını söyler. Eğer gerçekten kurulu olmasaydı bunu görmezdiniz.

---

## ❌ Kurulu Değilse Ne Görürsünüz?

Eğer kurulu değilse, buna benzer bir şey görürsünüz. İsmi yanlış yazacağım ve bunun “komut, fonksiyon, betik dosyası veya çalıştırılabilir program olarak tanınmadığını” söyleyecek.

Bu, bunun aslında yüklü bir yazılım parçası olmadığı anlamına gelir.

Eğer `dotnet` yazıp buna benzer bir mesaj görürseniz, bir şeyler ters gitmiştir. Yapmanız gereken, terminalinizi yeniden başlatıp komutu tekrar çalıştırmayı denemektir; bu işe yaramazsa, bilgisayarınızı yeniden başlatın; bu da işe yaramazsa, kurulum sürecini bir kez daha yeniden deneyin.

---

## 🧰 Visual Studio Code Kurulumu

Artık *.NET SDK* kurulduğuna göre,  *Visual Studio Code* ’u kurabiliriz.

Başka bir sekmem açık ve gitmeniz gereken adres şu:

```text
code.visualstudio.com/download
```

Ardından sisteminize uygun yükleyiciye tıklayın.

Bu örnekte, Windows 11 arıyorum. Görünüşe göre bunun *x64* ve *ARM64* üzerinde çalışacağı belirtilmiş; ben de *ARM64* kullanıyorum.

Şimdi buna tıklayacağım ve indirme başlayacaktır.

İndirmeye bir kez daha tıklayacaksınız ve bu sefer sözleşmeyi kabul etmek isteyeceksiniz. Ardından buradaki  *Next* ’e tıklayacaksınız; eğer konumu beğeniyorsanız.

Beğenmiyorsanız başka bir yere taşıyabilirsiniz; ancak varsayılanların genellikle çok iyi olduğunu düşünüyorum. Özellikle kaybolursanız, internetin bildiği bir yerde olur.

---

## ✅ Kurulum Seçenekleri

Şimdi şu sonraki seçenekleri kontrol edelim.

İlk iki seçenek konusunda endişelenmezdim; ancak son iki seçeneği kesinlikle işaretli bırakmak istersiniz.

Birincisi,  *code* ’u desteklenen dosya türleri için bir editör olarak kaydetmek. Bu, Visual Studio Code’un farklı programlama dosya türlerini doğrudan dosyanın kendisinden açabilmesi demektir.

Tıpkı bir e-tablo dosyanız olduğunda doğrudan Sheets veya Microsoft Excel’de açılması gibi. Bir kod dosyasını açmayı denerseniz, doğrudan Visual Studio Code’da açılır.

Ayrıca *path* ekleyebilirsiniz ve bu önemlidir. Bu, tıpkı  *.NET* ’te gösterdiğimiz gibi, Visual Studio Code’u terminalden çalıştırmanıza olanak tanır.

Bunu yapmak zorunda değilsiniz; ancak şiddetle tavsiye ederim. Elinizin altında olması çok kullanışlıdır.

Bu ikisiyle birlikte, *Next* ve  *Install* ’a tıklayacağız.

---

## 🚀 VS Code’u Açma

Kurulum tamamlandığında, bu işareti açık bırakarak Visual Studio Code’u başlatabilirsiniz; ancak ben bunu kapatacağım, böylece eğer daha önce açmadıysanız Visual Studio Code’u nasıl bulacağınızı gösterebilirim.

*Visual Studio Code* yazacağım ve bu, en iyi eşleşme olarak Visual Studio Code’u getirecektir.

Linux ve Mac’te de buna benzer arama seçenekleri vardır. Ayrıca *VS Code* yazabilirsiniz.

Bu, çoğu işletim sisteminde çalışır.

---

## ✅ Sonuç

Burada açıldığında, bunun Visual Studio Code olduğunu görebilirsiniz.

Artık  *Visual Studio Code* ’u ve  *.NET SDK* ’yı kurdunuz; bunlar bir *.NET geliştiricisi* olarak çalışmaya başlamanın ilk iki kritik adımıdır.
