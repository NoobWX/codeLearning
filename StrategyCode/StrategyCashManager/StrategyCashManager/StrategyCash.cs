using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyCashManager
{
    abstract class StrategyCash
    {
        public abstract double GetResult(double money);
    }
    class OriginalCost : StrategyCash
    {
        public override double GetResult(double money)
        {
            return money;
        }
    }
    class Discount : StrategyCash
    {
        private double discount = 0d;
        public Discount(double discount)
        {
            this.discount = discount;
        }
        public override double GetResult(double money)
        {
            return money * discount;
        }
    }
    class Reduction : StrategyCash
    {
        private double condition = 0d;
        private double deductionamount = 0d;
        public Reduction(double condition, double deductionamount)
        {
            this.condition = condition;
            this.deductionamount = deductionamount;
        }
        public override double GetResult(double money)
        {
            if (money >= condition)
            {
                return money - deductionamount;
            }
            return money;
        }
    }
}

