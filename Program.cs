namespace Composition;

public static class Program 
{
    public static void Main()
    {
        Antelope antelope = new();
        antelope.Walk();

        Hippo hippo = new();
        hippo.Walk();
        hippo.Swim();

        Duck duck = new();
        duck.Walk();
        duck.Swim();
        duck.Fly();
    }
}