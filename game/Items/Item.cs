using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game.Items
{
    internal class Item
    {
        internal string Name { get; set; }
        internal string Description { get; set; }
        internal int BuyValue { get; set; }
        internal int SellValue { get; set; }
        internal bool IsSpecial { get; set; }
        internal int TurnCostToUse { get; set; }
        internal int TurnDurationOfUse { get; set; }
        internal bool IsUsable { get; set; }
    }
}
