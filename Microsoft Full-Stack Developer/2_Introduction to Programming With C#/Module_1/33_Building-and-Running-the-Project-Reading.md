## 🏗️ Projeyi Derlemek ve Çalıştırmak

### 🚀 Giriş

Visual Studio Code ve .NET CLI kullanarak yeni bir .NET projesi oluşturmak için aşağıdaki adımları izleyin.

---

## 🧰 Yeni Bir .NET Projesi Nasıl Oluşturulur ve Çalıştırılır

### 📥 .NET SDK’yı yükleyin

**.NET web sitesine** gidin.

.NET SDK’yı indirin ve yükleyin.

---

### 🖥️ Visual Studio Code’u açın

Visual Studio Code’u başlatın.

 **View > Terminal** ’e tıklayarak Terminal’i açın.

---

### 🆕 Yeni bir .NET projesi oluşturun

Terminalde, projenizi oluşturmak istediğiniz klasöre gidin.

Aşağıdaki komutu yazın ve Enter’a basın (*ProjectName* yerine istediğiniz proje adını yazın):

```bash
dotnet new console -n ProjectName
```

---

### 📂 Projeyi Visual Studio Code’da açın

Yeni proje klasörünüze geçmek için:

```bash
cd ProjectName
```

Projeyi Visual Studio Code’da açmak için:

```bash
code .
```

---

### 🧱 Projeyi derleyin

Terminalde aşağıdaki komutu yazın ve Enter’a basın:

```bash
dotnet build
```

---

### ▶️ Projeyi çalıştırın

Terminalde aşağıdaki komutu yazın ve Enter’a basın:

```bash
dotnet run
```

---

## ✅ Sonuç

Bu adımlar, Visual Studio Code kullanarak yeni bir .NET projesini verimli bir şekilde kurmanıza ve çalıştırmanıza yardımcı olacaktır.
