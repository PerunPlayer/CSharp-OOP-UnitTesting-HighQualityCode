## Creational Patterns - Singleton
### _Homework_

1. Какво представлява?
          Шаблон, използван в моделирането на обекти, които трябва да бъдат широко достъпни или ако се цели пестене на памет. Много известен в софтуерното инженерство. Често се създава с Lazy loading принципа.
2. Защо се използва?
          Използва се, за да се подсигури, че определен клас има само една инстанция - с цел един обект да отговаря за определена работа. Използва се при нужда от уникални обекти. Наричан е anti-patern, защото носи голям coupling и остава в паметта за дълго. Нарушава принципи на обектно-ориентираното програмиране.
          Понякога при възможен достъп до класа от много места едновременно има възможност да се създаде проблем, затова се използва thread-safe имплементация.
3. Използва се за high score list в игрите и при нужда от наличие на единствена инстанция.

### Схема
![Schema](imgs/Singleton.png)

### Използване
normal Singleton

using System;

public class Singleton {
    private static Singleton instance = new Singleton();
    private Singleton() {}

    public static Singleton getInstance() {
        return instance;
    }
}

with lazy loading

using System;

public class Singleton {
    private static Singleton instance = null;
    private Singleton() {}

    public static Singleton getInstance() {
        if (instance == null) instance = new Singleton();
        return instance;
    }
}

thread-safe

public sealed class Singleton
{
    private static Singleton instance = null;
    private static readonly object padlock = new object();

    private Singleton()
    {
    }

    public static Singleton Instance
    {
        get
        {
            if (instance == null)
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }
                }
            }
            return instance;
        }
    }
}
