using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using randomGenerator;
namespace RandomPassword
{
    internal class Generator
    {
       static List<char> collectChar = new List<char>();
        public void getRanPass(int getScope) {
            string collectran;
            generatePass getMain= new generatePass();


            //llamando funcion recolectora
            obtenerChar(ref collectChar);

            bool repeticion = true;
            while (repeticion)
            {

                repeticion= false;
                collectran = randomPassword(getScope);
                Console.WriteLine($"Contrasena generada: {collectran}");
                Console.WriteLine("Quieres intentar una nueva contraseña?, pulsa [CTRL + R] o [CTRL + B] para volver al menu principal");
                start:
                    ConsoleKeyInfo tecla = new ConsoleKeyInfo();
                    tecla = Console.ReadKey(true);
                    if(tecla.Modifiers== ConsoleModifiers.Control && tecla.Key == ConsoleKey.R) {

                        Console.WriteLine("volviendo al inicio...");    
                        Thread.Sleep(1000);
                        Console.Clear();
                        getMain.mainCode();

                }else if(tecla.Modifiers == ConsoleModifiers.Control && tecla.Key == ConsoleKey.B)
                {
                    //codigo de marcos
                }
                else
                {

                    Console.WriteLine("Combinacion de teclas no correcta, intenta de nuevo");
                    Thread.Sleep(2000);
                    Console.Clear();
                    Console.WriteLine("recuerda que la combinacion es [CRTL + R], intenta de nuevo");
                    goto start;
                
                }

                




            }









        }
        static string randomPassword(int length)
        {

            StringBuilder sb= new StringBuilder();
            Random randomNum= new Random();
            int i = 0;
            while (i < length)
            {
                sb.Append(collectChar[randomNum.Next(0, collectChar.Count)]);
                i++;
            }
            return sb.ToString();
        }

        static void  obtenerChar( ref List<char>collectChar)
        {


            //characteres divididos en arreglos
            char[] obtenerLetras = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            char[] obtenerNums = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            char[] obtenerSignos = { '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '_', '-', '+', '=' };

            for (int x = 0; x < obtenerLetras.Length; x++)
            {
                collectChar.Add(obtenerLetras[x]);
            }
            for (int z = 0; z < obtenerNums.Length; z++)
            {
               
                  collectChar.Add(obtenerNums[z]);

            }
            for (int y = 0; y < obtenerSignos.Length; y++)
            {
                collectChar.Add(obtenerSignos[y]);


            }




        }
         


























    }
}
