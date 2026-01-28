## 🔄 Deserialization Kavramı

Bir uygulama kullandığınızda, genellikle tercihlerinizi veya nerede kaldığınızı hatırlar. Bunun nedeni, uygulamanın *deserialization* adı verilen bir süreçle verinizi kaydedip daha sonra yeniden kullanabilmesidir. Bu, kaydedilen verinin uygulama tarafından geri yüklenip kullanılabilmesini sağlar. Bu videoda, .NET’te nesnelerin deserialization sürecini açıklayacağız.

---

## 🧩 Serialization ve Deserialization İlişkisi

Serialization’ın, bir nesneyi kolayca depolanabilecek ve iletilebilecek bir formata dönüştürme süreci olduğunu hatırlayın.

Deserialization ise bunun tersidir; serialize edilmiş veriyi tekrar nesnelere dönüştürme sürecidir.

---

## 🧠 Deserialization Ne Sağlar?

Deserialization, bir uygulamanın kaydedilmiş veya iletilmiş veriyi alıp kullanılabilir bir şeye dönüştürmesini sağlar.

Bir uygulama veri kaydettiğinde, bunu depolanabilecek veya gönderilebilecek bir formata dönüştürür.

Uygulama yeniden açıldığında, deserialization bu veriyi profiliniz veya uygulama ayarlarınız gibi orijinal formuna geri çevirir.

Uygulamalar kaydedilmiş veriyi bu şekilde yeniden kullanır.

Şimdi deserialization’ın .NET framework içinde nasıl çalıştığını ve kaydedilmiş veya dış kaynaklı verilerle çalışmak için neden önemli olduğunu inceleyelim.

---

## 🧱 .NET’te Deserialization Neden Önemlidir?

.NET’te deserialization, daha önce kaydedilmiş nesneleri geri yüklemek için gereklidir; örneğin bir kullanıcı uygulamaya yeniden giriş yaptığında profili geri yüklenir.

Ayrıca web API’lerinden gelen *JSON* gibi dış verileri—uygulamaların bilgi paylaşmasını sağlayan bir servis—uygulamanın üzerinde çalışabileceği nesnelere dönüştürmeye yardımcı olur.

Deserialization, veri formatlarını uygulamanın kullanabileceği bir şeye dönüştürür; örneğin JSON verisini bir kullanıcı profiline çevirmek gibi.

---

## 🧾 JSON, XML ve Binary ile Deserialization

*JSON* (JavaScript Object Notation), uygulamaların veri alışverişi için kullandığı basit bir metin formatıdır.

JSON, kullanıcı detayları gibi basit verileri değiştirmek (exchange) için kullanılır; çünkü uygulamalar için okuması hızlı ve kolaydır.

*XML* başka bir veri formatıdır ve daha yapılandırılmış veriyle çalışabildiği için uygulama ayarları gibi daha detaylı bilgiler için kullanılır.

*XML* (Extensible Markup Language), uygulama ayarları gibi daha karmaşık verileri düzenlemek için etiketler (tags) kullanır.

Son olarak, *binary deserialization* genellikle verimlilik kritik olduğunda kullanılır; örneğin büyük veri kümeleriyle veya hızlı performans gerektiren karmaşık nesnelerle çalışırken.

---

## 🌍 Gerçek Dünya Örneği

Deserialization, gerçek dünya uygulamalarında sürekli olan bir süreçtir.

Örneğin, kapanmadan önce bir kullanıcının tercihlerini kaydeden bir web uygulamasını düşünün.

Bu tercihler  *JSON* , *XML* veya binary veri gibi bir formata serialize edilir ve sonra kaydedilir.

Kullanıcı uygulamayı yeniden açtığında, deserialization kaydedilmiş veriyi tekrar ayarlara dönüştürür; böylece uygulama yeniden kullanılabilir.

Bu süreç serialization’ı tersine çevirir ve depolanmış veriyi tekrar kullanılabilir hâle getirir.

---

## ✅ Video Özeti

Bu videoda, .NET’te nesnelerin deserialization sürecini ve uygulamalarda veriyi geri yüklemek için neden önemli olduğunu öğrendiniz.

Veri  *JSON* ,  *XML* , *binary* veya başka bir formatta kaydedilmiş olsun, deserialization verinin tekrar saklanabilmesini ve yeniden kullanılabilmesini sağlar.
