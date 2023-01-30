using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_7
{
    public class Items
    {
        private static readonly Lazy<Items> singleton = new Lazy<Items>(new Items());
        public static Items Instance => singleton.Value;

        public readonly Dictionary<MedicalItem, Consumables> Medicals = new()
        {
            {
                MedicalItem.Potion,
                new()
                {
                    Name = "Potion",
                    Healing = 15,
                    Value = 75,
                    Description = "Simple bandage to dress minor injuries."
                }
            }

        };

        public readonly Dictionary<Weapon, Weapons> Weapons = new()
        {
            {
                Weapon.LongSword,
                new()
                {
                    Name = "Long Sword",
                    PhysicalDmg = 5,
                    Crit = 5,
                    Value= 100,
                    Description = "A long sword. Perfect for warriors."
                }
            }
        };

        public readonly Dictionary<Armor, Armors> Armors = new()
        {
            {
                Armor.Chestplate,
                new()
                {
                    Name = "Chestplate",
                    PhysicalDef = 5,
                    Value = 200,
                    Description = "A chestplate to protect you from deadly injuries."
                }
            }
        };

        public Consumables this[MedicalItem key] => Medicals[key];
        public Weapons this[Weapon key] => Weapons[key];
        public Armors this[Armor key] => Armors[key];
    }
    public class Weapons : ItemBase
    {
        public float PhysicalDmg { get; init; }
        public float Crit { get; init; }
    }

    public class Armors : ItemBase
    {
        public float PhysicalDef { get; init; }
    }

    public class Consumables : ItemBase
    {
        public float Healing { get; init; }
    }

    public enum MedicalItem { Potion }
    public enum Weapon { LongSword }
    public enum Armor { Chestplate }

};
