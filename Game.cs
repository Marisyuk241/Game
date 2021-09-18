using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using cod;
namespace cod
{
    
    class Program
    {

        static void Main(string[] args)
        {
            short thislo;
            bool a = true;
            Game game = new Game();
            Console.WriteLine("Комп`ютор загадал число УГАДАЙ?????");
            for (; a;)
            {
            //  Console.WriteLine(game.Number);

                thislo = Convert.ToInt16(Console.ReadLine());

                if (game.Get_right(thislo))
                {
                    a = false;
                    Console.WriteLine("victory");
                }
                else
                {
                    game.Number_of_attempts--;
                    if (game.Number_of_attempts < 1)
                    {
                        Console.WriteLine(game.Number);
                        game.Reset();
                        Console.WriteLine(" All over again");
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
