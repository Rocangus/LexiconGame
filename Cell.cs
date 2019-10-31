using System.Collections.Generic;

namespace LexiconGame
{
    internal class Cell
    {
        public List<Item> items { get; set; } = new List<Item>;
        private readonly string symbol;

        public Cell()
        {
            symbol = ".";
        }
    }
}