class Animal {
    protected string _name = "";
    private int _shuttimes = 3;
    public Animal (string name) {
        this._name = name;
    }
    public Animal () {
        this._name = "无名";
    }
    public int ShutTimes {
        get { return _shuttimes; }
        set { _shuttimes = value; }
    }
    public void Introduce () {
        System.Console.WriteLine ("我叫{0}", _name);
    }
    public virtual void Shut () {
        for (int i = 0; i < ShutTimes; ++i) {

            System.Console.WriteLine ();
        }
    }
}

class Cat:Animal
{
    public Cat():base()
    {}
    public Cat(string name):base (name)
    {}
    public override Shut()
    {
        for(int i = 0; i < ShutTimes; ++i)
    }

}


//二代代码
// class Animal {
//     protected string _name = "";
//     private int _shuttimes = 3;
//     public Animal (string name) {
//         this._name = name;
//     }
//     public Animal () {
//         this._name = "无名";
//     }
//     public int ShutTimes {
//         get { return _shuttimes; }
//         set { _shuttimes = value; }
//     }
// }
// class Cat : Animal {
//     public Cat () : base () { }
//     public Cat (string name) : base (name) { }
//     public void Shut () {
//         System.Console.WriteLine ("我叫{0}。", _name);
//     }
//     public void CatShut () {
//         for (int i = 0; i < ShutTimes; i++)
//             System.Console.WriteLine ("喵喵喵！");
//     }
// }
// class Dog : Animal {
//     public Dog () : base () { }
//     public Dog (string name) : base (name) { }
//     public void Shut () {
//         System.Console.WriteLine ("我叫{0}。", _name);
//     }
//     public void DogShut () {
//         for (int i = 0; i < ShutTimes; i++)
//             System.Console.WriteLine ("汪汪汪");
//     }
// }

// 初始代码
// class Cat {
//     private string _name = "";
//     public Cat (string name) {
//         this._name = name;
//     }
//     public Cat () {
//         this._name = "无名猫";
//     }
//     private int _times = 1;
//     public int Times {
//         get { return _times; }
//         set { _times = value; }
//     }
//     public void CatShut () {
//         for (int i; i < _times; i++) {
//             System.Console.WriteLine ("喵喵喵！");
//         }
//     }
//     public void Shut () {
//         System.Console.Write ("我的名字叫{0}喵喵喵", _name);
//     }
// }
// class Dog {
//     private string _name = "";
//     public Dog (string name) {
//         this._name = name;
//     }
//     public Dog () {
//         this._name = "无名狗";
//     }
//     private int _times = 1;
//     public int Times {
//         get { return _times; }
//         set { _times = value; }
//     }
//     public void DogShut () {
//         for (int i; i < _times; i++) {
//             System.Console.WriteLine ("汪汪汪！");
//         }
//     }
//     public void Shut () {
//         System.Console.Write ("我的名字叫{0}汪汪汪", _name);
//     }
// }