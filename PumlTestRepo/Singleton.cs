namespace PumlTestRepo;

public class Singleton
{
    private Singleton Instance { set; get; }

    public Singleton GetInstance()
    {
        if (Instance == null)
            Instance = new Singleton();

        return Instance;
    }
}