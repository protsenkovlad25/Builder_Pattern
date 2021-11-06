using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaCafe_Builder.Products;

namespace PizzaCafe_Builder.Pizzas
{
    class Pizza
    {
        public Cheese Cheese { get; set; }
        public Tomatoes Tomatoes { get; set; }
        public Olives Olives { get; set; }
        public Meat Meat { get; set; }

        public Pizza Bake(PizzaBuilder pizzaBuilder, List<object> ingredients)
        {
            pizzaBuilder.CreatePizza();

            foreach (int ing in ingredients)
            {
                switch(ing)
                {
                    case 1:
                        pizzaBuilder.SetCheese();
                        break;
                    case 2:
                        pizzaBuilder.SetTomatoes();
                        break;
                    case 3:
                        pizzaBuilder.SetOlives();
                        break;
                    case 4:
                        pizzaBuilder.SetMeat();
                        break;
                }
            }

            return pizzaBuilder.Pizza;
        }

        public override string ToString()
        {
            StringBuilder s = new StringBuilder();

            if (Cheese != null)
                s.Append(Cheese.Name + "\n");
            if (Tomatoes != null)
                s.Append(Tomatoes.Name + "\n");
            if (Olives != null)
                s.Append(Olives.Name + "\n");
            if (Meat != null)
                s.Append(Meat.Name + "\n");
            return s.ToString();
        }
    }
}
