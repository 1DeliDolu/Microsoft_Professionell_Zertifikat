## 🎛️ Kontrol Yapıları

## 🎯 Amaç

Bu etkinliğin sonunda, farklı seyahat türleri için bilet rezervasyonu ile ilgili bir programda kararları simüle etmek amacıyla *if-else* ifadelerini ve  *switch case* ’leri uygulayabileceksiniz.

## 1️⃣ Bilet Fiyatlandırması için If-Else İfadesi

Bir seyahat şirketi için, yolcunun yaşına göre bilet fiyatını belirleyen bir program geliştiriyorsunuz. Şirket, çocuklar ve yaşlılar için indirimli fiyatlar sunar. Kurallar şunlardır:

* Çocuklar (12 yaş altı) yarı fiyat öder.
* Yetişkinler (12 ile 65 arası) tam fiyat öder.
* Yaşlılar (65 yaş üstü) %20 indirim alır.

Bir yolcunun hangi fiyatı ödeyeceğini belirlemek için *if-else* ifadesi kullanan bir program yazın.

### 🧱 Adımlar

* Yolcunun yaşını saklamak için `int age` adlı bir değişken tanımlayın.
* `Console.WriteLine` kullanarak kullanıcıdan yaşını girmesini isteyin ve girdiyi `Console.ReadLine()` ile alın.
* Girdi string olduğu için `int.Parse()` ile integer’a çevirin ve sonucu `age` değişkenine atayın.
* Bilet fiyatını belirlemek için bir *if-else* yapısı yazın:
  * `age < 12` ise `"Half price ticket."` yazdırın.
  * Yaş 12 ile 65 arasındaysa `"Full price ticket."` yazdırın.
  * Aksi hâlde `"Senior discount ticket."` yazdırın.

Kodunuzu doğrudan **Dot Net Fiddle** içinde taslak olarak yazıp çalıştırabilirsiniz; bu, .NET projeleri için basit bir çevrim içi editördür. İsterseniz Notepad veya Visual Studio Code gibi bir metin düzenleyici de kullanabilirsiniz; ancak DotNetFiddle kodunuzu hızlıca test edip çalıştırmak için harikadır.

Cevabınızı kontrol etmek için  **Dot Net Fiddle** ’a gidin, sayfadaki kodu silin, kodunuzu sol tarafa yapıştırın ve *run* seçeneğini seçin. Çalıştırdığınızda bir hata alırsanız, bir sonraki sayfadaki okumaya giderek kodunuzu doğru cevapla karşılaştırın.

## 2️⃣ Seyahat Modu Seçimi için Switch İfadesi

Seyahat şirketi birden fazla seyahat modu sunar: `"Bus"`, `"Train"` ve `"Flight"`. Her modun farklı bir rezervasyon mesajı vardır. Kullanıcının hangi ulaşım modunu seçtiğini belirlemek için bir *switch* ifadesi kullanan bir program oluşturun.

### 🧱 Adımlar

* Kullanıcının seyahat modunu saklamak için `string mode` adlı bir değişken tanımlayın.
* `Console.WriteLine` kullanarak kullanıcıdan bir mod seçmesini isteyin ve girdiyi `Console.ReadLine()` ile alın.
* Hangi mesajın yazdırılacağını belirlemek için bir *switch* ifadesi yazın:
  * Kullanıcı `"Bus"` seçerse `"Booking a bus ticket."` yazdırın.
  * Kullanıcı `"Train"` seçerse `"Booking a train ticket."` yazdırın.
  * Kullanıcı `"Flight"` seçerse `"Booking a flight ticket."` yazdırın.
  * Geçersiz girdiler için *default case* ekleyin ve `"Invalid selection. Please choose Bus, Train, or Flight."` mesajını yazdırın.

Kodunuzu doğrudan **Dot Net Fiddle** içinde taslak olarak yazıp çalıştırabilirsiniz; bu, .NET projeleri için basit bir çevrim içi editördür. İsterseniz Notepad veya Visual Studio Code gibi bir metin düzenleyici de kullanabilirsiniz; ancak DotNetFiddle kodunuzu hızlıca test edip çalıştırmak için harikadır.

Cevabınızı kontrol etmek için  **Dot Net Fiddle** ’a gidin, sayfadaki kodu silin, kodunuzu sol tarafa yapıştırın ve *run* seçeneğini seçin. Çalıştırdığınızda bir hata alırsanız, bir sonraki sayfadaki okumaya giderek kodunuzu doğru cevapla karşılaştırın.
