using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericInterface
{
   
    class Program
    {

        static void Main(string[] args)
        {
           // GetIntfDemo c = new GetIntfDemo();
            ByTwos<int> intBt = new ByTwos<int>(GetIntfDemo.InPlusTwo);

            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine(intBt.GetNext() + " ");
                Console.WriteLine(); 
            }


            ByTwos<double> doubleBt = new ByTwos<double>(GetIntfDemo.DoublePlusTwo);

            doubleBt.SetStart(11.4);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(doubleBt.GetNext() + " ");
                Console.WriteLine(); ;
            }

            ByTwos<ThreeD> threeBt = new ByTwos<ThreeD>(GetIntfDemo.ThreeDPlusTwO);
            ThreeD coord;
            for (int i = 0; i < 5; i++)
            {

                coord = threeBt.GetNext();
                Console.Write(coord.x + " ," +
                    coord.y + " ," +
                    coord.z + " " );
                Console.WriteLine(); ;
            }


        }
    }
}
