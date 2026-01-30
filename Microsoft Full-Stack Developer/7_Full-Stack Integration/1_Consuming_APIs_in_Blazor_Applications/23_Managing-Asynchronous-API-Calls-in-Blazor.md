## 🔄 Blazor’da Asenkron API Çağrılarını Yönetme

Blazor uygulamasında API çağrıları yaparken bazen işler ters gidebilir ve bazen de çağrılar gecikebilir; çünkü internet üzerinden istek atıyorsunuz. Bazen alıcı tarafta, yani API tarafında bir sorun olur. Bazen de uygulamanızda bir problem vardır.

Bu bölümde, API’ye çağrı yapılırken arayüzün bloklanmaması için asenkron çağrıları nasıl kullanabileceğinizi göstereceğiz. Yani çağrı arka planda gerçekleşir. Ayrıca, API çağrısında bir şeyler ters giderse bu durumlarla nasıl başa çıkabileceğinizi de göstereceğiz.

---

## 🧩 Basit Uygulama Yapısı

Diğer ekran kayıtlarında da kullandığımız basit bir Blazor uygulamam var. Bu uygulama temelde `typical.com` adlı bir API’den veri çekiyor ve bunu `FetchData.razor` dosyamızın üst kısmındaki bir nesneye yüklüyor.

Burada bazı HTML’lerimiz var. `FetchUsers` metodunu çağıran bir buton var; bu metod da `@code` bloğumuzun içinde.

`FetchUsers` metodu API’ye çağrı yapıyor ve API’den JSON formatında bir veri paketi alıyor. Yani bu butona her tıkladığımızda dışarı çıkıp o veriyi getirmeye çalışacak.

Veri çekildikten sonra bunu bir nesnenin içine yerleştiriyor; bunu da `@code` bloğunda oluşturduk.

Bir `user` nesnemiz var ve bu nesne bir `address` nesnesi kullanıyor. API’den JSON formatında dönen veriyi bu `user` nesnesi üzerinden bir `users` listesine dolduracağız.

Çağrı yapıldığında bu gerçekleşiyor ve `user` nesnesi doldukça, bu veriler web sayfamızdaki HTML öğelerinde görünüyor.

---

## ⏳ Spinner ve Hata Mesajı Eklemek

Bir spinner ekledim. Veri yüklenirken, API’ye istek atıldığını simüle ediyoruz. Veri yüklenirken API çağrısının dönmesini bekliyoruz. Bu sırada bir “loading message” gibi bir şey yerine küçük bir spinner görerek bir şeylerin olduğunu anlayacağız.

Ayrıca bir hata mesajı da ekledim; çağrıda bir şey ters giderse göstermek için.

`FetchUsers` metodunda bir hata simüle etmek istiyorum ki böyle bir durumda hatayı nasıl yöneteceğimizi gösterebilelim.

Bir randomizer var: butona tıkladığımda bazen gerçek, canlı API’ye gidiyor ve veri döndürüyor; bazen de geçersiz (invalid) bir endpoint’e gidiyor.

Geçersiz endpoint’e gittiğinde veri almaya çalışıyor ama endpoint bulunamadığı için hata üretiyor; `catch` bloğuna düşüyor, bir exception yakalanıyor ve bu da error message’ı dolduruyor. Böylece bir şeylerin ters gittiğini, hatanın üretildiğini görebiliyoruz.

Gerçek dünyada bu tabii ki birçok farklı şey olabilir. Endpoint down olabilir. İnternet trafiği çok yoğun olabilir ve işlem çok uzun sürebilir. Dolayısıyla, kullanıcıya “bir şeyler yanlış gitti, tekrar dene” demek isteyeceğiniz çeşitli exception senaryolarını düşünebilirsiniz.

Sonra API’nin çalıştığından emin olmak için diğer kontrol mantığımız var.

---

## ▶️ Uygulamayı Çalıştırma ve Hata Senaryosunu Görme

İlk yapacağım şey, uygulamayı çalıştırıp hem hata üretildiğinde hem de doğru şekilde tamamlandığında nasıl davrandığını göstermek.

Uygulamayı çalıştıralım. O sayfaya gideceğim; `fetch data` route’una gitmemiz gerekiyor.

Butonumuz var ve daha tıklamadık, yani elimizde veri yok.

Butona tıklıyorum ve ne olacağına bakıyorum.

İlk çağrıda dışarı çıkıp veriyi buldu. Tekrar tıklıyorum; doğru URL’ye gitti.

Bu sefer butona tıkladığımda randomizer onu geçersiz endpoint’e gönderdi. Hata mesajını görüyoruz: `Error fetching data, response status code does not indicate success.`

Yani URL endpoint’i bulunamadı ve bunu kullanıcıya gösterebiliriz.

API çağrısıyla ilgili problemleri bu yöntemle yönetebiliriz.

Gerçek dünyada şöyle bir şey yapabilirim: “Veriyi alırken bir sorun oluştu, tekrar dene” diyebilirim; kullanıcı butona tekrar basar ve bir noktada başarılı bir çağrı alır çünkü doğru API’ye gider.

Uygulamaya geri dönelim. Bu, asenkron çağrılarda sorunları yönetmenin bir yolu.

Asenkron çağrıda bir sorun varsa, bunu yakaladığınızdan ve düzgün şekilde ele aldığınızdan emin olmak istersiniz.

---

## 🐢 Gecikmeyi Simüle Etme ve UI Tepkiselliğini Gösterme

Şimdi yapmak istediğimiz diğer şey, asenkron çağrıların bilgiyi işlerken kullanıcıya web sayfasıyla etkileşim kurmaya devam etme imkânı verdiğini göstermek.

Uygulamayı `Ctrl + C` ile durduracağım ve sonra bir gecikme ekleyeceğim. Bu iki saniyelik bir gecikme.

Bu bir simülasyon ama gerçek dünyada bazı API’ler daha yavaştır; bazen veri çekilmesi uzun sürebilir. Özellikle API tarafında işlem yapılması gerekiyorsa bu daha belirgin olur.

Karmaşık bir sorgu gönderdiğinizde veya veri uzun süreli depolamadan çekilecekse, verinin dönmesi zaman alabilir. Ben de bunu gecikmeyle simüle edeceğim.

Veri alınırken spinner görünecek. Spinner, veri yüklenirken gerçekleşir. Ekranda bu spinner’ı görmeliyiz; ardından API çağrısı tamamlanacak ve spinner kaybolacak.

Uygulamayı tekrar çalıştıracağım, sayfaya geri dönüp yenileyeceğim.

Şimdi veriyi çekeceğiz ve spinner’ın iki saniye boyunca ekranda görünüp ardından çağrının tamamlandığını görebilirsiniz.

Bu, kullanıcıların bir şey olurken uygulamayla etkileşime devam edebilmesi için iyi bir yöntemdir.

Kullanıcıya bir şeylerin çalıştığını ve sistemin işlem yaptığını hissettirir.

---

## 🧭 Asenkron Çağrılarla Sayfayla Etkileşim Devam Eder

Şunu fark edin: Bu bir async çağrı olduğu için, butona bastığımda spinner ekrandayken uygulamayla hâlâ etkileşim kurabiliyorum.

Örneğin, API çağrısı hâlâ veri almaya çalışırken `ASP.NET About` sayfasına gidebildiğimi görebilirsiniz.

Bu, çağrının async olmasından kaynaklanır. Async çağrı, veri alınmaya çalışılırken bile sayfayla etkileşimi sürdürmemizi sağlar.

Ayrıca, sayfaya geri döndüğümde verinin alınmış olduğunu ya da bir hata oluştuğunu görebilirsiniz; çünkü ben web sayfasıyla etkileşim kurabilmiş olsam bile çağrı arka planda çalışıyordu.

Bu, API çağrıları kullanırken önemli bir özelliktir.

Async yaklaşım kullanmak, veri çekmek için iş yapılırken bile uygulamanızın tepkisel kalmasını sağlar.

Bu yöntemleri kullanarak uygulamanızı tepkisel ve yönetilebilir biçimde geliştirmeye devam edebilir, kullanıcılarınızı gerçekten memnun eden bir uygulama oluşturabilirsiniz.
