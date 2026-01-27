## 🗂️ Proje Yapısı

Tıpkı bir mutfağı düzenlemenin yemek yapmayı daha verimli hâle getirmesi gibi. Proje yapınızı anlamak, kodlama sürecinizi daha akıcı hâle getirecektir. Bu videoda, .NET’te proje yapısını ve dosya organizasyonunu açıklayacağız. **Program.cs** dosyamızı, **csproj** dosyamızı ve **bin** ile **obj** klasörlerini konuşarak başlayacağız. İlk olarak, **Program.cs** uygulamamızın giriş noktasıdır. Uygulamamız başladığında çalıştırılan dosya budur.

Kod içeren ve bu dosyadaki kod tarafından çalıştırılan başka birçok dosyamız olabilir, ancak yürütme burada başlar. Bu, özel uygulama mantığımızın kalbidir. Tüm .NET proje türleri giriş noktası olarak **Program.cs** dosyasını kullanmaz; bu da .NET projelerini scaffold etmenin harika olmasının bir parçasıdır. Biraz deneyimle, yeni bir proje oluşturduğunuzda üretilen dosyaları inceleyip hangi dosyanın giriş noktası olduğunu belirleyebilmeniz gerekir. Farklı .NET proje türlerinde giriş noktasının adını öğrenmek için her zaman bir web araması veya bir yapay zekâ aracı kullanabilirsiniz.

---

## 🧩 `Program.cs`

Artık uygulamamızın nereden başladığını bildiğimize göre, projenin nasıl yapılandırıldığını belirlemek için **csproj** dosyasını inceleyelim.

---

## ⚙️ `.csproj` Dosyası

Önceki bir videoda **csproj** dosyasını konuşmuştuk. Bu dosya proje ayarlarınızı, bağımlılıklarınızı ve yapılandırmanızı tanımlar. .NET build sistemine projenizi nasıl derleyeceğini, hangi dosyaların dahil edildiğini, projenizin hangi **NuGet** paketlerine ve kütüphanelere bağlı olduğunu ve diğer yapılandırma ayrıntılarını söyler. Bu oldukça basit bir **csproj** dosyasıdır. Kendi projelerinizi oluşturduğunuzda, muhtemelen NuGet’ten çok daha fazla bağımlılığınız ve oluşturduğunuz bağlantılı projeleriniz olacak.

Ayrıca projenizin nasıl derlendiğini etkileyen ayarları da tanımlayabilirsiniz.

---

## 📦 `bin` Klasörü

Sıradaki **bin** klasörü. Bunun, derlenmiş kodumuzun saklandığı yer olduğunu söylemiştik. `ConsoleApp.exe` dosyasını açarsak bir uyarı göreceğiz; çünkü bu bir binary dosyadır. Yine de açalım, çünkü burada ne olduğunu göstermek istiyorum. Bunu bir metin düzenleyici olarak açacağız ve burada genellikle neden açmadığımızı göreceksiniz. Bu biraz korkutucu görünebilir, ancak olan şey şu: Bu, bir sürü anlamsız karakter gibi görünür; çünkü bu bizim için tasarlanmamıştır.

Bu dosyanın bilgisayar tarafından okunması amaçlanır ve VS Code bu durumda onu metin olarak yorumlamaya çalıştığı için bu garip görünen çıktı ortaya çıkar. Çalıştırılabilir (executable) dosya, uygulamamızı çalıştırdığımızda yürütülen dosyadır. Buradaki **DLL** dosyaları ise uygulamamız tarafından yürütülen, ancak son kullanıcı tarafından doğrudan çalıştırılmayan diğer kod parçalarıdır. Burada iki DLL’imiz var: **Pastel** ve  **ConsoleApp.dll** , yani yazdığımız kod. Bu kod, Pastel ile birlikte çalıştırılabilir dosyaların yanında çalışan bir kütüphaneye dönüştürülmüştür.

---

## 🧱 `obj` Klasörü

Derlenmiş kodumuzun nereye gittiğini belirledikten sonra, şimdi **obj** klasörünü inceleyelim. **obj** klasörü derleme sürecine dahildir. Genellikle obj klasörüyle doğrudan etkileşime girmeniz gerekmez, ancak neden burada olduğunu anlamak faydalıdır.

Bu dizin, derleme süreci sırasında oluşturulan ve kullanılan ara (intermediate) dosyaları saklar. Bu dosyalar nihai çıktı değildir, ancak projenizi son hâline derlemek için gereklidir. Derleme sürecinizde bir şeyler ters giderse, neler olduğunu anlamak için bu klasördeki dosyaları kontrol edebilirsiniz. Ve artık basit bir .NET projesinde gezinmek için gerekli tüm temel bilgilere sahipsiniz. Farklı proje türlerinde başka dosyalar da olacaktır, ancak tüm .NET projeleri bu çekirdek dosya ve dizinleri paylaşır.
