using System;

namespace UseOfOutParam
{

    public class num
    {
        public bool HasComFactor(int x , int y ,out int least,out int greatest)
        {
            int i;
            int max = x < y ? x : y;
            bool first = true;
            least = 1;
            greatest = 1;

            for ( i = 2; i < max / 2 + 1; i++)
            {
                if(((y%i)==0) & ((x % i) == 0))
                {
                    if (first)
                    {
                        least = i;
                        first = false;
                    }
                    greatest = i;
                }
            }

            if (least != 1) return true;
            else return false;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            num ob = new num();
            int lcf, gcf;

            if(ob.HasComFactor(231,105,out lcf,out gcf))
            {
                Console.WriteLine("Lcf of 231 and 105 is" + lcf );
                Console.WriteLine("gcf of 231 and 105 is" + gcf);
            }
            else
            {
                Console.WriteLine("No common factor for 35 and 49");
            }


            if (ob.HasComFactor(35, 51, out lcf, out gcf))
            {
                Console.WriteLine("Lcf of 35 and 51 is" + lcf);
                Console.WriteLine("gcf of 35 and 51 is" + gcf);
            }
            else
            {
                Console.WriteLine("No common factor for 35 and 51");
            }

        }
    }
}
