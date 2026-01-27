## 🧩 C#’ta Çok Biçimliliği Kodlamak

Tek bir aracın, eldeki göreve bağlı olarak farklı enstrümanlara dönüşebildiğini hayal edin. Programlamada çok biçimliliğin gücü de budur. Bu videoda, C# programlarında çok biçimliliği uygulayacağız.

Önce çok biçimliliği tanımlayarak başlayalım.  *Çok biçimlilik (polymorphism)* , geliştiricilerin tek bir metot adını kullanarak, üzerinde işlem yaptığı nesnenin türüne bağlı olarak farklı görevler gerçekleştirmesini sağlar. Esasen bu, aynı ada sahip bir metodun, kendisinden ne istendiğine bağlı olarak farklı işler yapabileceği anlamına gelir.

Şimdi geliştiricilerin C#’ta çok biçimliliği uygulayabileceği birkaç yolu inceleyelim.

---

## 🧬 Taban Sınıfta Virtual Metot Kullanımı

Geliştiriciler C#’ta çok biçimliliği, bir taban sınıfta *virtual* bir metot oluşturarak kullanır. Bu, metodun geçersiz kılınabileceğini ( *overridden* ) belirtir.

*Method overriding* (metot geçersiz kılma), bir alt sınıfın, taban sınıfında tanımlı olan bir metodun belirli bir uygulamasını sağlamasına izin verir.

Bir örnek inceleyelim. Bir geliştiricinin müzik enstrümanlarını yöneten bir sınıf oluşturmak istediğini varsayalım. Sınıfı *public* olarak bildirir ve *play* adlı bir *virtual* metodu vardır; bu metot *publicVirtualVoidPlay* olarak bildirilmiştir ve çağrıldığında konsola *playing an instrument* mesajını yazar.

Bu sınıf, bir alt sınıf tarafından geçersiz kılınabilecek tek bir *virtual* metoda sahiptir. Bu taban sınıflar ayrıca geçersiz kılınamayan ( *can't be overridden* ) somut ( *concrete* ) metotlar da içerir.

---

## 🎹 Override ile Piano Alt Sınıfı

*Play* metodunu geçersiz kılmak için geliştirici, *Instrument* taban sınıfından miras alan *Piano* adlı bir alt sınıf oluşturur.

*Play* metodunu *override* anahtar sözcüğüyle oluşturur; bu metot *publicOverrideVoidPlay* olarak bildirilir.

Geçersiz kılınan metot, konsola *the piano is playing* mesajını yazdırır.

Diğer enstrümanlar için de aynı şekilde sınıflar oluşturulabilir ve her sınıfın bir *play* metodu olur.

---

## 🧾 Interface Kullanımı

Müzik metotları, geliştiricilerin C#’ta çok biçimliliği kullanmasının tek yolu değildir. Geliştiriciler ayrıca metodun uygulamasını içermeyen  *interface* ’ler de oluşturabilir.

Bir  *interface* ’in ne olduğunu merak ediyor olabilirsiniz. Bir  *interface* , miras alan bir sınıfın uygulamak zorunda olduğu bir metot kümesini tanımlayan bir sözleşmedir ( *contract* ).

Interface’ler genellikle miras alan sınıfın hangi metotları uygulaması gerektiğini içerir; ancak uygulama kodunu içermez.

Örneğin, bir geliştirici müzik enstrümanı çalma için *public interface iPlayable* bildirimiyle bir interface oluşturur. Metot, bir alt sınıfın iş yapan somut bir metot oluşturmak için kullanabileceği, *Play* adlı boş bir metot içerir.

---

## 🎸 iPlayable Uygulayan Guitar ve Piano Sınıfları

Bu interface’i uygulamak için geliştirici, *iPlayable* interface’inden miras alan *Guitar* ve *Piano* adlı alt sınıflar oluşturur.

Sonra *play* metodunu *publicVoidPlay* olarak bildirir.

Metot, *Guitar* alt sınıfı için *the guitar is playing* mesajını ve *Piano* alt sınıfı için *the piano is playing* mesajını yazar.

Interface kullanımı, farklı sınıflar arasında metotların tutarlı biçimde kullanılmasını teşvik eder.

---

## ✅ Kapanış

Kapanış olarak, geliştiriciler alt sınıflar için uygulama ayrıntısı ( *implementation detail* ) eklemek istediklerinde taban sınıfları tasarlarken C#’ta *virtual* metotları kullanmalıdır.

C#’taki interface’ler ise, geliştiricilerin bir alt sınıfın uygulamak zorunda olduğu temel bir metot kümesi sağlamak istediği; ancak bu metotların neler içereceğine dair ayrıntı vermeye ihtiyaç duymadığı senaryolar için en iyisidir.

Her ikisi de C#’ta çok biçimliliği kullanmanın güçlü yollarıdır. C# programlarında çok biçimliliği nasıl uygulayacağımızı inceledik. Metotları geçersiz kılarak ( *overwriting* ) ve interface kullanarak çok biçimliliği nasıl uygulayacağımızı inceledik.

Çok biçimliliği anlamak, geliştiricilerin C#’ta esnek ve yeniden kullanılabilir kod yazmasına yardımcı olur.

---
