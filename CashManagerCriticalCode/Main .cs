using System.Globalization;
using System;
using System.ComponentModel;
class Program
{
    double total = 0.0d;
    public static void Main(string [] args)
    {
        CashSuper cs = CashFactory.CreateCashAccept(cbxType.SelectedItem.ToString());
        double totalPrices = 0d;
        totalPrices = cs.acceptCash(Convert.ToDouble(txtPrice.Text) * Convert.ToDouble(txtNum.Text)+totalPrices);
        total += totalPrices;
    }
}