using System;
using System.Xml.Xsl.Runtime;
//现金收费抽象类
abstract class CashSuper {
    public abstract double acceptCash (double money);
}
//正常收费子类
class CashNormal : CashSuper {
    public override double acceptCash (double money) {
        return money;
    }
}
//打折收费子类
class CashRebate : CashSuper {
    private double moneyRebate = 1d;
    public CashRebate (string moneyRebate) {
        this.moneyRebate = double.Parse (moneyRebate);
    }
    public override double acceptCash (double money) {
        return money * moneyRebate;
    }
}
class CashReturn : CashSuper {
    private double moneyCondition = 0.0d;
    private double moneyReturn = 0.0d;
    public CashReturn (string moneyCondition, string moneyReturn) {
        this.moneyCondition = double.Parse (moneyCondition);
        this.moneyReturn = double.Parse (moneyReturn);
    }
    public override double acceptCash (double money) {
        if (money >= moneyCondition) {
            return money;
        } else {
            return money - moneyReturn;
        }
    }
}
//现金收费工厂
class CashFactory {
    public static CashSuper CreateCashAccept (string type) {
        CashSuper cs = null;
        switch (type) {
            case "正常收费":
                cs = new CashNormal ();
                break;
            case "满300减100":
                CashReturn cashReturn = new CashReturn ("300", "100");
                cs = cashReturn;
                break;
            case "打八折":
                CashRebate cashRebate = new CashRebate ("0.8");
                cs = cashRebate;
                break;
        }
        return cs;
    }
}