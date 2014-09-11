using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1dv402_jt222ii_1_2_rita_med_asterisker
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int rows = 0; rows < 25; rows++)
            {
                switch (rows % 3)
                { 
                    case 0:
                        { 
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            break;
                        }
                    case 1:
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            break;
                        }
                    case 2:
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            break;
                        }
                }
                for (int columns = 0; columns < 39; columns++)
                {
                    Console.Write("* ");
                }             
                Console.WriteLine();
                if (rows % 2 == 0)
                {
                    Console.Write(" ");
                } 
            }
           Console.ResetColor();
        }
    }
}
