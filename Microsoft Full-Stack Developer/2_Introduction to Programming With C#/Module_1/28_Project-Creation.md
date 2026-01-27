## 🧱 Proje Oluşturma

Geçmişte proje oluşturmak gerçekten zahmetli olabiliyordu. Doğru dizinlerde birden fazla dosya oluşturmanız ve aynı *boilerplate* bilgilerini her dosyaya koymanız gerekirdi.

Neyse ki modern geliştirme araçları yeni projeler oluşturmayı çok daha kolay hâle getirdi ve *.NET* de bunun bir istisnası değil. *.NET CLI* veya VS Code içindeki *Command Palette* kullanarak, ihtiyaçlarınıza göre özelleştirebileceğiniz temel *.NET projelerini* hızlıca kurabilirsiniz.

Bu videoda, yeni bir *.NET projesi* oluşturmanın ilk adımlarını anlayacağız. Süreci *Visual Studio Code* kullanarak proje oluşturarak adım adım ilerleyeceğiz. Komut satırını kullanmaya zaten aşinaysanız, projeleri *.NET New* komutuyla da oluşturabilirsiniz.

---

## 🚀 Yeni Bir Proje Oluşturmaya Başlama

Yeni bir proje oluşturmaya başlayalım. Yeni bir proje oluşturmak için, *C# dev kit* eklentisi kuruluysa, dosya gezginindeki ( *File Explorer* ) şu düğme üzerinden yapabilirsiniz; ancak ben bunu *Command Palette* üzerinden yapmayı tercih ediyorum.

Buradaki temel kısayol tuşu:

*Control Shift P*

Bu kısayolu kullanabilirsiniz. Ardından *.NET new project* yazabilirsiniz ve burada bu komut için bir seçenek göreceksiniz.

Buradan **“.Net New Project”** seçeneğine tıklarsanız, oluşturabileceğiniz farklı proje türlerinin bir listesini görürsünüz.

---

## 🧩 Proje Türünü Seçme

Burada oldukça uzun bir liste vardır ve web geliştirme için en çok ilgileneceğiniz türler genellikle *ASP.NET Core* ve *Blazor* olanlardır; ancak farklı türde pek çok proje bulunur.

Henüz web geliştirmeye hazır değiliz; bu yüzden bir *console app* oluşturacağız. Bu, terminalde çalışacak bir uygulamadır.

 **“Console App”** ’e tıklayacağım ve sonra bunu koymak istediğim bir klasör seçeceğim. *My Documents* içine koyacağım ve bu projeye **ConsoleApp** adını vereceğim.

 *Enter* ’a basın.

Burada oluşturulacak varsayılan bir klasör yapısı olacaktır. *Console App* için bunu istediğiniz yere koyabilirsiniz; ancak aynı isimde bir klasör içinde tutmanın oldukça faydalı olduğunu düşünüyorum.

---

## ✅ Dosyalara Güvenme ve Projenin Oluşturulması

Bu işlem, bir sürü klasör ve dosya oluşturacaktır. Şimdi bu dosya veya klasörlerin yazarına güvenmek isteyeceksiniz.

Bu, bilgisayarınızın programatik olarak bu dosyaları oluşturmasıdır. Ben, *yes, I trust the authors* diyeceğim ve bu, bu dosyalara erişmeme izin verecek.

Bu dosyalar artık *.NET* tarafından oluşturuldu.

Eğer klasörleri burada solda görmüyorsanız,  *File Explorer* ’a tıklayın. Bu farklı menülerden birinde olabilirsiniz.

---

## 📄 Program.cs Dosyası

Daha önce söylediğim gibi, burada birkaç dosya oluşturuyoruz. Bunların bazıları oldukça karmaşıktır ve manuel olarak oluşturmanız çok uzun sürerdi.

Ama bunların merkezinde *Program.cs* dosyası vardır. Özel kodunuzu yazacağınız yer burasıdır.

Burada tek bir satır kod olduğunu görebilirsiniz:

```csharp
Console.WriteLine("Hello, World!");
```

Bu satır, terminalde yeni bir satır metin yazdıran özel bir fonksiyon olan *Console.WriteLine* fonksiyonunu çağırır.

Bu örnekte, tek bir argüman alır; yani gösterilecek metin. Bu durumda, ünlem işaretiyle birlikte  *Hello, World* .

---

## 🖥️ Terminalde Çalıştırma

Bu bir terminal uygulaması olduğu için, bunu terminali kullanarak çalıştırmak mantıklıdır.

Programımızı çalıştırmak için  *.NET CLI* ’ı kullanabiliriz ve yapmamız gereken tek şey, programımızın adından sonra *dotnet run* yazmaktır.

Bu durumda şunu yazacağız: *dotnet run* ve ardından  *.\Program.cs* .

Kullanışlı bir püf noktası: *dotnet run* yazıp sonra *PR* harflerini yazarsanız ve ardından  *Tab* ’e basarsanız, otomatik olarak tamamlar. Bu, işi çok daha kolay hâle getirir.

Yine, *.\Program.cs* yazabilir veya *.\Pr* yazıp  *tab* ’e basabilirsiniz; otomatik tamamlayacaktır.

Programı çalıştırabiliriz.

Eğer bunu ilk kez çalıştırıyorsanız, bir saniye sürecektir; çünkü aslında o fonksiyonu çalıştıracak kodu derlemektedir. Unutmayın, *C#* derlenen ( *compiled* ) bir dildir.

Programın sonucu olarak, terminal çıktısında *Hello, World* görmelisiniz.

Burada görebilirsiniz.

Bu, gerçekten bizim kodumuz tarafından üretilen bir metindir.

---

## ✏️ Çıktıyı Değiştirme ve Yeniden Çalıştırma

Bunu farklı bir şey yapabiliriz. Şunu *Hello, .NET* yapalım ve bunu kaydettiğimden emin olacağım. Kaydetmezseniz, değişiklikleri görmezsiniz.

Burada *command S* kısayolunu kullanıyorum ve şimdi bunu bir kez daha çalıştıralım.

Bu sefer, *Hello, .NET* görürsünüz.

---

## ✅ Sonuç

Bu adımları takip ederek, resmi olarak ilk *.NET kodunuzu* yazmış oldunuz.

Bu, geliştirici olma yolculuğunuzu sürdürürken önemli bir kilometre taşıdır. Tebrikler.
