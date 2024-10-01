namespace nikoloz_chachua_geolab.homework__2;

public class TASK1
{
    public static void Run()
    {
        for(int i = 0; i <=100; i++){
            Console.Write($"{i} ");
        }
        
        int a = 0;
        Console.WriteLine();

        for (int i=0; i < 25; i++)
        {
            Console.WriteLine(a += 2);
        }

    }
}