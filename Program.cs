using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Brief_calculatrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nombre1;
            int nombre2;
            int choix;
            fonction.Affichage();
            choix = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.Write("Choissisez le premier nombre : ");
            nombre1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(new string('-', 30));
            Console.Write("Choissisez le second nombre : ");
            nombre2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(new string('-', 30));

            switch (choix)
                {
                    case 1:

                        Console.Write("le produit est : ");
                        fonction.Multiplication(nombre1, nombre2);
                        break;

                    case 2:
                        Console.Write("la somme est : ");
                        fonction.Addition(nombre1, nombre2);
                        break;

                    case 3:

                        Console.Write("le quotient est : ");
                        fonction.Division(nombre1, nombre2);
                        break;

                    case 4:
                        Console.Write("le différence est : ");
                        fonction.Soustraction(nombre1, nombre2);
                        break;

                }
            }
        }
    
    };





