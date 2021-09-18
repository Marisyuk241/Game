 using System;
    using System.IO;
    using System.Linq;
    using System.Collections.Generic;
    using cod;
    namespace cod
    {
        public class Game
        {
            private short number_of_attempts = 5;
            private int number;
            public Game()
            {
                Random rand = new Random();
                number = rand.Next(1, 100);
            }
            public short Number_of_attempts
            {
                set { number_of_attempts = value; }
                get { return number_of_attempts; }
            }
            public int Number
            {
                set { number = value; }
                get { return number; }
            }
            public void Reset()
            {
                Random rand = new Random();
                number = rand.Next(1, 100);
                number_of_attempts = 5;
            }
            public bool Get_right(short n)
            {
                if (n < number)
                {
                    Console.WriteLine("the number is greater");
                }
                if (n > number)
                {
                    Console.WriteLine("number less");
                }
                return n == number;
            }
        }
    }