## 🗂️ Küçük Bir Proje Oluşturma ve Bir Programı Debug Etme

### 🧾 Adım 1: Uygulamayı Planlama

Kursun başında oluşturduğunuz **Visual Studio Code** konsol uygulamasını kullanarak küçük bir uygulama oluşturacaksınız. Uygulamanız, kullanıcıların basit bir yapılacaklar listesini yönetmesine olanak tanır. Program, kullanıcıların görev eklemesine, görev listesini görüntülemesine ve görevleri tamamlandı olarak işaretlemesine izin verecek.

Konsol uygulamanızdaki `Program.cs` dosyasındaki mevcut kodları kaldırın ve her adımda yazacağınız tüm kodu bu dosyada oluşturun.

---

## 🧩 Adım 2: Görev Listesini Oluşturma

Görevleri saklamak için bir dizi oluşturun ve kaç görev eklendiğini takip etmek için bir değişken tanımlayın.

**Talimatlar:**

* `ToDoList` adlı bir sınıf tanımlayın.
* En fazla 10 görev tutabilecek `tasks` adlı bir dizi oluşturun.
* Kaç görev eklendiğini takip etmek için `taskCount` adlı bir değişken oluşturun.

---

## ➕ Adım 3: Görev Ekleme

Kullanıcının listeye görev eklemesine izin veren bir metot oluşturun.

**Talimatlar:**

* Sınıf tanımı içinde `AddTask` adlı bir metot yazın; bu metot kullanıcıdan bir görev girmesini ister ve girdiyi `tasks` dizisinde saklar.
* Her görev eklendiğinde `taskCount` değişkenini artırın.

---

## 👀 Adım 4: Görevleri Görüntüleme

Kullanıcının şu ana kadar eklediği tüm görevleri görüntüleyen bir metot oluşturun.

**Talimatlar:**

* Sınıf tanımı içinde ve varsa mevcut metotların altına `ViewTasks` adlı bir metot yazın; bu metot `tasks` dizisi üzerinde döngü kurar ve her görevi yazdırır.
* Kaç görev yazdırılacağını belirlemek için `taskCount` değişkenini kullanın.

---

## ✅ Adım 5: Görevi Tamamlandı Olarak İşaretleme

Kullanıcının bir görevi tamamlandı olarak işaretlemesine izin veren bir metot oluşturun.

**Talimatlar:**

* Sınıf tanımı içinde ve varsa mevcut metotların altına `CompleteTask` adlı bir metot yazın; bu metot kullanıcıdan tamamlandı olarak işaretlemek için bir görev seçmesini ister.
* Seçilen görevi “tamamlandı” olduğunu gösterecek şekilde güncelleyin.

---

## ▶️ Adım 6: Programı Çalıştırma

Her şeyi bir araya getiren ve kullanıcının programla etkileşime girmesini sağlayan `Main` metodunu yazın.

**Talimatlar:**

* Sınıf tanımı içinde ve varsa mevcut metotların altına, kullanıcıya bir menü sunan `Main` metodunu yazın.
* Kullanıcı çıkmayı seçene kadar kullanıcıdan girdi istemeye devam etmek için bir döngü kullanın.
* Cevabınızı kontrol etmek için **Visual Studio Code** konsol uygulamasını çalıştırın. Kod çalıştırıldığında hata alırsanız, bir sonraki sayfadaki okumaya giderek kodunuzu doğru cevapla karşılaştırın.

---

## 🐛 Adım 7: Debugging Teknikleri

Programınızda oluşabilecek yaygın bir hatayı tanıtın ve onu bulup düzeltme sürecini uygulayın.

**Talimatlar:**

* `CompleteTask` metodunu, metod içinde `taskNumber` değerini yazdıran bir debug satırı ekleyerek güncelleyin.
* `CompleteTask` metodunu, görev numarası aralık dışındaysa kullanıcıya bir hata mesajı gösterecek şekilde güncelleyin.
* Cevabınızı kontrol etmek için **Visual Studio Code** konsol uygulamasını çalıştırın. Kod çalıştırıldığında hata alırsanız, bir sonraki sayfadaki okumaya giderek kodunuzu doğru cevapla karşılaştırın.
