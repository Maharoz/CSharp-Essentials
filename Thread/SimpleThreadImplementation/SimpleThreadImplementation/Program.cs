Console.WriteLine("Main Thread Started");

Thread t1 = new Thread(method1)
{
    Name = "Thread1"
};

Thread t2 = new Thread(method2)
{
    Name = "Thread2"
};

Thread t3 = new Thread(method3)
{
    Name = "Thread3"
};

t1.Start();
t2.Start();
t3.Start();

Console.WriteLine("Main Thread Ended");
Console.ReadLine();
    
static void method1()
{
    Console.WriteLine("Method1 started using " + Thread.CurrentThread.Name);
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine("Method : " + i);
    }
    Console.WriteLine("Method Ended using " + Thread.CurrentThread.Name);
}


static void method2()
{
    Console.WriteLine("Method2 Started using " + Thread.CurrentThread.Name);
    for (int i = 1; i <= 5; i++)
    {
        Console.WriteLine("Method2 :" + i);
        if (i == 3)
        {
            Console.WriteLine("Performing the Database Operation Started");
            //Sleep for 10 seconds
            Thread.Sleep(10000);
            Console.WriteLine("Performing the Database Operation Completed");
        }
    }
    Console.WriteLine("Method2 Ended using " + Thread.CurrentThread.Name);
}


static void method3()
{
    Console.WriteLine("Method3 Started using " + Thread.CurrentThread.Name);
    for (int i = 1; i <= 5; i++)
    {
        Console.WriteLine("Method3 :" + i);
    }
    Console.WriteLine("Method3 Ended using " + Thread.CurrentThread.Name);
}