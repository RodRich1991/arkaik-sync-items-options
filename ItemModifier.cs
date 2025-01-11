using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArkaikSyncItemsOptions
{
    public class ItemModifier
    {
        public int Level { get; set; }
        public Durability Durability { get; set; }
        public List<RandomOption>? RandomOption { get; set; }
    }

    public class Durability
    {
        public int Min { get; set; }
        public int Max { get; set; }
    }

    public class RandomOption
    {
        public int? Id { get; set; }
        public string? Option { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
    }
}
