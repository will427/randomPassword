using Microsoft.SqlServer.Server;
using RandomPassword;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace randomGenerator
{
    internal class generatePass
    {

        public void mainCode() {


            Console.WriteLine();

            bool isItString = true;
            while (isItString)
            {
                Console.Write("in order to create a password you have to select between ");

                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.Write("8-16 characters");

                Console.ResetColor();

                Console.WriteLine();



                Console.WriteLine("Please specify how many characters you want your password to have");
                int collectDigit;

                string charNums = Console.ReadLine();


                if (int.TryParse(charNums, out collectDigit))
                {


                    if (collectDigit >= 8 && collectDigit <= 16)
                    {

                        
                        Generator getpass = new Generator();
                        getpass.getRanPass(collectDigit);

                        isItString = false;

                    }
                    else
                    {

                        Console.WriteLine("number of characters is not allowed");

                        Thread.Sleep(200);

                        Console.WriteLine("try again...");

                        Thread.Sleep(2000);

                        Console.Clear();

                        isItString = true;

                    }


                }
                else
                {

                    Console.WriteLine("only numbers(numeric digits) accepted.");

                    Thread.Sleep(2000);

                    Console.WriteLine("try again...");

                    Thread.Sleep(1000);

                    Console.Clear();

                    isItString = true;
                }
            }


            Console.ReadKey();



        }










            
        }






    }

