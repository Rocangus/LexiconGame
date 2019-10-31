using System;

namespace LexiconGame
{
    internal class Map
    {
        public int Width { get; }
        public int Height { get; }

        //ToDo: Make comment
        public readonly Cell[,] cells;
        public Map(int width, int height)
        {
            Width = width;
            Height = height;

            cells = new Cell[height, width];

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; y++)
                {
                    cells[y, x] = new Cell();
                }
            }
        }

        
    }
}

