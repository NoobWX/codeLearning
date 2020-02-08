class Program {
    public static void Main (string[] args) {
        Cat cat = new Cat ("小白");
        Cat cat1 = new Cat ();
        cat.Shut ();
        cat1.Shut ();
        cat.CatShut ();
        cat1.Times = 5;
        cat1.CatShut ();
        Dog dog = new Dog ("小黑");
        Dog dog1 = new Dog ();
        dog.Shut ();
        dog1.Shut ();
        dog.DogShut ();
        dog1.Times = 5;
        dog1.DogShut ();
    }
}