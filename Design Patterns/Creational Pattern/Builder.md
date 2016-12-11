## Creational Patterns - Builder
### _Homework_

1. Какво представлява?
          С Builder Pattern се създават обекти и дели логиката по създаването, като така един процес на създаване може да създаде различни обекти. Той позволява енкапсулация и улеснява създаването на обекти. Чрез него се премахва подаването на много параметри и конструктори. Шаблонът използва Director, абстрактен Builder и конкретен Builder.
          Съществува определена последователност при инициализирането на различните части. Създаването им се осъществява чрез методи, които са дефинирани в интерфейс, което позволява на всеки наследник да override-не създаването на компонентите.
2. Защо се използва?
          Използва се, с цел създаване на обекти, с определена последователност на инициализиране на различните компоненти на обекта.

### Схема
![Schema](imgs/Builder.png)

### Използване

using System;
using System.Collections.Generic;

namespace DoFactory.GangOfFour.Builder.Structural
{
  /// <summary>
  /// MainApp startup class for Structural
  /// Builder Design Pattern.
  /// </summary>
  public class MainApp
  {
    /// <summary>
    /// Entry point into console application.
    /// </summary>
    public static void Main()
    {
      // Create director and builders
      Director director = new Director();

      Builder b1 = new ConcreteBuilder1();
      Builder b2 = new ConcreteBuilder2();

      // Construct two products
      director.Construct(b1);
      Product p1 = b1.GetResult();
      p1.Show();

      director.Construct(b2);
      Product p2 = b2.GetResult();
      p2.Show();

      // Wait for user
      Console.ReadKey();
    }
  }

  /// <summary>
  /// The 'Director' class
  /// </summary>
  class Director
  {
    // Builder uses a complex series of steps
    public void Construct(Builder builder)
    {
      builder.BuildPartA();
      builder.BuildPartB();
    }
  }

  /// <summary>
  /// The 'Builder' abstract class
  /// </summary>
  abstract class Builder
  {
    public abstract void BuildPartA();
    public abstract void BuildPartB();
    public abstract Product GetResult();
  }

  /// <summary>
  /// The 'ConcreteBuilder1' class
  /// </summary>
  class ConcreteBuilder1 : Builder
  {
    private Product prodct = new Product();

    public override void BuildPartA()
    {
      prodct.Add("PartA");
    }

    public override void BuildPartB()
    {
      prodct.Add("PartB");
    }

    public override Product GetResult()
    {
      return prodct;
    }
  }

  /// <summary>
  /// The 'ConcreteBuilder2' class
  /// </summary>
  class ConcreteBuilder2 : Builder
  {
    private Product prodct = new Product();

    public override void BuildPartA()
    {
      prodct.Add("PartX");
    }

    public override void BuildPartB()
    {
      prodct.Add("PartY");
    }

    public override Product GetResult()
    {
      return prodct;
    }
  }

  /// <summary>
  /// The 'Product' class
  /// </summary>
  class Product
  {
    private List<string> parts = new List<string>();

    public void Add(string part)
    {
      parts.Add(part);
    }

    public void Show()
    {
      Console.WriteLine("\nProduct Parts -------");
      foreach (string part in parts)
        Console.WriteLine(part);
    }
  }
}
