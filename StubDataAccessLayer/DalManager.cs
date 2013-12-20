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

            joueurs.Add(new Joueur(1, "nom1", "prenom1", DateTime.Now, PosteJoueur.Poursuiveur, 2, 3));
            joueurs.Add(new Joueur(2, "nom2", "prenom2", DateTime.Now, PosteJoueur.Poursuiveur, 2, 3));
            joueurs.Add(new Joueur(3, "nom3", "prenom3", DateTime.Now, PosteJoueur.Poursuiveur, 2, 3));
            joueurs.Add(new Joueur(4, "nom4", "prenom4", DateTime.Now, PosteJoueur.Poursuiveur, 2, 3));
            joueurs.Add(new Joueur(5, "nom5", "prenom5", DateTime.Now, PosteJoueur.Poursuiveur, 2, 3));
            joueurs.Add(new Joueur(6, "nom6", "prenom6", DateTime.Now, PosteJoueur.Poursuiveur, 2, 3));

            return joueurs;
        }
        public List<Equipe> GetAllEquipes()
        {
            List<Equipe> equipes = new List<Equipe>();

            equipes.Add(new Equipe(7, "equipe1", "pays1"));
            equipes.Add(new Equipe(8, "equipe2", "pays2"));
            equipes.Add(new Equipe(9, "equipe3", "pays3"));
            equipes.Add(new Equipe(10, "equipe4", "pays4"));
            equipes.Add(new Equipe(11, "equipe5", "pays5"));
            equipes.Add(new Equipe(12, "equipe6", "pays6"));

            return equipes;
        }
        public List<Stade> GetAllStades()
        {
            List<Stade> stades = new List<Stade>();

            stades.Add(new Stade(13, "stade1", "adresse1", 500, 20.20));
            stades.Add(new Stade(14, "stade2", "adresse2", 500, 20.20));
            stades.Add(new Stade(15, "stade3", "adresse3", 500, 20.20));
            stades.Add(new Stade(16, "stade4", "adresse4", 500, 20.20));
            stades.Add(new Stade(17, "stade5", "adresse5", 500, 20.20));
            stades.Add(new Stade(18, "stade6", "adresse6", 500, 20.20));

            return stades;
        }
        public List<Match> GetAllMatchs()
        {
            List<Equipe> equipes = GetAllEquipes();
            List<Stade> stades = GetAllStades();

            List<Match> matchs = new List<Match>();

            matchs.Add(new Match(19, 1, DateTime.Now, equipes[0], equipes[1], 50.5, 0, 0, stades[0]));
            matchs.Add(new Match(20, 2, DateTime.Now, equipes[2], equipes[3], 50.5, 0, 0, stades[1]));
            matchs.Add(new Match(21, 3, DateTime.Now, equipes[4], equipes[5], 50.5, 0, 0, stades[2]));

            return matchs;
        }
        public List<Coupe> GetAllCoupes()
        {
            List<Coupe> coupes = new List<Coupe>();

            coupes.Add(new Coupe(22, 2010));
            coupes.Add(new Coupe(23, 2011));
            coupes.Add(new Coupe(24, 2012));
            coupes.Add(new Coupe(25, 2013));
            coupes.Add(new Coupe(26, 2014));

            return coupes;
        }
    }
}
