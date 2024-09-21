#if TASK7
Console.WriteLine("please enter any operation of your choice ('+', '-', '*', '/', '%') ");
string oper = Console.ReadLine();
Console.WriteLine("okay now provide with two numbers...");
double num1 = double.Parse(Console.ReadLine());
Console.WriteLine("now the second one...");
double num2 = double.Parse(Console.ReadLine());


if (oper == "+")
{
    Console.WriteLine("end product is: " + (num1+num2));
}
else if (oper == "-")
{
    Console.WriteLine("end product is: " + (num1 - num2));
}
else if (oper == "*")
{
    Console.WriteLine("end product is: " + (num1 * num2));
}
else if(oper == "/")
{
    Console.WriteLine("end product is: " + (num1 / num2));
}
else if (oper == "%")
{
    Console.WriteLine("end product is: " + (num1 % num2));
}
#endif