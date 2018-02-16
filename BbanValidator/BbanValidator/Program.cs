using System;

namespace BbanValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string machineFormat = "227720-35988";
            bool isMachineFormat = BankUtil.Correctnumber(ref machineFormat);
            if (isMachineFormat)
            {
                Console.WriteLine($"{machineFormat} - {BankUtil.IsValidAccount(machineFormat)}");
            }
            else
            {
                Console.WriteLine("Account number incorrect!");
            }
      
            Console.ReadKey();

        }
    }
}
