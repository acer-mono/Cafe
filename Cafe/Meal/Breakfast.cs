using Cafe.Dishes.Dessert;
using Cafe.Dishes.Drink;
using Cafe.Dishes.Main;
using Cafe.Dishes.Salad;

namespace Cafe.Meal
{
    public class Breakfast : IMeal
    {
        public IMain Main { get; } = new Porridge();
        public ISalad Salad { get; } = new Eggs();
        public IDessert Dessert { get; } = new Pancake();
        public IDrink Drink { get; } = new Coffee();
    }
}