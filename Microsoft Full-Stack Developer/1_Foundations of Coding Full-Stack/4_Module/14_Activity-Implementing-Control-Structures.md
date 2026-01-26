## 🛠️ Implementing Control Structures

### 🎯 Objective

Gelişmiş if-else ifadeleri ve karmaşık switch case’ler kullanarak karar verme senaryolarını çözme pratiği yapmak; değişken değerlerini ve program durumlarını değerlendirerek program akışını kontrol etmek.

---

### 📝 Description

Bu etkinlikte, vergi hesaplamaları ve telefon planı seçimi gibi senaryolarda program akışını kontrol etmek için if-else ifadeleri ve switch case’ler kullanacaksınız. Ardından bu becerileri bir spor salonu üyelik ücreti sistemi ve bir banka hesabı yönetim sistemi oluşturmak için uygulayacaksınız.

---

## 🧾 Full Example 1: Advanced If-Else Statements – Tax Calculation System

### 🧩 Problem Statement

Bir vergi hesaplama sistemi geliştirmeniz isteniyor. Program, kullanıcının gelirine ve kullanıcının *resident* mi yoksa *non-resident* mi olduğuna göre vergi oranını hesaplamalıdır. Vergi oranları aşağıdaki gibidir:

* Gelir $50,000’den az ise, resident’lar %10, non-resident’lar %15 vergilendirilir.
* Gelir $50,000 ile $100,000 arasındaysa, resident’lar %20, non-resident’lar %25 vergilendirilir.
* Gelir $100,000’den fazlaysa, resident’lar %30, non-resident’lar %35 vergilendirilir.

---

### 🧱 Step-by-Step Code Construction with Syntax Explanation

#### ✅ Step 1: Start with the Primary Condition

```csharp
if (income < 50000) {
```

**Explanation:**

* `if`: Bu, bir koşulu değerlendiren temel if ifadesidir. Parantez içindeki koşul doğruysa, blok `{}` içindeki kod çalışır.
* `income < 50000`: Bu bir karşılaştırma operatörüdür. `income` değerinin 50.000’den küçük olup olmadığını kontrol eder. Koşul doğruysa, blok içindeki sonraki adıma geçilir.
* `{ }`: Süslü parantezler, koşul doğru olduğunda çalışacak kod bloğunu kapsar.

Bu durumda koşul şunu sorar: `"Gelir $50,000’den düşük mü?"`

---

#### 🏠 Step 2: Add Nested If-Else to Check Residency

```csharp
    if (isResident) {
        taxRate = 0.10;  // 10% tax for residents
    } else { 
        taxRate = 0.15;  // 15% tax for non-residents
     }
```

**Explanation:**

* `isResident`: Bu bir boolean değişkendir. `true` veya `false` değerini tutar. Bu durumda kullanıcı resident ise `isResident` `true` olur.
* `if (isResident)`: `isResident`’ın `true` olup olmadığını kontrol ediyoruz. Doğruysa resident vergi oranı (%10) uygulanır.
* `taxRate = 0.10;`: Eşittir işareti `=` atama operatörüdür. `taxRate` değişkenine `0.10` (veya %10) değerini atar.
* `else`: İlk koşul (kullanıcının resident olup olmadığı) yanlışsa, program `else` bloğuna geçer ve non-resident vergi oranı %15’i uygular.
* `taxRate = 0.15;`: Bu, non-resident için `taxRate`’e `0.15` (%15) değerini atar.

Bu yapı, programın iki sonuç arasında karar vermesini sağlar: biri resident’lar, diğeri non-resident’lar için.

---

#### 💰 Step 3: Handle the Next Income Bracket

```csharp
} else if (income >= 50000 && income <= 100000) {
    if (isResident) {
        taxRate = 0.20;  // 20% tax for residents
    } else {
        taxRate = 0.25;  // 25% tax for non-residents
    }
}
```

**Explanation:**

* `else if`: İlk `if` koşulu yanlışsa başka bir koşulu kontrol etmek için kullanılır. Yani gelir $50,000’den düşük değilse, program şimdi gelirin $50,000 ile $100,000 arasında olup olmadığını kontrol eder.
* `income >= 50000 && income <= 100000`: Bu bir mantıksal koşuldur. `>=` ve `<=` operatörlerini kullanarak gelirin $50,000 ile $100,000 aralığında olup olmadığını kontrol eder. `&&` operatörü, iki koşulun da doğru olması gerektiği anlamına gelir.

Bu blok içinde resident kontrolü için aynı mantık izlenir:

* `if (isResident)`: Kullanıcının resident olup olmadığını kontrol eder. Doğruysa `taxRate = 0.20;` ile %20 resident vergi oranı atanır.
* `else`: Kullanıcı resident değilse, program `taxRate = 0.25;` ile %25 non-resident vergi oranını atar.

---

#### 🧾 Step 4: Handle the Final Income Bracket

```csharp
} else {
    if (isResident) {
        taxRate = 0.30;  // 30% tax for residents
    } else {
        taxRate = 0.35;  // 35% tax for non-residents
    }
}
```

**Explanation:**

* `else`: Bu, son olası sonuç için nihai geri dönüş (fallback) bloğudur. Koşul gerektirmez çünkü eleme yöntemiyle $100,000 üzerindeki tüm gelir değerlerini kapsar.

Burada da resident kontrolü için yine bir if-else bloğu iç içe yerleştiriyoruz:

* Kullanıcı resident ise (`isResident` `true`), vergi oranı %30 olur.
* Kullanıcı resident değilse (`isResident` `false`), vergi oranı %35 olur.

---

#### 🧮 Step 5: Calculate and Print the Tax

```csharp
tax = income * taxRate;
Console.WriteLine("The tax is: $" + tax);
```

**Explanation:**

* `tax = income * taxRate;`: Çarpma operatörü `*` ile geliri vergi oranıyla çarparak vergiyi hesaplar.
* `System.Console.WriteLine`: Konsola çıktı yazdırır. Bu örnekte, hesaplanan vergiyi bir mesajla birlikte yazdırır.

---

#### ▶️ Step 6: Run the code

Artık vergiyle çalışan tam kodu oluşturduk. Aşağıdaki kodu çalıştırmak isterseniz,
`Dot Net Fiddle`
adresine gidin, sayfadaki kodu silin, aşağıdaki kodu sol tarafa yapıştırın ve `run` seçin. Kodun nasıl çalıştığını görmek için Gelir ve Resident durumunda farklı varyasyonlar deneyin.

* `45000` ve `Yes` girin, sonra `Run` seçin
* `75000` ve `No` girin, sonra `Run` seçin

**User Input:** Program, kullanıcıdan gelirini ve resident olup olmadığını girmesini ister.

* `Console.ReadLine()`: Kullanıcı girişini string olarak okur.
* `Convert.ToDouble(Console.ReadLine())`: Giriş string’ini double’a çevirir; böylece çarpma gibi sayısal işlemler yapılabilir.
* `bool isResident = residentInput.ToLower() == "yes";`: Kullanıcının `"yes"` veya `"no"` girişini boolean değere çevirir.
* **Logic Execution:** Mantık aynı kalır, ancak değerler artık kullanıcıdan gelir.

```csharp
using System;

public class Program {
   public static void Main() {
        // Step 1: Prompt the user for input
        Console.WriteLine("Enter your income:");
        double income = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Are you a resident? (yes/no):");
        string residentInput = Console.ReadLine();
        bool isResident = residentInput.ToLower() == "yes";

        double taxRate = 0;
        double tax;

        // Step 2: Use advanced if-else statements to calculate tax
        if (income < 50000) {
            if (isResident) {
                taxRate = 0.10;  // 10% tax for residents
            } else {
                taxRate = 0.15;  // 15% tax for non-residents
            }
        } else if (income >= 50000 && income <= 100000) {
            if (isResident) {
                taxRate = 0.20;  // 20% tax for residents
            } else {
                taxRate = 0.25;  // 25% tax for non-residents
            }
        } else {
            if (isResident) {
                taxRate = 0.30;  // 30% tax for residents
            } else {
                taxRate = 0.35;  // 35% tax for non-residents
            }
        }

        // Step 3: Calculate and print the tax
        tax = income * taxRate;
        Console.WriteLine("The tax is: $" + tax);
    }
}
```

---

## 📱 Full Example 2: Complex Switch Cases – Phone Plan Selector

### 🧩 Problem Statement

Kullanıcıların istedikleri veri miktarına ve uluslararası arama isteyip istemediklerine göre bir telefon planı seçmelerine yardımcı olacak bir program geliştiriyorsunuz. Mevcut planlar şunlardır:

* **Basic Plan:** 2GB veri, uluslararası arama yok.
* **Standard Plan:** 5GB veri, uluslararası arama yok.
* **Premium Plan:** 10GB veri, uluslararası arama var.
* **Elite Plan:** Sınırsız veri, uluslararası arama var.

---

### 🧱 Step-by-Step Code Construction with Syntax Explanation

#### ✅ Step 1: Start with a Switch Based on Data Usage

```csharp
switch (dataNeeds) {
```

**Explanation:**

* `switch (dataNeeds)`: Switch ifadesi tek bir değişkeni değerlendirir (burada `dataNeeds`). Program, `dataNeeds` değerini bir dizi `case` etiketiyle karşılaştırır.
* `dataNeeds`: Kullanıcının talep ettiği veri miktarını tutan değişkendir. Switch, bu değeri mevcut plan seçenekleriyle karşılaştırır.

---

#### 🧩 Step 2: Add Cases to Handle Data Ranges

```csharp
    	case 2:
       	 plan = "Basic Plan";
      	  break;
```

**Explanation:**

* `case 2`: Kullanıcının 2GB veri isteyip istemediğini kontrol eder. Doğruysa blok çalışır.
* `plan = "Basic Plan";`: `plan` değişkenine `"Basic Plan"` string’ini atar. Kullanıcı Basic Plan’a uygundur.
* `break;`: Switch ifadesinden çıkılmasını sağlar. `break` olmadan program diğer case’leri kontrol etmeye devam eder; doğru plan bulunduğunda bu gereksizdir.

```csharp
    case 5:
         plan = "Standard Plan";
           break;
```

**Explanation:**

* `case 5`: Kullanıcının 5GB veri isteyip istemediğini kontrol eder. Doğruysa kullanıcı Standard Plan’a atanır.

---

#### ⭐ Step 3: Handle Premium and Unlimited Plans

```csharp
   case 10:
        if (wantsInternationalCalling) {
            plan = "Premium Plan";
        } else {
            plan = "Standard Plan";
        }
        break;
```

**Explanation:**

* `case 10`: Talep edilen verinin 10GB olup olmadığını kontrol eder.
* `if (wantsInternationalCalling)`: Bu case içinde, kullanıcının uluslararası arama isteyip istemediğini kontrol etmek için if kullanılır. Doğruysa Premium Plan verilir.
* `else`: Kullanıcı uluslararası arama istemiyorsa Standard Plan atanır.
* `break;`: Doğru plan seçildikten sonra switch’ten çıkar.

```csharp
    case -1:
        plan = "Unlimited Plan";
        break;
```

**Explanation:**

* `case -1`: Burada `-1`, “sınırsız” veriyi temsil etmek için bir placeholder olarak kullanılır. Kullanıcı sınırsız veri isterse Elite Plan’a atanır.
* `break`: Unlimited Plan atandıktan sonra switch’ten çıkar.

---

#### 🧯 Step 4: Default Case

```csharp
    default:
        plan = "Invalid data request";
        break;
}
```

**Explanation:**

* `default`: Diğer case’lerin hiçbiri doğru değilse çalışacak geri dönüş bloğudur. Burada `plan` değerine `"Invalid data request"` atanır.
* `break`: Default case’ten sonra switch ifadesinden çıkılır.

---

#### ▶️ Step 5: Run the code

Artık vergiyle çalışan tam kodu oluşturduk. Aşağıdaki kodu çalıştırmak isterseniz,
`Dot Net Fiddle`
adresine gidin, sol paneldeki mevcut kodu silin, aşağıdaki kodu yapıştırın ve `run` seçin.

**User Input:** Program, kullanıcıdan veri kullanımını (GB cinsinden) ve uluslararası arama isteyip istemediğini girmesini ister.

* `Convert.ToDouble(Console.ReadLine())`: Giriş string’ini numeric değere (double) çevirir; böylece koşul kontrolleri yapılabilir.
* `bool wantsInternationalCalling = intlCallingInput.ToLower() == "yes";`: Kullanıcının girişini boolean değere çevirir.
* **Switch Case Logic:** Switch, kullanıcının girdiği veri kullanımını değerlendirir ve uygun planı seçer. Belirli planlar için uluslararası arama ihtiyacını kontrol etmek üzere nested if-else kullanılır.

```csharp
using System;

public class Program {
   public static void Main() {
        // Step 1: Prompt the user for input
        Console.WriteLine("Enter your data usage (in GB):");
        double dataUsage = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Do you want international calling? (yes/no):");
        string intlCallingInput = Console.ReadLine();
        bool wantsInternationalCalling = intlCallingInput.ToLower() == "yes";

        string plan = "";

        // Step 2: Use switch statement to select the plan
        switch (dataUsage) {
            case 2:
                plan = "Basic Plan";
                Console.WriteLine("You are choosing the Basic Plan");
                break;

            case 5:
                plan = "Standard Plan";
                Console.WriteLine("You are choosing the Standard Plan");
                break;

            case 10:
                if (wantsInternationalCalling) {
                    plan = "Premium Plan";
                    Console.WriteLine("You are choosing the Premium Plan with International Calling");
                } else {
                    plan = "Standard Plan";
                    Console.WriteLine("You are choosing the Standard Plan");
                }
                break;

            case -1:
                plan = "Unlimited Plan";
                Console.WriteLine("You are choosing the Unlimited Plan with International Calling");
                break;

            default:
                Console.WriteLine("Invalid data request");
                break;
        }
    }
}
```

---

## 🏋️ Problem 1: Membership Fee Calculation System

### 🧩 Problem Statement

Bir spor salonu için üyelik ücretini hesaplayan bir program geliştiriyorsunuz. Ücret, kullanıcının yaşına ve üyelik türüne bağlıdır:

* 18 yaş altı kullanıcılar için ücret basic üyelikte $15, premium üyelikte $25’tir.
* 18 ile 60 yaş arasındaki kullanıcılar için ücret basic üyelikte $30, premium üyelikte $50’dir.
* 60 yaş üstü kullanıcılar için ücret basic üyelikte $20, premium üyelikte $35’tir.

### 📌 Instructions

Yaş ve üyelik türüne göre üyelik ücretini hesaplamak için gelişmiş bir if-else ifadesi yazın.

Kodunuzu doğrudan `Dot Net Fiddle` üzerinde taslak hâline getirip çalıştırabilirsiniz; bu, .NET projeleri için basit bir çevrim içi editördür. İsterseniz Notepad veya Visual Studio Code gibi bir metin editörü de kullanabilirsiniz; ancak DotNetFiddle kodunuzu hızlıca test etmek ve çalıştırmak için idealdir.

Kodunuzu çalıştırmak için `Dot Net Fiddle`’a gidin, sayfadaki kodu silin, kodunuzu sol tarafa yapıştırın ve `run` seçin.

---

## 🏦 Problem 2: Bank Account Management System

### 🧩 Problem Statement

Bir banka hesabı yönetim sistemi geliştiriyorsunuz. Program, farklı banka hesabı türlerini yönetmeli ve hesap türüne göre doğru ücretleri veya faiz oranlarını uygulamalıdır:

* **Savings Account:** %2 faiz oranı uygula.
* **Checking Account:** Aylık $10 ücret uygula.
* **Business Account:** %1 faiz oranı ve aylık $20 ücret uygula.
* Diğer tüm hesap türleri için bir hata mesajı göster.

### 📌 Instructions

Farklı hesap türlerini ele almak ve doğru ücretleri veya faiz oranlarını uygulamak için bir switch case yazın.

Kodunuzu doğrudan `Dot Net Fiddle` üzerinde taslak hâline getirip çalıştırabilirsiniz; bu, .NET projeleri için basit bir çevrim içi editördür. İsterseniz Notepad veya Visual Studio Code gibi bir metin editörü de kullanabilirsiniz; ancak DotNetFiddle kodunuzu hızlıca test etmek ve çalıştırmak için idealdir.

Kodunuzu çalıştırmak için `Dot Net Fiddle`’a gidin, sayfadaki kodu silin, kodunuzu sol tarafa yapıştırın ve `run` seçin.
