using System.Collections.Generic;

namespace LexiconGame
{
    internal class Cell
    {
        public List<Item> items { get; set; } = new List<Item>;
        private readonly string symbol;

        //ToDO: Remove?
        public Creature enemies { get; set; }

        public Cell()
        {
            symbol = ".";
        }
    }
}