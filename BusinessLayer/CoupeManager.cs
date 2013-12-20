using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesLayer;
using StubDataAccessLayer;

namespace BusinessLayer
{
    class CoupeManager
    {
        DalManager _manager;

        public CoupeManager()
        {
            _manager = new DalManager();
        }

        /*renvoie toutes les coupes*/
        public List<Coupe> GetCoupes()
        {
            return _manager.GetAllCoupes();
        }

        /*renvoie tous les joueurs*/
        public List<Joueur> GetJoueurs()
        {
            return _manager.GetAllJoueurs();
        }

        /*renvoie toutes les équipes*/
        public List<Equipe> GetEquipes()
        {
            return _manager.GetAllEquipes();
        }

        /*renvoie tous les stades*/
        public List<Stade> GetStades()
        {
            return _manager.GetAllStades();
        }

        /*renvoie tous les matchs*/
        public List<Match> GetMatchs()
        {
            return _manager.GetAllMatchs();
        }

        /*affiche les liste des matchs prévus classés par date*/
        public List<string> GetListeMatchsCoupe(int inCoupeID)
        {
            List<string> result = new List<string>();
            List<Match> matchs = this.GetMatchs();

            if (matchs != null)
            {
                result = (from x in matchs
                          where x.CoupeId == inCoupeID
                          orderby x.Date
                          select x.ToString()).ToList();
            }

            return result;
        }
    }
}
