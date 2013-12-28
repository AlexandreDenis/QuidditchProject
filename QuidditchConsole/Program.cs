using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BusinessLayer;
using EntitiesLayer;

namespace QuidditchConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            CoupeManager cp = new CoupeManager();
            int choix = -1;
            bool fin = false;

            /*List<String> s = cp.GetListeMatchsCoupe(22);

            foreach (String fs in s)
                Console.WriteLine(fs);*/

            /*Boucles principale*/
            while (true)
            {
                /*Saisie du choix par l'utilisateur*/
                do
                {
                    /*MENU*/
                    Console.WriteLine("Que voulez-vous faire?");
                    Console.WriteLine("     0 : Afficher la liste des joueurs");
                    Console.WriteLine("     1 : Afficher la liste des équipes");
                    Console.WriteLine("     2 : Afficher la liste des stades");
                    Console.WriteLine("     3 : Afficher la liste des matchs");
                    Console.WriteLine("     4 : Afficher la liste des coupes");
                    Console.WriteLine("     5 : Quitter");
                    try
                    {
                        choix = int.Parse(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        continue;
                    }
                } while (choix < 0 || choix > 5);

                switch (choix)
                {
                    case 0:
                        List<Joueur> ljoueurs = cp.GetJoueurs();

                        Console.WriteLine("Liste des joueurs existants :");
                        foreach (Joueur pl in ljoueurs)
                        {
                            Console.WriteLine(pl.ToString());
                        }
                        break;
                    case 1:
                        List<Equipe> lequipes = cp.GetEquipes();

                        Console.WriteLine("Liste des équipes existantes :");
                        foreach (Equipe pl in lequipes)
                        {
                            Console.WriteLine(pl.ToString());
                        }
                        break;
                    case 2:
                        List<Stade> lstades = cp.GetStades();

                        Console.WriteLine("Liste des stades existants :");
                        foreach (Stade pl in lstades)
                        {
                            Console.WriteLine(pl.ToString());
                        }
                        break;
                    case 3:
                        List<Match> lmatchs = cp.GetMatchs();

                        Console.WriteLine("Liste des matchs existants :");
                        foreach (Match pl in lmatchs)
                        {
                            Console.WriteLine(pl.ToString());
                        }
                        break;
                    case 4:
                        List<Coupe> lcoupes = cp.GetCoupes();

                        Console.WriteLine("Liste des coupes existantes :");
                        foreach (Coupe pl in lcoupes)
                        {
                            Console.WriteLine(pl.ToString());
                        }
                        break;
                    case 5:
                        fin = true;
                        break;
                }

                if (fin)
                    break;
            }


            
            /*
            int choix = -1;
            while (choix != 3)
            {
                Console.WriteLine("Que voulez-vous faire?");
                Console.WriteLine("   0 -> afficher la liste des matchs");
                Console.WriteLine("   1 -> afficher la liste des stades");
                Console.WriteLine("   2 -> afficher la liste des attrapeurs");
                Console.WriteLine("   3 -> quitter");

                try
                {
                    choix = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    continue;
                }
                switch (choix)
                {

                }
            }*/
        }
    }
}
