class Animal {
    protected string name = "";
    public Animal () {
        this.name = "无名";
    }
    Public Animal (string name) {
        this.name = name;
    }
    protected int shutNum = 3;
    public int ShutNum {
        get { return shutNum; }
        set { shutNum = value; }
    }
    public virtual string Shut () {
        return "";
    }
}
class Cat : Animal {
    public Cat () : base () { }
    public Cat (string name) : base (name) { }
    public override string Shut () {
        string Lines = "";
        for (int i = 0; i < ShutNum; ++i) {
            Lines += "喵";
        }
        return "我的名字叫" + name + "  " + Lines;
    }
}
class Dog : Animal {
    public Dog () : base () { }
    public Dog (string name) : base (name) { }
    public override string Shut () {
        string Lines = "";
        for (int i = 0; i < ShutNum; ++i) {
            Lines += "汪";
        }
        return "我的名字叫" + name + "   " + Lines;
    }
}