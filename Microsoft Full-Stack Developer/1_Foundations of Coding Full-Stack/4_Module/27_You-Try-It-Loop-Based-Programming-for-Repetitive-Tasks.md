## 🔁 Tekrarlayan Görevler için Döngü Tabanlı Programlama

### 🎯 Amaç

Bu etkinliğin sonunda, *for* ve *while* döngülerini kullanarak basit döngü tabanlı programlar yazabileceksiniz. Ayrıca tekrarlayan görevleri otomatikleştirmek için döngüleri *if-else* ve *switch* ifadeleri gibi kontrol yapılarıyla birleştireceksiniz.

---

## 🧩 Adım 1: Toplam Puanları Hesaplamak için *For* Döngüsü Kullanma

Bir quiz sistemi için, öğrencinin bireysel quiz puanlarına göre toplam puanını hesaplayan bir program geliştiriyorsunuz. Puanlar bir dizide saklanır ve bunları toplamak için bir *for* döngüsü kullanmanız gerekir.

### 📌 Yönergeler

* **85, 90, 78, 92 ve 88** tamsayılarını içeren `"scores"` adlı bir dizi tanımlayın.
* Dizideki her eleman üzerinde yineleme yapmak ve toplam puanı hesaplamak için bir *for* döngüsü kullanın.
* Toplam puanı `Console.WriteLine()` kullanarak yazdırın.

Kodunuzu doğrudan **Dot Net Fiddle** içinde taslak hâlinde yazıp çalıştırabilirsiniz; bu, .NET projeleri için basit bir çevrim içi editördür. İsterseniz Notepad veya Visual Studio Code gibi bir metin editörü de kullanabilirsiniz; ancak DotNetFiddle, kodunuzu hızlıca test edip çalıştırmak için harikadır. Cevabınızı kontrol etmek için  **Dot Net Fiddle** ’a gidin, sayfadaki kodu silin, kodunuzu sol tarafa ekleyin ve *run* seçeneğine tıklayın. Kodu çalıştırdığınızda bir hata alırsanız, kodunuzu doğru cevapla karşılaştırmak için bir sonraki sayfadaki okumaya gidin.

---

## 🧮 Adım 2: Faktöriyel Hesaplamak için *While* Döngüsü Kullanma

Bir *while* döngüsü kullanarak verilen bir sayının faktöriyelini hesaplayan bir program oluşturun. Program kullanıcıdan bir tamsayı istemeli ve ardından faktöriyelini hesaplamalıdır.

### 📌 Yönergeler

* `number` adlı bir tamsayı değişkeni tanımlayın ve değerini **5** olarak ayarlayın.
* Sayının faktöriyelini hesaplamak için bir *while* döngüsü kullanın.
* Her yinelemeden sonra `number` değerini bir azaltın.
* Faktöriyeli `Console.WriteLine()` kullanarak yazdırın.

Kodunuzu doğrudan **Dot Net Fiddle** içinde taslak hâlinde yazıp çalıştırabilirsiniz; bu, .NET projeleri için basit bir çevrim içi editördür. İsterseniz Notepad veya Visual Studio Code gibi bir metin editörü de kullanabilirsiniz; ancak DotNetFiddle, kodunuzu hızlıca test edip çalıştırmak için harikadır. Cevabınızı kontrol etmek için  **Dot Net Fiddle** ’a gidin, sayfadaki kodu silin, kodunuzu sol tarafa ekleyin ve *run* seçeneğine tıklayın. Kodu çalıştırdığınızda bir hata alırsanız, kodunuzu doğru cevapla karşılaştırmak için bir sonraki sayfadaki okumaya gidin.

---

## ✅ Adım 3: Geçti/Kaldı Belirlemek için Döngü ve *If-Else* Birleştirme

Her öğrencinin puanının geçme kriterini karşılayıp karşılamadığını kontrol etmek için *if-else* yapısıyla birlikte bir *for* döngüsü kullanan bir program yazın. Bir öğrenci, puanı **50 veya üzeriyse** geçer.

### 📌 Yönergeler

* **45, 60, 72, 38 ve 55** tamsayılarını içeren `"studentScores"` adlı bir dizi tanımlayın.
* Dizideki her eleman üzerinde yineleme yapmak için bir *for* döngüsü kullanın.
* Döngünün içinde, puanın 50 veya üzeri olup olmadığını kontrol etmek için bir *if-else* ifadesi kullanın.
* Puan 50 veya üzeriyse `"Pass"` yazdırın; değilse `"Fail"` yazdırın.

Kodunuzu doğrudan **Dot Net Fiddle** içinde taslak hâlinde yazıp çalıştırabilirsiniz; bu, .NET projeleri için basit bir çevrim içi editördür. İsterseniz Notepad veya Visual Studio Code gibi bir metin editörü de kullanabilirsiniz; ancak DotNetFiddle, kodunuzu hızlıca test edip çalıştırmak için harikadır. Cevabınızı kontrol etmek için  **Dot Net Fiddle** ’a gidin, sayfadaki kodu silin, kodunuzu sol tarafa ekleyin ve *run* seçeneğine tıklayın. Kodu çalıştırdığınızda bir hata alırsanız, kodunuzu doğru cevapla karşılaştırmak için bir sonraki sayfadaki okumaya gidin.

---

## 🗓️ Adım 4: Görev Planlama için Döngü ve *Switch* İfadelerini Birleştirme

Her gün için bir görev atamak amacıyla, bir *for* döngüsü içinde bir *switch* ifadesi kullanarak haftalık görevleri planlayan bir program oluşturun.

### 📌 Yönergeler

* `"Monday," "Tuesday," "Wednesday," "Thursday," "Friday"` stringlerini içeren `"weekDays"` adlı bir dizi tanımlayın.
* Dizideki her eleman üzerinde yineleme yapmak için bir *for* döngüsü kullanın.
* Döngünün içinde, her güne bir görev atamak için bir *switch* ifadesi kullanın:
  * `"Monday"` ise `"Team Meeting."` yazdırın.
  * `"Tuesday"` ise `"Code Review."` yazdırın.
  * `"Wednesday"` ise `"Development."` yazdırın.
  * `"Thursday"` ise `"Testing."` yazdırın.
  * `"Friday"` ise `"Deployment."` yazdırın.

Kodunuzu doğrudan **Dot Net Fiddle** içinde taslak hâlinde yazıp çalıştırabilirsiniz; bu, .NET projeleri için basit bir çevrim içi editördür. İsterseniz Notepad veya Visual Studio Code gibi bir metin editörü de kullanabilirsiniz; ancak DotNetFiddle, kodunuzu hızlıca test edip çalıştırmak için harikadır. Cevabınızı kontrol etmek için  **Dot Net Fiddle** ’a gidin, sayfadaki kodu silin, kodunuzu sol tarafa ekleyin ve *run* seçeneğine tıklayın. Kodu çalıştırdığınızda bir hata alırsanız, kodunuzu doğru cevapla karşılaştırmak için bir sonraki sayfadaki okumaya gidin.
