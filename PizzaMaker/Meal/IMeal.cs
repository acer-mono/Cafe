using PizzaMaker.Dishes.Dessert;
using PizzaMaker.Dishes.Drink;
using PizzaMaker.Dishes.Main;
using PizzaMaker.Dishes.Salad;

namespace PizzaMaker.Meal
{
    public interface IMeal
    {
        IMain Main { get; }
        ISalad Salad { get; }
        IDessert Dessert { get; }
        IDrink Drink { get; }

        string GetMenu()
        {
            return $"Main: {Main.GetType().Name}\n" +
                   $"Salad: {Salad.GetType().Name} \n" +
                   $"Dessert: {Dessert.GetType().Name}\n" +
                   $"Drink: {Drink.GetType().Name}";
        }
    }
}