using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.IO;

namespace Game1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;

            List<string> Players = new List<string>();

            int playerRandomNum;
            int playerRandomNum2;
            int playerRandomNum3;
            int playerRandomNum4;
            int playerRandomNum5;
            int playerRandomNum6;
            int playerRandomNum7;
            int playerRandomNum8;
            int playerRandomNum9;
            int enemyRandomNum;
            int enemyRandomNum2;
            int enemyRandomNum3;
            int enemyRandomNum4;
            int enemyRandomNum5;
            int enemyRandomNum6;
            int enemyRandomNum7;
            int enemyRandomNum8;
            int enemyRandomNum9;
            int opponentRandomNum;
            int opponentRandomNum2;
            int opponentRandomNum3;
            int opponentRandomNum4;
            int opponentRandomNum5;
            int opponentRandomNum6;
            int opponentRandomNum7;
            int opponentRandomNum8;
            int opponentRandomNum9;

            string round1opponentTotal = "";
            string round2opponentTotal = "";
            string round3opponentTotal = "";



            Random random = new Random();
            while (!endApp)
            {
                Console.Clear();
                PrintTitle();


                int numberOfPlayer;
                while (true)
                {
                    Console.Write("How many people are playing this game? (2-5): ");
                    string answer = Console.ReadLine();

                    if (int.TryParse(answer, out numberOfPlayer))
                    {
                        if (2 <= numberOfPlayer && numberOfPlayer <= 5) break;
                        Console.WriteLine("Please enter 2 to 5");
                    }
                    else Console.WriteLine("Please enter a number");
                }

                for (int i = 0; i < numberOfPlayer; i++)
                {
                    Console.Write($"Enter name for player {i + 1}: ");
                    Players.Add(Console.ReadLine());
                }

                Console.ReadKey();
            }
        }

        static void PrintTitle()
        {
            Console.WriteLine(@"=====================================================================================");
            Console.WriteLine(@"   ______      _                __           __  __                _ ____            ");
            Console.WriteLine(@"  / ____/___  (_)___  ____ _   / /_____     / / / /___ _____ ___  (_) / /_____  ____ ");
            Console.WriteLine(@" / / __/ __ \/ / __ \/ __ `/  / __/ __ \   / /_/ / __ `/ __ `__ \/ / / __/ __ \/ __ \");
            Console.WriteLine(@"/ /_/ / /_/ / / / / / /_/ /  / /_/ /_/ /  / __  / /_/ / / / / / / / / /_/ /_/ / / / /");
            Console.WriteLine(@"\____/\____/_/_/ /_/\__, /   \__/\____/  /_/ /_/\__,_/_/ /_/ /_/_/_/\__/\____/_/ /_/ ");
            Console.WriteLine(@"                   /____/                                                            ");
            Console.WriteLine(@"=====================================================================================");
        }
    }
}
