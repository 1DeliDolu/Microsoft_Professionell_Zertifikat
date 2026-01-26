## 🧩 Kontrol Yapıları ve Döngülerin Entegre Kullanımı

### 🎯 Amaç

Bu etkinliğin sonunda, pratik kodlama problemlerini çözmek için *if-else* ve *switch* kontrol yapılarını döngülerle birleştirebileceksiniz. Döngüler içinde karar verme süreçlerini yönetmek için bu yapıları entegre eden basit programlar yazacaksınız.

---

## ✅ Adım 1: Döngülerle *If-Else* Entegrasyonu

Kullanıcıdan 1 ile 10 arasında bir sayı girmesini tekrar tekrar isteyen ve sayının **çift** olmasını sağlayan bir program oluşturun. Döngü, kullanıcı geçerli bir giriş yapana kadar devam etmelidir ve geçerliliği kontrol etmek için bir *if-else* ifadesi kullanılmalıdır.

### 📌 Yönergeler

* 1 ile 10 arasında **çift** bir sayı istemek için sürekli olarak kullanıcıya istem göstermek üzere bir *do-while* döngüsü kullanın.
* Döngünün içinde, sayının çift olup olmadığını ve 1 ile 10 arasında bulunup bulunmadığını doğrulamak için bir *if-else* ifadesi kullanın.
* Girdi geçerliyse, sayıyı yazdırın ve `break` ifadesini kullanarak döngüden çıkın. Geçersizse, bir hata mesajı gösterin ve istemi tekrar edin.

Kodunuzu doğrudan **Dot Net Fiddle** içinde taslak hâlinde yazıp çalıştırabilirsiniz; bu, .NET projeleri için basit bir çevrim içi editördür. İsterseniz Notepad veya Visual Studio Code gibi bir metin editörü de kullanabilirsiniz; ancak DotNetFiddle, kodunuzu hızlıca test edip çalıştırmak için harikadır. Cevabınızı kontrol etmek için  **Dot Net Fiddle** ’a gidin, sayfadaki kodu silin, kodunuzu sol tarafa yapıştırın ve *run* seçeneğini seçin. Kodu çalıştırdığınızda bir hata alırsanız, kodunuzu doğru cevapla karşılaştırmak için bir sonraki sayfadaki okumaya gidin.

---

## 🏫 Adım 2: Notları Değerlendirmek için *If-Else* Kullanma

Bir öğrenci notları listesini değerlendirmek için bir *for* döngüsü ve bir *if-else* yapısı kullanan bir program yazın. Her not için, not değerine göre öğrencinin geçip geçmediğini belirleyin.

### 📌 Yönergeler

* Öğrenci notlarını içeren `"grades"` adlı bir dizi tanımlayın.
* Dizideki her not üzerinde yineleme yapmak için bir *for* döngüsü kullanın.
* Döngünün içinde, her notun 65’e eşit veya büyük olup olmadığını kontrol etmek için bir *if-else* ifadesi kullanın. Not geçerliyse `"Pass"`, değilse `"Fail"` yazdırın.

Kodunuzu doğrudan **Dot Net Fiddle** içinde taslak hâlinde yazıp çalıştırabilirsiniz; bu, .NET projeleri için basit bir çevrim içi editördür. İsterseniz Notepad veya Visual Studio Code gibi bir metin editörü de kullanabilirsiniz; ancak DotNetFiddle, kodunuzu hızlıca test edip çalıştırmak için harikadır. Cevabınızı kontrol etmek için  **Dot Net Fiddle** ’a gidin, sayfadaki kodu silin, kodunuzu sol tarafa yapıştırın ve *run* seçeneğini seçin. Kodu çalıştırdığınızda bir hata alırsanız, kodunuzu doğru cevapla karşılaştırmak için bir sonraki sayfadaki okumaya gidin.

---

## 🛒 Adım 3: Döngülerle *Switch* İfadelerini Entegre Etme

Birden fazla siparişi durumlarına göre işleyen bir program oluşturun. Her sipariş `"Pending," "Shipped," "Delivered,"` veya `"Cancelled"` olabilir ve program her siparişin durumuna göre bir mesaj yazdıracaktır.

### 📌 Yönergeler

* `"Pending," "Shipped," "Delivered,"` ve `"Cancelled."` durumlarını içeren `"orderStatuses"` adlı bir dizi tanımlayın.
* Sipariş durumları listesini dolaşmak için bir döngü kullanın.
* Döngünün içinde, sipariş durumuna bağlı olarak farklı bir mesaj yazdırmak için bir *switch* ifadesi kullanın.

Kodunuzu doğrudan **Dot Net Fiddle** içinde taslak hâlinde yazıp çalıştırabilirsiniz; bu, .NET projeleri için basit bir çevrim içi editördür. İsterseniz Notepad veya Visual Studio Code gibi bir metin editörü de kullanabilirsiniz; ancak DotNetFiddle, kodunuzu hızlıca test edip çalıştırmak için harikadır. Cevabınızı kontrol etmek için  **Dot Net Fiddle** ’a gidin, sayfadaki kodu silin, kodunuzu sol tarafa yapıştırın ve *run* seçeneğini seçin. Kodu çalıştırdığınızda bir hata alırsanız, kodunuzu doğru cevapla karşılaştırmak için bir sonraki sayfadaki okumaya gidin.

---

## 🎓 Adım 4: Döngüler ve *Switch* ile Öğrenci Notlarını Değerlendirme

Bir *for* döngüsü kullanarak öğrenci puanları listesini dolaşan ve puana göre harf notu atamak için bir *switch* ifadesi kullanan bir program yazın.

### 📌 Yönergeler

* Öğrenci puanlarından oluşan bir dizi tanımlayın.
* Her puanı dolaşmak için bir *for* döngüsü kullanın.
* Döngünün içinde, puana göre bir harf notu (`A, B, C, D, F`) atamak için bir *switch* ifadesi kullanın.

Kodunuzu doğrudan **Dot Net Fiddle** içinde taslak hâlinde yazıp çalıştırabilirsiniz; bu, .NET projeleri için basit bir çevrim içi editördür. İsterseniz Notepad veya Visual Studio Code gibi bir metin editörü de kullanabilirsiniz; ancak DotNetFiddle, kodunuzu hızlıca test edip çalıştırmak için harikadır. Cevabınızı kontrol etmek için  **Dot Net Fiddle** ’a gidin, sayfadaki kodu silin, kodunuzu sol tarafa yapıştırın ve *run* seçeneğini seçin. Kodu çalıştırdığınızda bir hata alırsanız, kodunuzu doğru cevapla karşılaştırmak için bir sonraki sayfadaki okumaya gidin.
