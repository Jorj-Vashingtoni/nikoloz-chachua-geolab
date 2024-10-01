namespace nikoloz_chachua_geolab.homework__2;

public class TASK5
{
    public static void Run()
    {
        for (int i = 3; i <= 100; i++)
        {
            if (i % 3 == 0)
            {
                Console.WriteLine("fizz");
            }
            if (i % 5 == 0)
            {
                Console.WriteLine("buzz");
            }
            if(i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine("fizz buzz");
            }
            else
                Console.WriteLine(i);
        }
    }
}