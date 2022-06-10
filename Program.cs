using System;
using SnakeFramework.Interface;
using SnakeFramework.Models.Consol;

namespace ConsoleApp1_Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            IArea gameArea = new GameArea
            {
                X = 0,
                Y = 0,
                Width = 60,
                Height = 60,
                Color = ConsoleColor.DarkBlue
            };
            
            gameArea.AddBoxes(new Box(2, 6, 30, 3), new Box(15, 1, 20, 20), new Box(8, 3, 20, 45));
            
            Boa boa = new Boa()
            {
                X = 4,
                Y = 4,
                BackgroundColor = ((GameArea)gameArea).Color,
                BoaColor = ConsoleColor.Yellow
            };

            Food food = new Food(10, 10);

            Game game = new Game() { GameArea = gameArea, Boa =  boa, Food = food};
            
            game.Start();
            Console.Clear();
            Console.WriteLine(game.GameResult);
            Console.WriteLine("Ваш счет: " + game.Score);
            //Console.ReadKey();
        }
    }
}
