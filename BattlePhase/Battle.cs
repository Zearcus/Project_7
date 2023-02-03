using Microsoft.VisualBasic.FileIO;
using Project_7;
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
        public static List<SkillsActions> SkillList;
        Player p = new Player();
        Enemies e = new Enemies("Quadrillator");
        public Random RNG = new Random();
        public int index = 0;
        int Pot = 3;
        public Battle() 
        {
            
        }
        
        public void BattleScene () 
        {    
            Actions = new List<Actions>
            {
                new Actions("Attack", ()=>Attack()),
                new Actions("Skills", ()=>Skillscene()),
                new Actions("Potion", ()=>Potion()),
            };

            WriteBattleMenu(Actions, Actions[index]);

            ConsoleKeyInfo keyInfo;
            do
            {
                keyInfo = Console.ReadKey(true);
                
                if (keyInfo.Key == ConsoleKey.S)
                {
                    if (index + 1 < Actions.Count) 
                    {
                        index++;
                        WriteBattleMenu(Actions, Actions[index]);
                    }
                }
                if (keyInfo.Key == ConsoleKey.Z)
                {
                    if (index - 1 >= 0)
                    {
                        index--;
                        WriteBattleMenu(Actions, Actions[index]);
                    }
                }
                if (keyInfo.Key == ConsoleKey.Enter) 
                {
                    Actions[index].Selected.Invoke();
                    index = 0;
                }
            }
            while (keyInfo.Key != ConsoleKey.X);

            System.Threading.Thread.Sleep(1000);
            BattleScene();

        }

        public void Attack ()
        {
            int _RNG = RNG.Next(p.Strenght, p.Strenght + 3);

            e.CurrentHp  -= (_RNG -= (e.Armor / 2));
            Console.WriteLine("You dealt " + _RNG + " to the enemy.");
            System.Threading.Thread.Sleep(1000);
            WriteBattleMenu(Actions, Actions[index]);
            TakeTurn();
            Victory();
            
        }

        public void Skillscene () 
        {

            SkillList = new List<SkillsActions>
            {
                new SkillsActions("Heavy Slash", ()=>SkillsInit.SkillList["Heavy Slash"].HeavySlash(10,5,e,p)),
            };

            WriteSkills(SkillList, SkillList[index = 0]);

            ConsoleKeyInfo keyInfo;
            do
            {
                keyInfo = Console.ReadKey(true);

                if (keyInfo.Key == ConsoleKey.S)
                {
                    if (index + 1 < SkillList.Count)
                    {
                        index++;
                        WriteSkills(SkillList, SkillList[index]);
                    }
                }
                if (keyInfo.Key == ConsoleKey.Z)
                {
                    if (index - 1 >= 0)
                    {
                        index--;
                        WriteSkills(SkillList, SkillList[index]);
                    }
                }
            }
            while (keyInfo.Key != ConsoleKey.Enter);

            SkillList[index].Selected.Invoke();
            index = 0;
            TakeTurn();
            Victory();
            BattleScene();

        }

        public void Potion ()
        {
            
            if (Pot > 0)
            {
                Pot -= 1;
                ConsumablesInit.ConsumablesList["Potion"].Heal(15,3,p);
                Console.WriteLine("You Still have " + Pot + " Potions.");
                System.Threading.Thread.Sleep(1000);
                TakeTurn();
                System.Threading.Thread.Sleep(1000);
                WriteBattleMenu(Actions, Actions[index]);
            }
            else
            {
                Console.WriteLine("You don't have anymore potions");
                WriteBattleMenu(Actions, Actions[index]);
            }

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
                p.CurrentHp -= (_RNGE -= (p.Armor / 2));
                Console.WriteLine("The enemy dealt " + _RNGE + " to you.");
                System.Threading.Thread.Sleep(1000);
                WriteBattleMenu(Actions, Actions[index]);
            }
        }

        public void Victory () 
        { 
            if (e.CurrentHp == 0)
            {
                Console.WriteLine("You won the battle !");
                Console.WriteLine("You won " + e.Exp + " exp !");
                System.Threading.Thread.Sleep(1000);

                if (p.Exp >= p.LVL2)
                {
                    Console.WriteLine("You leveled up !");
                    System.Threading.Thread.Sleep(500);
                    Console.WriteLine("Strenght + 1"); p.Strenght += 1;
                    System.Threading.Thread.Sleep(500);
                    Console.WriteLine("Hp + 3"); p.MaxHp += 3;
                    System.Threading.Thread.Sleep(500);
                    Console.WriteLine("Armor + 1"); p.Armor += 1;
                    System.Threading.Thread.Sleep(500);
                    p.Exp = 0;
                }
                p.battle = false;
            }
            else if (p.CurrentHp <= 0)
            {
                Console.WriteLine("You lost the battle !");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("Luckly a wanderer was passing by and saved you in-extremis.");
                p.CurrentHp = p.MaxHp;
                p.battle = false;
            }
            p.battle = false;
        }

        public void WriteBattleMenu(List<Actions> actions, Actions selectedOption)
        {
           
            Console.Clear();

            Console.WriteLine("======================================");
            Console.WriteLine("Player Name :" + "           Enemy Name : ");
            Console.WriteLine("Player HP :" + p.CurrentHp + "/" + p.MaxHp + "      Enemy HP :" + e.CurrentHp + "/" + e.MaxHp );
            Console.WriteLine("Player MP :" + p.CurrentMp + "/" + p.MaxMp + "      Enemy MP :" + e.CurrentMp + "/" + e.MaxMp);
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

        public void WriteSkills(List<SkillsActions> skills, SkillsActions selected)
        {
            Console.Clear();

            Console.WriteLine("======================================");
            Console.WriteLine("                  Skills");
            foreach (SkillsActions skill in skills)
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
        }
    }
}
