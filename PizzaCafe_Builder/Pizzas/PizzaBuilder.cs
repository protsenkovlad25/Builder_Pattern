using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCafe_Builder.Pizzas
{
    abstract class PizzaBuilder
    {
        public Pizza Pizza { get; private set; }

        public void CreatePizza()
        { 
            Pizza = new Pizza(); 
        }

        public abstract void SetCheese();
        public abstract void SetTomatoes();
        public abstract void SetOlives();
        public abstract void SetMeat();
    }
}
