using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Brief_calculatrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nombre1;
            double nombre2;
            int choix;
            while (true) {
                
                Console.BackgroundColor = ConsoleColor.Blue; // fond en bleu
                fonction.Affichage(); // j'appelle ma méthode affichage
            choix = Convert.ToInt32(Console.ReadLine()); // le nombre pour le menu
            if (choix == 5)
            {
                    Console.WriteLine();
                    Console.WriteLine("Le programme est finit");
                    break; // permet d'arreter la calculatrice

                } else if (choix <= 0 || choix > 4) {

                    Console.WriteLine(new string('-', 30));
                    Console.ForegroundColor = ConsoleColor.Red; // écriture en rouge
                    Console.Clear();
                    Console.WriteLine("Fallait saisir un chiffre entre 1 et 4 !!");// si le chiffre n'est pas entre 1 et 4
                    Console.ResetColor();
                 

                }

            else
                {
                    Console.Clear(); // je nettoie la console
                    Console.Write("Choissisez le premier nombre : ");
                    nombre1 = Double.Parse(Console.ReadLine()); // 1er nombre
                    Console.WriteLine(new string('-', 30)); // visuel avec des tirets
                    Console.Write("Choissisez le second nombre : ");
                    nombre2 = Convert.ToDouble(Console.ReadLine()); // 2eme nombre
                    Console.WriteLine(new string('-', 30));
                    Console.Clear();

                    switch (choix)
                    {
                        case 1:
                            Console.Write("le produit est : ");
                            fonction.Multiplication(nombre1, nombre2); // j'appelle ma méthode
                            break;

                        case 2:
                            Console.Write("la somme est : ");
                            fonction.Addition(nombre1, nombre2); // j'appelle ma méthode
                            break;

                        case 3:

                            Console.Write("le quotient est : ");
                            fonction.Division(nombre1, nombre2); // j'appelle ma méthode
                            break;

                        case 4:
                            Console.Write("la différence est : ");
                            fonction.Soustraction(nombre1, nombre2); // j'appelle ma méthode
                            break;
                    }

                }
            }
        }

    }
};





