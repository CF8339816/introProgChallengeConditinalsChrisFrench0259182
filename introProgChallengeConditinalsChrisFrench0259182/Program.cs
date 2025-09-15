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

                    */


    }


}