namespace PumlTestRepo;

public class Singleton
{
    private Singleton Instance;

    public Singleton GetInstance()
    {
        if (Instance == null)
            Instance = new Singleton();

        return Instance;
    }
}