namespace PumlTestRepo;

public class C1
{

    
    private int intPrivate;
    public int IntPublic;
    private const int IntConst = 10;
    public const int IntConstPublic = 20;
    private static int IntStatic;
    public static int IntStaticPublic = 40;
    protected int IntProtected = 50;
    internal int IntInternal = 55;

    private int IntProp { get; set; }
    public int IntPropPublic { get; set; } = 60;

    public int IntPropCombined1 { private get; init; }

    public void Void(){}
    
    private void VoidPrivate(){}
    
    public void VoidWithArgs(string args, int args2){}
    
    public static void VoidStaticPublic(){}
    private static void VoidStaticPrivate(List<Type> a){}

    public List<string> ListPublic()
    {
        return null;
    }

    public C1()
    {
        
    }
    
    public C1(C1Interface c1Interface)
    {
        
    }

}

public interface C1Interface
{
    
}

public struct C2
{
}

internal class C3
{
    private class C3Inside
    {
    }
}

public static class C4
{
}

public class C5<T1, T2>
{
    public T1 T1Field;
    
    
}