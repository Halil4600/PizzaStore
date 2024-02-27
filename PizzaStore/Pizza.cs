using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class Pizza
    {
        #region Instance Field
        string _name;
        int _price;
        #endregion

        #region Constructor
        public Pizza(string name, int price)
        {
            _name = name;
            _price = price;
        }
        #endregion

        #region Properties
        public string Name 
        { 
            get { return _name; } 
            private set { _name = value; }
        }

        public int Price
        {
            get { return _price;  }
            private set { _price = value; }
        }

        #endregion

        #region Methods
        public override string ToString() 
        {
            return $"Name: {Name} - Price {Price}";
        }
        #endregion
    }

}
