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
                Console.WriteLine("Your Position is " + Position);
                Console.WriteLine("Enter Die Number 1 to 6 :");
                int Num_on_Die = Convert.ToInt16(Console.ReadLine());
                if (Num_on_Die <= 6)
                {
                    Position = Position + Num_on_Die;
                }
                else
                {
                    Console.WriteLine("Enter Valid Number");
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
            Console.WriteLine("Your Position is 100 \n You Won ");

        }
    }
}
