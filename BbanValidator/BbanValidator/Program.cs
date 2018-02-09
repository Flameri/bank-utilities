using System;

namespace BbanValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string machineFormat = BankUtil.IsValid("423456-781");
            Console.WriteLine();
            
            

            Console.ReadKey();

        }
    }
}
