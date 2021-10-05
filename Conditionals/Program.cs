using System;

namespace Conditionals
{
    class Program
    {

        static string Role = "Barbarian";

        static string Race = "Human";

        static int Level = 1;

        static float exp = 0f;

        static int health = 100;

        static int lives = 5;

        static float expMultip = 2.5f;

        static int weapon = 0;

        static string hands = "Hands";

        static string sword = "Sword";

        static string axe = "Axe";

        static string mace = "Mace";

        static string whip = "Whip";

        static string health1 = "You Feel Healthy!";

        static string health2 = "You feel a little beaten up.";

        static string health3 = "Your vision is getting blurry...";

        static string health4 = "You are fighting off unconsciousness";

        static string health5 = "You have died...";


        static void HealthState()
        {
            if (health >= 80)
            {
                Console.WriteLine(health1);
            }
            if (health <= 79 && health >= 60)
            {
                Console.WriteLine(health2);
            }
            if (health <= 59 && health >= 40)
            {
                Console.WriteLine(health3);
            }
            if (health <= 39 && health >= 20)
            {
                {
                    Console.WriteLine(health4);
                }
                if (health <= 0)
                {
                    Console.WriteLine(health5);
                }
            }
        }

            static void WeaponChangeRand()
            {
            weapon = new Random().Next(0, 4);
            }

            static void WeaponChange(int wep)
            {
            weapon = wep;
            }
            
            static void EXPMultiplier(int expM)
            {
                exp = expM * expMultip + exp;
            }

            static void TakeDamage(int damage)
            {
                health = health - damage;
            }

            static void Heal(int heal)
            {
                health = health + heal;
                if (health >= 100)
                {
                    health = 100;
                }

            }

            static void Death()
            {
            if (health <= 0)
            {
                lives = lives - 1;
                health = 100;
                Console.WriteLine("");
                Console.WriteLine("You lost a life!");
                Console.WriteLine("");
            }
            }

            static void LevelUp()
            {
                if (exp >= 100)
                {
                    exp = exp - 100;
                    Level = Level + 1;
                    Console.WriteLine("");
                    Console.WriteLine("You Leveled up!");
                    Console.WriteLine("");
                }

            }

            static void ShowHUD()
            {
                LevelUp();
                Death();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("|" + "Class:" + Role + "                        |");
                Console.WriteLine("|" + "Race:" + Race + "                             |");
                Console.WriteLine("|" + "Weapon:"); Weapon();
                Console.WriteLine("|" + "Level:" + Level + "  " + "Exp:" + exp + "                       |");
                Console.WriteLine("|" + "Current Health:" + health + "  " + "Current Lives:" + lives + "   |");
                Console.WriteLine("--------------------------------------");
                HealthState();
                Console.WriteLine("");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.ForegroundColor = ConsoleColor.White;
            }

            static void Weapon()
            {
                if (weapon <= -1)
                {
                    Console.WriteLine(hands);
                }
                if (weapon == 0)
                {
                    Console.WriteLine(hands);
                }
                if (weapon == 1)
                {
                    Console.WriteLine(sword);
                }
                if (weapon == 2)
                {
                    Console.WriteLine(axe);
                }
                if (weapon == 3)
                {
                    Console.WriteLine(mace);
                }
                if (weapon == 4)
                {
                    Console.WriteLine(whip);
                }
                if (weapon >= 5)
                {
                    Console.WriteLine(hands);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Altervis");
            Console.WriteLine("Press any key to start");
            Console.ReadKey();

            ShowHUD();

            Console.WriteLine("You fight a bear with your hands");
            Console.WriteLine("");
            Console.WriteLine("He deals 44 damage to you");
            TakeDamage(44);
            Console.WriteLine("");
            Console.WriteLine("You defeat the bear");
            Console.WriteLine("");
            Console.WriteLine("You gain 30 EXP!");
            EXPMultiplier(30);
            Console.WriteLine("");
            Console.WriteLine("You see a small chest in the corner");
            Console.WriteLine("");
            Console.WriteLine("Inside you find a...");
            WeaponChangeRand();
            Weapon();
            Console.ReadKey();

            ShowHUD();

            Console.WriteLine("You go to town to trade in your weapon.");
            Console.WriteLine("");
            Console.WriteLine("You trade your...");
            Weapon();
            Console.WriteLine("for a better weapon.");
            Console.WriteLine("");
            Console.WriteLine("You choose a nice whip");
            WeaponChange(4);
            Console.ReadKey();

            ShowHUD();

            Console.WriteLine("You chug and HP potion");
            Console.WriteLine("");
            Console.WriteLine("It restores 50 health");
            Heal(50);
            Console.ReadKey();

            ShowHUD();

            Console.WriteLine("You and a guard get in a fight");
            Console.WriteLine("");
            Console.WriteLine("You both stab each other!");
            Console.WriteLine("");
            Console.WriteLine("You killed the guard but slowly bleed out after");
            Console.WriteLine("");
            Console.WriteLine("You gained 40 EXP and lost 120HP");
            TakeDamage(120);
            EXPMultiplier(40);
            Console.ReadKey();

            ShowHUD();

















        }
    }
}
