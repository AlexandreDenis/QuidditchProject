using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class Coupe : EntityObject
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

        public override string ToString()
        {
            StringBuilder res = new StringBuilder();

            res.Append(Year);
            res.Append(" - Coupe ");
            res.Append(Id);
            
            res.Append("\n");

            return res.ToString();
        }
    }
}
