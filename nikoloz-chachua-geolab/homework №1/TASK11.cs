#if TASK11
Console.WriteLine("to purchase the product we will need you to provide your location (country only)...");

string country= Console.ReadLine();

Console.WriteLine("now plese provide with your age...");

int age = int.Parse(Console.ReadLine());

if (age >= 0 && age <= 122) {
    if (country == "America" && age >= 21 && age <= 122)
    {
        Console.WriteLine("you are allowed");
    }
    else if (country == "America" && age < 21)
    {
        Console.WriteLine("unfortunately you are not allowed yet");
    }
    else if (country != "America" && age >= 18)
    {
        Console.WriteLine("you are allowed");
    }
    else if (country != "America" && age < 18)
    {
        Console.WriteLine("unfortunately you are not allowed");
    }
}
else
{
    Console.WriteLine("plaese provide valid data");
}
#endif