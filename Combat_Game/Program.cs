using System;
namespace Combat_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerHp = 20;
            int enemyHp = 40;

            int playerAttack = 5;
            int enemyAttack = 7;
            int healAmount = 5;
            Random rand = new Random();

            while(playerHp > 0 && enemyHp > 0)
            {
                //player turn
                Console.WriteLine("--player--turn---");
                Console.WriteLine("Player Hp - " + playerHp +  ". enemy hp - " + enemyHp);
                Console.WriteLine("Enter 'a' to attack or 'h' to heal");

                string choice = Console.ReadLine();

                if (choice == "a")
                {
                    enemyHp -= playerHp;
                    Console.WriteLine("Player attack enemy and deala" + playerAttack + "damage!");
                }
                else
                {
                    playerAttack += healAmount;
                    Console.WriteLine("Player restores" + healAmount + "health points!");
                }

                //emeny turn
                if(enemyHp > 0)
                {
                    Console.WriteLine("--enemy turn");
                    Console.WriteLine("Player Hp - " + playerHp + ". enemy hp - " + enemyHp);
                    int enemyChoice = rand.Next(0, 2);

                    if(enemyChoice == 0)
                    {
                        playerHp -= enemyAttack;
                        Console.WriteLine("Enemy attacka and dea" + enemyAttack + "damage");
                    }
                    else
                    {
                        enemyHp += healAmount;
                        Console.WriteLine("Enemy retores" + healAmount + "health ponits" );
                    }
                }
            }
            if(playerHp > 0)
            {
                Console.WriteLine("congratulation youhave won");
            }
            else
            {
                Console.WriteLine("oops! you loose");
            }
        }
    }
}