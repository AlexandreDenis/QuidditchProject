using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    abstract class EntityObject
    {
        private int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public EntityObject (int inId)
	    {
            this.Id = inId;
	    }

        
    }
}
