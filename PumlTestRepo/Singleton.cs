namespace PumlTestRepo;

public class Singleton
{
    private static Singleton Instance { set; get; }

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