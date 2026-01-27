### 1.

Question 1

What is the purpose of the async keyword in C#?

[ ]It allows a method to execute without blocking the main thread

[ ]It forces tasks to run in order

[ ]It completes the method immediately

[ ]It pauses method execution until a task completes


### 2.

Question 2

Which of the following statements about await in C# is correct?

[ ]It forces tasks to run in sequence

[ ]It cancels all other tasks while waiting

[ ]It pauses method execution until the awaited task is complete

[ ]It blocks the entire application until the task completes


### 3.

Question 3

What is the correct way to call an asynchronous method using await in C#?

[ ]Task CallMethodAsync()

{
await SomeAsyncMethod();
}

[ ]async Task CallMethodAsync()

{
SomeAsyncMethod().Wait();
}

[ ]async Task CallMethodAsync()

{
return await SomeAsyncMethod;
}

[ ]async Task CallMethodAsync()

{
await SomeAsyncMethod();

}



### 1.

#### ❓ Soru 1

C#’ta **async** anahtar sözcüğünün amacı nedir?

* [X] Bir metodun ana iş parçacığını ( *main thread* ) engellemeden çalışmasına olanak tanır
* [ ] Görevlerin sırayla çalışmasını zorlar
* [ ] Metodu hemen tamamlar
* [ ] Bir görev tamamlanana kadar metodun yürütülmesini duraklatır

---

### 2.

#### ❓ Soru 2

C#’ta **await** hakkında aşağıdaki ifadelerden hangisi doğrudur?

* [ ] Görevleri sıralı çalışmaya zorlar
* [ ] Beklerken diğer tüm görevleri iptal eder
* [X] Beklenen ( *awaited* ) görev tamamlanana kadar metodun yürütmesini duraklatır
* [ ] Görev tamamlanana kadar tüm uygulamayı bloklar

---

### 3.

#### ❓ Soru 3

C#’ta **await** kullanarak asenkron bir metodu çağırmanın doğru yolu hangisidir?

* [ ] `Task CallMethodAsync() { await SomeAsyncMethod(); }`
* [ ] `async Task CallMethodAsync() { SomeAsyncMethod().Wait(); }`
* [ ] `async Task CallMethodAsync() { return await SomeAsyncMethod; }`
* [X] `async Task CallMethodAsync() { await SomeAsyncMethod(); }`
