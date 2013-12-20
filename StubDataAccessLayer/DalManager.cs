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

            joueurs.Add(1, "nom1", "prenom1", DateTime.Now, PosteJoueur.Poursuiveur, 2, 3);

            return joueurs;
        }
        public List<Equipe> GetAllEquipe()
        {
            List<Equipe> equipes = new List<Equipe>();

            return equipes;
        }
        public List<Stade> GetAllStades()
        {
            List<Stade> stades = new List<Stade>();

            return stades;
        }
        public List<Match> GetAllMatchs()
        {
            List<Match> matchs = new List<Match>();

            return matchs;
        }
        public List<Coupe> GetAllCoupes()
        {
            List<Coupe> coupes = new List<Coupe>();

            return coupes;
        }
    }
}
