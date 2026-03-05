// Exercise 1
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.WriteLine("the first number is greater than the second");
}
else if (b > a)
{
    Console.WriteLine("the first number is less than the second");
}
else
{
    Console.WriteLine("equal");
}

// Exercise 2
int q = Convert.ToInt32(Console.ReadLine());

if (q > 5 && q < 10)
{
    Console.WriteLine("The number is greater than 5 and less than 10");
}
else
{
    Console.WriteLine("Unknown number");
}

// Exercise 3
int w = Convert.ToInt32(Console.ReadLine());

if (w == 5 || w == 10)
{
    Console.WriteLine("The number is either 5 or 10");
}
else
{
    Console.WriteLine("Unknown number");
}

// Exercise 4
double deposit = Convert.ToDouble(Console.ReadLine());

if (deposit < 100)
{
    deposit = deposit + (deposit * 0.05);
}
else if (deposit <= 200)
{
    deposit = deposit + (deposit * 0.07);
}
else
{
    deposit = deposit + (deposit * 0.1);
}

Console.WriteLine(deposit);

// Exercise 5
double deposit2 = Convert.ToDouble(Console.ReadLine());

if (deposit2 < 100)
{
    deposit2 = deposit2 + (deposit2 * 0.05);
}
else if (deposit2 <= 200)
{
    deposit2 = deposit2 + (deposit2 * 0.07);
}
else
{
    deposit2 = deposit2 + (deposit2 * 0.1);
}

Console.WriteLine(deposit2 + 15);

// Exercise 6
Console.WriteLine("Enter operation number: 1.Addition 2.Subtraction 3.Multiplication");
int g = Convert.ToInt32(Console.ReadLine());

switch (g)
{
    case 1:
        Console.WriteLine("Addition");
        break;
    case 2:
        Console.WriteLine("Substraction");
        break;
    case 3:
        Console.WriteLine("Multiplication");
        break;
}
if (g > 3)
{
    Console.WriteLine("the operation is undefined");
}

// Exercise 7
Console.WriteLine("Enter operation number: 1.Addition 2.Subtraction 3.Multiplication");
int r = Convert.ToInt32(Console.ReadLine());
int h = Convert.ToInt32(Console.ReadLine());
int j = Convert.ToInt32(Console.ReadLine());

switch (r)
{
    case 1:
        Console.WriteLine("Addition");
        Console.WriteLine(h + j);
        break;
    case 2:
        Console.WriteLine("Substraction");
        Console.WriteLine(h - j);
        break;
    case 3:
        Console.WriteLine("Multiplication");
        Console.WriteLine(h * j);
        break;
}
if (r > 3)
{
    Console.WriteLine("the operation is undefined");
}