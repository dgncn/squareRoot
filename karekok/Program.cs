using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace karekok
{
    class Program
    {
        static double carpan = 2;

        static void Main(string[] args)
        {
            try
            {
                Console.Write("Karekökünü almak istediğin sayıyı gir: ");

                double a = double.Parse(Console.ReadLine());
                
                double root = squareRoot(a);
                Console.WriteLine(root.ToString("G17"));


                Console.ReadKey();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
        }
        static double squareRoot(double x)
        {
            double result = 1;

            double difference = x - x / 2;
            double a = 2;
            double xb2 = x / a;



            int counter = 0;
            while (counter < 10000000)
            {

                if (xb2 * xb2 > x)
                {
                    xb2 = xb2 - difference / 2;
                    result = xb2;
                }
                else if (xb2 * xb2 < x)
                {
                    xb2 = xb2 + difference / 2;
                    result = xb2;
                }
                else if (xb2 * xb2 == x || xb2 * xb2 < x + 0.1 || xb2 * xb2 > x - 0.1)
                {
                    result = xb2;
                    break;
                }
                difference = difference / 2;
                counter++;
            }


            return result;
        }


    }
}
