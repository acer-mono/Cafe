using PizzaMaker.Dishes.Dessert;
using PizzaMaker.Dishes.Drink;
using PizzaMaker.Dishes.Main;
using PizzaMaker.Dishes.Salad;

namespace PizzaMaker.Meal
{
    public class Supper : IMeal
    {
        public IMain Main { get; } = new Yogurt();
        public ISalad Salad { get; } = new Fruit();
        public IDessert Dessert { get; } = new Cake();
        public IDrink Drink { get; } = new Tea();
    }
}