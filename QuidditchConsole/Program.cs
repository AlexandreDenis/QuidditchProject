using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BusinessLayer;

namespace QuidditchConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            CoupeManager cp = new CoupeManager();
            List<String> s = cp.GetListeMatchsCoupe(22);

            foreach (String fs in s)
                Console.WriteLine(fs);

            int choix = int.Parse(Console.ReadLine());

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
