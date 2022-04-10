using System;

namespace Task1Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 1.
            //while (true)
            //{
            //    Console.WriteLine("Zehmet olmasa ikireqemli tam eded daxil edin.");
            //    int a = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Daxil etdiyiniz eded: " + a);
            //    if (a % 2 == 1)
            //    {
            //        Console.WriteLine("Daxil etdiyiniz eded tekdir");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Daxil etdiyiniz eded cutdur");
            //    }
            //}
            #endregion

            #region Task 2.
            while (true)
            {
                Console.Write("Zehmet olmasa imtahan balinizi daxil edin: ");
                int bal = Convert.ToInt32(Console.ReadLine());
                if (bal <= 100 && bal >= 91)
                {
                    Console.WriteLine("Sizin aldiginiz qiymet (herf ile): A");
                }
                else if (bal < 91 && bal >= 81)
                {
                    Console.WriteLine("Sizin aldiginiz qiymet (herf ile): B");
                }
                else if (bal < 81 && bal >= 71)
                {
                    Console.WriteLine("Sizin aldiginiz qiymet (herf ile): C");
                }
                else if (bal < 71 && bal >= 61)
                {
                    Console.WriteLine("Sizin aldiginiz qiymet (herf ile): D");
                }
                else if (bal < 61 && bal >= 51)
                {
                    Console.WriteLine("Sizin aldiginiz qiymet (herf ile): E");
                }
                else if (bal < 50 && bal >= 0)
                {
                    Console.WriteLine("Sizin aldiginiz qiymet (herf ile): F");
                    Console.WriteLine("Tessuf ki kesildiniz. Daha cox calisin.");
                }
                else
                {
                    Console.WriteLine("Balinizi duzgun daxil edin!");
                }
            }
            #endregion
        }
    }
}