class WildGoose : Birds, IFly {
    public WildGoose () : base () {

    }
    public string LayEggs () {
        return "I can LayEggs";

    }
    public string Fly()
    {
        return "I can Fly";
    }

}