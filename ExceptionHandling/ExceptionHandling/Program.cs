using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StreamReader streamReader = new StreamReader(@"G:\Udemy\Data.txt");
                Console.WriteLine(streamReader.ReadToEnd());
                streamReader.Close();
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Please check if the {0} file exists",ex.FileName);
                
            }
            
        }
    }
}
