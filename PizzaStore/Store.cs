using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class Store
    {
        #region Instance Field

        #endregion

        #region Constructor
        public Store() 
        {
        
        }
        #endregion

        #region Properties

        #endregion

        #region Methods
        public void Start()
        {
        Pizza pizza1 = new Pizza("Margherita", 69);
        Pizza pizza2 = new Pizza("Calzone", 80);
        Pizza pizza3 = new Pizza("Big Mamma", 90);

        Customer customer1 = new Customer("Rami");
        Customer customer2 = new Customer("Ismail");
        Customer customer3 = new Customer("Arsalon");

        Order order1 = new Order(pizza1, customer1);
        order1.Pizza = pizza1;

        Order order2 = new Order(pizza2, customer2);
        order2.Pizza = pizza2;

        Order order3 = new Order(pizza3, customer3);
        order3.Pizza = pizza3;

            Console.WriteLine(order1);
            Console.WriteLine(order2);
            Console.WriteLine(order3);
        }
        #endregion
    }

}
