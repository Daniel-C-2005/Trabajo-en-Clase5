using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_5
{
    class Program
    {
        static void saludar(String nomsal)
        {
            Console.WriteLine($"Un gran saludo a {nomsal}");

        }
        static int Calculo_año_nacimiento(int edad)
        {
            int añon = 2023 - edad;
            return añon;

        }
        //static void marque(string palabra)
        //{
        //    int longitud = palabra.Length;
        //    for (int c = longitud - 1; c > 0; c--)
        //    {
        //        console.setcursorposition(5 + c, 10);
        //        console.writeline(palabra[c]);

        //    }

        //    string pal = "";
        //    for (int c = longitud - 1; c <= 0; c--)
        //    {
        //        pal = pal + palabra[c];
        //    }
        //}
        //static void Main(string[] args)
        //{
        //    string palabra;
        //    palabra = "maria";
        //    marque(palabra);

        //    Console.ReadKey();


        //string nombre;
        //int edad;
        //char letra = 'a',
        //    string palabra = letra;
        //console.writeline("como te llamas");
        //nombre = console.readline();
        //saludar(nombre);


        //console.writeline($"hola, gusto de saludarte {nombre}");
        //console.writeline("cuantos años tienes?");
        //edad = convert.toint32(console.readline());



        //console.writeline($"bonita edad: {edad} naciste en { calculo_año_nacimiento(edad)}");
        //console.readkey();

        static bool palindromo(string palabra)
        {
            int longitud = palabra.Length;
            
            string pal = "";
            for (int c = longitud - 1; c <= 0; c--)
            {
                pal = pal + palabra[c].ToString().ToUpper();
            }
             if (palabra.ToUpper().Equals(pal))
               {
                return true;

             }
            {
                return false;
            }
            bool esPalindromo = palindromo("Ana".ToUpper());
            if (esPalindromo)
            {
                Console.Write("Es palindromo");

            }
        
            else
            {
                Console.WriteLine("nel");
            }
        
        }


    }
}

    

