using Cafe.Dishes.Dessert;
using Cafe.Dishes.Drink;
using Cafe.Dishes.Main;
using Cafe.Dishes.Salad;

namespace Cafe.Meal
{
    public class Supper : IMeal
    {
        public IMain Main { get; } = new Yogurt();
        public ISalad Salad { get; } = new Fruit();
        public IDessert Dessert { get; } = new Cake();
        public IDrink Drink { get; } = new Tea();
    }
}