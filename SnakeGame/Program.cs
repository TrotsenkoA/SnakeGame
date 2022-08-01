using System;
using static System.Console;

namespace SnakeGame
{
    class Program
    {
        private const int MapWidth = 30;
        private const int MapHeight = 20;

        private const ConsoleColor BorderColor = ConsoleColor.Gray;
            static void Main()
        {
            SetWindowSize(MapWidth, MapHeight);
            SetBufferSize(MapWidth, MapHeight);
            CursorVisible = false;

            DrawBorder();

            ReadKey();
                    
        }

        static void DrawBorder()
        {
            for (int i = 0; i < MapWidth; i++)
            {
                new Pixel(x: i, y: 1, BorderColor).Draw();
                new Pixel(x: i, y: MapHeight - 1, BorderColor).Draw();
            }

            //for (int i = 0; i < MapHeight; i++)
            //{
            //    new Pixel(x: 0, y: i, BorderColor).Draw();
            //    new Pixel(x: MapWidth - 1, y: i, BorderColor).Draw();
            //}
        }
    }
}
