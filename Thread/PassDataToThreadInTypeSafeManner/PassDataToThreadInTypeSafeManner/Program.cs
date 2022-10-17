int Max = 10;

NumberHelper obj = new NumberHelper(Max);
Thread t1 = new Thread(new ThreadStart(obj.DisplayNumber));
t1.Start();
Console.Read();
public class NumberHelper
{
    int _Number;
    public NumberHelper(int Number)
    {
        _Number = Number;
    }

    public void DisplayNumber()
    {
        for (int i = 0; i < _Number; i++)
        {
            Console.WriteLine("value : " +i);
        }
    }
}


