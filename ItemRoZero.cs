using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ArkaikSyncItemsOptions
{
    public class ItemRoZero
    {
        public int Item { get; set; }
        public string Desc { get; set; }
        public Potential Potential { get; set; }
        public string Rarity { get; set; }
        public int GemSlot { get; set; }
        public List<ItemModifier> Modifier { get; set; }
    }

    public class Potential
    {
        public int Min { get; set; }
        public int Max { get; set; }
    }

}
