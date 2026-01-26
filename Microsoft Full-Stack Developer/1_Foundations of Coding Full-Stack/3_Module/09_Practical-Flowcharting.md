## 🧭 Pratik Akış Şeması Oluşturma

Son çevrimiçi sipariş verdiğiniz zamanı düşünün. Yalnızca birkaç kullanıcı eylemiyle siparişiniz işleme alınır ve size doğru yola çıkar. Ancak bu basit eylemlerin arkasında, ödemeyi doğrulama, envanteri kontrol etme ve kargoyu hesaplama gibi karmaşık bir dizi adım vardır. Akış şemaları, bu karmaşık süreçleri basitleştirerek onları net ve yönetilebilir adımlara dönüştürür.

Bu videoda, kavramsal bir programın mantığını görselleştirmek için akış şemaları oluşturacağız.

---

## 🔐 Örnek: Basit Bir Giriş Yapma Süreci Akış Şeması

Basit bir giriş yapma sürecine ait örnek bir akış şemasını inceleyelim. Akış şeması, bir kullanıcının bir uygulamaya giriş yapmak için attığı adımları temsil edecektir.

Akış şemasını, sürecin başladığını belirtmek için bir **oval** ile başlatın. Oval şekil, akış şemasının başlangıç noktasını temsil eden evrensel bir akış sembolüdür.

Akış şemasında bir sonraki adıma geçmeden önce, sıranın hangi yöne aktığını belirtmek için bir **ok** kullanarak bir sonraki adıma işaret etmek isteyeceksiniz. Akış şemanızı oluştururken, bir sonraki adıma doğru akışı belirtmek için yön oklarını kullanmaya devam edin.

Bu örnekte süreç akışı aşağı yönlü ilerlediği için, ovali dikdörtgene bağlayan okun ucu aşağı doğru konumlandırılmıştır.

Artık akışı belirlediğinize göre, program sırasındaki ilk süreci belirtin. Bir süreci göstermek için evrensel akış şeması sembolü olan **dikdörtgeni** kullanın.

Bu örnekte,  **giriş formunu görüntüleyin** .

Sıradaki süreci, eylemi belirtmek üzere yine bir dikdörtgen kullanarak düşünün; bu örnekte eylem **kimlik bilgilerini girmek**tir.

Kullanıcı kimlik bilgilerini girdikten sonra ne olur? Sıradaki adım, kullanıcıların giriş kimlik bilgilerini girdikleri formu göndermektir. Bu süreci belirtmek için **Submit form** yazılı bir dikdörtgen kullanın.

Sıradaki dizide, üzerinde **validate credentials** yazan ve sonunda soru işareti bulunan elmas şekilli sembole dikkat edin.

Burası kararın verilmesi gereken yerdir ve bu durumda program, giriş kimlik bilgilerinin geçerli olup olmadığına karar verecektir. Bu, iki yolun kullanıcıyı farklı eylemlerden geçireceği bir yol ayrımı olarak kabul edilir.

Kimlik bilgileri geçerliyse, **yes** ile temsil edilen yol sağa doğru devam eder. Kimlik bilgileri geçerli değilse, **no** ile temsil edilen yol sola doğru devam eder.

Kullanıcının kimlik bilgilerinin geçerli olduğunu varsayalım. Sağdaki yolu takip ederek, süreçteki bir sonraki adım kullanıcının uygulamaya giriş yapabilmesini belirtir.

Şimdi de kullanıcı giriş kimlik bilgilerinin geçerli olmadığını varsayalım; bu durumda süreçteki bir sonraki adım **bir hesap oluşturmak**tır.

Giriş yapma sürecinin başladığı akış şemasının en üstüne geri dönen dikey çizgiye dikkat edin. Hesap oluşturması gereken kullanıcılar için akış, programın kullanıcının kimlik bilgilerini doğrulayacağı aynı karar noktasından tekrar geçerek devam eder.

Giriş kimlik bilgilerinin geçerli olduğu varsayıldığında, kullanıcı artık giriş yapabilecektir.

Akış şeması, başladığı şeklin aynısı olan bir **oval** ile biter; üzerinde **log in process complete** yazan bu oval, sürecin tamamlandığını gösterir.

---

## ✅ Kapanış

Bu videoda, kavramsal programların mantığını görselleştirmek için akış şemalarının nasıl oluşturulacağını öğrendiniz. Kavramsal programların mantığını görselleştirmek için akış şemaları oluşturmak, geliştiriciler için temel bir beceridir.

Bir uygulamaya giriş yapmak veya sıralama algoritmaları gibi süreçleri temsil etmek için akış şemalarını kullanarak, karmaşık mantığı basitleştirebilir ve etkili biçimde iletebilirsiniz.
