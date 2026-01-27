## 🛠️ Pratik Uygulama

Modern bir uygulama geliştirdiğinizi hayal edin; aynı anda birden fazla görevi ele alması gerekiyor—örneğin veri çekmek, dosyaları işlemek ve kullanıcı etkileşimlerine yanıt vermek. Uygulamanızın bu yük altında donmamasını veya yavaşlamamasını nasıl sağlarsınız? Anahtar, C#’ta **async** ve  **await** ’i ustalıkla kullanmaktır; bu araçlar, zaman alan işlemleri arka planda yürütürken uygulamanızın akıcı kalmasını sağlar.

Bu araçlar, bir orkestranın şefi gibidir; parça ne kadar karmaşık olursa olsun hiçbir ritmi kaçırmadan her bölümün uyum içinde çalmasını sağlar. Bu videoda, C# programlarında **async** ve  **await** ’i uygulayacağız. Pratik örneklerle, bu anahtar sözcüklerin gerçek dünya senaryolarında nasıl kullanıldığını öğreneceksiniz. **Async** ve  **await** , C#’ta asenkron programlamayı basitleştirmek için kullanılır.

 **Async** , bir metodu asenkron olarak işaretler.  **Await** , asenkron görevi çağıran metodun yürütmesini görev tamamlanana kadar duraklatır; ancak ana programı engellemez ve diğer kodları çalıştırmaya devam etmesine izin verir.

Asenkron işlemler C#’ta **Task** türünü kullanır. **Task** türü, ana programı engellemeden gelecekte yapılacak işi temsil etmenin bir yoludur. Henüz mevcut olmayan bir değer için bir yer tutucu ( *placeholder* ) gibi düşünün. Bu değer, bir hesaplamanın sonucu, bir dosya işlemi veya tamamlanması zaman alan başka herhangi bir eylem olabilir. Asenkron işlemleri gerçekleştirmek için **async** ve **await** anahtar sözcüklerini **Task** türüyle birlikte kullanırsınız.

---

## 🧪 Örnekler

Şimdi bu anahtar sözcüklerin C#’ta nasıl kullanıldığına dair bazı örnekleri inceleyelim. Bir gecikmeli işlemi simüle etmekle başlayacağız.

### ⏱️ Gecikmeli Bir İşlemi Simüle Etme

İlk olarak, **async** anahtar sözcüğünü kullanarak **SimulateDelay** adlı public bir asenkron task metodu tanımlayın. Metodun içinde, belirli bir süre boyunca görevi duraklatacak bir komutla **await** anahtar sözcüğünü kullanarak zaman alan bir işlemi simüle edin.

Bunu `Task.Delay(5000)` komutuyla yapabiliriz. Task nesnesindeki delay komutu, saniyenin 1/1000’i cinsinden sayılar alır. Gecikmeden sonra metot, konsola `"Operation completed after five seconds"` yazdırır.

Bu örnekteki gecikme, ana programı engellemeden bulut tabanlı bir veritabanından veri çekme gibi zaman alan bir görevi simüle eder.

---

## 📄 Dosya İşlemleri için `async` Kullanımı

Şimdi dosya işlemleri için  **async** ’in nasıl kullanılacağını inceleyelim. Dosya verisini almak bazen zaman alabilir ve bu işlemi arka planda yürütmek için **async** kullanabilirsiniz.

Bir dosyayı asenkron okumak için önce, dosya yolunu parametre olarak alan **ReadFileAsync** adlı public bir asenkron metot tanımlarsınız. Bu metotta, bir dosyadan veri okuyan birçok özel kod kullanacağız. Şu anda o özel koda odaklanmanız gerekmiyor; bu kodu yalnızca **await** anahtar sözcüğünün nasıl çalıştığını göstermek için kullanıyoruz.

Ardından, metodun içinde dosyayı açmak için bir **StreamReader** kullanın. Dosyanın tüm içeriğini asenkron olarak okumak için **ReadToEndAsync** ile birlikte **await** anahtar sözcüğünü kullanın. Son olarak, dosyayı okuduktan sonra metot dosya içeriğini konsola yazdırır.

Bu örnekte, **async** anahtar sözcüğü dosyayı arka plan görevinde alır; ancak **await** anahtar sözcüğü, program tüm dosyayı alana kadar içeriğin konsola yazdırılmamasını sağlar.

---

## 🔀 Tek Metotta Birden Fazla Asenkron İşlem

Bu örnekler, **async** ve **await** kullanarak tek bir işlem gerçekleştirmeyi gösterir. C#, tek bir metotta birden fazla asenkron işlem yapma ve bu işlemler tamamlanana kadar kontrolü çağıran metoda geri döndürmeme yeteneği de sağlar. Bunu gerçekleştirmek için  **async** ’in nasıl kullanılacağını inceleyelim.

Birden fazla asenkron işlemi eşzamanlı ele almak için önce **GetDataFromMultipleSources** adlı public bir asenkron metot tanımlayın. Ardından metodun içinde, her biri farklı bir API uç noktasından ( *endpoint* ) veri alan iki görev oluşturmak için **GetDataFromApiAsync** metodunu kullanarak iki task oluşturun.

Son olarak, her iki görevin de aynı anda tamamlanmasını beklemek için **await** anahtar sözcüğüyle birlikte **Task.WhenAll** kullanın. Her iki görev bittiğinde, her bir görevin sonuçlarını konsola yazdırın.

**WhenAll** kullanarak, yönetilen tüm işlemler tamamlanana kadar devam etmemesini asenkron işleme söylersiniz. Bu yaklaşım, ana programı engellemeden birden fazla asenkron işlemi verimli şekilde ele alır.

---

## 🧯 Asenkron İşlemlerde Hata Yönetimi

Tek bir metotta ne kadar çok asenkron işlem yaparsanız, bir şeylerin planlandığı gibi gitmeme olasılığı o kadar artar. Hata yönetimi, asenkron işlemlerinizin programınızda kritik hatalar oluşturmasını engeller.

**try-catch** bloğu adı verilen özel bir kod kullanabilirsiniz. **try-catch** bloğunu bir güvenlik ağı gibi düşünün. Çalıştırmak istediğiniz kod, bloğun **try** kısmına konur. Hatasız çalışırsa **catch** kısmı hiç çalışmaz. **try** kısmında bir hata oluşursa, **catch** kısmı hatayı yakalar ve onu ele almanıza izin verir. Bu, bir hata oluştuğunda programınızın bozulmasını önleyebilir.

**try-catch** bloklarını her türlü kodda kullanabilirsiniz; ancak bu hata yönetimi kodunu asenkron metotlarda uygulayan bir örnek kod parçasını inceleyeceğiz.

Asenkron bir metotta olası hataları ele almak için önce **GetDataWithHandling** adlı public bir asenkron metot tanımlayın. Ardından metodun içinde, istisnaları ( *exceptions* ) ele almak için bir **try-catch** bloğu kullanın.

**try** bloğunda bir **HttpClient** nesnesi oluşturun ve bir API’den veri çekmek için **GetStringAsync** ile birlikte **await** anahtar sözcüğünü kullanın. Sonuç başarılıysa veriyi konsola yazdırın. Bir **HttpRequestsException** oluşursa, **catch** bloğu istisna ayrıntılarıyla birlikte bir hata mesajı yazdırarak bunu ele alır.

C# **async** metotlarınızda **try-catch** blokları kullanarak, programınız hataları zarif bir şekilde ( *gracefully* ) ele alacaktır.

---

## ✅ Kapanış

Bu örneklerle, **async** ve  **await** ’in C# programlarında asenkron işlemleri yönetmeye nasıl yardımcı olabileceğini gördünüz. Bu kavramları pratik ederek, daha duyarlı ve daha verimli uygulamalar yazabileceksiniz.

Bu videoda, C# programlarında **async** ve  **await** ’i uygulamayı öğrendiniz. **await** ile birlikte **async** kullanmak uygulamalarınızı duyarlı hâle getirir. C#, tek bir metotta birden fazla asenkron işlem yapmanıza ve başka bir işlem gerçekleştirmeden önce bunların hepsi tamamlanana kadar beklemenize olanak tanır. Ayrıca asenkron işlemlerde hataları yakalayıp yönetebilirsiniz; böylece asenkron kodunuz verimli ve kesintisiz şekilde çalışmaya devam eder.
