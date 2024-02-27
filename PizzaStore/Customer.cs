using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class Customer
    {
        #region Instance Field
        private string _name;
        #endregion

        #region Constructor
        public Customer(string name)
        { 
            _name = name; 
        }
        #endregion

        #region Properties
        public string Name
        {
            get { return _name; }
            private set { _name = value; }
        }
        #endregion

        #region Methods
        public override string ToString() 
        {
            return $"Customer: {Name}";
        }
        #endregion
    }

}
