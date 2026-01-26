## 🧩 Parameters

Programlamada esnek ve yeniden kullanılabilir kod oluşturmak, verimli yazılım geliştirme için önemlidir. Belirli görevleri gerçekleştirmek üzere tasarlanmış kod blokları olan metotlar, bu süreçte kritik bir rol oynar. Parametreler, metotlara bilgi geçmemizi sağlar; böylece metotlar değişen girdilerle görevleri yerine getirebilir. Bu esneklik, uyarlanabilir, sürdürülebilir ve verimli kod yazmanın temel bir parçasıdır.

Bu videoda, parametrelerin ne olduğunu ve metotlardaki rollerini tanımlayacağız.

---

## 📌 Parametre Nedir?

Parametreler, bir fonksiyon veya metot tanımında yer alan ve fonksiyonun kabul edebileceği girdileri belirten değişkenlerdir. Metot çağrıldığında metoda geçirilecek değer için birer yer tutucu ( *placeholder* ) görevi görürler.

Örneğin, **CalculateSum(int a, int b)** metodunda **a** ve **b** parametredir.

---

## 🔧 Parametrelerin Metotlardaki Rolü

Parametreler, bir metot çağrıldığında metot içine veri geçirmenizi sağlar. Bu veri daha sonra belirli görevleri veya hesaplamaları gerçekleştirmek için kullanılabilir.

Parametrelerin temel rolü, metotları daha esnek ve yeniden kullanılabilir hâle getirmektir. Aynı metodun farklı girdilerle çalışmasına ve geliştiricinin veya kullanıcının sağladığı değerlere bağlı olarak farklı çıktılar üretmesine olanak tanırlar.

---

## 🧱 C#’ta Parametre Türleri

C# metotlarında iki ana parametre türü vardır: **value parameters** ve  **reference parameters** .

Şimdi bunların her birini, nasıl çalıştıklarını ve metotların nasıl işlediğini inceleyelim.

---

## 🟦 Value Parameters

 *Value parameters* , argümanın değerinin bir kopyasını metoda geçirir. Metot içinde parametre üzerinde yapılan değişiklikler, orijinal argümanın değerini etkilemez.

Örneğin, **void display value int num** ifadesi, **num** değerinin bir kopyasını alır. Çağıran koddaki  **num** ’un orijinal değeri etkilenmez.

---

## 🟨 Reference Parameters

 *Reference parameters* , orijinal argümana bir referans alır; böylece metoda geçirilen değeri, çağıran kod içinde değiştirmesine izin verir.

Bu, C# gibi dillerde **ref** anahtar kelimesi kullanılarak yapılır.

Örneğin, **void UpdateValue(ref int num)** metodu, orijinal **num** değerini güncelleyebilir.

---

## 🌍 Gerçek Dünya Örnekleri

Şimdi parametrelerin metotlarda nasıl kullanıldığına dair bazı gerçek dünya örneklerini inceleyelim; value parameter içeren bir örnekle başlayalım.

---

## 🗨️ Value Parameter Örneği

**PrintMessage** adlı, *value parameter* olarak **input** alan bir metot oluşturduğumuzu varsayalım.

Bu metodu **welcome customer** string değeri geçirerek çağırabiliriz ve metot bu string’in bir kopyasını alır.

Daha sonra bu kopyayı, çağıran koddaki orijinal değeri etkilemeden değiştirebilir.

---

## 🔁 Reference Parameter Örneği

Bu *reference parameter* örneğinde, **double value** metodu bir sayıyı referansla alır ve iki katına çıkarır.

Metodun dönüş türünün **void** olduğuna ve metot gövdesinde **return** anahtar kelimesini kullanmadığımıza dikkat edin; ancak **number** parametresine geçirilen argüman, yine de metodu çağıran kod içinde güncellenecektir.

Diyelim ki **mynumber** adlı bir değişken tanımlar ve ona **5** değerini atarız.

Eğer bunu **DoubleValue** metoduna geçirirsek, **mynumber** değişkeni  **5** ’ten  **10** ’a güncellenecektir.

Bu değişiklik, metodu çağıran kodda da görülecektir.

Bu kod çalıştırıldığında, konsol **ten** yazdıracaktır.

---

## 🎯 Özet

Bu videoda, parametrelerin ne olduğunu ve metotlardaki rollerini öğrendiniz.

*Value* ve *reference* parametreler arasındaki farkı ele aldık ve her türün metotlar içinde veriyi yönetmede nasıl belirli bir amaca hizmet ettiğini anladık.

Parametre kullanımında ustalaşarak, daha uyarlanabilir, verimli ve sürdürülebilir kod yazmak için gerekli becerilerle donanmış olursunuz; bu, sağlam yazılım çözümleri geliştirmeyi hedefleyen her programcı için temel bir yetkinliktir.
