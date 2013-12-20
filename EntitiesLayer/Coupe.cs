using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    class Coupe : EntityObject
    {
        private int _year;
        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }

        public Coupe(int inId, int inYear) : base(inId)
        {
            this.Year = inYear;
        }
    }
}
