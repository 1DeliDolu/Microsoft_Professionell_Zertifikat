### 1.

Question 1

Which of the following describes a key challenge when debugging asynchronous code?

[ ]Asynchronous code pauses the main program automatically

[ ]Errors are always easy to identify

[ ]Tasks always run in a predetermined order

[ ]Non-linear execution makes it harder to trace tasks


### 2.

Question 2

What debugging technique allows you to inspect the program's state while paused?

[ ]Breakpoints

[ ]Task Explorer

[ ]Logpoints

[ ]Call Stack Tool


### 3.

Question 3

What is the most effective way to debug asynchronous code in C# using breakpoints?

[ ]Disable breakpoints when debugging asynchronous code because they interfere with task scheduling

[ ]Set a breakpoint before every await keyword to see what the code does before suspending execution

[ ]Use breakpoints after every await keyword, as the code execution continues immediately after the await without any delay.

[ ]Breakpoints should only be set at the beginning and end of the method, as await automatically handles all issues



### 1.

#### ❓ Soru 1

Aşağıdakilerden hangisi asenkron kodu hata ayıklarken karşılaşılan temel bir zorluğu açıklar?

* [ ] Asenkron kod ana programı otomatik olarak duraklatır
* [ ] Hataları tespit etmek her zaman kolaydır
* [ ] Görevler her zaman önceden belirlenmiş bir sırada çalışır
* [X] Doğrusal olmayan yürütme, görevleri izlemeyi zorlaştırır

---

### 2.

#### ❓ Soru 2

Hangi hata ayıklama tekniği, program duraklatılmışken programın durumunu incelemenizi sağlar?

* [X] Breakpoints
* [ ] Task Explorer
* [ ] Logpoints
* [ ] Call Stack Tool

---

### 3.

#### ❓ Soru 3

C#’ta breakpoint kullanarak asenkron kodu hata ayıklamanın en etkili yolu hangisidir?

* [ ] Asenkron kodda breakpoint’leri devre dışı bırakın; çünkü task planlamasına müdahale ederler
* [X] Yürütme askıya alınmadan önce kodun ne yaptığını görmek için her **await** anahtar sözcüğünden önce breakpoint koyun
* [ ] Her  **await** ’ten sonra breakpoint kullanın; çünkü await’ten sonra yürütme gecikme olmadan hemen devam eder
* [ ] Breakpoint’ler yalnızca metodun başına ve sonuna konmalıdır; çünkü await tüm sorunları otomatik olarak çözer
