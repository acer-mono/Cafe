using PizzaMaker.Dishes.Dessert;
using PizzaMaker.Dishes.Drink;
using PizzaMaker.Dishes.Main;
using PizzaMaker.Dishes.Salad;

namespace PizzaMaker.Meal
{
    public class Breakfast : IMeal
    {
        public IMain Main { get; } = new Porridge();
        public ISalad Salad { get; } = new Eggs();
        public IDessert Dessert { get; } = new Pancake();
        public IDrink Drink { get; } = new Coffee();
    }
}