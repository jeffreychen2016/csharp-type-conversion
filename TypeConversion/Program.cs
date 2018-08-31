using System;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            /*------------------------------Type Conversion-----------------------------*/

            //int i = 1;
            //byte b = (byte)i;  -- (byte)  is called casting
            //Console.WriteLine(b);
            //Console.ReadLine();

            /* 
                when convert large data type to smaller data type 
                the data may get lost
                it is called overflow
            */

            try
            {
                var number = "1234";
                byte i = Convert.ToByte(number);
                Console.WriteLine(i);
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("The number could not be converted to byte");
                Console.ReadLine();
            }


        }
    }
}
