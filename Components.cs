namespace Composition;
public class Walker {
    public string Name;
    public Walker(string name) {
        this.Name = name;
    }
    public void Walk(){
        System.Console.WriteLine($"{Name} is walking.");
    }
}

public class Swimmer {
    public string Name;
    public Swimmer(string name) {
        this.Name = name;
    }
    public void Swim(){
        System.Console.WriteLine($"{Name} is swimming.");
    }
}

public class Flyer {
    public string Name;
    public Flyer(string name) {
        this.Name = name;
    }
    public void Fly(){
        System.Console.WriteLine($"{Name} is flying.");
    }
}