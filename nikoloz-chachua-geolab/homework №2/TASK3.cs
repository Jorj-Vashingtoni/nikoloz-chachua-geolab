namespace nikoloz_chachua_geolab.homework__2;

public class TASK3
{
    public static void Run()
    {
        Console.WriteLine("enter num under 10");

        int num = int.Parse(Console.ReadLine());



        do {

            Console.WriteLine("please follow the instructions ");
            num = int.Parse(Console.ReadLine());

        }
        while (num > 10);
        Console.WriteLine($"the number is: {num}");
        
        int index = 0;

        do {

            Console.WriteLine("if you would like to continiue type yes...");
            string confirmation = Console.ReadLine();
            if (confirmation != "yes")
            {
                Console.WriteLine("you have chosen not to continiue....");
                break;
            }
   


            index++;
        }
        while (index != 3);
    }
}