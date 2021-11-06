using System;
using System.Collections.Generic;
using PizzaCafe_Builder.Pizzas;

namespace PizzaCafe_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Какую пиццу желаете?\n");
            Console.Write("1-Маргарита\n2-Карбонара\n3-Итальянская\n4-Пепперони\n");
            int clientPizza = Convert.ToInt32(Console.ReadLine());

            List<object> Ingredients = new List<object>();

            switch (clientPizza)
            {
                case 1:
                    Console.Write("Хотите добавить сыр?\n1-да 0-нет\n");
                    int ing = Convert.ToInt32(Console.ReadLine());
                    if (ing == 1) Ingredients.Add(1);

                    Console.Write("Хотите добавить томаты?\n1-да 0-нет\n");
                    ing = Convert.ToInt32(Console.ReadLine());
                    if (ing == 1) Ingredients.Add(2);

                    Console.Write("Хотите добавить оливки?\n1-да 0-нет\n");
                    ing = Convert.ToInt32(Console.ReadLine());
                    if (ing == 1) Ingredients.Add(3);

                    Console.Write("Хотите добавить мясо?\n1-да 0-нет\n");
                    ing = Convert.ToInt32(Console.ReadLine());
                    if (ing == 1) Ingredients.Add(4);

                    Pizza pizza = new Pizza();
                    PizzaBuilder builder = new Margarita();

                    Console.WriteLine("Ваш заказ: Маргарита");
                    Pizza margarita = pizza.Bake(builder, Ingredients);
                    Console.WriteLine(margarita.ToString());
                    break;
                case 2:
                    Console.Write("Хотите добавить сыр?\n1-да 0-нет\n");
                    ing = Convert.ToInt32(Console.ReadLine());
                    if (ing == 1) Ingredients.Add(1);

                    Console.Write("Хотите добавить томаты?\n1-да 0-нет\n");
                    ing = Convert.ToInt32(Console.ReadLine());
                    if (ing == 1) Ingredients.Add(2);

                    Console.Write("Хотите добавить оливки?\n1-да 0-нет\n");
                    ing = Convert.ToInt32(Console.ReadLine());
                    if (ing == 1) Ingredients.Add(3);

                    Console.Write("Хотите добавить мясо?\n1-да 0-нет\n");
                    ing = Convert.ToInt32(Console.ReadLine());
                    if (ing == 1) Ingredients.Add(4);

                    pizza = new Pizza();
                    builder = new Carbonara();

                    Console.WriteLine("Ваш заказ: Карбонара");
                    Pizza carbonara = pizza.Bake(builder, Ingredients);
                    Console.WriteLine(carbonara.ToString());
                    break;
                case 3:
                    Console.Write("Хотите добавить сыр?\n1-да 0-нет\n");
                    ing = Convert.ToInt32(Console.ReadLine());
                    if (ing == 1) Ingredients.Add(1);

                    Console.Write("Хотите добавить томаты?\n1-да 0-нет\n");
                    ing = Convert.ToInt32(Console.ReadLine());
                    if (ing == 1) Ingredients.Add(2);

                    Console.Write("Хотите добавить оливки?\n1-да 0-нет\n");
                    ing = Convert.ToInt32(Console.ReadLine());
                    if (ing == 1) Ingredients.Add(3);

                    Console.Write("Хотите добавить мясо?\n1-да 0-нет\n");
                    ing = Convert.ToInt32(Console.ReadLine());
                    if (ing == 1) Ingredients.Add(4);

                    pizza = new Pizza();
                    builder = new Italian();

                    Console.WriteLine("Ваш заказ: Итальянская");
                    Pizza italian = pizza.Bake(builder, Ingredients);
                    Console.WriteLine(italian.ToString());
                    break;
                case 4:
                    Console.Write("Хотите добавить сыр?\n1-да 0-нет\n");
                    ing = Convert.ToInt32(Console.ReadLine());
                    if (ing == 1) Ingredients.Add(1);

                    Console.Write("Хотите добавить томаты?\n1-да 0-нет\n");
                    ing = Convert.ToInt32(Console.ReadLine());
                    if (ing == 1) Ingredients.Add(2);

                    Console.Write("Хотите добавить оливки?\n1-да 0-нет\n");
                    ing = Convert.ToInt32(Console.ReadLine());
                    if (ing == 1) Ingredients.Add(3);

                    Console.Write("Хотите добавить мясо?\n1-да 0-нет\n");
                    ing = Convert.ToInt32(Console.ReadLine());
                    if (ing == 1) Ingredients.Add(4);

                    pizza = new Pizza();
                    builder = new Pepperoni();

                    Console.WriteLine("Ваш заказ: Пепперони");
                    Pizza pepperoni = pizza.Bake(builder, Ingredients);
                    Console.WriteLine(pepperoni.ToString());
                    break;
                default:
                    Console.WriteLine("Такой пиццы нет");
                    break;
            }

            Console.Read();
        }
    }
}
