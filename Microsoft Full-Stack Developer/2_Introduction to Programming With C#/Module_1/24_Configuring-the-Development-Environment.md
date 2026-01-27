## ⚙️ Geliştirme Ortamını Yapılandırma

Artık *Visual Studio Code* kurulu olduğuna göre, çalışma ortamını yapılandıralım. Bu videoda, *.NET geliştirme ortamını* nasıl yapılandıracağımızı öğreneceğiz.

 *Visual Studio Code* ’u kurduğunuzda, bunun gibi bir pencere göreceksiniz. Sağ tarafta başlamak için bazı kaynaklar bulunur. *learn the fundamentals* veya  *getting started with VS Code* ’a tıklamanızı şiddetle öneririm. Bu, özelleştirebileceğiniz şeylerin kullanışlı bir listesini verir.

Ama önce, *Visual Studio Code* içinde nasıl gezineceğimizi konuşalım.

---

## 🧭 Visual Studio Code’da Gezinme

Burada, web tarayıcısındaki sekmeler gibi ana çalışma alanınızı göreceksiniz. Bunları kapatabilir, taşıyabilir ve hatta yan yana olacak şekilde bölünmüş bir görünüm ( *split pane* ) kullanabilirsiniz.

Üst tarafta, dosyaları kaydetme, seçiminizi değiştirme, terminalle çalışma ve kodunuzu çalıştırma gibi işlemleri yapmanızı sağlayan bir gezinme çubuğu bulunur.

Sol tarafta, kenar çubuğu menüsünde dosya gezgini ( *file explorer* ) vardır. Ayrıca  *search* , *source control* bulunur.

Kodunuzu çalıştırabilir ve hata ayıklayabilirsiniz;  *run and debug* ’ın hem aşağıda hem de yukarıda yer aldığını fark edeceksiniz.

Ek olarak, neredeyse her şeyin yanında  *hotkey* ’ler de göreceksiniz. Farklı menüler veya kısayol tuşları üzerinden, ulaşmak istediğiniz şeye gitmenin birden fazla yolu vardır.

---

## ⌨️ Kısayol Tuşları

Sürekli kullandığınız beceriler için birkaç kısayol tuşunu öğrenmeye bir dakikanızı ayırmanızı şiddetle öneririm. Editördeki her kısayolu öğrenmeye çalışmayın. Çok fazla var; ancak gezinme, dosya arama, yeni dosya açma ve kod biçimlendirme için sürekli kullandığım bazı kısayollar bulunuyor.

Bir şeyi tekrar tekrar yaptığınızı fark ettiğinizde, bunun için kullanabileceğiniz bir kısayol olup olmadığına bakın.

---

## 🎛️ Ortamı Kişiselleştirme

Gezinmenin temellerini ele aldığımıza göre, ortamınızı nasıl kişiselleştirebileceğinizi inceleyelim.

*Visual Studio Code* son derece yapılandırılabilirdir. Geliştirme deneyiminizde sonsuz değişiklik yapabilirsiniz ve editör deneyiminizi ihtiyaçlarınıza göre ince ayarlamaya büyük olasılıkla devam edeceksiniz.

Bununla birlikte, çoğu şey için varsayılan ayarlarla kalmanızı öneririm. Editörü aşırı özelleştirmek performansı yavaşlatabilir ve karşılaştığınız sorunları hızlı bir web aramasıyla çözmeyi zorlaştırabilir.

Ancak tema değiştirmek, farklı dillere destek eklemek (ki bunu yapacağız), diğer ayarları ince ayarlamak, farklı cihazlar arasında senkronize etmek ve komut paletini kullanmak gibi şeyler yapabilirsiniz.

---

## 🧰 Komut Paleti

Komut paleti, *Visual Studio Code* içinde gezinmenin en iyi yollarından biridir.

Buradaki seçeneğe tıklarsanız *unlock productivity with the command palette* yazdığını görebilirsiniz ve burada çok önemli bir kısayol vardır.  *Control* , *Shift* ve  *P* ’ye basarsam, bu küçük komut istemi açılır.

Bu, bir terminale çok benzeyecektir; çünkü benzer şekilde çalışır. Kullanmak istediğim belirli bir seçeneği yazabilirim ve bu çalıştırabileceğim bir komuttur.

*close window* yapabilirim. Bunu doğrudan bir kısayolla da çağırabilirdim; ancak bir şeyi nasıl yapacağınızı bilmiyorsanız, bir şey yapmanın yolunu hızlıca arayabileceğiniz devasa bir komut listesine sahip olursunuz ve bu komut listesi gerçekten çok büyüktür.

Daha fazla eklenti ekledikçe, bu listeye ek komutlar da ekleyebilirsiniz.

---

## 🧩 Eklenti Kurulumu

Bir sonraki yapacağımız şey bazı eklentiler yüklemek. Buradan komut paleti üzerinden de yapabileceğinizi görebilirsiniz; ancak ben size menüler üzerinden nasıl yapılacağını göstermek istiyorum.

Sol tarafta *extensions* düğmesi var ve buna tıklayacaksınız; eklentileri yükleyip yöneteceğiniz yer burasıdır.

Belki de eklemeniz gereken en önemli eklenti, *.NET* ile çalışmak için  *C# Dev Kit* ’tir.

Şu anda burada listede en üstte görebiliyorum; ancak siz listenin en üstünde görmüyorsanız, *C# dev kit* yazabilirsiniz ve bu hızlıca arayacaktır.

Buradan doğrudan  *Install* ’a tıklayabilirsiniz. Ayrıca bu liste öğesine tıklayarak eklenti hakkında tüm bilgileri görebilirsiniz.

 *C# Dev Kit* ’i, kimin yaptığını, kaç kez indirildiğini, kaç yıldız aldığını görebilir ve burada daha fazla bilgiye ulaşabilirsiniz.

Bu gerçekten kullanışlıdır; özellikle kurduktan sonra, yapabileceğiniz şeylerin türlerini size söyleyecektir.

Burada  *Install* ’a tıklayacağım ve bunun biraz daha koyu renge döndüğünü göreceksiniz.

Kurulması için bir saniye bekleyeceğiz.

---

## ✅ Kurulumun Doğrulanması

Eklenti kurulduğunda, *installed* işaretini görmelisiniz ve *disable* ile *uninstall* düğmelerini görmelisiniz.

Eğer eklentiyi kaldırmak isterseniz, bunları kullanırsınız; ya da devre dışı bırakmak isterseniz, bunu kullanabilirsiniz.

Bazen eklentinin sorun yaşadığı ve doğru çalışmadığı bir durumla da karşılaşabilirsiniz; burada eklentiyi yeniden başlatma seçeneği olacaktır.

---

## 🎉 Sonuç

Bununla birlikte, tebrikler; artık bir *.NET geliştiricisi* olmak için ihtiyaç duyduğunuz tüm temel araçlara sahipsiniz.

 *.NET SDK* ’niz var, *Visual Studio Code* içinde *C# Dev Kit* kurulu ve artık hazırsınız.

Bir geliştirici olarak yolculuğunuzda, ek eklentiler eklemek isteyebilirsiniz; ancak bu basit kurulum, dünya genelindeki milyonlarca *.NET geliştiricisi* için omurgayı sağlar.
