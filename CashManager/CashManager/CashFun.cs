using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashManager
{
    abstract class CashFun
    { 
        protected int Count = 0;
        protected double Price = 0;
        protected double Debate = 0.0d;
        public CashFun(double Debate,int Count,double Price)
        {
            this.Debate = Debate;
            this.Count = Count;
            this.Price = Price;
        }
        public abstract double GetResult();
    }
    class CashCost : CashFun
    {
        public CashCost(double Debate,int Count,double Price) : base(Debate,Count,Price)
        { }
        public override double GetResult()
        {
            return Count * Price;
        }
    }
    class CashRecost : CashFun
    {
        public CashRecost(double Debate, int Count, double Price) : base(Debate, Count, Price)
        { }
        public override double GetResult()
        {
            return Count * Price - Debate;
        }
    }
    class CashDiscount : CashFun
    {
        public CashDiscount(double Debate, int Count, double Price) : base(Debate, Count, Price)
        { }
        public override double GetResult()
        {
            return Count * Price * Debate;
        }
    }
    class CreateCashFactory
    {
        private int _count = 0;
        private double _price = 0.0d;
        public CreateCashFactory(string count,string price)
        {
            this._count = Convert.ToInt32(count);
            this._price = Convert.ToDouble(price);
        }
        public CashFun CreateCashFun(int selectedindex)
        {
            CashFun cf = null;
            try
            {
                switch (selectedindex)
                {
                    case 0:
                        cf = new CashCost(1,_count,_price);
                        return cf;
                    case 1:
                        cf = new CashDiscount(0.8,_count,_price);
                        return cf;
                    case 2:
                        if (_count * _price >= 300)
                        {
                            cf = new CashRecost(100,_count,_price);
                            return cf;
                        }
                        else
                        {
                            cf = new CashCost(1,_count,_price);
                            return cf;
                        }
                    default:
                        return cf;
                }
            }
            catch
            {
                MessageBox.Show("尚未添加此优惠方案");
                return null;
            }
        }
    }
}
