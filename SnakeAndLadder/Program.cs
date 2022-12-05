using System;
namespace Snake_Ladder
{
    class Program
    {
        static void Main(string[] args)
        {
            int Position1 = 0, Position2 = 0;
            int Turn = 0;
            int Num_Dice_Played_Player1 = 0,Num_Dice_Played_Player2= 0;
            int n = 0, w = 0;
            for (int Position = 0; Position <= 100;)
            {
               
                Random Num = new Random();
                Random Opt = new Random();
                again:
                againn2:
                Console.WriteLine("Player1 Position is " + Position1);
                Console.WriteLine("Player2 Position is " + Position2);
                if (Turn == 0)
                {
                
                    Console.WriteLine("\nEnter to rolls the Die for player 1");
                   

                    int Num_on_Die = Num.Next(1, 6);
                    Num_Dice_Played_Player1++;
                    int Option = Opt.Next(0, 3);
                    Console.WriteLine("Die Number is " + Num_on_Die);
                    switch (Option)
                    {
                        case 0:
                            Console.WriteLine("Its No Play");
                            break;
                        case 1:
                            Console.WriteLine("Its Ladder");
                            Position1 = Position1 + Num_on_Die;
                            if (Position1 > 100)
                            {
                                Position1 = Position1 - Num_on_Die;
                            }
                            if (Position1 == 100)
                            {
                                n = Num_Dice_Played_Player1;
                                w = 1;
                                goto result;
                            }
                            goto again;
                            
                        case 2:
                            Console.WriteLine("Its Snake");
                            Position1 = Position1 - Num_on_Die;
                            if (Position1 <= 0)
                            {
                                Position1 = 0;
                            }
                            break;
                    }
                    
                    Turn = 1;
                    
                }
                else
                {
                    {
                                        
                        Console.WriteLine("\nEnter to rolls the Die for player 2");
                        Console.ReadLine();
                        int Num_on_Die = Num.Next(1, 6);
                        Num_Dice_Played_Player2++;
                        int Option = Opt.Next(0, 3);
                        Console.WriteLine("Die Number is " + Num_on_Die);
                        switch (Option)
                        {
                            case 0:
                                Console.WriteLine("Its No Play");
                                break;
                            case 1:
                                Console.WriteLine("Its Ladder");
                                Position2 = Position2 + Num_on_Die;
                                if(Position2>100)
                                {
                                    Position2 = Position2 - Num_on_Die;
                                }
                                if (Position2 == 100)
                                {
                                    n = Num_Dice_Played_Player2;
                                    w = 2;
                                    goto result2;
                                }
                                goto againn2;
                                
                            case 2:
                                Console.WriteLine("Its Snake");
                                Position2 = Position2 - Num_on_Die;
                                if (Position2 <= 0)
                                {
                                    Position2 = 0;
                                }
                                break;
                        }
                       
                        Turn = 0;
                     

                    }
                }
                
            }
            result:
            result2:
            Console.WriteLine("\nPlayer"+w+" Won \n Player1 position is"+Position1+"\nPlayer2 position is"+Position2+ "Number of Dice Played To win is " + n);
            
        }
    }
}
