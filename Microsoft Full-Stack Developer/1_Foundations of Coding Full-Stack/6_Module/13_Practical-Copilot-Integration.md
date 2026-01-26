## 🧩 Pratik Copilot Entegrasyonu

Ya gerçek zamanlı olarak hataları tespit eden ve çözümler öneren bir yapay zekâ aracıyla debugging sürecinizi sadeleştirebilseydiniz? Microsoft Copilot’u doğrudan iş akışınıza entegre etmek, debugging’i daha hızlı ve daha akıllı hâle getirir. Sorunları hızlıca bulup düzeltmenize yardımcı olur; böylece bug kovalamaya daha az, iyi kod yazmaya daha çok zaman ayırırsınız.

Bu videoda, pratik kodlama görevleri için debugging sürecine Microsoft Copilot’u entegre edeceğiz. Debugging süreci birkaç temel adımdan oluşur. İlk olarak hata mesajlarını inceleriz. Sonra hatayı yeniden üretir ve izole ederiz; ardından sorunu analiz eder ve düzeltiriz.

Hadi başlayalım. Visual Studio Code’da, hatalar içeren bir proje dosyasında zaten bazı kodlarım var ve GitHub Copilot yüklü ve bize yardımcı olmaya hazır.

---

## 🧮 Üzerinde Çalışılacak Kod ve Hatanın İncelenmesi

Üzerinde çalışacağımız kod burada. Bu, sayı dizisinin toplamını hesaplayan basit bir C# programı. Ancak doğru toplamın hesaplanmasını engelleyen bir mantık hatası var.

Önce kodu inceleyip hatayı bulmaya çalışalım. `Main` metodunda, `numbers` adlı bir dizi beş değerle başlatılıyor: `1, 2, 3, 4 ve 5`.

Sonra `CalculateSum` fonksiyonunu çağırıyoruz. Bu fonksiyonun amacı, dizideki sayıları toplayıp sonucu döndürmek.

Fonksiyon, bir döngü oluşturan `for` anahtar sözcüğüyle başlar. Döngünün içinde, `numbers` dizisindeki elemanların konumunu temsil eden `i` değişkenini başlatırız.

Döngü koşulu, `i` değerinin dizideki toplam eleman sayısından küçük veya eşit olup olmadığını kontrol eder. Bu, döngünün `i` dizinin uzunluğuna eşit olduğunda bile çalışmaya devam edeceği anlamına gelir.

Döngü her çalıştığında, dizideki mevcut konumdaki değer, `sum` adlı birikimli toplama eklenir. Döngü bittiğinde fonksiyon `sum` değerini döndürür; bu da döngünün işlediği tüm elemanların toplamıdır.

Ancak diziler 0’dan saymaya başlar; yani ilk eleman 0 konumundadır ve son eleman `numbers.Length - 1` konumundadır. Döngü `numbers.Length` konumuna erişmeye çalıştığında, dizinin sonunun ötesine geçmeye çalışır.

Debugger, satır içinde `'Index was outside the bounds of the array'` hata mesajını gösterir ve soruna kodun 20. satırının neden olduğunu vurgular.

---

## 🧷 Hatayı Yeniden Üretme ve İzole Etme

Bir sonraki adım, hatayı yeniden üretmek ve izole etmektir. Sorunu izole edebilmek için 20. satıra bir breakpoint koyacağım; böylece kodu adım adım ilerleterek hatanın kesin sebebini görebiliriz.

Hata mesajından sorunun 20. satırda olduğunu bilsek bile, yine de hatanın tam olarak ne noktada oluştuğunu izole etmemiz gerekir.

Breakpoint’ler, kodu belirli bir satırda durdurmamıza ve değişkenleri ile program akışını incelememize olanak tanır.

Sonra debugger’ı tekrar çalıştıracağım. Bu kez, koyduğum breakpoint nedeniyle 20. satırda durduğunu göreceksiniz. Kodu adım adım ilerletirken her parçanın nasıl çalıştırıldığını gözlemleyebilirim.

Döngü boyunca ilerlerken `sum` ve `i` değerlerinin değiştiğine dikkat edin. `i` değeri `5` olduğunda ve `sum` `15`’e eşit olduğunda hata mesajı ortaya çıkar.

Bu, hatanın döngüde tam olarak bu noktada, yani kod beşinci kez çalışmaya çalışırken oluştuğunu gösterir.

---

## 🧠 Sorunu Analiz Etme ve Düzeltme

Artık sorunu izole ettiğimize göre, analiz edip düzeltmemiz gerekiyor.

İşte bu noktada Copilot’u debugging iş akışınıza entegre edebilirsiniz. Döngünün tamamını, 18 ile 23. satırlar arasını işaretleyeceğim.

Sonra sarı “sparkle” ikonunu seçeceğim ve `"Modify using Copilot"` seçeneğini seçeceğim. Bir diyalog kutusu açıldığını göreceksiniz; burada Copilot ile sohbet edebilir ve komutlar verebilirim.

`'Index was outside the bounds of the array'` hatasının ne anlama geldiğini daha iyi anlamak istiyorum, bu yüzden `"/explain"` komutunu yazacağım ve `"the error is in this for loop"` ifadesini ekleyip `"Enter"`’a basacağım.

Copilot, döngünün geçerli dizi elemanlarının ötesine bir adım fazla ilerlemesine izin verildiğini açıklar. Bu, debugging sürecinde gözlemlediklerimizle uyumludur.

Şimdi Copilot’tan bir düzeltme önermesini isteyelim. Bunun için `"/fix"` komutunu yazacağım ve `"edit code"` seçeneğini seçeceğim. Copilot, problemi anladığına dayanarak bir çözüm üretecek.

Copilot’un kodu editör içinde doğrudan yeniden yazdığına dikkat edin. `i less than or equal to numbers.Length` ifadesini `i less than numbers.Length` olarak değiştirir.

Bu doğru görünüyor; bu yüzden `"accept"` seçerek değişikliği uygulayacağım.

Ardından düzeltmeyi doğrulamak için debugger’ı tekrar çalıştıracağım.

Bu kez program hatasız şekilde çalışır. Debug konsolunda beklenen `15` değerini de görürüz.

Copilot, problemi verimli bir şekilde çözmemize yardımcı oldu.

---

## ✅ Kapanış

GitHub Copilot’u debugging iş akışınıza entegre ederek, sorunları analiz etme ve düzeltme sürecinde zaman kazanabilirsiniz.

Şimdi sıra sizde: Visual Studio Code’da Copilot ve breakpoint’lerle debugging yapmayı deneyin.
