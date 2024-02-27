using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PizzaStore
{
    public class Order
    {
        #region Instance Field
        Pizza _pizza;
        double _tax;
        int _deliveryfee;
        private Customer _customer;
        #endregion

        #region Constructor
        public Order(Pizza pizza, Customer customer)
        {
            _pizza = pizza;
            Customer = customer;
            Tax = 0.25;
            Deliveryfee = 40;
        }
        #endregion

        #region Properties
        public Pizza Pizza 
        { 
            get { return _pizza; }
            
            set { _pizza = value; } 
        }

        public Double Tax
        { 
           get { return _tax; } 
           set {  _tax = value; } 
        } 

        public int Deliveryfee 
        { 
            get { return _deliveryfee; }
            private set { _deliveryfee = value; }        
        }

        public Customer Customer 
        {
            get { return _customer; } 
            private set { _customer = value; } 
        }
        #endregion

        #region Methods
        public double CalculateTotalPrice() 
        { 
            return Pizza.Price + (Pizza.Price * Tax) + Deliveryfee;
        }
        public override string ToString() 
        {
            return $"{Customer.ToString()}, {Pizza.ToString()}, Total Price: {CalculateTotalPrice()}";
        }
        #endregion
    }

}
