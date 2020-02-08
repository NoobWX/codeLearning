class Birds : Animal {
    private bool feather = true;
    private bool beak = true;
    private Wings wings;
    public Birds () {
        wings = new Wings ();
    }
    public bool Feather {
        get { return feather; }
    }
    public bool Beak {
        get { return beak; }
    }
    public string LayEggs () {
        return "I can LayEggs";
    }
}