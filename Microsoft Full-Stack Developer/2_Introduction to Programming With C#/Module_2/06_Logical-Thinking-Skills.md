## 🧩 Mantıksal Düşünme Becerileri

Bir bulmacayı çözmeye çalıştığınızı hayal edin. Tüm parçalar elinizdedir, ancak onları birleştirmek dikkatli düşünmeyi ve adım adım bir yaklaşımı gerektirir. Programlamada mantıksal düşünme de aynı şekilde çalışır.

Bu videoda, programlamada mantıksal düşünmenin ilkelerini açıklayacağız.

Programlamada mantıksal düşünme, bir problemi tanımlamak ve bir çözüme ulaşmak için sistematik akıl yürütme uygulama sürecini ifade eder. Programlama bağlamında geliştiriciler en sık iki temel mantıksal düşünme becerisini kullanır: *tümdengelimli akıl yürütme (deductive reasoning)* ve  *problem parçalama (problem decomposition)* .

Önce tümdengelimli akıl yürütmeyle başlayalım.

---

## 🧠 Tümdengelimli Akıl Yürütme

Tümdengelimli akıl yürütme, genel öncüllerden (premises) hareketle belirli sonuçlar çıkarma sürecidir. Bunun programlamada nasıl çalıştığına bakalım.

Tümdengelimli akıl yürütme öncüllerle başlar.  *Öncül (premise)* , bir sonuca ulaşmak için kullanılan bir varsayım ya da olgudur. Programcılar, hata ayıklama ( *debugging* ) ve sorunları daha verimli şekilde düzeltmek için tümdengelimli akıl yürütmeyi kullanır.

Örneğin, bir sistemi hata ayıklarken beklenmedik davranışa neden olan bir fonksiyon keşfettiğinizi varsayalım. Problemi, iki temel öncülden hareket ederek ele alırsınız.

Birincisi, sistemdeki tüm hataların beklenmedik davranışa yol açtığıdır; ikincisi ise bu fonksiyonun beklenmedik davranışa neden olduğudur. Bu öncüllere dayanarak, bu fonksiyonun bir hata ( *bug* ) içerdiği sonucuna varabilirsiniz.

Programcılar, bir problemin nasıl çözülmesi gerektiğine dair üst düzey bir anlayış kazanmak için tümdengelimli akıl yürütmeyi kullanır. Problemin üst düzey görünümünü elde ettikten sonra, onu çözmek için mantıksal ve adım adım bir yaklaşım tanımlayabilirler.

Şimdi, programlamada problem çözmek için en yaygın kullanılan adım adım yaklaşımlara bakalım.

---

## 🧱 Problem Parçalama

Bir problemle karşılaştığınızda, büyük olasılıkla onu değerlendirir ve nasıl çözeceğinize dair strateji kurmaya başlarsınız. Yaygın bir yaklaşım, daha büyük bir problemi onu oluşturan parçalara ayırarak çözmeyi kolaylaştırmaktır.

Buna *problem parçalama (problem decomposition)* denir.

Problem parçalamada iki ana yaklaşım vardır: *yukarıdan aşağıya (top-down)* ve  *aşağıdan yukarıya (bottom-up)* .

---

## 🔽 Yukarıdan Aşağıya Yaklaşım

Yukarıdan aşağıya yaklaşım, bir probleme geniş bir genel bakışla başlayan ve onu daha küçük, daha yönetilebilir parçalara bölen bir problem çözme yöntemidir.

Yukarıdan aşağıya yaklaşım, probleme dair net bir genel bakışınız olduğunda, ancak onu yönetmeyi kolaylaştırmak için parçalara ayırmanız gerektiğinde kullanışlıdır. Bu yaklaşımı kullanarak, problemi daha kolay ele alınabilen küçük, atomik görevlere ayırabilirsiniz.

Örneğin, bir e-ticaret web sitesi geliştiriyorsanız, alışveriş sepeti işlevselliğini tasarlamak gibi üst düzey bir probleme odaklanabilirsiniz. Sonra bu işlevselliği, sepete ürün ekleme, miktarları güncelleme ve ödemeleri işleme gibi daha küçük bileşenlere ayırırsınız.

Ardından, bu bileşenlerin her birini daha da küçük, daha spesifik parçalara bölmeye devam eder ve nihayetinde yönetilebilir kodlama görevlerine ulaşırsınız.

Yukarıdan aşağıya yaklaşım, yazılım geliştirirken geliştiricilerin büyük bir fikirden somut görevlere inmesine yardımcı olur.

Ancak her durumda ideal değildir. Bazen geliştiricinin hata ayıklarken daha fazla bilgi toplaması veya yazılım geliştirmede modüler bir yaklaşım benimsemesi gerekir. Bu durumlarda, problemi çözmek için aşağıdan yukarıya yaklaşımları tercih edebilirler.

Şimdi aşağıdan yukarıya yaklaşımı inceleyelim.

---

## 🔼 Aşağıdan Yukarıya Yaklaşım

Aşağıdan yukarıya yaklaşım, en temel öğelerden başlayan ve onları birleştirerek daha geniş bir bütün oluşturan bir problem çözme yöntemidir.

Aşağıdan yukarıya yaklaşım, geliştiricilerin başlangıçta çok fazla bilgiye sahip olmadan problemleri keşfetmesine veya geliştirmeye başlamasına olanak tanır ve araştırma-geliştirme çabalarını ihtiyaç oldukça ölçeklendirmelerine izin verir.

E-ticaret örneğimizde, sepete ürün ekleme gibi temel fonksiyonlarla başlayabilirsiniz. Ardından bu fonksiyonları birleştirerek tüm alışveriş sepeti modülü gibi daha büyük bileşenler oluşturursunuz. Son olarak bu daha büyük bileşenleri entegre ederek tam sistemi oluşturur ve tüm parçaların birlikte sorunsuz çalıştığından emin olursunuz.

---

## 🏢 Örnek: Groove Eco

Bunu bir örnekle bir araya getirelim: sürdürülebilir yaşam ürünleri sunan, hızla büyüyen bir e-ticaret şirketi olan Groove Eco’yu ele alalım. Groove Eco’nun  *debt team* ’i, yakın zamanda kullanıma sundukları ürün öneri motorunun düşük güvenilirlik sorunlarıyla karşı karşıya olduğunu gözlemlemiştir.

Bu zorluğu çözmek için, şu öncüllerden başlayarak mantıksal düşünmeyi uygularlar.

Hatalı algoritmalar hatalara neden olur ve hatalar güvenilirlik sorunlarına yol açar. Ardından, öneri motorunun daha düşük güvenilirliğinin, ürün yazılımındaki bir algoritmayla ilgili bir hatadan kaynaklanıyor olabileceği sonucuna varırlar.

Bu, odaklanmaları gereken belirli bir problemi tanımlamalarına yardımcı olur.

Daha sonra bu problemi yukarıdan aşağıya bir yaklaşımla parçalarlar ve ana öneri algoritmasını olası bir suçlu olarak belirlerler. Ardından algoritmayı, kullanıcı davranışı analizi ve ürün eşleştirme için daha küçük fonksiyonlara ayırırlar.

Her bir küçük fonksiyonu ayrı ayrı ele alarak, kök nedene giderek daha fazla yaklaşır ve onu çözerler; böylece genel öneri sistemini iyileştirirler.

---

## ✅ Kapanış

Bu videoda, programlamada mantıksal düşünmeyi problemleri verimli biçimde çözmek ve sağlam çözümler oluşturmak için nasıl uygulayacağınızı öğrendiniz.

*Tümdengelimli akıl yürütme* ve *problem parçalama* konusunda ustalaşarak, her türlü kodlama zorluğunu sistematik ve etkili biçimde ele alabilirsiniz.
