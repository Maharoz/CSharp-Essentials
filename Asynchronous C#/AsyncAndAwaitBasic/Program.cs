Console.WriteLine("Main Method stated");
SomeMethod();
Console.WriteLine("Main Method end");
Console.ReadKey();


async static void SomeMethod()
{
    Console.WriteLine("Some Method started");

    await Task.Delay(TimeSpan.FromSeconds(5));
    Console.WriteLine("\n");
    Console.WriteLine("Some method ends");
}