## 🧪 Setting Up a Full-Stack Development Environment

Bu guided lab’de iki projemiz var. **set up full stack environment** adında bir klasör oluşturdum ve ardından step one’daki komutları kullanarak **backend** adında bir proje ve **frontend** adında bir proje oluşturdum.

İlk yaptığım şey, terminalde doğru klasörde olduğumdan emin olmaktı. Sonra step one’daki iki komutu çalıştırdım; bu komutlar iki projeyi kendi klasörleri içinde oluşturur ki bu önemli.

Yani step one: bu komutları kullanmak,  **.net new** .

---

## ✅ Step 2: Projeleri Doğrulama

Step two’da bizden projeleri doğrulamamız isteniyor. Talimatlara göre, herhangi birini çalıştırmak veya build etmek istiyorsanız, her birinin klasörünün içine girmeniz gerekiyor.

Örneğin frontend için:

```bash
cd frontend
dotnet --version
dotnet build
```

Backend için de aynı şeyi yaparsınız. Bunun için bir üst klasöre çıkıp backend klasörüne girersiniz:

```bash
cd ..
cd backend
dotnet --version
dotnet build
```

Ben burada onları ayrı ayrı çalıştırabilmek için iki terminal açıyorum: biri frontend için, biri backend için.

---

## ⚙️ Step 3: Back-End API’yi Ayarlama

Şimdi step three: backend API’yi kurmak.

API’de, burada **program.cs** var.

**builder** altında, bu zaten burada olmalı: `builder.Services` ve `var builder` ilk services satırının altında yer alan kodun bir parçası olmalı.

Bu arada, dosyada örnek kod olabilir. Ben tüm örnek kodu kaldırdım. Ama sahip olduğunuzdan emin olmanız gereken şeyler var:

* Buradaki **CORS** öğesi (çünkü client’tan server’a, yani frontend’den backend’e çağrı yapıyoruz)
* `var app` yani `app` tanımı (bu da varsayılan olarak burada olmalı)
* Ve `app.UseCors` eklediğinizden emin olmalısınız

Sonra **getRoute** da burada eklenir. Yani `UseCors`’un altına `getRoute` ekliyorsunuz; bu step three code sample’da var.

Yani şu şeylerin bu özel sırada olduğundan emin olun. Şunun şundan önce olduğundan ve buna benzer şeylere dikkat edin; ayrıca tüm `app` tanımlamalarının `app` değişkeni oluşturulduktan sonra geldiğinden emin olun.

Bu, step three.

---

## 🔌 Step 4: Veriyi Çekme

Step four’da veriyi alacağız. Burada frontend’e geçiyoruz.

Şimdi frontend kodundayız ve **Pages** klasörüne gidiyoruz. Bu lab için bir **Fetch.razor** sayfası oluşturuyoruz.

Bu koddaki dikkat edeceğiniz birkaç şey:

* Bu  **port** ’un doğru olduğundan emin olun
* Bazen uygulamanın hangi portta çalıştığını görmeniz gerekir

Bu yüzden önce server’ı çalıştırırsınız. Bunu yapmak için backend tarafındayken:

```bash
dotnet run
```

Yüklendikten sonra size port numarasını verecek.

Bende  **5092** . Bu yüzden bu sayının 5092 olduğundan emin olun. Lab için bunu “your port number” olarak bırakacağız sanırım ama port numarası yazmak isteyip istemediğinize bağlı; ben benimkini 5092 olduğu gibi bırakacağım.

Kodda doldurduğumuz tek şeyin bu olduğunu düşünüyorum. Sayfanın route’u  **/fetch** . Yani bunun doğru olduğundan emin olmanız gerekiyor.

Diğer her şeyin iyi olması gerekir.

---

## ▶️ Front-End’i Çalıştırma ve Sonucu Görme

Şimdi bunu çalışır hâle getirdiğimize göre, frontend’e geçip çalıştıracağım.

Frontend **5204** portunda çalışıyor. Onu açacağım ve nasıl göründüğünü göstereceğim.

Uygulama çalışıyor, şimdi route’umuz olan  **fetch** ’e gideceğim. Ve server tarafında tanımladığımız öğeleri içeri çekiyor.

Yani server tarafındaki route’ta olan öğeler—**laptop** ve  **phone** —tarayıcıda görüntülendi.

Lab’i bu şekilde kurarsınız.
