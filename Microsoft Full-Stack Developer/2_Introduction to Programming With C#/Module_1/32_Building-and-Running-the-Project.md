## 🏗️ Projeyi Derlemek ve Çalıştırmak

İlk dot net uygulamanızı kodlamayı yeni bitirdiğinizi hayal edin. Sırada ne var? Çalıştırmaya ve dağıtmaya hazır olduğundan nasıl emin olursunuz? Kodumuzu çalıştırdığımızda ve derlediğimizde neler olduğundan bahsedelim. Bu videoda yeni bir .net projesini çalıştıracağız. Uygulamamızı terminali kullanarak nasıl çalıştıracağımızı gösterdik; bu mantıklı çünkü bu bir terminal uygulaması. Peki ya farklı bir uygulama türü yapmak isteseydik, örneğin bir web uygulaması veya Windows uygulaması?

Bunları yine terminalden çalıştırabilirsiniz, ancak VS Code’a yerleşik olan ve uygulamanızı grafik kullanıcı arayüzü üzerinden çalıştırmanıza imkân tanıyan kullanışlı bir özellik de vardır. Burada ekranın sol tarafında  **Run** ’a tıklayabildiğimizi görebilirsiniz; bu da kodumuzu çalıştırmamıza ve hata ayıklamamıza olanak tanır. Yani burada  **Run** ’a tıklarsam,  **Run and Debug** ’a gidebilirim. Hangi dil olduğunu soracak ve bu durumda **C#** ve **C# Console app** diyeceğim. Bu benim launch configuration’ım olacak. Ve şimdi uygulamamız çalışıyor. İlk kez bu uygulamayı başlattığınızda bu biraz zaman alacaktır.

Bu bir terminal uygulaması olduğu için terminali otomatik olarak açar. Ve işte çıktımız.  **Hello World** ’ü görüyorsunuz. Şimdi kodumuzu çalıştırdığımızda perde arkasında ne olduğundan kısaca bahsedelim.  **C# derlenen (compiled) bir dildir** , yani yazdığımız kod, çalıştırılmadan önce bilgisayarın yürütüp çalıştırabileceği talimatlara dönüştürülmelidir. Bu dönüştürme sürecine genellikle uygulamayı **derlemek (build etmek)** denir. `dotnet run` komutunu kullandığımızda, önce uygulamayı derler veya build eder, ardından çalıştırır.

Grafik kullanıcı arayüzü üzerinden kodumuzu çalıştırdığımızda da perde arkasında olan şey budur. Uygulama derlendikten sonra derlenmiş çıktı **bin** klasörüne yerleştirilir. Yani dosya gezginine geri dönüp  **bin** ’e bakarsak, buranın artık dosyalarla dolu olduğunu görürsünüz. Bu, bu terminal çıktısını üretmek için çalıştırılan koddur.

Genellikle yalnızca uygulamanızı çalıştırmak istersiniz, ancak bazen çalıştırmadan sadece derlemek isteyebilirsiniz. Bunu yapmak için komut paletini tekrar kullanabilir ve **build** yazabilirsiniz. Ve burada `dotnet: build` gibi bir seçenek görmelisiniz. Aradığımız bu. Bu, build komutu. Eğer  **Build** ’e basarsak, aynı süreçten bir kez daha geçeriz, ancak bu sefer aynı terminal çıktısını görmeyiz. Çünkü kodumuz derlenir ama çalıştırılmaz.

Aynı şeyi yeni bir terminal açıp `dotnet build` çalıştırarak da yapabiliriz. Bu aynı komutu çalıştıracaktır ve burada projemizi bir kez daha derlediğimizi görebilirsiniz. Sadece derlemekle kalmayız, aynı zamanda onu kaldırabiliriz.

Eğer derlenmiş kodunuzu kaldırmak isterseniz, `dotnet clean` komutunu kullanabilirsiniz. Bunu komut paletinden de yapabilirsiniz, ancak bu durumda komut satırını kullanacağız ve işte burada. Yukarıdaki klasörün artık boş olduğunu görüyorsunuz. Bunun nedeni tüm binary’lerin kaldırılmış olmasıdır. **obj** içinde bazı geçici dosyaları bırakır, ancak binary çıktılarımız artık temizdir.

Yanlışlıkla çalışmayan dosyalar oluşturduysanız ya da etrafta kalmasını istemediğiniz eski kodlarınız varsa kodunuzu temizlemek isteyebilirsiniz. Bazen cache bozulur ve `dotnet clean` çalıştırırken kodunuzu kaybedeceğiniz konusunda endişelenmeyin; bu yalnızca **bin** klasörünü etkiler, C# dosyalarınızı etkilemez.

İlk dotnet uygulamanızı başarıyla çalıştırdınız, derlediniz ve temizlediniz. Dotnet’in kod yürütme ve proje yönetimini nasıl ele aldığını anlamak, uygulamanızın daha ileri geliştirmeye ve nihai dağıtıma hazır olmasını sağlamak için gereklidir.

---

## 🖥️ CLI Komutları

```bash
dotnet run
```

```bash
dotnet build
```

```bash
dotnet clean
```
