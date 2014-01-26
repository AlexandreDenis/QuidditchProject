using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EntitiesLayer;

namespace QuidditchWPF
{
    public class GestionReservationViewModel
    {
        private ObservableCollection<ReservationViewModel> _reservations;
        public ObservableCollection<ReservationViewModel> Reservations
        {
            get { return _reservations; }
            set { _reservations = value; }
        }

        public GestionReservationViewModel(ObservableCollection<Reservation> inReservations)
        {
            _reservations = new ObservableCollection<ReservationViewModel>();

            foreach (Reservation reserv in inReservations)
            {
                _reservations.Add(new ReservationViewModel(reserv));
            }
        }
    }
}
