using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Project_7
{
    public class Battle
    {
        public static List<Actions> Actions;
        public static List<Skills> SkillList;
        Player p = new Player();
        Enemies e = new Enemies();
        Random RNG = new Random();
        public Battle() 
        {
            
        }
        
        public void BattleScene () 
        {
            Actions = new List<Actions>
            {
                new Actions("Attack", ()=>Attack()),
                new Actions("Skills", ()=>Skills()),
                new Actions("Items", ()=>UseItems()),
            };

            int index = 0;

            WriteMenu(Actions, Actions[index]);

            ConsoleKeyInfo keyInfo;
            do
            {
                keyInfo = Console.ReadKey();
                
                if (keyInfo.Key == ConsoleKey.S)
                {
                    if (index + 1 < Actions.Count) 
                    {
                        index++;
                        WriteMenu(Actions, Actions[index]);
                    }
                }
                if (keyInfo.Key == ConsoleKey.Z)
                {
                    if (index - 1 >= 0)
                    {
                        index--;
                        WriteMenu(Actions, Actions[index]);
                    }
                }
                if (keyInfo.Key == ConsoleKey.Enter) 
                {
                    Actions[index].Selected.Invoke();
                    index = 0;
                }
            }
            while (keyInfo.Key != ConsoleKey.X);

            Console.ReadKey();

        }


        public void Attack ()
        {
            int index = 0;
            e.CurrentHp -= RNG.Next(p.Strenght,p.Strenght + 3);
            Console.WriteLine("You dealt" + RNG.Next(p.Strenght, p.Strenght + 3) + "to the enemy");
            System.Threading.Thread.Sleep(1000);
            WriteMenu(Actions, Actions[index]);
        }

        public void Skills () 
        {
            
        }

        public void UseItems ()
        {
            
        }
        public void TakeTurn ()
        {

        }

        void WriteMenu(List<Actions> actions, Actions selectedOption)
        {
           
            Console.Clear();

            Console.WriteLine("======================================");
            Console.WriteLine("Player HP :" + p.CurrentHp + "         Enemy HP :" + e.CurrentHp);
            Console.WriteLine("Player MP :" + p.CurrentMp + "         Enemy MP :" + e.CurrentMp);
            Console.WriteLine("LVL :" + p.Level + "                LVL :" + e.Level);
            Console.WriteLine("======================================");

            foreach (Actions action in actions)
            {
                if (action == selectedOption)
                {
                    Console.Write("> ");
                }
                else
                {
                    Console.Write(" ");
                }

                Console.WriteLine(action.Name);
            }
        }

        void WriteSkills(List<Actions> actions, Actions selected)
        {
            Console.Clear();

            Console.WriteLine("======================================");
            Console.WriteLine("                  Skills");
            foreach (Actions action in actions)
            {

            }
            
        }
    }
}
