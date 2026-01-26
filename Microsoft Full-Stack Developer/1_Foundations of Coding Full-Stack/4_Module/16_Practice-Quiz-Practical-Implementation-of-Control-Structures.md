### 1.

Question 1

Which of the following C# code snippets correctly implements an advanced if-else statement?

[ ]int age = 25;

if (age > 18)

{

 Console.WriteLine("You are an adult.");

}

else if (age < 18)

{

 Console.WriteLine("You are a minor.");

}

[ ]int score = 90;

if (score > 80)

{

 Console.WriteLine("Great score!");

}

else

{

 Console.WriteLine("Try again.");

}

[ ]int number = 10;

if (number > 0 && number < 20)
{
    Console.WriteLine("Number is between 0 and 20.");
}
else if (number == 20)
{
    Console.WriteLine("Number is exactly 20.");
}
else
{
    Console.WriteLine("Number is less than 1 or greater than 20.");
}

[ ]int number = 10;

if (number != 0)
{
    Console.WriteLine("Number is positive or negative.");
}
else
{
    Console.WriteLine("Number is one.");
}

### 2.

Question 2

Which of the following C# code snippets correctly implements a complex switch case?

[ ]string weather = "sunny";

switch (weather)

{

    case "rainy":

    Console.WriteLine("Bring an umbrella.");

    break;

    case "cloudy":

    Console.WriteLine("Might rain later.");

    break;

    case "sunny":

    Console.WriteLine("Wear sunglasses.");

    break;

[ ]int age = 25;

switch (age)

{

    case 18:

    Console.WriteLine("You just became an adult.");

    break;

    case 21:

    Console.WriteLine("Legal drinking age.");

    break;

    case 25:

    Console.WriteLine("Quarter-life milestone.");

    break;

}

[ ]string day = "Tuesday";

switch (day)

{

 case "Monday":

 case "Tuesday":

 Console.WriteLine("Start of the work week.");

 break;

 case "Wednesday":

 Console.WriteLine("Midweek.");

 break;

 case "Thursday":

 case "Friday":

 Console.WriteLine("End of the work week.");

 break;

[ ]int number = 3;

switch (number)

{

    case 1:

    Console.WriteLine("One");

    break;

    case 2:

    Console.WriteLine("Two");

    break;

    case 3:

    Console.WriteLine("Three");

    break;

    default:

    Console.WriteLine("Other number");

    break;

[ ]int number = 3;

switch (number)

{

 case 1:

 Console.WriteLine("One");

 break;

 case 2:

 Console.WriteLine("Two");

 break;

 case 3:

 Console.WriteLine("Three");

 break;

### 3.

Question 3

Which control structure is most suitable for determining whether a product needs reordering based on its stock level?

[ ]An if-else statement to evaluate the stock level against a threshold

[ ]A switch statement to match different stock levels directly

[ ]A loop structure to repeatedly check the stock status

[ ]A function call that processes the reorder without any condition
