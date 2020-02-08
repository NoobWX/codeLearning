class Cats
{
    private string _name;
    public Cats(string name)
    {
        _name = name;
    }
    public delegate void CatShutEventHandler(object sender,CatShutEventArgs args);
    public event CatShutEventHandler CatShut;
    public void Shut()
    {
        System.Console.WriteLine(_name+":I am cat ! I will catch you !");
        if(CatShut != null)
        {
            CatShutEventArgs e = new CatShutEventArgs();
            e.Name = this._name;
            CatShut(this,e);
        }
    }
}