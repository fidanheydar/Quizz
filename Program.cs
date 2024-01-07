using System;

namespace Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 808; 

            if (IsSelf(number))
            {
                Console.WriteLine("Eyni ededdir");
            }
            else
            {
                Console.WriteLine("Eyni eded deyil ");
            }
        }


        //verilmish ededin tersden yazildiqda eyni eded olub olmadigini tapan alqoritm 
        //verilmis array-e verilmis elementi elave eden method
        //verilmish yazinin sonundaki boshluqlari silen method 
        //verilmis yazinin verilmis yazi ile bitib bitmediyini tapan method 


        //static string EndText(string text,string txt)
        //{
        //    for (int i = 0; i < text.Length; i++)
        //    {
        //        if (txt =)
        //        {   

        //        }
        //    }
        //}

        static bool IsSelf(int number)
        {
            int originalNumber = number;
            int reverseNumber = 0;

            while (number > 0)
            {
                int lastNum = number % 10;
                reverseNumber = reverseNumber * 10 + lastNum;
                number = number / 10;
            }

            return originalNumber == reverseNumber;
        }

    }

  
}
