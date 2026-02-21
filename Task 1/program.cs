using System;

Console.Write("Enter product name: ");
string product_name = Console.ReadLine();

Console.Write("Enter quantity: ");
int quantity = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter price item: ");
double price_item = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter discount in percentage: ");
double discount = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter delivery: ");
double delivery = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter distance: ");
double distance = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter first letter of payment: ");
string letter = Console.ReadLine();

double totalPrice = quantity * price_item;
double discountAmount = totalPrice * discount / 100;
double finalPrice = totalPrice - discountAmount + delivery + distance;

Console.WriteLine($"Price without discount: {totalPrice}");
Console.WriteLine($"Discount: {discountAmount}");
Console.WriteLine($"Final Price: {finalPrice}");
