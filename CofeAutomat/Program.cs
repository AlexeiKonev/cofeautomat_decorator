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
        }
    }

    /*classes
     * 
     * 
     */
    /// <summary>
    /// бъекты должны быть взаимо-
    //    заменяемы с Beverage, поэтому
    //    расширяем класс Beverage.
    //    Также все декораторы долж-
    //ны заново реализовать метод
    //    getDescription(). Зачем? Скоро
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
        description = "Espresso";
    }
   

        public override double cost()
        {
            return 1.99;
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
}
