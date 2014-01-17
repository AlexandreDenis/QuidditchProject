using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesLayer;

namespace StubDataAccessLayer
{
    public class DalManager
    {
        public List<Joueur> GetAllJoueurs()
        {
            List<Joueur> joueurs = new List<Joueur>();

            //Joueurs de l'equipe de Gryffondor
            joueurs.Add(new Joueur(0, "Daval", "Olivier", DateTime.Now, PosteJoueur.Poursuiveur, 2, 3));
            joueurs.Add(new Joueur(1, "Thuillier", "André", DateTime.Now, PosteJoueur.Attrapeur, 2, 3));
            joueurs.Add(new Joueur(2, "Perrier", "Kevin", DateTime.Now, PosteJoueur.Poursuiveur, 2, 3));
            joueurs.Add(new Joueur(3, "Lagrange", "Pascal", DateTime.Now, PosteJoueur.Poursuiveur, 2, 3));
            joueurs.Add(new Joueur(4, "Lebert", "Charles", DateTime.Now, PosteJoueur.Batteur, 2, 3));
            joueurs.Add(new Joueur(5, "Caillaud", "Claude", DateTime.Now, PosteJoueur.Batteur, 2, 3));
            joueurs.Add(new Joueur(6, "Despres", "Anthony", DateTime.Now, PosteJoueur.Gardien, 2, 3));

            //Joueurs de l'equipe de Serdaigle
            joueurs.Add(new Joueur(7, "Rubio", "Jean-Marie", DateTime.Now, PosteJoueur.Poursuiveur, 2, 3));
            joueurs.Add(new Joueur(8, "Leclerc", "François", DateTime.Now, PosteJoueur.Attrapeur, 2, 3));
            joueurs.Add(new Joueur(9, "Menu", "Jean-Paul", DateTime.Now, PosteJoueur.Poursuiveur, 2, 3));
            joueurs.Add(new Joueur(10, "Rossignol", "Damien", DateTime.Now, PosteJoueur.Poursuiveur, 2, 3));
            joueurs.Add(new Joueur(11, "Savy", "Lionel", DateTime.Now, PosteJoueur.Batteur, 2, 3));
            joueurs.Add(new Joueur(12, "Ribeiro", "Michel", DateTime.Now, PosteJoueur.Batteur, 2, 3));
            joueurs.Add(new Joueur(13, "Drouot", "Yannick", DateTime.Now, PosteJoueur.Gardien, 2, 3));

            //Joueurs de l'equipe de Serpentard
            joueurs.Add(new Joueur(14, "Menager", "Sylvain", DateTime.Now, PosteJoueur.Poursuiveur, 2, 3));
            joueurs.Add(new Joueur(15, "Mayer", "Emmanuel", DateTime.Now, PosteJoueur.Attrapeur, 2, 3));
            joueurs.Add(new Joueur(16, "Casanova", "Raymond", DateTime.Now, PosteJoueur.Poursuiveur, 2, 3));
            joueurs.Add(new Joueur(17, "Clavier", "Georges", DateTime.Now, PosteJoueur.Poursuiveur, 2, 3));
            joueurs.Add(new Joueur(18, "Bordier", "Guillaume", DateTime.Now, PosteJoueur.Batteur, 2, 3));
            joueurs.Add(new Joueur(19, "Voisin", "Loïc", DateTime.Now, PosteJoueur.Batteur, 2, 3));
            joueurs.Add(new Joueur(20, "Braun", "Mickaël", DateTime.Now, PosteJoueur.Gardien, 2, 3));

            return joueurs;
        }

        public List<Equipe> GetAllEquipes()
        {
            List<Equipe> equipes = new List<Equipe>();
            List<Joueur> joueurs = GetAllJoueurs();
            int i;

            Equipe e1 = new Equipe(21, "Gryffondor", "Grande-Bretagne");
            for (i = 0; i < 7; i++)
            {
                e1.AddJoueur(joueurs[i]);
            }

            Equipe e2 = new Equipe(22, "Serdaigle", "France");
            for (i = 7; i < 14; i++)
            {
                e2.AddJoueur(joueurs[i]);
            }

            Equipe e3 = new Equipe(23, "Serpentard", "Bulgarie");
            for (i = 14; i < 21; i++)
            {
                e3.AddJoueur(joueurs[i]);
            }

            equipes.Add(e1);
            equipes.Add(e2);
            equipes.Add(e3);

            return equipes;
        }

        public List<Stade> GetAllStades()
        {
            List<Stade> stades = new List<Stade>();

            stades.Add(new Stade(24, "stade1", "adresse1", 500, 20.20));
            stades.Add(new Stade(25, "stade2", "adresse2", 500, 20.20));
            stades.Add(new Stade(26, "stade3", "adresse3", 500, 20.20));
            stades.Add(new Stade(27, "stade4", "adresse4", 500, 20.20));
            stades.Add(new Stade(28, "stade5", "adresse5", 500, 20.20));
            stades.Add(new Stade(29, "stade6", "adresse6", 500, 20.20));

            return stades;
        }

        public List<Match> GetAllMatchs()
        {
            List<Equipe> equipes = GetAllEquipes();
            List<Stade> stades = GetAllStades();

            List<Match> matchs = new List<Match>();

            matchs.Add(new Match(30, 33, DateTime.Now, equipes[0], equipes[1], 50.5, 0, 0, stades[0]));
            matchs.Add(new Match(31, 33, DateTime.Now, equipes[1], equipes[2], 50.5, 0, 0, stades[1]));
            matchs.Add(new Match(32, 34, DateTime.Now, equipes[2], equipes[0], 50.5, 0, 0, stades[2]));

            return matchs;
        }

        public List<Coupe> GetAllCoupes()
        {
            List<Coupe> coupes = new List<Coupe>();

            coupes.Add(new Coupe(33, 2013, "Coupe des nations"));
            coupes.Add(new Coupe(34, 2014, "Coupe des régions"));

            return coupes;
        }

        public List<Utilisateur> GetAllUtilisateurs()
        {
            List<Utilisateur> utilisateurs = new List<Utilisateur>();

            utilisateurs.Add(new Utilisateur("Denis","Alexandre","alec","mdpalec"));
            utilisateurs.Add(new Utilisateur("Calime","Adrien","adrien","mdpadrien"));

            return utilisateurs;
        }

        public Utilisateur GetUtilsateurByLogin(string inLogin)
        {
            Utilisateur utilReturn = null;
            foreach (Utilisateur utilisateur in GetAllUtilisateurs())
            {
                if (utilisateur.Login.Equals(inLogin))
                    utilReturn = utilisateur;
            }

            return utilReturn;
        }
    }
}
