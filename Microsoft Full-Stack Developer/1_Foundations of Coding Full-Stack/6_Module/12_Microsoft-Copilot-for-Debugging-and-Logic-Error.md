## 🧠 Debugging ve Mantık Hataları İçin Microsoft Copilot

Microsoft Copilot, kodu gerçek zamanlı olarak analiz etmek için *yapay zekâ* kullanır; sorunları vurgular ve saatler sürebilecek manuel debugging’i azaltabilecek çözümler sunar. Bu güçlü araç, geliştirme sürecini daha akıcı hâle getirir ve temiz, işlevsel kod yazmaya odaklanmanızı sağlar.

Bu videoda, debugging ve mantık hatası tespiti için Microsoft Copilot’u nasıl kullanacağımızı göstereceğiz. Geliştirme ortamımı zaten kurdum ve Copilot eklentisini yükledim. Copilot’un debugging’de nasıl yardımcı olabileceğini incelemeden önce, biraz kod ekleyip bunu inceleyelim.

---

## 🔢 Örnek Kodun Hazırlanması

Başlamak için, `{1, 2, 3, 4, 5}` değerlerini içeren `numbers` adlı bir dizi ekliyorum. Bu dizi, bir dizi tamsayı tutar.

Bunun altında `sum` adında bir tamsayı değişken tanımladım ve bunu `0` ile başlattım. Bu değişken, `numbers` dizisindeki değerlerin toplamını saklayacak.

Ardından, `numbers` dizisindeki her elemanı dolaşıp `sum` değişkenine eklemesi gereken bir `for` döngüsü yazdım.

Son olarak döngüden sonra, `ConsoleWriteLine` kullanarak `sum` sonucunu yazdıran bir satır var. Bu, sayıların toplamını konsola yazdırır.

Ancak *Problems* sekmesinde bazı sorunlar olduğunu görüyorum ve program şu anda beklendiği gibi çalışmayacak. İşte Copilot’un devreye girdiği yer burasıdır.

---

## 🧩 Copilot ile Hata İnceleme

Copilot’un bu sorunları debug etmesine yardımcı olması için, ilk soruna tıklıyorum; sorun şunu söylüyor:

`"The type or namespace 'Integer' could not be found"`

Bunu yaptığımda, kırmızı X simgesinin yerini sarı bir ampulün aldığını fark edin. Sarı ampulü seçmek bana birkaç seçenek sunuyor.

* `Generate class 'integer'`
* `Convert to top-level statements`
* `Fix using Copilot`
* `Explain using Copilot`

Hatayı anlamak istiyorum, bu yüzden önce `"Explain with Copilot"` seçeneğini seçeceğim. Bu, Copilot sohbet arayüzünü açar.

---

## 🧾 Copilot Açıklaması ve Önerilen Düzeltme

Sohbette Copilot, `"Integer"`’ın C#’ta geçerli bir tür olmadığını açıklar.

Aşağı kaydırdığımda Copilot ayrıca hatayı düzeltmek için öneriler sunar. Bana `integer` yerine `int` kullanmamı söyler.

Artık hatayı anladığıma göre, Copilot’un bunu benim için düzeltmesini istiyorum. Bu yüzden sarı ampulü tekrar seçiyorum ve `"Fix Using Copilot"` seçeneğini seçiyorum.

Ekranın üst kısmında bir Copilot öneri kutusunun belirdiğine dikkat edin. `/fix` komutunu kullanarak hatayı tanımlar; `Integer` türünün `int` ile değiştirilmesi gerektiğini açıklar.

Copilot, dosyanın içinde, hatanın bulunduğu yerde yeni kod üretir ve düzeltme önerisini doğrudan orada sunar. Öneriyi kutudan doğrudan kabul edebilir veya reddedebilirsiniz.

Bu öneriyi kabul etmek için tıklayalım.

---

## ✅ Sonuç

Güncellenmiş kod artık Copilot’un önerisini yansıtıyor ve hatalar düzeltilmiş durumda. *Problems* sekmesinde artık dosyada hiçbir sorun olmadığını fark edin.

Bu videoda, debugging ve mantık hatalarını tespit etmek için Microsoft Copilot’u nasıl kullanacağımızı gösterdik ve Copilot’un kodunuzu analiz ederek manuel debugging’e saatler harcatabilecek problemler için akıllı çözümler nasıl sunduğunu inceledik.
