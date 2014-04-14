using System.Collections.Generic;
using System.Linq;

namespace PexDemo
{
  public class Meal
  {
    public int Servings { get; set; }
    public decimal Price { get; set; }
  }

  public class Demo
  {
    public static decimal CalculatePricePerServing1(IEnumerable<Meal> meals)
    {
      return meals.Average(p => p.Servings / p.Price);
    }

    public static decimal CalculatePricePerServing2(IEnumerable<Meal> meals)
    {
      if (meals == null || !meals.Any(p => p != null && p.Price != 0 && p.Servings != 0))
      {
        return -1;
      }

      return meals.Average(p => p.Servings / p.Price);
    }

    public static decimal CalculatePricePerServing3(IEnumerable<Meal> meals)
    {
      if (meals != null && meals.Any(b => b != null))
      {
        var notEmpty = meals.Where(b => b != null && b.Price > 0);
        if (!notEmpty.Any())
        {
          return -1;
        }
        return notEmpty.Average(p => p.Servings / p.Price);
      }

      return -1;
    }
  }
}
