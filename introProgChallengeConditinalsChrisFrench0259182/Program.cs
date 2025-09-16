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

        static int health = 100;
        static int enemyHealth = 100;
        static int weapon = 0;

        //  static string healthStat = isAlive;





        static void Main(string[] args)
        {

           // HUD();
           //     Console.ReadKey;

            //TakeDamage(20)

            // conditionals "if"

            //if(health > 0) //  you are alive


          //  bool isAlive = IsAlive();

            if (health == 100)
            {
                Console.WriteLine(" perfectly fit and healthy. ");
            }
            else if (health >= 75)
            {
                Console.WriteLine("You are healthy. ");
            }
            else if (health >= 50)
            {
                Console.WriteLine("You are in hurt. ");
            }
            else if (health >= 10)
            {
                Console.WriteLine(" You are badly hurt. ");
            }
            else if (health > 1)
            {
                Console.WriteLine("You are in immiment danger. ");
            }
            else if (health <= 0)
            {
                Console.WriteLine(" You are Dead. ");
            }




            /*
             static void DealDamageToEnemy(int amount)
            (
            enemyHealth -= amount;



        }

       /* static bool IsAlive()
        {
            if (health > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        static void HUD()
        {
            Console.WriteLine("{0,0}{1,9}", "health", "Health Status");
            Console.WriteLine("{0,0}{1,10}", health, healthStat);
        }




        /* class notes for methods  


                static int Square Number(int numToSquare)
                {
                    return numToSquare * numToSquare;
                }

                static string WriteClassInfo(string nameOfClass, int numOfStudents)
                {
                    string result = nameOfClass;
                    result += ": ";
                    result =+ numOfStudents;
                    result += "students";

                    return result;
                }



                static void TakeDamage(int damageammount)

                { 
                health -= damageammount;
                }


            
        enum weaponType
        {
            Fist = 0,
            Pistol = 1,
            RocketLauncher = 2,
            SniperRifle = 3,
        }

      
        static int weapon = weaponType;
        static int health = 100;
        //   static string healthStatus = hStats;
        
        static int EnemyHealth = 100;
      //  static string EnemyHealthStatus = EhStats;

        // static void dealdamage(int weapontype);

        static void hStat()
        {
            if (health == 100)
            {
                Console.WriteLine(" perfectly fit and healthy. ");
            }
            else if (health >= 75)
            {
                Console.WriteLine("You are healthy. ");
            }
            else if (health >= 50)
            {
                Console.WriteLine("You are in hurt. ");
            }
            else if (health >= 10)
            {
                Console.WriteLine(" You are badly hurt. ");
            }
            else if (health > 1)
            {
                Console.WriteLine("You are in immiment danger. ");
            }
            else if (health <= 0)
            {
                Console.WriteLine(" You are Dead. ");
            }
        }
            
            
            





            static void Main(string[] args)
        {
            HUD();


            // dealDamage(weaponType);

            


/*
                    switch (EhStat)
             {
                 case = 0
                     Console.WriteLine($" Health is {EnemyHealth} Enemy is Dead. ");
                     break;
                 case > 0
             Console.WriteLine($" Health is {EnemyHealth} Enemy is in immiment danger. ");
                     break; 
                case > 10
             Console.WriteLine($" Health is {EnemyHealth} Enemy is badly hurt. ");
                     break;
                 case  > 50
             Console.WriteLine($" Health is {EnemyHealth} Enemy is in hurt. ");
                     break;
                 case > 75
             Console.WriteLine($" Health is {EnemyHealth} Enemy is healthy. ");
                     break;
                 case = 100
                     Console.WriteLine($" Health is {EnemyHealth} Enemy is perfectly fit and healthy. ");
                     break;
             } 

                    If Ehealth > 0;

                     {
                         Console.WriteLine("Enemy still alive continue combat. ");
                     }

                     Else
                 {
                         Console.WriteLine("Enemy defeated you can breath again. ");
                     }
             */
            /*
                        if (isAlive)
                        {
                            if (health == 100)
                            {
                                Console.WriteLine($" Health is {health} You are perfectly fit and healthy. ");
                            }
                            else if (health >= 75)
                            {
                                Console.WriteLine($" Health is {health} You are healthy. ");
                            }
                            else if (health >= 50)
                            {
                                Console.WriteLine($" Health is {health} You are in hurt. ");
                            }
                            else if (health >= 10)
                            {
                                Console.WriteLine($" Health is {health} You are badly hurt. ");
                            }
                            else if (health > 1)
                            {
                                Console.WriteLine($" Health is {health} You are in immiment danger. ");
                            }
                            else if (health <= 0)
                            {
                                Console.WriteLine($" Health is {health} You are Dead. ");
                            }
                            Console.ReadKey();
                        }
                        */
            /*
                        int hStat()
                        {
                            if (health == 100)
                            {
                                Console.WriteLine($" Health is {health} You are perfectly fit and healthy. ");
                            }
                            else if (health >= 75)
                            {
                                Console.WriteLine($" Health is {health} You are healthy. ");
                            }
                            else if (health >= 50)
                            {
                                Console.WriteLine($" Health is {health} You are in hurt. ");
                            }
                            else if (health >= 10)
                            {
                                Console.WriteLine($" Health is {health} You are badly hurt. ");
                            }
                            else if (health >= 1)
                            {
                                Console.WriteLine($" Health is {health} You are in immiment danger. ");
                            }
                            else if (health <= 0)
                            {
                                Console.WriteLine($" Health is {health} You are Dead. ");
                            }
                            Console.ReadKey();
                        }

                        */

            /*
                        switch (hStats)
                        {
                            case = 0:
                                Console.WriteLine($" Health is {health} You are Dead. ");
                                break;
                            case < 11 + > 0:
                        Console.WriteLine($" Health is {health} You are in immiment danger. ");
                                break;
                            case < 50 + > 10:
                        Console.WriteLine($" Health is {health} EYou are badly hurt. ");
                                break;
                            case < 75 + > 49:
                        Console.WriteLine($" Health is {health} You are in hurt. ");
                                break;
                            case < 100 + > 74:
                        Console.WriteLine($" Health is {health} You are healthy. ");
                                break;
                            case == 100:
                                Console.WriteLine($" Health is {health} You are perfectly fit and healthy. ");
                                break;
                        }

                        */

        }

        /*
                static bool isAlive()
                {
                    if (health > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }



                     static int health = 0;






                static void Main(string[] args)
                {

                    //TakeDamage(20)

                    // conditionals "if"

                    //if(health > 0) //  you are alive


                    bool isAlive = IsAlive();

                    if (isAlive)  // another way of doing health to call out to a method if 
                    {

                        Console.WriteLine($"we are alive, our helth is {health} we are still alive  ");
                    }
                    else
                    {
                        Console.WriteLine($"we are no longer alive our helth is {health} ");

                    }







                }

                static bool IsAlive()
                {
                    if (health > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }







                /*   class notes for methods  


                        static int Square Number(int numToSquare)
                        {
                            return numToSquare * numToSquare;
                        }

                        static string WriteClassInfo(string nameOfClass, int numOfStudents)
                        {
                            string result = nameOfClass;
                            result += ": ";
                            result =+ numOfStudents;
                            result += "students";

                            return result;
                        }



                        static void TakeDamage(int damageammount)

                        { 
                        health -= damageammount;
                        }



                            static void printOneToFive()
                            {

                              //  Lines of code to wrire 1-5

                            }
           static int health = 100;






        static void Main(string[] args)
        {
            
			//TakeDamage(20)
			
			// conditionals "if"
			
			//if(health > 0) //  you are alive
			if(isAlive)  // another way of doing health to call out to a method if 
			{
				
				Console.Writeline($"we are alive, our helth is {health} we are still alive  ");
			}
			else			
			{
				Console.Writeline($"we are no longer alive our helth is {health} ");
			
			}
			
			
			
			
			
				
			
		}	
		
		static bool isAlive()
		{
			if(health > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}







/*   class notes for methods  

	
		static int Square Number(int numToSquare)
		{
			return numToSquare * numToSquare;
		}
		
		static string WriteClassInfo(string nameOfClass, int numOfStudents)
		{
			string result = nameOfClass;
			result += ": ";
			result =+ numOfStudents;
			result += "students";
			
			return result;
		}
		
		
		
		static void TakeDamage(int damageammount)
		
		{ 
		health -= damageammount;
		}
		
		
				
			static void printOneToFive()
			{
			
			  //  Lines of code to wrire 1-5
			
			}
			


                static void HUD()
                {

                    Console.WriteLine("{0,0}{1,13}{2,9}", "health", "weapon", "Health Status");
                    Console.WriteLine("{0,0}{1,10}{2,10}", health, weapon, hStat);

                }
                /*

                            }
                */





    }


}