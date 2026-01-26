## 🧾 Psödokoda Giriş

Bilgisayarlar, birler ve sıfırlardan oluşan ikili (binary) bir sistemle çalışır. Program mantığını binary olarak yazmak çok zor ve zaman alıcı olurdu. Modern programlama dilleri, geliştiriciler için işleri basitleştirmek amacıyla özel bir sözdizimi (syntax) kullanır.

Ancak bilgisayarın anlayabileceği kodu yazmaya başlamadan önce, programın mantıksal akışını İngilizce veya İspanyolca gibi doğal bir dilde yazmak çok faydalı olabilir. Psödokod tam olarak budur. Programın yapısını düz bir dille açıklamanın bir yoludur; geliştiricilerin program mantığındaki zorlukları daha kolay çözmesine ve mevcut programlarını hata ayıklamasına bile yardımcı olur. Bu videoda, problem çözme adımlarını taslak hâline getirmek için psödokod yazacağız.

---

## 🧠 Psödokod Nedir?

Psödokod, bir bilgisayar programının veya algoritmanın ne yapması gerektiğini programlama dili yerine doğal bir dilde ifade eden, ayrıntılı ve okunabilir bir açıklamadır.

Psödokod, doğal dil ile programlama kodu arasında bir köprü görevi görür. Geliştiriciler, bir programın mantığını gerçek koda çevirmeden önce taslaklamak için psödokodu kullanır.

Psödokod, geliştiricilerin fikirlerini açık bir şekilde planlamasına ve iletmesine yardımcı olur; böylece kod yazmaya zaman ayırmadan önce mantığın doğru ve takip etmesi kolay olup olmadığını doğrulayabilirler.

Örneğin, bir sıralama (sorting) algoritması için psödokod yazmak, geliştiricinin sözdizimiyle uğraşmadan adımlara odaklanmasını sağlar.

Psödokod doğal bir dilde yazılsa da, geliştiriciler psödokodun tüm geliştiriciler tarafından benzer şekilde kullanılabilmesi için bazı yönergeleri takip etmelidir. Bu yönergeler, psödokodu gerçek koda daha kolay çevirebilecek bir yapıda yazmayı da destekler.

---

## 📌 Psödokod Yazma Yönergeleri

### 1) 🗣️ Düz Dil Kullanın

Psödokod yazarken sade bir dil kullanın. Mantıksal adımları, başka bir geliştiricinin kolayca anlayabileceği şekilde basit ve net yazın.

Örneğin, kodunuzun bir dizideki (array) her sayıyı artırması gerekiyorsa, psödokod şöyle yazılmalıdır:

“Dizideki her sayı için 1 ekle”

Buna karşılık, şu gibi daha kapalı ifadeler yerine:

“for number in array plus 1”

---

### 2) ✂️ Kısa ve Öz Olun

Her mantıksal adımı kısa ve doğrudan tutun; gereksiz ayrıntılardan kaçının.

Örneğin, bir değişkeni değerlendirip değeri varsa bir sonraki kayda geçmek istiyorsanız, bunu kısa şekilde şöyle ifade edebilirsiniz:

“If the variable firstName is not null, move to the next record.”

Şu gibi daha uzun ve fazla değer katmayan açıklamalardan kaçınmalısınız:

“evaluate the variable called firstName and determine if it has a value. If it does, then the program should move to the next record.”

---

### 3) 🧱 Psödokodu Gerçek Kod Gibi Yapılandırın

Boşluklandırma (spacing) ve yapı olarak gerçek koda benzer bir format kullanın; döngüler (loops), koşullar (conditionals) ve fonksiyon çağrıları (function calls) gibi yapıları koruyun.

Örneğin, bir sayıyı diğerinden çıkarıp farkı döndüren bir fonksiyon yazarken üç satırlık bir psödokod yazabilirsiniz:

İlk satırda:

“function to subtract A from B.”

Sonraki iki satır gerçek koddaki gibi girintili olmalıdır:

İkinci satır:

“Set variable C equal to B minus A”

Üçüncü satır:

“Send back C.”

Aynı fonksiyonu şu şekilde de yazabilirsiniz:

“The function called SubtractNumbers should take two variables called A and B. Inside the function, a variable C should be set to equal the difference of a subtracted from B, and then send back the value of C.”

Ancak bu yapı, kodun formunu gizler ve anlamayı zorlaştırır.

---

### 4) 🧩 Mantığa Odaklanın

Spesifik sözdiziminden (syntax) ziyade programın mantıksal akışına odaklanın.

Örneğin, bir döngü yazmanız gerekiyorsa, belirli bir kod sözdizimi kullanmak yerine şöyle diyebilirsiniz:

“repeat until all items are sorted”

Bu yönergeleri izleyerek psödokod yazdığınızda, mantık hatalarını veya beklendiği gibi çalışmayabilecek kod bloklarını daha kolay fark edebilirsiniz.

---

## 🐞 Psödokodu Tersine Kullanarak Hata Ayıklama

Psödokodu tersine kullanarak da hata ayıklayabilirsiniz. Gerçek kodunuz çalışmıyorsa, ilgili kod bloğunu psödokoda dökerek sorun giderebilirsiniz.

Örneğin, number adlı bir değişkenin negatif değerini kontrol etmek için yanlışlıkla “greater than” sembolünü kullandığınızı varsayalım. Kodunuz şöyle der:

number değişkeni 0’dan büyükse konsola “The number is negative” yazdır, değilse “The number is positive” yazdır.

Bir hata ararken, bu mantık hatasını kod içinde fark etmek zor olabilir.

Bunu psödokoda şöyle yazabilirsiniz:

“If number is greater than zero, then print the number as negative to the console. Otherwise, print the number as positive to the console.”

Psödokod kullanarak hatayı daha kolay fark edebilirsiniz.

---

## ✅ Özet

Bu videoda, problem çözme adımlarını taslak hâline getirmek için psödokod yazmayı öğrendiniz. Psödokod, geliştiricilerin kodlarını tasarlamak ve sorun gidermek için kullanabileceği güçlü bir araçtır.

Kod mantığını doğal bir dille açıklayarak, geliştiriciler programlarının nasıl çalışacağına dair daha derin bir içgörü elde edebilir.
