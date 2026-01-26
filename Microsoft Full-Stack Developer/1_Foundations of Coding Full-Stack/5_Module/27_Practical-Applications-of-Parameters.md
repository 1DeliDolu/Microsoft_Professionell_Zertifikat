## 🧩 Practical Applications of Parameters

---

## 💰 Example: Using a Parameter with a Method

```csharp
public void ShowBalance(decimal balanceAmount)
{
	MessageBox.Show("Your balance is: $" + balanceAmount);
}
```

---

## 💰 Example: Using a Parameter with a Method

```csharp
ShowBalance(2000.50);
```

---

## 🧾 Example: Calculating Expenditures

```csharp
public void ShowTotalExpenditures(decimal[] expenditures) 

{ 
decimal total = 0; 

for (int i = 0; i < expenditures.Length; i++) 
{ 
total += expenditures[i]; 
} 

MessageBox.Show("Your total expenditures for the day are $:” + {total); 
}
```

---

## 🧾 Example: Calculating Expenditures

```csharp
decimal[] expenses = { 15.25, 8.50, 12.99, 5.75 };

ShowTotalExpenditures(expenses);
```

---

## 🧮 Example: Using Methods for Complex Calculations

```csharp
public double CalculateLoanPayment(double principal, double interestRate, int termInYears)
{
	double monthlyRate = interestRate / 12;
	int termInMonths = termInYears * 12;
    
     double monthlyPayment = principal * monthlyRate / (1 - Math.Pow(1 + monthlyRate, -termInMonths)); //Calculation of monthlyPayment


}
```

---

## 🧮 Example: Using Methods for Complex Calculations

```csharp
public double CalculateLoanPayment(double principal, double interestRate, int termInYears)
{
	double monthlyRate = interestRate / 12;
	int termInMonths = termInYears * 12;

	return monthlyPayment;
}
```

---

## 🧮 Example: Using Methods for Complex Calculations

```csharp
double monthlyPayment = CalculateLoanPayment(10000, 0.05, 5);
```

---

## ✅ Result

188.71
