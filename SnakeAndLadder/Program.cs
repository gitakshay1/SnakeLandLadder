using System;
namespace Snake_Ladder
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int Position = 0; Position <= 100;)
            {
            Here:
                Random Num = new Random();
                Random Opt = new Random();
                Console.WriteLine("Your Position is " + Position);
                Console.WriteLine("\nEnter to rolls the Die");
                Console.ReadLine();
                int Num_on_Die = Num.Next(1,6);
                int Option=Opt.Next(0,3);
                Console.WriteLine("Die Number is " + Num_on_Die);
                switch (Option)
                {
                    case 0:
                        Console.WriteLine("Its No Play");
                        break;
                    case 1:
                        Console.WriteLine("Its Ladder");
                        Position = Position + Num_on_Die;
                        break;
                    case 2:
                        Console.WriteLine("Its Snake");
                        Position = Position - Num_on_Die;
                        if(Position <= 0)
                        {
                            Position= 0;
                        }
                        break;
                }
       
                if (Position >= 101)
                {
                    Position = Position - Num_on_Die;
                    goto Here;
                }
                if (Position == 100)
                {
                    break;
                }

            }
            Console.WriteLine("\nYour Position is 100 \n You Won ");

        }
    }
}
