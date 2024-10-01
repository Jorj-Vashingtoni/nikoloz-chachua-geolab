namespace nikoloz_chachua_geolab.homework__2;

public class CART
{
    public static void Run()
    {
        double bal=0;
        string confirmation;
        do
        {

            Console.WriteLine("enter price of products...");
            double price = double.Parse(Console.ReadLine());
            bal += price;
            Console.WriteLine("would you like to continiue?");
            confirmation = Console.ReadLine();


        }
        while (confirmation == "yes");

        Console.WriteLine($"the final price is:{bal} ");
    }
}