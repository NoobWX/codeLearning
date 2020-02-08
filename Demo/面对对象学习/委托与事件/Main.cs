
class program
{
    public static void Main(string [] args)
    {
        Cats cats = new Cats("Tom");
        Mouses mouses1 = new Mouses("Jack");
        Mouses mouses2 = new Mouses("Jerry");
        cats.CatShut += new Cats.CatShutEventHandler(mouses1.MouseShut);
        cats.CatShut += new Cats.CatShutEventHandler(mouses1.Run);
        cats.CatShut += new Cats.CatShutEventHandler(mouses2.MouseShut);
        cats.CatShut += new Cats.CatShutEventHandler(mouses2.Run);
        cats.Shut();
        System.Console.ReadKey();
    }
}