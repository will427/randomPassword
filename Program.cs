﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using RandomPassword;
namespace randomGenerator
{
    internal class mainPro
    {
        static void Main(string[] args)
        {
            

            generatePass getMainCode=new generatePass();
            int regulator;
            bool accepted = true;
            while (accepted)
            {
                accepted = false;
                Console.WriteLine("Que tipo de contrasena deseas crear?\n 1)Aleatoria.\n 2)Aleatoria personalizada.");
                regulator = int.Parse(Console.ReadLine());
                switch (regulator)
                {
                    case 1:
                        getMainCode.mainCode();
                        break;
                    case 2:
                        Console.WriteLine("still being developed");
                        break;
                    default:
                        Console.WriteLine("este no es un numero aceptado");
                        Thread.Sleep(1000);
                        Console.Clear();
                        Console.WriteLine("intenta de nuevo...");
                        Thread.Sleep(1000);

                        accepted = true;
                        break;

                }
            }
        }
    }
}
