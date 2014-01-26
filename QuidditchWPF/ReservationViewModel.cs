using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EntitiesLayer;
using BusinessLayer;

namespace QuidditchWPF
{
    public class ReservationViewModel : ViewModelBase
    {
        private CoupeManager cp;

        private Reservation _reservation;
        public Reservation Reservation
        {
            get { return _reservation; }
            set { _reservation = value; }
        }

        public Coupe Coupe
        {
            get
            {
                return cp.GetCoupeById(_reservation.Match.CoupeId);
            }
        }

        public Match Match
        {
            get
            {
                return _reservation.Match;
            }

            set
            {
                _reservation.Match = value;
            }
        }

        public string Nom
        {
            get
            {
                return _reservation.Spectateur.Nom;
            }

            set
            {
                _reservation.Spectateur.Nom = value;
            }
        }

        public string Prenom
        {
            get
            {
                return _reservation.Spectateur.Prenom;
            }
        }

        public string Adresse
        {
            get
            {
                return _reservation.Spectateur.Adresse;
            }
        }

        public int NbPlaces
        {
            get
            {
                return _reservation.NombrePlacesReservees;
            }

            set
            {
                _reservation.NombrePlacesReservees = value;
                
            }
        }

        public double Prix
        {
            get
            {
                double res = _reservation.NombrePlacesReservees * _reservation.Match.Prix;
                res += res * _reservation.Match.Stade.PourcentageCommission / 100;
                OnPropertyChanged("Prix");
                return res;
            }
        }

        public ReservationViewModel(Reservation inReserv)
        {
            _reservation = inReserv;
            cp = new CoupeManager();
        }
    }
}
