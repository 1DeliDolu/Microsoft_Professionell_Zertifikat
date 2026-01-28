## 🧩 Dependency Injection Kavramı

Kodunuzu farklı parçalardan oluşan bir makine gibi düşünün. Bir parçayı değiştirmek diğerlerini etkileyebilir.  *Dependency Injection* , kod parçalarını ayrı tutmaya yardımcı olur; böylece başka parçalarla değiştirilebilir veya güncellenebilirler ve bu, kodun geri kalanını bozmadan yapılabilir.

Bu videoda,  *ASP.NET Core* ’da *Dependency Injection* kavramını açıklayacağız.

---

## 🧱 Dependency ve Service Nedir?

Dependency Injection’ı konuşmadan önce, dependency’lerin ve service’lerin ne olduğundan bahsedelim.

Yazılımda bir  *dependency* , bir class’ın veya fonksiyonun görevlerini yerine getirmek için güvendiği dış bir nesne veya servistir.

Dependency bir nesne olduğunda, o nesneye *service* denir.

Bir  *service* , başka bir class veya fonksiyon için bir fayda (utility) sağlayan bir nesnedir.

Örneğin, API route’larımızdan birinin, request geldiğinde authentication ve authorization işlemlerini yapan bir service’e erişmesi gerekebilir.

Bu service, API route’umuzun bir dependency’sidir.

Ve bu service, authentication ve authorization yapabilen bir nesnedir.

---

## ⚠️ Service’i Elle Oluşturmanın Sorunu: Tight Coupling

Service oluşturmanın en basit yolu, API route’un içinde o nesnenin bir instance’ını manuel olarak oluşturmaktır.

Ama bu, *tight coupling* denen bir probleme yol açar; service’te yaptığınız değişiklikler kodunuzun diğer bölümlerini bozabilir.

Eğer bu service’e ihtiyaç duyan 100 route’unuz varsa, bu aynı zamanda şu anlama gelir: Bir route’taki kodu değiştirmek istiyorsanız, diğer 99 yerde de değiştirmeniz gerekir.

Ayrıca her route’un saatte binlerce kez çağrıldığını düşünün.

Bu, API route’larımız her çağrıldığında bu nesnenin yeni bir instance’ının oluşturulduğu anlamına gelir ki bu ciddi performans etkileri doğurur.

---

## 🔓 Çözüm: Loose Coupling

Service’leri manuel olarak instantiate etmenin sorunlarını anladığımıza göre, şimdi bu sorunları *loose coupling* kullanarak nasıl çözebileceğimizden biraz daha bahsedelim.

 *Loose coupling* , bileşenlerin minimal dependency’ye sahip olduğu bir tasarım prensibidir; böylece bir bölümde yapılan değişiklikler diğerlerini çok az etkiler.

Bu esnekliği ve sürdürülebilirliği artırır ve sistemi değişikliklere karşı daha dayanıklı hâle getirir.

Authentication örneğimize geri dönelim.

Kullanıcılar login olduğunda doğrulama yapması gereken bir uygulama üzerinde çalıştığınızı hayal edin.

Authorization service’in bir instance’ını doğrudan oluşturmak yerine, uygulama bir `IAuth` service interface’i kullanır.

Buradaki kilit nokta şudur:

Uygulama authentication’ın nasıl gerçekleştiğini umursamaz.

Sadece `IAuth` service interface’ini uygulayan bir service kullanacağını bilir.

`IAuth` service, “bu kullanıcıyı authenticate etmem gerekiyor” diyen genel bir kontrattır; örneğin bir veritabanını kontrol etmek gibi implementation detaylarını belirtmez.

---

## 🧬 Dependency Injection Nedir?

Bileşenler arasındaki tight coupling’i azaltmak ve kodu daha modüler, test edilebilir ve sürdürülebilir yapmak için *dependency injection* kullanırız.

*Dependency injection* (DI), nesnelerin dependency’lerini içeride oluşturmak yerine dış bir kaynaktan almasıyla çalışan bir design pattern’dir.

---

## ✅ Dependency Injection’ın Faydaları

Dependency injection ile, gerçek authentication mantığını dışarıdan sağlayarak loosely coupled bir yapı elde edersiniz.

Bu injection’da DI faydalıdır; çünkü uygulama authentication detaylarını yönetmek veya bilmek zorunda değildir.

Sadece DI üzerinden sağlanan service’e güvenir.

---

## ⚡ Performans Artışı

DI’nin bir diğer faydası performansın artmasıdır.

Dependency injection ile bir service instance’ının ne zaman ve nasıl oluşturulacağını seçebiliriz.

Belki request’leri handle etmek için tek bir nesneye ihtiyacımız vardır.

Ya da belki her kullanıldığında yeni bir instance gerekir.

Ama API route’umuz bunların hiçbirini düşünmek zorunda değildir.

DI’yi kurarken bunun kararını biz veririz.

Yeni instance sayısını azaltmak performansı artırır.

---

## 🛠️ Daha Kolay Bakım ve Değiştirilebilirlik

DI’nin son faydası, daha sürdürülebilir (maintainable) olmasıdır.

Yine, tek bir dependency’ye bağlı birçok route varsa, değişikliği yalnızca tek bir yerde yapmanız gerekir.

Bu da kodunuzu daha sürdürülebilir yapar.

DI’yi authentication metodunu değiştirmek için de kullanabiliriz.

Diyelim ki veritabanı tabanlı authentication’dan API tabanlı authentication’a geçmeye karar verdiniz.

Uygulama yalnızca `IAuth` service interface’ine, yani genel kontrata bağımlı olduğu için, core application logic’i değiştirmeden yeni API tabanlı authentication service’i inject edebilirsiniz.

DI’nin sağladığı esneklik, örneğin authentication mantığı gibi bir bölümde yapılan değişikliğin sistemin geri kalanını etkilememesini sağlar.

Bu, daha önce konuştuğumuz  *loose coupling* ’dir.

Loose coupling, sürdürülebilirliği ve uyarlanabilirliği artırır; veritabanından API’ye geçmek gibi güncellemeleri sorunsuz ve verimli hâle getirir.

---

## ✅ Kapanış

Bu videoda dependency injection, loose coupling ve bunun maintainability’yi nasıl geliştirdiğini öğrendiniz.

Dependency injection ile authentication gibi service’leri, core application logic’inizi yeniden yazmadan güncelleyebilirsiniz.

Bu da kodunuzu esnek tutar ve uzun vadede yönetimini kolaylaştırır.
