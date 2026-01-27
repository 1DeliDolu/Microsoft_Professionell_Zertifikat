### 1.

Question 1

Which scenario benefits most from asynchronous programming?

[ ]Calculating a math problem that takes milliseconds to complete

[ ]Fetching data from an API while allowing users to interact with the application

[ ]Waiting for all tasks to finish before responding to user input

[ ]Executing tasks that need to run in sequence

1 point

### 2.

Question 2

What happens if an error occurs during an awaited asynchronous task?

[ ]The program freezes until the error is resolved

[ ]The task is forced to complete before the program continues

[ ]The error is ignored, and the program continues

[ ]The error can be caught and handled using a try-catch block

1 point

### 3.

Question 3

How does asynchronous programming help optimize resource usage?

[ ]It allows multiple tasks to be processed using the same resources

[ ]It limits the number of tasks that can run at once

[ ]It blocks resource usage during long tasks

[ ]It ensures resources are only used for one task at a time

1 point

### 4.

Question 4

In which scenario would using Task.WhenAll be beneficial?

[ ]When one task depends on another

[ ]When tasks must be completed in sequence

[ ]When only one task needs to run

[ ]When multiple data sources need to be fetched concurrently

1 point

### 5.

Question 5

What is an effective way to track errors in asynchronous code?

[ ]Use breakpoints to pause the code and check for errors

[ ]Use logging to capture and track errors as they occur

[ ]Ignore errors unless they crash the program

[ ]Wait for the task to finish and check for errors afterward

1 point

### 6.

Question 6

How can asynchronous programming help with file processing in a C# program?

[ ]It allows file operations to complete before other tasks start

[ ]It ensures all file operations are completed before continuing with user interactions

[ ]It pauses file operations if the user interacts with the program

[ ]It allows file operations to be handled in the background while the application remains responsive

1 point

### 7.

Question 7

In what scenario would you use Task.Delay in a C# program?

[ ]To ensure the task completes immediately

[ ]To simulate long-running tasks like data fetching or file processing

[ ]To stop the main application from running during the delay

[ ]To force the application to wait for a task to finish before continuing

1 point

### 8.

Question 8

How can you identify if an asynchronous task failed during execution?

[ ]By setting a timeout and automatically retrying the task a set number of times if no result is received.

[ ]By assuming the task succeeded if it has been running for a long time without any response.

[ ]By checking the task’s status or catching an exception in a try-catch block

[ ]By logging the task output continuously and halting execution when any unusual data appears.

1 point

### 9.

Question 9

What advantage does Task.WhenAll provide when running multiple asynchronous tasks?

[ ]It stops all tasks if one fails

[ ]It blocks the main thread until all tasks complete

[ ]It allows tasks to run concurrently and waits for all of them to finish

[ ]It ensures tasks run in order, one by one

1 point

### 10.

Question 10

How can Logpoints be useful when debugging asynchronous code in Visual Studio Code?

[ ]They automatically restart tasks after logging their values, ensuring continuous execution.

[ ]They log variable values and messages without stopping the program

[ ]They display variable values in the console, pausing the program when it reaches the Logpoint.

[ ]They capture errors and stop the task when an issue occurs, allowing you to debug in real-time.

1 point



### 1.

#### ❓ Soru 1

Hangi senaryo asenkron programlamadan en çok fayda sağlar?

* [ ] Milisaniyeler içinde tamamlanan bir matematik problemini hesaplamak
* [X] Kullanıcıların uygulamayla etkileşime devam etmesini sağlarken bir API’den veri çekmek
* [ ] Kullanıcı girdisine yanıt vermeden önce tüm görevlerin bitmesini beklemek
* [ ] Sırayla çalışması gereken görevleri yürütmek

---

### 2.

#### ❓ Soru 2

Beklenen ( *awaited* ) bir asenkron görev sırasında bir hata oluşursa ne olur?

* [ ] Hata çözülene kadar program donar
* [ ] Program devam etmeden önce görev zorla tamamlanır
* [ ] Hata yok sayılır ve program devam eder
* [X] Hata, **try-catch** bloğu kullanılarak yakalanıp ele alınabilir

---

### 3.

#### ❓ Soru 3

Asenkron programlama kaynak kullanımını nasıl optimize etmeye yardımcı olur?

* [X] Aynı kaynaklarla birden fazla görevin işlenmesine olanak tanır
* [ ] Aynı anda çalışabilecek görev sayısını sınırlar
* [ ] Uzun görevler sırasında kaynak kullanımını bloklar
* [ ] Kaynakların aynı anda yalnızca tek bir görev için kullanılmasını sağlar

---

### 4.

#### ❓ Soru 4

Hangi senaryoda **Task.WhenAll** kullanmak faydalıdır?

* [ ] Bir görev diğerine bağımlıysa
* [ ] Görevler sırayla tamamlanmak zorundaysa
* [ ] Yalnızca bir görevin çalışması gerekiyorsa
* [X] Birden fazla veri kaynağının eşzamanlı olarak çekilmesi gerekiyorsa

---

### 5.

#### ❓ Soru 5

Asenkron kodda hataları takip etmenin etkili bir yolu nedir?

* [ ] Breakpoint kullanarak kodu durdurmak ve hataları kontrol etmek
* [X] Hataları oluştukları anda yakalayıp takip etmek için **logging** kullanmak
* [ ] Programı çökertmedikçe hataları yok saymak
* [ ] Görev bitince bekleyip sonrasında hataları kontrol etmek

---

### 6.

#### ❓ Soru 6

Asenkron programlama, C# programında dosya işlemeye nasıl yardımcı olabilir?

* [ ] Diğer görevler başlamadan önce dosya işlemlerinin tamamlanmasını sağlar
* [ ] Kullanıcı etkileşimlerine devam etmeden önce tüm dosya işlemlerinin tamamlanmasını garanti eder
* [ ] Kullanıcı programla etkileşime girerse dosya işlemlerini duraklatır
* [X] Uygulama duyarlı kalırken dosya işlemlerinin arka planda yürütülmesini sağlar

---

### 7.

#### ❓ Soru 7

C# programında **Task.Delay** hangi senaryoda kullanılır?

* [ ] Görevin hemen tamamlanmasını sağlamak için
* [X] Veri çekme veya dosya işleme gibi uzun süren görevleri simüle etmek için
* [ ] Gecikme boyunca ana uygulamanın çalışmasını durdurmak için
* [ ] Devam etmeden önce uygulamayı görevin bitmesini beklemeye zorlamak için

---

### 8.

#### ❓ Soru 8

Bir asenkron görevin yürütme sırasında başarısız olup olmadığını nasıl anlayabilirsiniz?

* [ ] Zaman aşımı belirleyip sonuç gelmezse belirli sayıda otomatik yeniden denemekle
* [ ] Uzun süre yanıt vermeden çalışıyorsa başarılı olduğunu varsayarak
* [X] Görevin  **status** ’unu kontrol ederek veya **try-catch** ile istisnayı yakalayarak
* [ ] Görev çıktısını sürekli loglayıp olağandışı veri görünce yürütmeyi durdurarak

---

### 9.

#### ❓ Soru 9

Birden fazla asenkron görevi çalıştırırken **Task.WhenAll** ne avantaj sağlar?

* [ ] Biri başarısız olursa tüm görevleri durdurur
* [ ] Tüm görevler tamamlanana kadar ana iş parçacığını bloklar
* [X] Görevlerin eşzamanlı çalışmasına izin verir ve hepsinin bitmesini bekler
* [ ] Görevlerin sırayla, teker teker çalışmasını garanti eder

---

### 10.

#### ❓ Soru 10

Visual Studio Code’da asenkron kodu debug ederken **Logpoints** nasıl faydalı olabilir?

* [ ] Değerleri logladıktan sonra task’leri otomatik yeniden başlatır, sürekli yürütme sağlar
* [X] Programı durdurmadan değişken değerlerini ve mesajları loglar
* [ ] Değerleri konsolda gösterirken programa Logpoint’e geldiğinde duraklatır
* [ ] Hataları yakalar ve sorun oluşunca task’i durdurur, gerçek zamanlı debug sağlar
