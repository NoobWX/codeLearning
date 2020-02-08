class Program {
    static void Main (string[] args) {
        Operation opera = new Operation ();
        opera = SimpleFactory.CreateOperation ("+");
        opera.NumberA = 5;
        opera.NumberB = 6;
        System.Console.Write (opera.NumberA + "+" + opera.NumberB + "=" + opera.getResult ());
    }
}