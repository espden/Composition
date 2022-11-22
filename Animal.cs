namespace Composition;

public class Antelope {
    private Walker walker;
    public Antelope() {
        walker = new Walker(nameof(Antelope));
    }
    public void Walk() => walker.Walk();
}

public class Duck {
    private Walker walker;
    private Flyer flyer;
    private Swimmer swimmer;
    public Duck() {
        walker = new Walker(nameof(Duck));
        flyer = new Flyer(nameof(Duck));
        swimmer = new Swimmer(nameof(Duck));
    }

    public void Walk() => walker.Walk();
    public void Fly() => flyer.Fly();
    public void Swim() => swimmer.Swim();
}

public class Hippo {
    private Walker walker;
    private Swimmer swimmer;
    public Hippo() {
        walker = new Walker(nameof(Hippo));
        swimmer = new Swimmer(nameof(Hippo));
    }
    public void Walk() => walker.Walk();
    public void Swim() => swimmer.Swim();
}