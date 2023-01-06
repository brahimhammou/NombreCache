/*
 * Jeu du nombre caché
 * author: Emds
 * date: 23:05:2020
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NombreCache
{
    class Program
    {
        static void Main(string[] args)
        {//déclaration
            int valeur = 0, essai, nbre = 1;
            bool correct = false;
         //saisie du nombre à chercher
         while (!correct)
         {
            try
            {
            Console.Write("Entrez le nombre à chercher et cuisiner: ");
            valeur = int.Parse(Console.ReadLine());
                correct = true;
            }
            catch
            {
                    Console.WriteLine("Ereur de saisie : saisissez un nombre entier");
            }
         }
         Console.Clear();

            //saisie du premier essai
            Console.Write("Entrez un essai = ");
            essai = int.Parse(Console.ReadLine());
                 
            
            while (essai != valeur)
            {
                   //test de l'essai par rapport à la valeur à chercher
                   if (essai > valeur)
                   {
                    Console.WriteLine(" --> trop grand !");
                   }
                     else
                   {
                    Console.WriteLine(" --> trop petit !");
                   }
                    //saisie d'un nouvel essai
                    Console.Write("Entrer un essai = ");
                    essai = int.Parse(Console.ReadLine());
                //Compteur d'essai
                nbre++;
            }
            //valeur trouvée
            Console.WriteLine("Vous avez trouvé en "+nbre+" fois");



            Console.ReadLine();
        }
    }
}


