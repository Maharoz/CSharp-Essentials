using System;

namespace Events
{
    class Program
    {
        delegate void MyEventHandler();
        class MyEvent
        {
            public event MyEventHandler SomeEvent;
            public void OneSomeEvent()
            {
                if (SomeEvent != null)
                    SomeEvent();
            }
        }
        static void Handler()
        {
            Console.WriteLine("Event occured");
        }
        static void Main(string[] args)
        {
            MyEvent evt = new MyEvent();
            evt.SomeEvent += Handler;
            evt.OneSomeEvent();
        }
    }
}
