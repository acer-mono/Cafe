using System;
using Cafe.Meal;

namespace Cafe
{
    public class Cafe
    {
        public IMeal GetMeal(string timeOfDay)
        {
            return timeOfDay switch
            {
                "Breakfast" => new Breakfast(),
                "Lunch" => new Lunch(),
                "Supper" => new Supper(),
                _ => throw new ArgumentException($"Not available time of day - {timeOfDay}!")
            };
        }
    }
}