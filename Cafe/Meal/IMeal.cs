using Cafe.Dishes.Dessert;
using Cafe.Dishes.Drink;
using Cafe.Dishes.Main;
using Cafe.Dishes.Salad;

namespace Cafe.Meal
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