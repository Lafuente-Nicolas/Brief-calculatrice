using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Brief_calculatrice
{
    internal class fonction
    {
       public static void Affichage()
        {
            Console.WriteLine(new string( '-', 30));
            Console.WriteLine("1 - Multiplication");
            Console.WriteLine("2 - Addition");
            Console.WriteLine("3 - Division");
            Console.WriteLine("4 - Soustraction");
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Choissisez une opération : ");
            
        }
        public static void Multiplication(int nombre1, int nombre2)
        {
            
            int multiplication = nombre1 * nombre2;
            Console.WriteLine(multiplication);
        }
        public static void Addition(int nombre1, int nombre2)
        {
            int addition = nombre1 + nombre2;
            Console.WriteLine(addition);
        }
        public static void Division(int nombre1, int nombre2)
        {
            int division = nombre1 / nombre2;
            Console.WriteLine(division);
            if (nombre1 / nombre2 == 0)
            {
                Console.WriteLine("erreur");
            }
        }
        public static void Soustraction(int nombre1, int nombre2)
        {
            double soustraction = nombre1 - nombre2;
            Console.WriteLine(soustraction);
        }
    }
};
