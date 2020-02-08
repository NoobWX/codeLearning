class Mouses
{
    private string _name;
    public Mouses( string name)
    {
        _name = name;
    }
    public void MouseShut(object sender,CatShutEventArgs args)
    {
        System.Console.WriteLine(_name+": The cat is coming! Lets get out of there!");
    }
    public void Run(object sender,CatShutEventArgs args)
    {
        System.Console.WriteLine(_name+":Run!Run!Run!"+args.Name+"is comning!");
    }
}