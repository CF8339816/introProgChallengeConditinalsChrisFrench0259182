using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroProgConditionalsChrisFrench0259182
{
    internal class Program
    {

        enum weaponType
        {
            Fist = 0,
            Pistol = 1,
            RocketLauncher = 2,
            SniperRifle = 3,
        }

        static int weapon = weaponType;
        static int health = 100;
        static string healthStatus = hStats;
        static string Weapon = weaponName;
        static int EnemyHealth = 100;
        static string EnemyHealthStatus = EhStats;

        static void dealdamage(int weapontype);

        static



            }

        static void Main(string[] args)
        {
            HUD();

            dealdamage(weaponType);

            switch (EhStat)
            {
                case == 0:
                    Console.WriteLine($" Health is {EnemyHealth} Enemy is Dead. ");
                    break;
                case <= 10 + != 0:
            Console.WriteLine($" Health is {EnemyHealth} Enemy is in immiment danger. ");
                    break;
                case <= 49 + > 10:
            Console.WriteLine($" Health is {EnemyHealth} Enemy is badly hurt. ");
                    break;
                case <= 74 + > 49:
            Console.WriteLine($" Health is {EnemyHealth} Enemy is in hurt. ");
                    break;
                case <= 99 + > 74:
            Console.WriteLine($" Health is {EnemyHealth} Enemy is healthy. ");
                    break;
                case == 100:
                    Console.WriteLine($" Health is {EnemyHealth} Enemy is perfectly fit and healthy. ");
                    break;






                    If Ehealth > 0;

                    {
                        Console.WriteLine("Enemy still alive continue combat. ");
                    }

                    Else
                {
                        Console.WriteLine("Enemy defeated you can breath again. ");
                    }


            }
            static void HUD()
            {
                Console.WriteLine("{0,0}{1,13}{2,9}{3,12}", "health", "weapon", "Health Status");
                Console.WriteLine("{0,0}{1,10}{2,10}{3,10}", health, weaponName, hstat);

            }
        }
    }