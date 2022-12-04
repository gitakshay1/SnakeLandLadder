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
                Random rnd= new Random();
                Console.WriteLine("Your Position is " + Position);
                Console.WriteLine("Enter to rolls the Die");
                Console.ReadLine();
                int Num_on_Die = rnd.Next(1,6);
                Console.WriteLine("Die Number is " + Num_on_Die);
                Position = Position + Num_on_Die;
           
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
            Console.WriteLine("Your Position is 100 \n You Won ");

        }
    }
}
