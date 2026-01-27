## 🧠 Code Optimization With Copilot

### 🎯 Temel Fikir

Yazılım geliştirme gibi rekabetçi bir alanda, temiz ve verimli kod yazmak ekip çalışmasını ve kod tabanının bakımını kolaylaştırır. Ancak kodunuzu performans ve okunabilirlik açısından optimize etmek zaman alabilir. İşte bu noktada Microsoft Copilot devreye girer. C# kodunuzu gerçek zamanlı olarak iyileştirmenize yardımcı olan sanal bir asistan gibi çalışır.

Bu videoda, Microsoft Copilot’u C# kodunu optimize etmek için nasıl kullanacağımızı açıklayacağız.

---

## 🤖 Microsoft Copilot Nedir?

Microsoft Copilot, geliştiricilere Visual Studio Code gibi bir kod düzenleyici içinde doğrudan kod önerileri sunarak yardımcı olan yapay zekâ destekli bir asistandır.

İster *refactor* yapmak, ister optimize etmek, ister yalnızca kodu daha okunabilir hâle getirmek isteyin, Copilot her adımda size yardımcı olabilir.

---

## 🛠️ Refactoring ile Kodu Yeniden Düzenleme ve Basitleştirme

Microsoft Copilot’un kodunuzu geliştirmenize yardımcı olmasının bir yolu, kodu yeniden düzenlemek ve basitleştirmektir. Buna *refactoring* de denir.

Örneğin, büyük ve karmaşık bir metodu daha küçük ve daha odaklı metotlara bölmek isteyebilirsiniz.

Bunu göstermek için, sipariş işleme sisteminizde **Process Order** adlı bir metodunuz olduğunu hayal edin; bu metod siparişi doğrulamadan onay göndermeye kadar her şeyi tek bir kod bloğunda yapıyor olsun. Bu, kısa sürede dağınık hâle gelir ve yönetmesi zorlaşır.

Microsoft Copilot’a, okunabilirliği ve sürdürülebilirliği artırmak için bu metodu refactor etmesini isteyerek bir *prompt* verebilirsiniz. Microsoft Copilot, metodu daha küçük ve daha odaklı metotlara bölmeyi önerir.

Bunu yapmak için, orijinal *process order* metodunu şöyle bölüştürebilirsiniz: müşterinin adresini doğrulama, kargo şirketini seçme ve kargo hesaplama işlemleri **Process Shipping** adlı ayrı bir metodun içine alınır.

Bu yeniden yapılandırma, kodu okumayı, bakımını yapmayı ve test etmeyi kolaylaştırır.

Refactoring kodu daha sürdürülebilir yapmak için kritiktir, ancak bu yalnızca işin bir parçasıdır.

---

## ⚡ Performans Optimizasyonu

İyi yazılmış kod aynı zamanda verimli çalışmalıdır. Microsoft Copilot’un refactoring’e nasıl yardımcı olduğunu gördük; şimdi C# kodunun performansını nasıl optimize edebileceğine bakalım.

Büyük bir koleksiyondaki öğeleri işleyen bir `foreach` döngünüz olduğunu düşünün ve her öğeyi işlemeden önce geçerli olup olmadığını kontrol ediyorsunuz. Koleksiyon büyükse bu döngü uygulamanızı yavaşlatabilir.

Microsoft Copilot’tan döngüyü daha iyi performans için optimize etmesini isteyebilirsiniz. Copilot, *parallel processing* (paralel işleme) önerebilir.

`Parallel.ForEach` fonksiyonu kullanılarak döngü aynı anda birden fazla iterasyonu çalıştıracak şekilde yeniden yazılır. Bu değişiklik çalışma süresini önemli ölçüde azaltabilir ve büyük veri kümeleriyle çalışırken kodunuzu daha verimli hâle getirir.

Performans optimizasyonu uygulamanızı daha hızlı yapabilir; ancak en verimli kod bile okunması zorsa üzerinde çalışmak zorlaşır.

---

## 🧾 Okunabilirliği Artırma

Şimdi Microsoft Copilot’u kod okunabilirliğini artırmak için nasıl kullanabileceğinize bakalım.

Diyelim ki belirsiz veya anlaşılması zor değişken adları kullanıyorsunuz. Örneğin, **GetTotal** adlı bir fonksiyondan gelen toplam öğe sayısını tutan `x` adlı bir değişkeniniz var.

`x` ismi yeterli bağlam sunmaz, bu da kodun anlaşılmasını zorlaştırır.

Kodu daha anlaşılır hâle getirmek için Microsoft Copilot’tan daha iyi değişken isimleri önermesini isteyebilirsiniz. Araç, `x` adını daha açıklayıcı bir isme, örneğin `total items` gibi bir ada dönüştürmenize yardımcı olabilir.

Bu küçük değişiklik bile okunabilirliği ciddi ölçüde artırabilir ve başkalarının kodu daha kolay anlamasını sağlar.

---

## 🧩 Etkili Prompt Yazımı İçin En İyi Uygulamalar

Microsoft Copilot’un refactor, optimizasyon ve okunabilirlik geliştirme konularında nasıl yardımcı olabileceğini öğrendiniz. Bu özelliklerden en iyi şekilde yararlanmak için  *prompt* ’larınızı etkili yazmanız önemlidir.

Microsoft Copilot kullanırken, önerilerin kalitesi çoğu zaman prompt’unuzun ne kadar açık ve spesifik olduğuna bağlıdır. İşte bazı en iyi uygulamalar:

* **Spesifik olun.** Genel yardım istemek yerine, tam olarak hangi sorunu veya hangi tür optimizasyonu istediğinizi belirtin. Örneğin, “Bu döngüyü performans için optimize etmenin bir yolunu öner” demek, “Bu kodu iyileştir” demekten daha hedefli öneriler sağlar.
* **Bağlam sağlayın.** Kodunuz bağımlılıklar içeriyorsa veya belirli koşullara dayanıyorsa, prompt’unuza bu bilgileri ekleyin. Bu, Microsoft Copilot’un kodunuzun daha geniş kapsamını anlamasına yardımcı olur.
* **Prompt’u geliştirmekten veya ek öneriler istemekten çekinmeyin.** Microsoft Copilot ile bir konuşma yapabilirsiniz. Bir şey net değilse veya daha fazla bilgiye ihtiyacınız varsa, araçtan isteyin; ihtiyacınız olan yanıtı alana kadar sizinle etkileşim kuracaktır.

---

## ✅ Kapanış

Bu videoda Microsoft Copilot’u C# kodunu optimize etmek için nasıl kullanacağımızı açıkladık.

Microsoft Copilot’u etkili şekilde kullanarak C# kodlarınızın  *okunabilirliğini* , *performansını* ve *sürdürülebilirliğini* geliştirebilirsiniz.

En iyi sonuçlar için prompt’larınızda spesifik olmayı ve bağlam sağlamayı unutmayın.
