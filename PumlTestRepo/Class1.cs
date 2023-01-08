using System.Collections;
using System.Data;
using System.Security;

namespace PumlTestRepo;

public class PublicClass
{
    private class PrivateClass
    {
    }
}

internal class InternalClass
{
}

public struct PublicStruct
{
    private struct PrivateStruct
    {
    }
}

internal struct InternalStruct
{
}

public class ClassWithGenerics<T1, T2>
{
}

public enum EnumPublic
{
    A = 10,
    B = 135,
    C = 2137
}

internal enum EnumInternal
{
    a,
    b,
    c,
}

public enum EnumPublicTyped : long
{
    X,
    Y,
    Z = -123
}

internal enum EnumInternalTyped : ushort
{
    x,
    y,
    z = 99
}

public abstract class XXXX
{
    public abstract int X { get; set; }
    public abstract void H(int a, string b, Tuple<int, float> c);
    internal abstract int Y();
}

public class C100
{
    public virtual void XD()
    {
        Console.Write("XD");
    }

    public virtual event EventHandler Somet;
    public readonly int ReadOnlyInt = 217000;
}

public class C1002 : C100
{
    public override void XD()
    {
        Console.Write("XD2");
    }


    public override event EventHandler Somet;

    public void xDDD()
    {
    }
}

public class C1
{

    private C1 instance;


    
    
    
    public event EventHandler Somet;
    private static event EventHandler XD;
    internal event EventHandler<string> lol;
    private int intPrivate;
    public int IntPublic;
    private const int IntConst = 10;
    public const int IntConstPublic = 20;
    private static int IntStatic;
    public static int IntStaticPublic = 40;
    protected int IntProtected = 50;
    internal int IntInternal = 55;
    protected internal int IntInternalProtected = 55;
    protected internal int IntInternalProtectedWithoutValue;


    public static string StringProp { protected get; set; } =
        "WITAM SERDECZNIE TUTAJ JAKUB GAŹDZIK <<internal>> {static}";

    public static string StringField = "";

    public Tuple<int, string, LoaderOptimization> TupleFun()
    {
        return null;
    }

    public (int a, string b) TupleFun2()
    {
        return (0, "");
    }


    public static Tuple<Int16, int> AdditionalGenericArgs(int a,
        Tuple<int, float, IsolationLevel> tuple1, Dictionary<string, Tuple<Int16, Int32>> tuple2)
    {
        return new Tuple<short, int>(0, 1);
    }


    internal void VoidInternal()
    {
    }

    protected void VoidProtected(int a, InternalBufferOverflowException b, SuppressUnmanagedCodeSecurityAttribute c)
    {
    }

    protected internal void VoidProtectedInternal()
    {
    }

    private int IntProp { get; set; }
    public int IntPropPublic { get; set; } = 60;

    public int IntPropPublicWithProtected { protected get; set; }


    public int IntPropExt
    {
        get { return IntProtected; }
        set { intPrivate = value; }
    }


    public int IntPropCombined1 { private get; init; }

    public void Void()
    {
    }

    private void VoidPrivate()
    {
    }

    public void VoidWithArgs(string args, int args2)
    {
    }

    public static void VoidStaticPublic()
    {
    }

    private static void VoidStaticPrivate(List<Type> a)
    {
    }

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

public abstract class AbstractClass
{
    public abstract void AVoid();
    internal abstract DictionaryBase DictionaryAbstractInternal();
    public abstract int X { get; set; }
    public abstract DateOnly DDD(DateTime someName);
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

    public Dictionary<T1, T2> Dict()
    {
        return null;
    }

    public Dictionary<T1, T2> Dict2(Dictionary<T1, T2> ddd)
    {
        return null;
    }
}