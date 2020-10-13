using PizzaMaker.Dishes.Dessert;
using PizzaMaker.Dishes.Drink;
using PizzaMaker.Dishes.Main;
using PizzaMaker.Dishes.Salad;

namespace PizzaMaker.Meal
{
    public class Lunch : IMeal
    {
        public IMain Main { get; } = new Pasta();
        public ISalad Salad { get; } = new Vegies();
        public IDessert Dessert { get; } = new Biscuit();
        public IDrink Drink { get; } = new Compote();
    }
}