## 🐞 Asenkron Programları Hata Ayıklama ve Oluşturma

Bu laboratuvarda, bir asenkron işlemi simüle edip gösterebilmemizi sağlayacak basit bir uygulama ile çalışacağız. Bir sunucuya veri gidip gelmesini simüle etmek için **Task.Delay** kullanacağız; ancak bu gecikme sadece asenkronun nasıl çalıştığını göstermek içindir.

Ayrıca `.NET new console` şablonunu kullanarak oluşturduğum basit bir konsol uygulamasını kullanacağız. Birinci adımda **async** ve **await** anahtar sözcüklerini gözden geçiriyoruz. Bunlar, işlemleri arka planda gerçekleştirmemizi ve uygulamayı diğer işler yapmaktan alıkoymadan ( *block etmeden* ) çoklu görev yapmamızı sağlar.

Dolayısıyla sunucudan veri almak zorunda olduğumuzda veya veri işleme gibi uzun süren bir süreç olduğunda, bunu asenkron olarak yapabiliriz; böylece kullanıcı uygulamanın diğer bölümünde UI ile etkileşime girebilir, kaydırabilir ( *scroll* ), vb. Bu yöntemler, programlama yaparken kullanabileceğiniz çok güçlü ve modern tekniklerdir.

---

## 🧱 2. Adım: Asenkron Metodu Uygulama

İkinci adımda asenkron metodu uygulayacağız. Benim uygulamamda üzerinde çalıştığım tek dosya **Program.cs** ve burada **performLongOperationsAsync** adlı metodum var.

Burada **async** ve **Task** anahtar sözcüklerini kullanıyoruz; bunlar asenkron işlemler gerçekleştirirken önemli. Böylece programa şunu belirtmiş oluyoruz: bunlar asenkron işlemler ve bu işlemlerle çalışırken bir **Task** oluşturmanı istiyoruz.

Birden fazla task oluşturup sonra onları yönetebileceğiniz için bunu **Task** olarak belirtiriz. Bu metot çok basit: konsola bir işlemin başladığını yazar. Yaklaşık üç saniyelik bir gecikme veririz ve sonra işlemin tamamlandığını yazarız.

**await Task.Delay** satırının olduğu yeri, bir sunucuya gidip veri aldığınız veya kullanıcı uygulamanın başka bir yerinde çalışırken büyük miktarda veriyi işlediğiniz uzun süren bir işlem gibi düşünebilirsiniz.

**await** kullandığımızda, **Task** anahtar sözcüğünü ve Task nesnesindeki **Delay** metodunu bu gecikmeyi simüle etmek için kullanıyoruz.

---

## ▶️ 3. Adım: Asenkron Metodu Çağırma

Üçüncü adımda asenkron metodu çağıracağız. Kodumu aşağıya, programımızdaki **Main** metodunun olduğu yere taşıyacağım.

Burası, **Main** metodunun içinde tekrar Task nesnesini kullanarak metodu çağırdığımız yer. Ayrıca **async** anahtar sözcüğünü kullanıyoruz ve **await** etmesini söylüyoruz; başka bir ifadeyle **perform long operation async** metodu dönene kadar beklemesini istiyoruz.

Yani o iş bitene kadar bekle, sonra bir sonraki satıra geç; bu örnekte sadece **main method completed** yazdırıyoruz. **await** ile kullanılan **Task.Run** bir sonraki satıra, task tamamlanmadan geçmez.

Arka planda çalışıyor olsa bile, o **Console.WriteLine** satırını çalıştırmadan önce bekleyecektir. Uygulama çalıştığında programımızın **Main** metodu çalışır. O işlemi çalıştırır.

Şimdi bunu çalıştıralım; konsolda bu mesajları görmemiz gerekir. **perform long operations async** içinde aşağıda **Operation started** mesajını görüyoruz. Gecikmeden sonra **Operation completed** geliyor ve sonra **Main method completed** satırı çalışıyor.

Yani uygulama beklendiği gibi çalıştı ve asenkron işlemi simüle etti.

---

## 🧯 4. Adım: Hata Yönetimi Eklemek

Dördüncü adımda bu metoda biraz daha ekleyeceğiz ve hataları ele alacağız.

Ben bunu aşağıda **perform long operations two** adlı ayrı bir metot olarak zaten yazdım ve bu metotta **try-catch** bloğu var. **try** bloğu önce çalışır ve o kod bloğundaki tüm işlemleri yapmayı dener. Bir şey ters giderse **catch** bloğu çalışır ve ne olduğunu bize söyler.

Bu örnekte istisnayı **ex** değişkeninde yakalıyoruz ve sonra bu istisnanın mesajını yazdırıyoruz. **try** bloğunda, bir istisna fırlatmak için **throw** anahtar sözcüğünü kullanıyoruz.

Elbette gerçek bir programda bunu yapmak zorunda değiliz. Bu bir simülasyon; hata ürettiğimizde ne olacağını göstermek için. Bu **throw** satırı hatayı simüle eder.

Gerçek bir uygulamada bunu yorum satırı yapabiliriz. Bazı durumlarda bir istisna fırlatmak isteyebilirsiniz ki oluşan bir hatayı yakalayabilesiniz; ama burada yalnızca hatayı simüle etmek için kullanıyoruz.

Burada görmemiz gereken şey:  **Operation started** . **Operation completed** satırına hiç ulaşmamalıyız. Bu satır biraz sönük görünüyor çünkü Visual Studio Code bunun asla çalışmayacağını söylüyor; çünkü her zaman `throw new exception` satırına gelmeden **Console.WriteLine** satırına ulaşamayacak.

Yani konsolda  **Operation started** , sonra hatanın ne olduğuna dair mesajla  **An error occurred** , ardından **Main method completed** görmeliyiz.

Şimdi metodumu, hata yönetimi olan ikinci metodu çağıracak şekilde değiştireceğim. Tekrar çalıştıracağım.

 **Operation started** . Bir **simulated error** mesajı görüyoruz ve ardından  **Main method completed** .

Tüm kodumuz çalıştı. Üretilen mesajda simüle edilmiş hata var; çünkü **throw** komutuna “simulated error” verdik, dolayısıyla çıkan mesaj da bu.

Gerçek dünya senaryosunda  **ex** , uygulamada oluşan gerçek hatayı yakalardı.

---

## ✅ Kapanış

Yani **async** kullanarak, bir uygulamanın arka planda çalışması nasıl olurdu bunu simüle edebilirsiniz.  **async** , **Task** ve **await** anahtar sözcüklerini kullanarak arka planda işlemler yapan metotlar oluşturabilirsiniz; bu da daha iyi bir kullanıcı deneyimi sağlayabilir.
