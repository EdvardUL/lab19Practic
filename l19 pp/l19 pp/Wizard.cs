using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l19_pp
{
    class Wizard:Character
    {
        public int currentMana;
        public int maxMana;
        public List<Spell> spells = new List<Spell>();
        public string spell = @"Введите номер заклинания:
            1-Поднять хп
            2-«Вылечить»
            3-«Противоядие»
            4-«Оживить»
            5-«Броня»
            6-«Отомри!»";

        public Wizard(int _MaxMana,int _currentMana,string _Name, string _State, bool _TalkPossibility, bool _WalkPossibility, string _Race, string _Gender, int _Age, int _CurrentHP, int _Exp, int _MaxHP):base(_Name, _TalkPossibility,_WalkPossibility,_Race,_Gender,_Age,_CurrentHP,_Exp, _MaxHP)
        {
            currentMana = _currentMana;
            maxMana = _MaxMana;
        }
        public override void AddArtifact()
        {
            string s = @"Введите номер предмета:
            1-Бутылка с живой водой
            2-Бутылка с мертвой водой
            3-Посох «Молния»
            4-Декокт из лягушачьих лапок
            5-Ядовитая слюна
            6-Глаз василиска";
            Console.WriteLine(s);
            int a = Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case 1:
                    {
                        SaintBottle obj1 = new SaintBottle();
                        inventory.Add(obj1);
                        break;
                    }
                case 2:
                    {
                        DeadBottle obj2 = new DeadBottle();
                        inventory.Add(obj2);
                        break;
                    }
                case 3:
                    {
                        StaffOfFlash obj3 = new StaffOfFlash();
                        inventory.Add(obj3);
                        break;
                    }
                case 4:
                    {
                        DecoctOfFrogLegs obj4 = new DecoctOfFrogLegs();
                        inventory.Add(obj4);
                        break;
                    }
                case 5:
                    {
                        PoisonedSplit obj5 = new PoisonedSplit();
                        inventory.Add(obj5);
                        break;
                    }
                case 6:
                    {
                        EyeOfBasilisk obj6 = new EyeOfBasilisk();
                        inventory.Add(obj6);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Ошибка");
                        break;
                    }

            }
        }
        public override string ToString()
        {
            return base.ToString()+$"\nМана:{currentMana}\nМаксимальное значение{maxMana}";
        }
        public void ChangeMana(int countOfneededmana)
        {
            if(countOfneededmana>currentMana)
            { Console.WriteLine("Ошибка"); }
            else
            { currentMana -= countOfneededmana; }
        }
        public void CastStrrenght(int strength)
        {
            if(strength>currentMana)
            {
                Console.WriteLine("");
            }
            else
            {
                currentMana -= strength;
            }
        }
        public void addSpell()
        {
            Console.WriteLine("Каждое заклинание можно добавить только один раз");
            Console.WriteLine(spell);
            int a = Convert.ToInt32(Console.ReadLine());
            switch(a)
            {
                case 1:
                    {
                        RestoreHP obj1 = new RestoreHP();
                        spells.Add(obj1);
                        spell.Replace("1-Поднять хп"," ");
                        break;
                    }
                case 2:
                    {
                        HeaL obj2 = new HeaL();
                        spells.Add(obj2);
                        spell.Replace("2-«Вылечить»"," ");
                        break;
                    }
                case 3:
                    {
                        Antidote obj3 = new Antidote();
                        spells.Add(obj3);
                        spell.Replace("3-«Противоядие»"," ");
                        break;
                    }
                case 4:
                    {
                        Revive obj4 = new Revive();
                        spells.Add(obj4);
                        spell.Replace("4-«Оживить»"," ");
                        break;
                    }
                case 5:
                    {
                        Armor obj5 = new Armor();
                        spells.Add(obj5);
                        spell.Replace("5-«Броня»"," ");
                        break;
                    }
                case 6:
                    {
                        Unparalize obj6 = new Unparalize();
                        spells.Add(obj6);
                        spell.Replace("6-«Отомри!»"," ");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Добавленны все заклинания");
                        break;
                    }

            }
        }
        public void DelSpell()
        {
            Console.WriteLine("Введите номер заклинания для забытия:");
            int a = Convert.ToInt32(Console.ReadLine());
            inventory.RemoveAt(a);
        }
        public void UseSpell()
        {
            Console.WriteLine("Введите номер заклинания для использования:");
            int a = Convert.ToInt32(Console.ReadLine());
            spells[a].Use(this);
        }
        public void PrintListOfSpells()
        {
            Console.WriteLine($"List currently has {spells.Count} elements.");
            Console.Write("List contents:\n");
            for (int i = 0; i < spells.Count; i++)
            {
                Console.Write($"Номер {i}: {spells[i]}");
                Console.WriteLine("\n");
            }
            Console.WriteLine("\n");
        }
    }
}
