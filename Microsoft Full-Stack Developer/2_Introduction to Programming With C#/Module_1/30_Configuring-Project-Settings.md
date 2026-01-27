## ⚙️ Proje Ayarlarını Yapılandırma

Yeni bir binanın temelini attığınızı hayal edin. Duvarları ve pencereleri eklemeden önce, planların vizyonunuzla mükemmel şekilde hizalandığından emin olmanız gerekir. Aynı şekilde, başlangıç ayarlarını yapılandırmak, yeni bir **.NET** projesine başlarken her şeyin sorunsuz çalışmasını sağlamak için kritik bir adımdır. Bu videoda, başlangıç proje ayarlarını yapılandıracağız. İlk bakacağımız yer **csproj** dosyamız olacak. Dosyanın adı, proje oluştururken belirttiğiniz adla aynı olacaktır. Bu, projenizin çalıştırma, test etme, derleme ve diğer yapılandırma türlerini nasıl ele alacağını tanımlayan özel bir dosyadır.

Burada nispeten temel bir kurulumumuz var, bu yüzden oldukça basit. İleride çok daha karmaşık **csproj** dosyaları görebilirsiniz. Bir **csproj** dosyasındaki veriler **XML** kullanır; bu, verileri metin formatında hem insanlar tarafından okunabilir hem de makineler tarafından okunabilir biçimde düzenlemek ve saklamak için kullanılan bir formattır. Köşeli parantezler arasındaki metne **etiket (tag)** denir. Etiketler çift hâlinde gelir: bir **açılış etiketi** ve bir  **kapanış etiketi** . Kapanış etiketi bir ters bölü işaretiyle başlar. Bazı bilgiler etiketlerin arasında yer alır.

Burada etiketleri başka etiketlerin içine **iç içe (nest)** koyabildiğinizi görebilirsiniz. Bu **output type** etiketi, içinde yalnızca metin olan bir değere sahiptir. Bu durumda bu değer  **exe** ’dir. Etiketlerin ayrıca parametreleri de olabilir. Burada karşılaştığımız ilk etiket, **Sdk equals Microsoft.NET.Sdk** özniteliğine sahip olan **project** etiketidir. Bu, meta veriyi ayarlayan şeydir. Bu, etiketlerin içinde tutulan veri değildir.

Bu, verinin kendisi hakkında olan veridir. XML’de bilgiyi kodlamanın bir başka yoludur. Değerleri etiketlerin arasına koyabilirsiniz. Etiketin kendi içinde yaşayan bu özniteliklere (attributes) sahip olabilirsiniz. Bu, **MSBuild** adlı bir araca ne tür bir proje üzerinde çalıştığınızı söyler. Eğer bu bir web projesi olsaydı, yalnızca **.sdk** yerine **.sdk.web** görebilirdiniz; ya da masaüstü uygulaması olsaydı **sdk.windows desktop** görebilirdiniz. Bir diğer önemli bilgi de  **target framework** ’tür; bu örnekte  **NET 8.0** ’dır; yani bu proje **.NET sürüm 8** kullanır ve bu, bu videonun kaydedildiği tarih itibarıyla en güncel kararlı sürümdür.

Farklı bir **.NET** sürümü kullanmak isteseydiniz, bunun belirtileceği yer burasıdır. İleride muhtemelen **.NET 9** ve sonrası olacaktır. **C# Dev Kit** gibi bir aracı kullanarak bu dosyaların iskeletini (scaffold) oluşturmak bize harika bir başlangıç sağladı. Çoğu zaman **csproj** dosyanızı değiştirmek konusunda endişelenmeniz gerekmeyecek. Burada nelerin olduğunu bilmek faydalıdır, ancak bunların tam olarak ne yaptığını bilme konusunda çok fazla endişelenmeyin. Eğer bir gün belirli bir şeyi bulmanız gerekirse, daha sonra araştırabilirsiniz. İşte **.NET** projesinde yapılandırmayı göreceğiniz ilk yer burasıdır.

---

## 📦 Paket Ekleme

Sonraki adım olarak paket eklemek isteyebiliriz. Paketler, projenizde kullanabileceğiniz önceden yazılmış kodlardır. **.NET** ekosisteminde paketler, **NuGet** adlı bir yazılım parçası tarafından eklenir. Burada **Program.cs** dosyamıza bakarsak, oldukça temel bir konsol uygulaması olduğunu görürsünüz. Sadece **Hello, World** yazdıran tek bir `Console.WriteLine` var. Şimdilik olanı beğeniyorum ama çıktı metninin rengini değiştirmek istiyorum. Bunu yapmak için **Pastel** adlı bir paketi kullanalım.

Komut paletini açarsak, bir **NuGet** paketi eklemenin bir yolunu bulup bulamayacağımıza bakalım. NuGet, **N-U-G-E-T** şeklinde yazılır; bu yüzden burada ne olduğuna bakmak için **add nuget** yazalım. Hey, istediğimiz komut tam burada. **NuGet, add NuGet package.** Paketimizin adı  **Pastel** , o yüzden bunu arama çubuğuna yazıp Enter’a basalım; bu, Pastel için bir arama çalıştıracaktır. Dönen paketler listesinin en üstündeki **Pastel** seçeneği, istediğimiz ilk seçenek. Sonra bizden sürümü seçmemiz istenecek.

Bu noktada **5.1.0** en güncel sürüm. Ancak farklı bir sürüm istiyorsanız ya da ileride daha yeni bir sürüm çıkarsa, onu seçebilirsiniz. Bu kodu takip ediyorsanız, kod değişiklikleri olabileceği ihtimaline karşı aynı sürümü kullanmak en iyisidir. Şimdi **csproj** dosyamıza gidersek, yeni bir şey görmelisiniz. **Pastel version 5.1.0** içeren bir **item group** ve  **package reference include** . Bu, Pastel paketini kurduğumuzu ve bunun bu projenin bir bağımlılığı (dependency) olduğunu gösterir. Yani bu, kodumuzun artık dayanacağı bir kod parçasıdır.

---

## 🧩 Pastel Paketini Kodda Kullanma

Önce `Program.cs` dosyamıza gideceğiz ve kapanış çift tırnağın hemen sonrasını seçeceğim. Nokta yazacağım, sonra  **Pas** , ve burada otomatik tamamlamanın  **Pastel** ’e başladığını görebilirsiniz. Bunu seçmek için tıklayacağım ve aslında bunu sadece yazabilirdim. Ama buraya tıklarsam çok faydalı bir şey yapacak. Ona tıkladığımda, **using Pastel** eklediğini göreceksiniz. Bu, bize bu paket için içe aktarmayı (import) sağlayacak. Bu, kodumuzun artık Pastel’in nereden geldiğini anladığı anlamına gelir.

Bu, harici bir paket veya kütüphaneden geliyor. Sonraki adım olarak, parantez açalım ve ben `Color.Green` yazarsam… Burada büyük/küçük harfe dikkat edin: **Color** için büyük  **C** , **Green** için büyük **G** kullanmanız gerekir, yoksa bu kod doğru çalışmaz. Yine burada  **IntelliSense** ’i kullanabiliriz. Bize green ile başlayan veya adında green geçen tüm renk seçeneklerini gösteriyor. Bu örnekte  **light green** ’i seçeceğim. Ancak istediğiniz herhangi bir rengi seçebilirsiniz.

Yine, büyük/küçük harfe dikkat ettiğinizden emin olun; aksi hâlde bu kod doğru çalışmayacaktır. Şimdi dosyamı kaydedip terminali tekrar açarsam… Eğer `dotnet run` yazıp program dosyamı bunun sonuna eklersem, yani `dotnet run.\Program.cs` yazıp Enter’a basarsam, burada çıktıyı görmelisiniz: **Hello, World** artık açık gri renk yerine **açık yeşil** olarak görünecek. Harika. **csproj** dosyası bilgimiz ve Pastel gibi harici bir paket eklememiz sayesinde projemiz gerçekten iyi ilerliyor.

---

```bash
dotnet run
```

```bash
dotnet run.\Program.cs
```

```csharp
Console.WriteLine
```

```csharp
using Pastel
```

```csharp
Color.Green
```
