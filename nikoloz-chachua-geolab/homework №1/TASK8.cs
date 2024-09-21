#if TASK8
Console.WriteLine("plaese enter your age...");
int age = int.Parse(Console.ReadLine());

if (age >= 18  && age <= 122)
{
    Console.WriteLine("you are allowed to vote...");
}
else if (age < 0 )
{
    Console.WriteLine("please enter valid data...");
}
else if (age > 122)
{
    Console.WriteLine("please enter valid data...");
}
else
{
    Console.WriteLine("you are not allowed to vote yet");
}
#endif