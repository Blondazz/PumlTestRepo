namespace PumlTestRepo;

public class Singleton
{
    private static Singleton Instance { get; set; }
    private Singleton Test2;
    public Singleton Test3;

    private Singleton()
    {
    }

    public static Singleton GetInstance()
    {
        if (Instance == null)
        {
            Instance = new Singleton();
        }

        return Instance;
    }
}