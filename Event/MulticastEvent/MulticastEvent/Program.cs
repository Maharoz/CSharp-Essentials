using System;



namespace MulticastEvent
{

    delegate void MyEventHandler();

    class MyEvent
    {
        public event MyEventHandler SomeEvent;

        public void OnSomeEvent()
        {
            if(SomeEvent != null)
            {
                SomeEvent();
            }
        }
    }

    class X
    {
        public void Xhandler()
        {
            Console.WriteLine("Event received by X Object");
        }
    }

    class Y
    {
        public void Yhandler()
        {
            Console.WriteLine("Event received by X Object");
        }
    }

    
    class Program
    {

        static void Handler()
        {
            Console.WriteLine("Event occured");
        }


        static void Main(string[] args)
        {
            MyEvent evt = new MyEvent();
            X xOb = new X();
            Y yOb = new Y();

            evt.SomeEvent += Handler;
            evt.SomeEvent += xOb.Xhandler;
            evt.SomeEvent += yOb.Yhandler;

            evt.OnSomeEvent();
            Console.WriteLine();

            evt.SomeEvent -= xOb.Xhandler;
            evt.OnSomeEvent();

        }
    }
}
