using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_QA
{
    abstract class Player
    {
        private int health;
        private string name;
        private int armorPoints;
        private string gender;

        private List<string> inventory;
        private string[] armor;
        

        public Player(string name)
        {
            this.name = name;

            this.inventory = new List<string>();
            this.inventory.Add("apple");
            this.inventory.Add("pen");

            this.armor = new string[5];
            this.armor[0] = "Helmet";
            this.armor[3] = "Chestplate";
            this.armor[4] = "Boots";

        }

        public abstract void Kill();

        public void ShowInventory()
        {
            Console.WriteLine("Inventory: ");
            for (int i = 0; i < this.inventory.Count; i++)
            {

                Console.WriteLine(this.inventory[i]);
            }
        }

        public void ShowArmor()
        {
            Console.WriteLine("Armor: ");
            for (int i = 0; i < this.armor.Length; i++)
            {
                Console.WriteLine(this.armor[i]);
            }
        }

        public string GetName()
        {
            return this.name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }



    }
}
