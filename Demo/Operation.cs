/// <summary>
/// 运算类
/// </summary>
class Operation {
    private double _numberA = 0;
    private double _numberB = 0;
    public double NumberA {
        set { _numberA = value; }
        get { return _numberA; }
    }
    public double NumberB {
        set { _numberB = value; }
        get { return _numberB; }
    }
    public virtual double getResult () {
        double result = 0;
        return result;
    }
}
/// <summary>
/// 加法运算
/// </summary>
class AddOperation : Operation {
    override getResult () {
        return _numberA + _numberB;
    }
}
/// <summary>
/// 减法运算
/// </summary>
class SubOperation : Operation {
    override getResult () {
        return _numberA - _numberB;
    }
}
/// <summary>
/// 乘法运算
/// </summary>
class MulOperation : Operation {
    override getResult () {
        return _numberA * _numberB;
    }
}
/// <summary>
/// 除法运算
/// </summary>
class DivOperation : Operation {
    override getResult () {
        return _numberB == 0 ? 0 : _numberA / _numberB; //三目运算判断是否合法
    }
}