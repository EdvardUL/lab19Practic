using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l19_pp
{
    class Character : IComparable
    {
        public List<Artifact> inventory = new List<Artifact>();
        public readonly int ID = 0;
        public readonly string Name;
        private string hbState;
        public string HbState
        {
            set { hbState = value; }
            get { return hbState; }
        }
        private bool talkPossibility;
        private bool walkPossibility;
        public bool TalkPossibility
        {
            set
            {
                talkPossibility = value;
            }
            get
            {
                return talkPossibility;
            }
        }
        public bool WalkPossibility
        {
            set
            {
                walkPossibility = value;
            }
            get
            {
                return walkPossibility;
            }
        }
        public readonly string Race;
        public readonly string Gender;
        private int age;
        public int Age
        {
            set
            {
                age = value;
            }
            get { return age; }
        }
        public int currentHp;
        public int CurrentHP
        {
            set
            {
                currentHp = value;
                if (CurrentHP < (MaxHP / 10))
                {
                    hbState = "Ослаблен";
                }
                if (CurrentHP >= (MaxHP / 10))
                {
                    hbState = "Здоров";
                }
                if (CurrentHP == 0)
                {
                    hbState = "Мертв";
                }
            }
            get { return currentHp; }
        }
        public int maxhp;
        public int MaxHP
        {
            set
            {
                maxhp = value;
            }
            get { return maxhp; }
        }
        public int exp;
        public int Exp
        {
            set
            {
                exp = value;
            }
            get { return exp; }
        }
        public Character(string _Name,  bool _TalkPossibility, bool _WalkPossibility, string _Race, string _Gender, int _Age, int _CurrentHP, int _Exp, int _MaxHP)
        {
            ID = ID + 1;
            Name = _Name;
            this.TalkPossibility = _TalkPossibility;
            this.WalkPossibility = _WalkPossibility;
            Race = _Race;
            Gender = _Gender;
            Age = _Age;
            CurrentHP = _CurrentHP;
            Exp = _Exp;
            MaxHP = _MaxHP;
            if (CurrentHP < (MaxHP / 10))
            {
                hbState = "Ослаблен";
            }
            else if (CurrentHP >= (MaxHP / 10))
            {
                hbState = "Здоров";
            }
            else if (CurrentHP == 0)
            {
                hbState = "Мертв";
            }
        }
        public int CompareTo(object obj)
        {
            return Exp.CompareTo(obj);
        }
        public override string ToString()
        {
            return $"Имя:{Name}\nВозвраст:{Age}\nРаса:{Race}\nID:{ID}\nСостояние:{hbState}\nПерсонаж может ходить?{WalkPossibility}\nПерсонаж может говорить?{TalkPossibility}\nОпыт персонажа:{Exp}\nТекущее хп:{CurrentHP}\nМаксимальное хп:{MaxHP}";
        }
        virtual public void AddArtifact()
        {
            string s = @"Введите номер предмета:
            1-Бутылка с живой водой
            2-Посох «Молния»
            3-Декокт из лягушачьих лапок
            4-Ядовитая слюна
            5-Глаз василиска";
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
                        StaffOfFlash obj2 = new StaffOfFlash();
                        inventory.Add(obj2);
                        break;
                    }
                case 3:
                    {
                        DecoctOfFrogLegs obj3 = new DecoctOfFrogLegs();
                        inventory.Add(obj3);
                        break;
                    }
                case 4:
                    {
                        PoisonedSplit obj4 = new PoisonedSplit();
                        inventory.Add(obj4);
                        break;
                    }
                case 5:
                    {
                        EyeOfBasilisk obj5 = new EyeOfBasilisk();
                        inventory.Add(obj5);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Ошибка");
                        break;
                    }

            }
        }
        public void PrintInventory()
        {
            Console.WriteLine($"В инвентаре {inventory.Count} предметов.");
            Console.Write("Инвентарь:\n");
            for (int i = 0; i < inventory.Count; i++)
            {
                Console.Write($"Номер {i}: {inventory[i]}");
                Console.WriteLine("\n");
            }
            Console.WriteLine("\n");
        }
        public void DelArtifact()
        {
            Console.WriteLine("Введите номер артифакта для удаления:");
            int a = Convert.ToInt32(Console.ReadLine());
            inventory.RemoveAt(a);
        }
        public void Use()
        {
            Console.WriteLine("Введите номер артифакта для использования:");
            int a = Convert.ToInt32(Console.ReadLine());
            inventory[a].Use(this);
            if(inventory[a].IsReusable==false)
            {
            inventory.RemoveAt(a);
            }
        }

    }
}
