using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FelhanteringModul
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continueLoop = true;
            while (continueLoop)
            {
                try
                {

                    //Console.Write("Mata in ett datum med (yyyy-mm-dd)");
                    //string datum = Console.ReadLine();

                    //if (!KontrolleraDatum1(datum))
                    //{
                    //    Console.WriteLine("Datumet är tidigare än dagens datum");
                    //}


                    //else
                    //{
                    //    Console.WriteLine("Datumet är senare än dagens datum");
                    //}

                    Console.WriteLine("Mata in ett tal");
                    int tal = int.Parse(Console.ReadLine());
                    int num = DivisionZero(tal);
                    Console.WriteLine("Den här är summan " + num);

                    Console.ReadLine();
                }
                //catch (DivideByZeroException dbze)
                //{
                //    Console.WriteLine(dbze.Message);
                //}

                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                    
                    Console.WriteLine("Try again! ");
                }
                Console.ReadLine();
            }

            
            

        }

        private static int DivisionZero(int tal)
        {
            tal = 10 / tal;
            return tal;
        }

        


        private static bool KontrolleraDatum1(string datum)
        {
            return KontrolleraDatum2(datum);
        }

        private static bool KontrolleraDatum2(string datum)
        {
            bool senareDatum = false;

            if (DateTime.Parse(datum) > DateTime.Now)
            {
                senareDatum = true;
            }
            return senareDatum;

        }
    }
}
