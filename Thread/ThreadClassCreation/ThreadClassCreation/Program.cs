
//Example to Understand Constructors of Thread Class in C#.

//Thread t1 = new Thread(DisplayNumber);
//t1.Start();
//Console.Read();

//static void DisplayNumber()
//{
//    for(int i = 0; i <= 5; i++)
//    {
//        Console.WriteLine("Method1 :" +i);
//    }
//}

//Example to Understand ThreadStart Delegate in C#

//ThreadStart obj = new ThreadStart(DisplayNumbers);

//Thread t1 = new Thread(obj);
//t1.Start();
//Console.Read();

//static void DisplayNumbers()
//{
//    for (int i = 1; i <= 5; i++)
//    {
//        Console.WriteLine("Method1 :" + i);
//    }
//}

//Creating Thread Class Instance using Anonymous Method in C#

Thread t1 = new Thread(delegate ()
{
    for(int i = 0; i < 5; i++)
    {
        Console.WriteLine("Method1: "+i);
    }
});

t1.Start();
Console.Read();