using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EntitiesLayer;

namespace QuidditchWPF
{
    class ReservationViewModel : ViewModelBase
    {
        private Reservation _reservation;
        public Reservation Reservation
        {
            get { return _reservation; }
            set { _reservation = value; }
        }
    }
}
