class Penguins : Birds {
    Weather we = new Weather ();
    public string cause () {
        return "I am Penguins" + we.cause ();
    }
    public string LayEggs () {
        return "I can LayEggs";
    }
}