using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public enum PosteJoueur
    {
        None,
        Poursuiveur,
        Batteur,
        Gardien,
        Attrapeur
    }

    public class Joueur : Personne
    {
        private PosteJoueur _poste;
        internal PosteJoueur Poste
        {
            get { return _poste; }
            set { _poste = value; }
        }

        private int _nbSelection;
        public int NbSelection
        {
            get { return _nbSelection; }
            set { _nbSelection = value; }
        }
        
        private int _score;
        public int Score
        {
            get { return _score; }
            set { _score = value; }
        }

        public Joueur(int inId, string inNom, string inPrenom, DateTime inDateNaiss, PosteJoueur inPoste, int inSelection, int inScore)
            : base(inId, inNom, inPrenom, inDateNaiss)
        {
            this.Poste = inPoste;
            this.NbSelection = inSelection;
            this.Score = inScore;
        }
    }
}
