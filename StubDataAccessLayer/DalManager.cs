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

            joueurs.Add(new Joueur(EntityObject.nextId, "Daval", "Olivier", DateTime.Now, PosteJoueur.Poursuiveur, 2, 3));
            joueurs.Add(new Joueur(EntityObject.nextId, "Thuillier", "André", DateTime.Now, PosteJoueur.Attrapeur, 2, 3));
            joueurs.Add(new Joueur(EntityObject.nextId, "Perrier", "Kevin", DateTime.Now, PosteJoueur.Poursuiveur, 2, 3));
            joueurs.Add(new Joueur(EntityObject.nextId, "Lagrange", "Pascal", DateTime.Now, PosteJoueur.Poursuiveur, 2, 3));
            joueurs.Add(new Joueur(EntityObject.nextId, "Lebert", "Charles", DateTime.Now, PosteJoueur.Batteur, 2, 3));
            joueurs.Add(new Joueur(EntityObject.nextId, "Caillaud", "Claude", DateTime.Now, PosteJoueur.Batteur, 2, 3));
            joueurs.Add(new Joueur(EntityObject.nextId, "Despres", "Anthony", DateTime.Now, PosteJoueur.Gardien, 2, 3));

            joueurs.Add(new Joueur(EntityObject.nextId, "Rubio", "Jean-Marie", DateTime.Now, PosteJoueur.Poursuiveur, 2, 3));
            joueurs.Add(new Joueur(EntityObject.nextId, "Leclerc", "François", DateTime.Now, PosteJoueur.Attrapeur, 2, 3));
            joueurs.Add(new Joueur(EntityObject.nextId, "Menu", "Jean-Paul", DateTime.Now, PosteJoueur.Poursuiveur, 2, 3));
            joueurs.Add(new Joueur(EntityObject.nextId, "Rossignol", "Damien", DateTime.Now, PosteJoueur.Poursuiveur, 2, 3));
            joueurs.Add(new Joueur(EntityObject.nextId, "Savy", "Lionel", DateTime.Now, PosteJoueur.Batteur, 2, 3));
            joueurs.Add(new Joueur(EntityObject.nextId, "Ribeiro", "Michel", DateTime.Now, PosteJoueur.Batteur, 2, 3));
            joueurs.Add(new Joueur(EntityObject.nextId, "Drouot", "Yannick", DateTime.Now, PosteJoueur.Gardien, 2, 3));

            joueurs.Add(new Joueur(EntityObject.nextId, "Menager", "Sylvain", DateTime.Now, PosteJoueur.Poursuiveur, 2, 3));
            joueurs.Add(new Joueur(EntityObject.nextId, "Mayer", "Emmanuel", DateTime.Now, PosteJoueur.Attrapeur, 2, 3));
            joueurs.Add(new Joueur(EntityObject.nextId, "Casanova", "Raymond", DateTime.Now, PosteJoueur.Poursuiveur, 2, 3));
            joueurs.Add(new Joueur(EntityObject.nextId, "Clavier", "Georges", DateTime.Now, PosteJoueur.Poursuiveur, 2, 3));
            joueurs.Add(new Joueur(EntityObject.nextId, "Bordier", "Guillaume", DateTime.Now, PosteJoueur.Batteur, 2, 3));
            joueurs.Add(new Joueur(EntityObject.nextId, "Voisin", "Loïc", DateTime.Now, PosteJoueur.Batteur, 2, 3));
            joueurs.Add(new Joueur(EntityObject.nextId, "Braun", "Mickaël", DateTime.Now, PosteJoueur.Gardien, 2, 3));

            return joueurs;
        }

        public List<Equipe> GetAllEquipes()
        {
            List<Equipe> equipes = new List<Equipe>();
            List<Joueur> joueurs = GetAllJoueurs();
            int i;

            Equipe e1 = new Equipe(EntityObject.nextId, "Gryffondor", "Grande-Bretagne");
            for (i = 0; i < 7; i++)
            {
                e1.AddJoueur(joueurs[i]);
            }

            Equipe e2 = new Equipe(EntityObject.nextId, "Serdaigle", "France");
            for (i = 7; i < 14; i++)
            {
                e2.AddJoueur(joueurs[i]);
            }

            Equipe e3 = new Equipe(EntityObject.nextId, "Serpentard", "Bulgarie");
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

            stades.Add(new Stade(EntityObject.nextId, "stade1", "adresse1", 500, 20.20));
            stades.Add(new Stade(EntityObject.nextId, "stade2", "adresse2", 500, 20.20));
            stades.Add(new Stade(EntityObject.nextId, "stade3", "adresse3", 500, 20.20));
            stades.Add(new Stade(EntityObject.nextId, "stade4", "adresse4", 500, 20.20));
            stades.Add(new Stade(EntityObject.nextId, "stade5", "adresse5", 500, 20.20));
            stades.Add(new Stade(EntityObject.nextId, "stade6", "adresse6", 500, 20.20));

            return stades;
        }

        public List<Match> GetAllMatchs()
        {
            List<Equipe> equipes = GetAllEquipes();
            List<Stade> stades = GetAllStades();

            List<Match> matchs = new List<Match>();

            matchs.Add(new Match(EntityObject.nextId, 22, DateTime.Now, equipes[0], equipes[1], 50.5, 0, 0, stades[0]));
            matchs.Add(new Match(EntityObject.nextId, 22, DateTime.Now, equipes[1], equipes[2], 50.5, 0, 0, stades[1]));
            matchs.Add(new Match(EntityObject.nextId, 23, DateTime.Now, equipes[2], equipes[0], 50.5, 0, 0, stades[2]));

            return matchs;
        }

        public List<Coupe> GetAllCoupes()
        {
            List<Coupe> coupes = new List<Coupe>();

            coupes.Add(new Coupe(EntityObject.nextId, 2010));
            coupes.Add(new Coupe(EntityObject.nextId, 2011));
            coupes.Add(new Coupe(EntityObject.nextId, 2012));
            coupes.Add(new Coupe(EntityObject.nextId, 2013));
            coupes.Add(new Coupe(EntityObject.nextId, 2014));

            return coupes;
        }
    }
}
