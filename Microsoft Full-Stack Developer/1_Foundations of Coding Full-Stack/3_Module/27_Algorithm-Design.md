
## 🧠 Algoritma Tasarımı

Algoritmalar, yazdığınız her programın merkezindedir; en basitinden en karmaşık uygulamaya kadar. İster bir sayı listesini sıralıyor olun ister bir oyun oluşturuyor olun, algoritma tasarlama sanatında ustalaşmak; fikirlerinizi işlevsel ve verimli koda dönüştürmenin anahtarıdır.

Bu videoda, verilen bir problemi çözmek için basit bir algoritma tasarlayacağız.

Algoritma tasarlamaya yaklaşımımızı yapılandırmak için, bunu birkaç adıma bölelim ve her adımı ayrıntılı şekilde inceleyelim.

---

## 🎯 1. Adım: Problemi Anlamak ve Hedef Belirlemek

Algoritma tasarlamanın ilk adımı, problemi anlamak ve bir hedef belirlemektir. Bu, algoritmanın neyi başarmasını istediğinizi bilmek anlamına gelir.

Örneğin, bir sayı listesindeki en büyük sayıyı bulmak için bir algoritma oluşturmak istediğimizi düşünelim.

Buradaki hedefimiz, listedeki en yüksek değeri belirlemektir.

Problemi ve hedefimizi anladıktan sonra, bir sonraki adımda bunu diyagram hâline getirmeye ve taslaklamaya başlayabiliriz.

---

## 🧩 2. Adım: Çözümü Diyagramlamak ve Taslaklamak

Bir çözümü diyagramlamak ve taslaklamak, problemi daha küçük ve daha kolay adımlara bölmektir.

Bunu uygulamaya dökmek için, sayı listesindeki en büyük sayıyı bulma örneğimizi ele alalım ve algoritmamızı sözde kod ( *pseudocode* ) kullanarak tasarlayalım.

Listenin ilk sayısıyla başlarız ve onu listenin ikinci sayısıyla karşılaştırırız.

Eğer ikinci sayı birinci sayıdan büyükse, bu ikinci sayı yeni en büyük sayı olur.

İlk karşılaştırmada daha büyük sayıyı belirledikten sonra, listedeki her sayı için bu süreci tüm sayılar karşılaştırılana kadar sürdürürüz.

Artık listedeki tüm sayıları karşılaştırdığımıza göre, elde edilen son en büyük sayı sonuçtur.

---

## 🧮 Örnek Üzerinden Algoritmanın Çalışması

Bu algoritmanın nasıl çalıştığını, gerçek bir sayı listesiyle gösterelim.

Sayı listemiz: yedi, iki, sekiz ve üç.

Ve hedefimiz: listedeki en büyük sayıyı bulmak.

Listedeki ilk sayı yedidir. Bunu bir sonraki sayı olan iki ile karşılaştıralım.

Eğer ikinci sayı daha büyükse, yeni en büyük sayı olur.

İki, yediden büyük olmadığı için yeni en büyük sayı olmaz ve yedi hâlâ en büyük sayıdır.

Bunu listenin sonuna kadar tekrarlarız.

Yedi, bir sonraki sayı olan sekizden büyük mü? Hayır; sekiz daha büyüktür, yani artık en büyük sayı sekizdir.

Son olarak, sekizi listedeki son sayı olan üç ile karşılaştırırız.

Sekiz, üçten büyüktür; dolayısıyla listedeki en büyük sayı sekizdir.

---

## ✅ Kapanış

Bu videoda, algoritma tasarımının temel adımlarını öğrendiniz: problemi anlamak, çözümü diyagramlamak ve taslaklamak, ve her şeyi sözde koda dökmek.

Bu adımlarda ustalaşarak, en karmaşık problemleri bile yönetilebilir çözümlere bölebilirsiniz.
