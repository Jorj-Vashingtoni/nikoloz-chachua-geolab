#if TASK10
Console.WriteLine("please enter final price to pay");

double price = double.Parse(Console.ReadLine());

if (price > 0 && price < 100)
{
    Console.WriteLine($"unfortunately there is no discount for you, your total will be: {price} ");
}
else if (price >= 100 && price <= 500)
{
    Console.WriteLine($"fortunately for you we have a discount of 10% on everything, your new total will be: {price - (price * 0.1)}");
}
else if (price >= 500)
{
    Console.WriteLine($"fortunately for you we have a discount of 20% on everything, your new total will be: {price - (price * 0.2)}");
}
else {
    Console.WriteLine("please provide with valid data...");
}
#endif