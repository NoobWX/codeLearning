using System;
class CatShutEventArgs : EventArgs
{
    private string name;
    public string Name
    {
        get {return name;}
        set {name = value;}
    }
}