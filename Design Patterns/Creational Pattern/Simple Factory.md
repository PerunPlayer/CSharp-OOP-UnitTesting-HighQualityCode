## Creational Patterns - Simple Factory
### _Homework_

1. Какво представлява?
          Шаблон, който се използва в обектно-ориентираното програмиране. Дава различна инстанция за всеки тип. По принцип Factory-тата са единствени в дадена програма, затова за създаването им често се използва Singleton.
2. Защо се използва?
          Използва се, когато трябва да се централизира създаването на обекти на едно място, запазва single responsibility принципа, крие тежка логика. Създава се с наследяване или с Decorator patern.

### Схема
![Schema](imgs/Simple Factory.png)

### Използване

public IScientist GetScience(ScienceType type)
{
    switch(type)
    {
        case ScienceType.Physics: return new PhysicDoctor();
        case ScienceType.Anatomy: return new AnatomyDoctor();
        case ScienceType.Biology: return new BiologyProfessor();
        default throw new ArgumentException("Invalid science type")
    }
}
