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
    public abstract class Beverage
    {
     public   string description = "Unknown Beverage";
        public string getDescription()
        {
            return description;
        }
        public abstract double cost();
    }


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
}
