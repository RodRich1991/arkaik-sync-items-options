using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArkaikSyncItemsOptions
{
    public class ItemRaEquip
    {
        public int Id { get; set; }
        public string AegisName { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string? SubType { get; set; }
        public int? Buy { get; set; }
        public int? Weight { get; set; }
        public int? Attack { get; set; }
        public int? Range { get; set; }
        public int? Slots { get; set; }
        public Job? Jobs { get; set; }
        public Location? Locations { get; set; }
        public int? WeaponLevel { get; set; }
        public int? EquipLevelMin { get; set; }
        public bool? Refineable { get; set; }
        public string? Script { get; set; }
        public string? EquipScript { get; set; }
        public Trade? Trade { get; set; }
        public List<ItemModifier> Modifier { get; set; }
    }

    public class Job
    {
        public bool? Alchemist { get; set; }
        public bool? Assassin { get; set; }
        public bool? Blacksmith { get; set; }
        public bool? Crusader { get; set; }
        public bool? Knight { get; set; }
        public bool? Merchant { get; set; }
        public bool? Novice { get; set; }
        public bool? Rogue { get; set; }
        public bool? SuperNovice { get; set; }
        public bool? Swordman { get; set; }
        public bool? Thief { get; set; }
    }

    public class Location
    {
        public bool? Right_Hand { get; set; }
        public bool? Both_Hand { get; set; }
    }

    public class Trade
    {
        public int? Override { get; set; }
        public bool? NoDrop { get; set; }
        public bool? NoTrade { get; set; }
        public bool? NoSell { get; set; }
        public bool? NoCart { get; set; }
        public bool? NoStorage { get; set; }
        public bool? NoGuildStorage { get; set; }
        public bool? NoMail { get; set; }
        public bool? NoAuction { get; set; }
    }
}
