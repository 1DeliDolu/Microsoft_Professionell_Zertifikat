## 🎛️ Kontrol Yapıları

Bu adımda, *if else* ifadelerinin temellerini inceleyeceğiz. Bunlar, programların koşullara bağlı olarak karar vermesine olanak tanıyan temel kontrol yapılarıdır. Başlamak için, *if else* ifadelerinin ne olduğunu anlayalım. Bir koşulun doğru mu yanlış mı olduğuna bağlı olarak bir programın farklı eylemler gerçekleştirmesini sağlarlar.

## 🗳️ Oy Kullanma Uygunluğu Örneği

Bir kişinin yaşına göre oy kullanmaya uygun olup olmadığını kontrol eden basit bir program oluşturmak istediğinizi hayal edin. Bunu yapmak için, oy kullanma yaşının 18 olduğunu varsayalım. Birisi 18 yaşında veya daha büyükse oy kullanabilir. 18 yaşın altındaysa oy kullanamaz.

Öncelikle, kullanıcının yaşını saklayacak bir değişken tanımlamamız gerekir. Programlamada bir değişken, daha sonra kullanmak istediğiniz bilgileri saklayabileceğiniz bir kap gibidir. Tam sayılarla çalıştığımız için (yaşlar), *int* türünde bir değişken tanımlayacağız; bu *integer* anlamına gelir. *Int* türü tam sayıları saklamak için kullanılır ve bu değişkene `age` adını vereceğiz.

## 🖥️ Konsoldan Girdi Alma

Sonra, kullanıcıdan yaşını girmesini isteyeceğiz. Bunu yapmak için ekranda bir mesaj görüntüleyen `Console.WriteLine` kullanacağız. Bu mesaj, kullanıcıdan yaşını girmesini isteyecek.

İstemi görüntüledikten sonra, kullanıcının girdisini almamız gerekir. `Console.ReadLine` fonksiyonu, kullanıcının girdisini bir *string* olarak okumak için kullanılır. Ancak biz bir *integer* ile çalışmamız gerektiğinden, string’i `int.Parse` kullanarak integer’a dönüştürmeli ve sonucu `age` değişkeninde saklamalıyız.

Artık kullanıcının yaşı `age` değişkeninde saklandığına göre, kullanıcının oy kullanmaya uygun olup olmadığını kontrol etmek için bir *if else* ifadesi kullanabiliriz. Kullanıcının yaşı 18 veya daha büyükse program `"you're eligible to vote"` yazdırır. Aksi hâlde `"you're not eligible to vote"` yazdırır.

## 🔀 Switch İfadelerine Giriş

Sonraki adımda, birden fazla *if else* ifadesine göre birden çok koşulu daha verimli şekilde ele almanın bir yolunu sunan *switch* ifadelerini öğreneceğiz. *Switch* ifadeleri *if else* ifadelerine benzer, ancak çok sayıda olası koşul olduğunda daha verimlidir.

## 🥤 Otomat Örneği: VendingMachine Metodu

Basit bir otomat programı oluşturmak için bir *switch* ifadesi kullanalım. Aynı proje içinde `VendingMachine` adlı yeni bir metot oluşturarak başlayacağız. Bir metot, belirli bir görevi gerçekleştirmek için tasarlanmış bir kod bloğudur. Bu durumda, `VendingMachine` metodu kullanıcıların bir içecek seçebileceği bir otomatı simüle edecektir.

`VendingMachine` metodunun içinde `choice` adlı bir *string* değişken tanımlayacağız. Bu değişken, kullanıcının seçtiği içeceği tutacaktır. *String* türü, kelimeler veya cümleler gibi metinleri saklamak için kullanılır.

Sonra, kullanıcıdan bir içecek seçmesini istememiz gerekir. `Console.WriteLine` kullanarak kullanıcıdan su, soda veya kahve arasında seçim yapmasını isteyen bir mesaj görüntüleriz. Ardından `Console.ReadLine` kullanarak kullanıcının girdisini alır ve `choice` değişkeninde saklarız.

Kullanıcının seçimi `choice` değişkeninde saklandığına göre, farklı olası seçimleri ele almak için bir *switch* ifadesi kullanabiliriz. *Switch* ifadesi, `choice` değerini kontrol eder ve kullanıcının girdisine bağlı olarak ilgili *case* bloğunu çalıştırır.

Kullanıcı su seçerse program `"dispensing water"` yazdırır. Benzer şekilde, soda için `"dispensing soda"` ve kahve için `"dispensing coffee"` yazdırır. Ayrıca, geçersiz girdileri ele almak için bir *default case* ekleyeceğiz ve kullanıcıdan geçerli bir seçenek seçmesini isteyen bir mesaj sağlayacağız.

## 🏫 Gerçek Dünya Senaryosu: Not Kontrolü ve If-Else

Bu adım, *if else* ifadelerinin gerçek dünya senaryosuna uygulanmasını içerir. Bir okul için, öğrencilerin notlarına göre geçip geçmediğini kontrol eden bir program geliştirdiğinizi hayal edin. Bu mantığı uygulamak için *if else* ifadelerini kullanacaksınız.

`CheckGrade` adlı yeni bir metot oluşturarak başlayacağız. Bu metot, bir öğrencinin notuna göre geçip geçmediğini kontrol etmeye yönelik mantığı içerecektir.

`CheckGrade` metodunun içinde, öğrencinin notunu saklamak için `grade` adlı bir *integer* değişken tanımlayın. Notlar tam sayı olduğundan *int* türü kullanılır.

Sonra, `Console.WriteLine` kullanarak kullanıcıdan öğrencinin notunu girmesini isteyin. `Console.ReadLine` ile girdiyi alın ve `int.Parse` ile integer’a dönüştürün. Bu değer `grade` değişkeninde saklanacaktır.

Şimdi, öğrencinin geçip geçmediğini belirlemek için bir *if else* ifadesi kullanın. Not 50 veya üzerindeyse program `"passed"` yazdırır. Not 50’nin altındaysa `"failed"` yazdırır.

## 🔤 Daha Karmaşık Karar Verme: Harf Notu ve Switch

Şimdi, daha karmaşık bir karar verme senaryosu için bir *switch* ifadesi uygulayalım. *Switch* ifadeleri, birden fazla koşulla çalışırken karar verme süreçlerini basitleştirebilir.

Sayısal puanlara göre harf notu atamak için bir *switch* ifadesi kullanacağız. Aynı proje içinde `AssignLetterGrade` adlı yeni bir metot oluşturarak başlayacağız. Bu metot, bir öğrencinin sayısal puanına göre harf notu atamak için bir mantık içerecektir.

`AssignLetterGrade` metodunun içinde, öğrencinin puanını saklamak için `score` adlı bir *integer* değişken tanımlayın. Puanlar tam sayı olduğu için *int* türü uygundur.

Sonra, `Console.WriteLine` kullanarak kullanıcıdan öğrencinin puanını girmesini isteyin. `Console.ReadLine` ile girdiyi alın ve `int.Parse` ile integer’a dönüştürün. Sonuç `score` değişkeninde saklanacaktır.

Artık, öğrencinin harf notunu belirlemek için bir *switch* ifadesi kullanacağız. *Integer* bölme kullanarak, `score` değerini 10’a bölerek, puanları 90-100, 80-89 gibi aralıklara gruplayabilir ve karşılık gelen harf notlarını (`A`, `B`, `C`, `D`, `F`) atayabiliriz.

## ✅ Tamamlama

Tebrikler.

*If else* ifadeleri ve *switch* durumlarını kullanma laboratuvarını başarıyla tamamladınız. Kodunuzda nasıl karar vereceğinizi ve birden fazla koşulu nasıl verimli şekilde yöneteceğinizi öğrendiniz. Bu beceriler, etkileşimli ve dinamik uygulamalar oluşturmak için gereklidir.
