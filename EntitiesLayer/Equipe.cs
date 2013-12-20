using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    class Equipe : EntityObject
    {
        private string _nom;
        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }


        private string _pays;
        public string Pays
        {
            get { return _pays; }
            set { _pays = value; }
        }

        private List<Joueur> _joueurs;
        public List<Joueur> Joueurs
        {
            get { return _joueurs; }
            set { _joueurs = value; }
        }

        public Equipe(int inId, string inNom, string inPays) : base(inId)
        {
            this.Nom = inNom;
            this.Pays = inPays;
            this.Joueurs = new List<Joueur>();
        }

    }
}
