using System;

//methods
class programm
{
    public static void Main()
    {
        programm.EventNumbers(30);

        programm P = new programm();
        int sum = P.Add(10, 20);

        Console.WriteLine(sum);
    }

    public int Add(int fn, int sn)
    {
        return fn + sn;
    }

    public static void EventNumbers(int num)
    {
        int start = 0;

        while(Start <= num)
        {
            Console.WriteLine(Start);
            start = start + 2;
        }
    }
}
