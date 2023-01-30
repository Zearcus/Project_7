using Project_7;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Project_7
{
    public class Inventory
    {
        public List<ItemBase> Equipements = new()
        {
            Items.Instance[Armor.Chestplate],
            Items.Instance[Weapon.LongSword],
        };

        public List<ItemBase> Backpack = new List<ItemBase>()
        {
            Items.Instance[MedicalItem.Potion],
        };
    }
}