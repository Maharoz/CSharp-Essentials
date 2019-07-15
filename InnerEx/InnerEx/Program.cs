using System;
using System.IO;

namespace InnerEx
{
    class Program
    {
        public static void Main()
        {
            try
            {
                try
                {

                    Console.WriteLine("Enter the first number : ");
                    int FN = Convert.ToInt32(Console.ReadLine());


                    Console.WriteLine("Enter the Second number : ");
                    int SN = Convert.ToInt32(Console.ReadLine());

                    int Result = FN / SN;

                    Console.WriteLine("Result {0}", Result);
                }
                catch (Exception ex)
                {
                    string filePath = "D:\\Log.txt";
                    if (File.Exists(filePath))
                    {
                        StreamWriter sw = new StreamWriter(filePath);
                        sw.Write(ex.GetType().Name);
                        sw.Write(ex.Message);
                        sw.Close();
                        Console.WriteLine("There is a problem,please try later");
                    }
                    else
                    {
                        throw new FileNotFoundException(filePath + " is not present");
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine("current exception {0}", exception.GetType().Name);
                if (exception.InnerException != null)
                {
                    Console.WriteLine("Inner exception {0}",exception.InnerException.GetType().Name);
                }
            }
        }
    }
}
