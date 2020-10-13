using Cafe.Dishes.Dessert;
using Cafe.Dishes.Drink;
using Cafe.Dishes.Main;
using Cafe.Dishes.Salad;

namespace Cafe.Meal
{
    public class Lunch : IMeal
    {
        public IMain Main { get; } = new Pasta();
        public ISalad Salad { get; } = new Vegies();
        public IDessert Dessert { get; } = new Biscuit();
        public IDrink Drink { get; } = new Compote();
    }
}