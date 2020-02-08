class Program {
    public static void Main (string[] args) {
        Animal[] arrayAnimal = new Animal[5];
        // arrayAnimal[0] = new Cat ("小白");
        // arrayAnimal[1] = new Dog ("小黑");
        // arrayAnimal[2] = new Cat ("小莉");
        // arrayAnimal[3] = new Cat ("咪咪");
        // arrayAnimal[4] = new Dog ("旺财");
        arrayAnimal[0] = new Cattle("小花");
        arrayAnimal[1] = new Cat("咪咪");
        arrayAnimal[2] = new Dog("小黑");
        arrayAnimal[3] = new Sheep("小咩");
        arrayAnimal[4] = new Cat("喵喵");
        foreach (Animal item in arrayAnimal) {
            System.Console.WriteLine (item.Shut ());
        }
    }
}