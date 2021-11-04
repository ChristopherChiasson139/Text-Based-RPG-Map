using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace template
{
    class Program
    {
        
        static char[,] map = new char[,] // dimensions defined by following data:
        {
            
            {'^','.','.','.','.','*','*','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','~','~','~','.','.'},
            {'^','.','.','.','*','*','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','~','~','~','.','.','.','.'},
            {'.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.'},
            {'.','.','.','~','~','~','.','.','.','.','.','.','*','*','.','.','.','.','.','.','.','.','.','.','.','.','.','.'},
            {'.','.','.','~','~','~','.','.','.','.','.','.','*','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.'},
            {'.','.','~','~','~','~','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','^','^','.','.','.','.','.'},
            {'.','.','.','.','~','~','~','.','.','.','.','.','.','.','.','.','.','.','.','.','^','^','^','^','.','.','.','.'},
            {'.','.','.','.','~','~','~','~','.','.','.','.','.','.','.','.','.','.','.','.','.','.','^','^','^','^','.','.'},
            {'.','.','.','.','.','.','~','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.'},
            {'.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.','.'},
            
        };
        
        static int bord = map.GetLength(1);

        // map legend:
        // ^ = mountain
        // . = grass
        // ~ = water
        // * = trees
        

        static void Main(string[] args)
        {
            
            DisplayMapScale(3);
            Console.ReadKey(true);

        }
         static void DisplayMap()
         {
            
            Console.WriteLine("+" + new string('-', bord) + "+");
            for (int y = 0; y <= 9; y = y + 1) 
            {
                Console.Write("|");
               for (int x = 0; x <= 27; x = x + 1)
               {
                    Console.Write(map[y, x]);
               }
                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("+" + new string('-', bord) + "+");


         }
        static void DisplayMapScale(int scale)
        {
            
            Console.WriteLine("+" + new string('-', bord * scale) + "+");
            for (int y = 0; y <= 9; y = y + 1)
            {
                
                for (int b = 0; b < scale; b = b + 1)
                {

                    Console.Write("|");
                    for (int x = 0; x <= 27; x = x + 1)
                    {
                        for (int a = 0; a < scale; a = a + 1)
                        {
                            if(map[y, x] == '^')
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                            }
                            else if (map[y, x] == '.')
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                            }
                            else if (map[y, x] == '~')
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                            }
                            else if (map[y, x] == '*')
                            {
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                            }
                            else 
                            {
                                Console.ForegroundColor = ConsoleColor.White;
                            }

                            Console.Write(map[y, x]);
                            
                        }

                        

                    }
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("|");
                    Console.WriteLine();
                }
                    

            }

            Console.WriteLine("+" + new string('-', bord * scale) + "+");
        }    



    }
    
    
}

