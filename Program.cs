// 1) positive and negative numbers

Console.Write("Enter number: ");
int x = Convert.ToInt32(Console.ReadLine());
if (x > 0)
    Console.WriteLine("{0} is a positive number", x);
else if (x < 0)
    Console.WriteLine("{0} is a negative number", x);
else
    Console.WriteLine("Something goes wrong try again");


// 2) adult
Console.Write("Enter your age: ");
int age = Convert.ToInt32(Console.ReadLine());
if (age >= 18)
    Console.WriteLine("congratulations! You have the right to vote");
else if (age < 18)
    Console.WriteLine("Sorry , you don't have voting rights yet.");
else
    Console.WriteLine("Something goes wrong try again");

// 3) n m 
Console.WriteLine("Enter a number");
int m = Convert.ToInt32(Console.ReadLine());
int n;
if (m > 0)
    Console.WriteLine($"n = {n = 1}");
else if (m < 0)
    Console.WriteLine($"n = {n = -1}");
else if (m == 0)
    Console.WriteLine($"n = {n = 0}");
else
    Console.WriteLine("Something goes wrong enter correct number");

Console.WriteLine();
// 4) biggest number

Console.WriteLine("Enter a first number");
int firstN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number");
int secondN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter third number");
int thirdN = Convert.ToInt32(Console.ReadLine());
if (firstN > secondN && firstN > thirdN)
    Console.WriteLine("The first number is biggest");
else if (secondN > firstN && secondN > thirdN)
    Console.WriteLine("The second number is biggest");
else if (thirdN > firstN && thirdN > secondN)
    Console.WriteLine("The third number is biggest");
else
    Console.WriteLine("Something goes wrong");

// 5) week days
Console.WriteLine("Enter a number");
int day = Convert.ToInt32(Console.ReadLine());
switch (day)
{
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    case 3:
        Console.WriteLine("Wednesday");
        break;
    case 4:
        Console.WriteLine("Thursday");
        break;
    case 5:
        Console.WriteLine("Friday");
        break;
    case 6:
        Console.WriteLine("Saturday");
        break;
    case 7:
        Console.WriteLine("Sunday");
        break;
    default:
        Console.WriteLine("Something goes wrong try again");
        break;
}

// 6) summ
Console.WriteLine("Enter first number");
int first = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter secondn umber");
int second = Convert.ToInt32(Console.ReadLine());
if (first != second)
    Console.WriteLine(first + second);
else if (first == second)
    Console.WriteLine((first + second) * 3);
else
    Console.WriteLine("Something goes wrong");
