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
       public static void Affichage() // affichage du menu
        {
            Console.WriteLine();
            Console.WriteLine(new string( '-', 30));
            Console.WriteLine("1 - Multiplication");
            Console.WriteLine("2 - Addition");
            Console.WriteLine("3 - Division");
            Console.WriteLine("4 - Soustraction");
            Console.WriteLine("5 - Arrêter la calculatrice");
            Console.WriteLine(new string('-', 30));
            Console.Write("Choisissez une opération : ");
            
        }
        public static void Multiplication(double nombre1, double nombre2) // méthode pour multiplier
        {
            
            double multiplication = nombre1 * nombre2;
            Console.WriteLine(multiplication);
        }
        public static void Addition(double nombre1, double nombre2) // méthode pour l'addition
        {
            double addition = nombre1 + nombre2;
            Console.WriteLine(addition);
        }
        public static void Division(double nombre1, double nombre2) // méthode pour la division
        {
            if (nombre1 == 0 || nombre2 == 0) // si un des nombres est égal à 0, ça affiche erreur
            {
                Console.WriteLine(" une erreur");
            } else { 
                double division = nombre1 / nombre2;
            Console.WriteLine(division);
            } 
        }
        public static void Soustraction(double nombre1, double nombre2) // méthode pour la soustraction
        {
            double soustraction = nombre1 - nombre2;
           Console.WriteLine(soustraction);
        }
    }
};
