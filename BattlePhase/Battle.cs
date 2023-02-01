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
        public Random RNG = new Random();
        public int index = 0;
        public Battle() 
        {
            
        }
        
        public void BattleScene () 
        {    
            Actions = new List<Actions>
            {
                new Actions("Attack", ()=>Attack()),
                new Actions("Skills", ()=>Attack()),
                new Actions("Items", ()=>UseItems()),
            };

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
            int _RNG = RNG.Next(p.Strenght, p.Strenght + 3);

            e.CurrentHp -= _RNG;
            Console.WriteLine("You dealt " + _RNG + " to the enemy.");
            System.Threading.Thread.Sleep(1000);
            WriteMenu(Actions, Actions[index]);
            TakeTurn();
            
        }

        public void Skills () 
        {
            
        }

        public void UseItems ()
        {
            ConsumablesInit.ConsumablesList["Potion"].Heal(10,p);
            System.Threading.Thread.Sleep(1000);
            WriteMenu(Actions, Actions[index]);
        }
        public void TakeTurn ()
        {
            int _RNGE = RNG.Next(e.Strenght, e.Strenght + 3);

            if (e.CurrentHp <= 0)
            {
                e.CurrentHp = 0;
            }
            else if (e.CurrentHp > 0)
            {
                p.CurrentHp -= _RNGE;
                Console.WriteLine("The enemy dealt " + _RNGE + " to you.");
                System.Threading.Thread.Sleep(1000);
                WriteMenu(Actions, Actions[index]);
            }
        }

        public void Victory () 
        { 
            if (e.CurrentHp == 0)
            {
                Console.WriteLine("You won the battle !");
                Console.WriteLine("You won " + e.Exp + " !");

                if (p.Exp >= p.LVL2)
                {
                    Console.WriteLine("You leveled up !");
                    Console.WriteLine("Strengt + 1");
                }
            }
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

        /*void WriteSkills(List<Skills> skilllist, Actions selected)
        {
            Console.Clear();

            Console.WriteLine("======================================");
            Console.WriteLine("                  Skills");
            foreach (Skills skill in skilllist)
            {
                if (skill == selected)
                {
                    Console.Write("> ");
                }
                else
                {
                    Console.Write(" ");
                }

                Console.WriteLine(skill.Name);
            }
        }*/
    }
}
