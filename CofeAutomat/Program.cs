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
            Console.WriteLine(beverage.GetDescription() + " $" + beverage.Cost());

            Beverage beverage2 = new HouseBlend();
            beverage2 = new Mocha(beverage2);
            beverage2 = new Soy(beverage2);
            beverage2 = new Whip(beverage2);
            Console.WriteLine(beverage2.GetDescription() + " $" + beverage2.Cost());

            Beverage beverage3 = new DarkRoast();
            beverage3 = new Mocha(beverage3);
            beverage3 = new Mocha(beverage3);
            beverage3 = new Whip(beverage3);
            Console.WriteLine(beverage3.GetDescription() + " $" + beverage3.Cost());
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
        protected Beverage Beverage;

    }


    public abstract class Beverage
    {
        public abstract string GetDescription();

        public abstract decimal Cost();
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
        public override string GetDescription()
        {
            return "Espresso";
        }

        public override decimal Cost()
        {
            return 1.99m;
        }
    }
public class DarkRoast : Beverage
    {
        public override string GetDescription()
        {
            return "Dark Roast Coffee";
        }

        public override decimal Cost()
        {
            return 0.99m;
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
        public override string GetDescription()
        {
            return "House Blend Coffee";
        }

        public override decimal Cost()
        {
            return 0.89m;
        }
    }

     public class Mocha : CondimentDecorator
    {

        public Mocha(Beverage beverage)
        {
            Beverage = beverage;
        }

        public override string GetDescription()
        {
            return Beverage.GetDescription() + ", Mocha";
        }

        public override decimal Cost()
        {
            return 0.20m + Beverage.Cost();
        }
    }



   public class Whip : CondimentDecorator
    {
        public Whip(Beverage beverage)
        {
            Beverage = beverage;
        }

        public override string GetDescription()
        {
            return Beverage.GetDescription() + ", Whip";
        }

        public override decimal Cost()
        {
            return Beverage.Cost() + 0.10m;
        }
    }
    
     public class Soy : CondimentDecorator
    {
        public Soy(Beverage beverage)
        {
            Beverage = beverage;
        }

        public override string GetDescription()
        {
            return Beverage.GetDescription() + ", Soy";
        }

        public override decimal Cost()
        {
            return Beverage.Cost() + 0.15m;
        }
    }
}
