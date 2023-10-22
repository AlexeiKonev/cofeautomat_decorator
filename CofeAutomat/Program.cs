using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CofeAutomat
{
    class Program
    {
        static void Main(string[] args)
        {

            Beverage beverage = new Espresso();
Console.WriteLine(beverage.GetDescription()
+ " $" + beverage.cost());
Beverage beverage2 = new DarkRoast();
beverage2 = new Mocha(beverage2);
beverage2 = new Mocha(beverage2);
beverage2 = new Whip(beverage2);
Console.WriteLine(beverage2.GetDescription()
+ " $" + beverage2.cost());
Beverage beverage3 = new HouseBlend();
beverage3 = new Soy(beverage3);
beverage3 = new Mocha(beverage3);
beverage3 = new Whip(beverage3);
Console.WriteLine(beverage3.GetDescription()
+ " $" + beverage3.cost());
            Console.ReadKey();
        }
    }

    /*classes
     * Starbuzz Coffee
.89
.99
1.05
1.99
.10
.20
.15
.10
реализация классов напитков
Кофе
Домашняя смесь
Темн.обжарка
Без кофеина
Эспрессо
Дополнения
Молочная пена
Шоколад
Соя
Взбитые сливки
     * 
     */
    /// <summary>
    /// бъекты должны быть взаимо-
    //    заменяемы с Beverage, поэтому
    //    расширяем класс Beverage.
    //    Также все декораторы долж-
    //ны заново реализовать метод
    //    GetDescription(). Зачем? Скоро
    //    узнаете...
    //    Объект Beverage, кото-
    //рый будет «заворачиваться»
    //в каждый Decorator.Обрати-
    //те внимание: мы используем
    //    подтип Beverage, чтобы деко-
    //ратор мог быть оберткой для
    //    любого напитка.
    //    128
    //глава 3
    //Программируем классы напитков
    /// </summary>
    /// 

    public abstract class CondimentDecorator : Beverage
    {
       public Beverage beverage; //abstractый напиток
      public abstract new string GetDescription();
}



    public abstract class Beverage
    {
     public   string description = "Unknown Beverage";

        public string GetDescription()
        {
            return description;
        }
        public abstract double cost();
    }

    /// <summary>
    /// Все классы конкретных напит- ков расширяют Beverage.
//    Описание задается в конструкто-
//ре класса.Стоит напомнить, что
//переменная description наследуется
//от Beverage.
//Остается вычислить стоимость напитка. В этом
//классе беспокоиться о дополнениях не нужно, поэто-
//му мы просто возвращаем стоимость «базового»
//эспрессо — $1.99.
    /// </summary>
    public class Espresso : Beverage
    {
    public Espresso()
    {
        description = "Espresso";//Описание задается в конструкторе
    }
   

        public override double cost()
        {
            return 1.99;
        }
    }
public class DarkRoast : Beverage
    {
    public DarkRoast()
    {
        description = "DarkRoast";//Описание задается в конструкторе
    }
   

        public override double cost()
        {
            return .99;
        }
    }

    /// <summary> Другой класс напитка. От нас
//    требуется лишь назначить подхо-
//дящее описание и вернуть правиль-
//ную стоимость.
//Два других класса напитков (DarkRoast
//и Decaf) создаются аналогично.
    /// </summary>
    public class HouseBlend : Beverage
    {
    public HouseBlend()
    {
        description = "House Blend Coffee";
    }
    public override double cost()
    {
        return 0.89;
    }
}

    public class Mocha : CondimentDecorator
    {
   public Mocha(Beverage beverage)
    {
        this.beverage = beverage;
    }
    public override string GetDescription()
    {
        return beverage.GetDescription() + ", Mocha";
    }
   
        public override double cost()
        {
            return beverage.cost() + .20;
        }
    } 



   public class Whip : CondimentDecorator
    {
     public Whip(Beverage beverage)
    {
        this.beverage = beverage;
    }
    public override string GetDescription()
    {
        return beverage.GetDescription() + ", Whip";
    }
   

         

        public override double cost()
        {
            return beverage.cost() + .10;
        }
    }
    
    public class Soy : CondimentDecorator
    {
   public Soy(Beverage beverage)
    {
        this.beverage = beverage;
    }
    public override string GetDescription()
    {
        return beverage.GetDescription() + ", Soy";
    }
   

        public override double cost()
        {
            return beverage.cost() + .15;
        }
    }
}
