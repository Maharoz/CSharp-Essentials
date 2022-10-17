class Program
{
    static void Main(string[] args)
    {
        Program obj = new Program();
        ParameterizedThreadStart PTSD = new ParameterizedThreadStart(obj.DisplayNumbers);
        Thread t1 = new Thread(PTSD);
        t1.Start(5);
        Console.Read();
    }


    void DisplayNumbers(object Max)
    {
        int Number = Convert.ToInt32(Max);
        for (int i = 1; i <= Number; i++)
        {
            Console.WriteLine("Method1 :" + i);
        }
    }
}

