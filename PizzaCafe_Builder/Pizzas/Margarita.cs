using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaCafe_Builder.Products;

namespace PizzaCafe_Builder.Pizzas
{
    class Margarita: PizzaBuilder
    {
        public override void SetCheese()
        { 
            this.Pizza.Cheese = new Cheese { Name =  "Cыр" }; 
        }

        public override void SetTomatoes()
        {
            this.Pizza.Tomatoes = new Tomatoes { Name = "Томаты" };
        }

        public override void SetOlives()
        {
            this.Pizza.Olives = new Olives { Name = "Оливки" };
        }

        public override void SetMeat()
        {
        }
    }
}
