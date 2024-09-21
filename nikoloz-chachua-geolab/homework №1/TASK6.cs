#if TASK6
Console.WriteLine("plaese provide with 3 numbers you would like to compare");

double num1 = double.Parse(Console.ReadLine());
Console.WriteLine("now the second one...");
double num2 = double.Parse(Console.ReadLine());
Console.WriteLine("now the third one...");
double num3 = double.Parse(Console.ReadLine());

if (num1 > num2 && num1 > num3)
{
    Console.WriteLine($"the first {num1} number is the greatest");
}
else if (num1 < num2 && num2 > num3)
{
    Console.WriteLine($"the second {num2} number is the greatest");
}
else if(num3 > num1 && num3 > num2)
{
    Console.WriteLine($"the third {num3} numebr is the greatest ");
}
#endif