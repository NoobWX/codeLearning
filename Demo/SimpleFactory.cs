/// <summary>
/// 简单的实例化工厂类
/// </summary>
class SimpleFactory {
    /// <summary>
    /// 实例化方法
    /// </summary>
    /// <param name="sign">运算符</param>
    /// <returns>返回运算法则</returns>
    public static Operation CreateOperation (string sign) {
        Operation opera = null;
        switch (sign) {
            case "+":
                opera = new AddOperation ();
                break;
            case "-":
                opera = new SubOperation ();
                break;
            case "*":
                opera = new MulOperation ();
                break;
            case "/":
                opera = new DivOperation ();
                break;
            default:
                throw new System.Exception ("暂未添加此功能！");
        }
        return opera;
    }
}