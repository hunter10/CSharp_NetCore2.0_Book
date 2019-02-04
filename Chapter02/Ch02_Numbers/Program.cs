using System;

namespace Ch02_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine($"int uses {sizeof(int)} bytes and can store numbers in the range {int.MinValue:N0} to {int.MaxValue:N0}.");
            //Console.WriteLine($"double uses {sizeof(double)} bytes and can store numbers in the range {double.MinValue:N0} to {double.MaxValue:N0}.");
            Console.WriteLine($"decimal uses {sizeof(decimal)} bytes and can store numbers in the range {decimal.MinValue:N0} to {decimal.MaxValue:N0}.");

            //부동소수점 double 사용
            double double1 = 0.1;
            double double2 = 0.2;
            
            if (double1 + double2 == 0.3)
                Console.WriteLine("값 일치");
            else
                Console.WriteLine("일치하지 않음");
   
 
            //고정소수점 decimal 사용         
            decimal decimal1 = 0.1M;
            decimal decimal2 = 0.2M;
            
            if (decimal1 + decimal2 == 0.3M)
                Console.WriteLine("값 일치");
            else
                Console.WriteLine("일치하지 않음");
        }
    }
}
