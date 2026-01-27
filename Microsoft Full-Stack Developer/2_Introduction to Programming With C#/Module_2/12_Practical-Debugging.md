## 🛠️ Pratik Hata Ayıklama

Hata ayıklama ( *debugging* ), her geliştirici için değerli bir beceridir; kodunuzun sorunsuz ve verimli çalışmasını sağlar. Kodda hata yapmak kaçınılmazdır, ancak bu hataları nasıl tespit edip düzelteceğinizi bilmek zaman kazandırır ve olası sorunların önüne geçer.

Bu videoda, kodda hataları tespit etmek ve düzeltmek için hata ayıklama tekniklerini uygulamayı öğreneceğiz. Hata ayıklama çabalarınıza yardımcı olabilecek bazı araçları inceleyelim.

---

## 🧰 Visual Studio Code ve Debugger

Birçok geliştirici için başvurulan araçlardan biri  *Visual Studio Code* ’dur. Şu yaygın senaryoyu düşünün: iki sayıyı bölen basit bir kod parçası.

Her şey derleyici açısından doğru görünür: değişken adları nettir ve virgüller ile noktalı virgüller doğru yerlerdedir. Sonuç olarak derleyici herhangi bir sözdizimi ( *syntax* ) hatası işaretlemez; yani kodun yapısında veya biçiminde bir sorun yoktur.

Ancak bu kod çalıştırılır ve kullanıcı payda ( *denominator* ) argümanı olarak sıfır verirse, bir çalışma zamanı ( *runtime* ) hatası oluşur.

Çalışma zamanı hatasını, yalnızca program yürütüldüğünde görürsünüz. Bu durumda hata, paydada sıfır olmasının matematiksel olarak imkânsız olmasından kaynaklanır.

Bunu düzeltmek için birçok programcı bir *debugger* kullanır.

---

## 🐞 Debugger Nedir?

Bir debugger, geliştiricilerin kodlarındaki hataları veya  *bug* ’ları bulmasına ve düzeltmesine yardımcı olan bir araçtır. Kodunuzu adım adım çalıştırmanıza, değişkenleri incelemenize ve yürütme akışını anlamanıza olanak tanır; böylece işlerin nerede ters gittiğini tespit edebilirsiniz.

Ön yüz ( *front-end* ) geliştiricilerin kullandığı en popüler debugger’lardan biri, *Visual Studio Code (VS Code)* içine entegre edilmiştir ve sağ üst köşedeki debugger düğmesi üzerinden erişilebilir.

VS Code debugger’ında programın yürütmesini durdurmak için  *breakpoint* ’ler ayarlayabilir, değişkenleri izleyebilir ( *watch* ), ve kodu adım adım ilerleterek tam olarak nasıl çalıştığını anlayabilirsiniz.

Bu da VS Code’u hataları hızlıca tespit edip düzeltmek için güçlü bir araç hâline getirir; böylece kodunuzun kalitesi ve güvenilirliği artar.

---

## ➗ Örnek: İki Sayıyı Bölme

Bu örnekte, `DivideNumbers` metodunu oluşturduk. İki parametre alır ve bölüm sonucunu döndürür.

Bu örnekte kodu çalıştıracağız ve metodu paydada sıfır ile çağıracağız. Bunu yapmak için sonucu `result` adlı bir değişkende saklıyorum.

Burada pay `10`, payda `0` olacak şekilde bölme yapıyoruz ve ardından sonucu yazdırıyoruz.

Kod derlenir, yani sözdizimi hatası yoktur; ancak programı çalıştırdığımda “result is” ifadesini ve ardından bir sonsuzluk işareti görürüm.

Bu bir çalışma zamanı ( *runtime* ) hatasıdır.

---

## 🧷 Breakpoint’ler

Böyle bir hatayla karşılaştığınızda, kodu hata ayıklamak için çeşitli debugger özelliklerine güvenebilirsiniz. İlki  *breakpoint* ’lerdir.

İşte `DivideNumbers` metodunun kodu. VS Code’da breakpoint, yürütmeyi durdurmak istediğiniz satır numarasının yanındaki boşluğa tıklanarak ayarlanır.

Bu satıra bir breakpoint ekleyebiliriz. Program bir sonraki çalıştırmada bu satıra geldiğinde, yürütmeden önce durur; böylece breakpoint’ten önce neler olduğunu belirleyebilirsiniz.

Genel olarak, değişkenlerinizin değiştiği satırlara breakpoint eklemek istersiniz; böylece daha sonra değerlerini inceleyebilir ve beklendiği gibi olup olmadıklarını kontrol edebilirsiniz.

---

## 🔎 Değişkenleri İnceleme

Breakpoint’leri ayarladıktan sonraki adım, değişkenleri incelemektir.

Bu, breakpoint’e gelindiği anda kodunuzda tam olarak ne olduğunu belirleyebileceğiniz yerdir. Yürütme sırasında değişkenlerin değerlerini kontrol etmek, programınızın veriyi beklendiği gibi işleyip işlemediğini doğrulamanıza yardımcı olur.

Debugger, *inspector* adlı bir araç içerir. Bir değişkenin üzerine gelerek o anda hangi değeri tuttuğunu görebilirsiniz.

Bu örnekte, payda `0`’dır.

---

## 👣 Kodda Adım Adım İlerleme

Değişkenleri kontrol ettikten sonra, debugger’daki *step through code* özelliğini kullanarak bir sonraki satıra manuel olarak geçebilirsiniz.

Bu özellik, araç çubuğundaki kontrollerle satır satır ilerlemenizi sağlar; böylece akışın tam olarak nasıl ilerlediğini takip eder ve nerede yanlış gidebileceğini yakalarsınız.

Debugger araç çubuğu, kullanabileceğiniz bir dizi düğme gösterir:

* **Continue** : Bir sonraki breakpoint’e gelene kadar veya program bitene kadar yürütmeyi sürdürür.
* **Step Over** : Mevcut satırı çalıştırır ve bir sonraki satıra geçer; ancak o satırın çağırdığı fonksiyon/metotların içine girmez.
* **Step Into** : Mevcut satırı çalıştırır ve satır bir fonksiyon/metot içeriyorsa onun içine girerek içeride satır satır hata ayıklama yapmanıza izin verir.
* **Step Out** : Mevcut fonksiyonun yürütmesini tamamlar, çağıran fonksiyona geri döner ve ardından duraklar.
* **Restart** : Mevcut debugging oturumunu durdurur ve baştan yeniden başlatır.
* **Stop** : Mevcut debugging oturumunu tamamen sonlandırır ve tüm kod yürütmesini durdurur.

Kodda adım adım ilerleme, debugger yürütmeyi bir breakpoint nedeniyle durdurduğunda çalışır.

Bu örnekte, işlemin sonucunu incelemek istediğim için `result` adlı bir değişken ekledim. Bunu yapmak için bu satıra bir breakpoint ekledim.

Bu noktada, değişkenleri inceleyebilir ve kodunuzda neler olduğunu kontrol edebilirsiniz. İsterseniz adım adım ilerleyerek hatanın tam olarak nerede oluştuğunu görebilirsiniz.

Bu durumda, `result` değişkeninin `0` olduğunu fark ederiz; bu da araştırdığımız hataya neden olacaktır.

Kodda adım adım ilerlemek, sorunların tam olarak nerede oluştuğunu belirlemenizi sağlar.

Örneğin, bu satırda **step over** yaptığımda ve şimdi değişkeni incelediğimde, başlangıçta beklenmedik davranış olan `infinity` değerini elde ederim.

Doğru odakla, kodunuzdaki hataları bulabilirsiniz. Debugger’ın  *inspector* ’ını kullanmak, değişkenlerin değerlerini anlamanıza ve onlar hakkında daha fazla bilgi edinmenize yardımcı olur.

---

## ✅ Kapanış

Bu videoda, kodunuzdaki hataları verimli biçimde tespit etmek ve düzeltmek için hata ayıklama tekniklerinin önemini inceledik.

 *Visual Studio Code debugger* ’ını kullandık; bu araç breakpoint ayarlamanıza, değişkenleri incelemenize ve kodda adım adım ilerlemenize olanak tanıyarak sorunları anlamak ve çözmek için güçlü bir yol sunar.

Bu araç ve tekniklerde ustalaşarak problem çözme becerilerinizi geliştirecek ve daha özgüvenli, daha verimli bir programcı olacaksınız.
