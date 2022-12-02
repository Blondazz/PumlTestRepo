namespace TestApp.Test1;

public interface InterfaceA : InterfaceParent
{
    int IntMethod();
    int IntMethodWithParams(bool a, int b);
    void VoidMethod();

    InterfaceB CreateB();
    void UseB(InterfaceB b);
    
    static void StaticVoidMethod()
    {
        Console.WriteLine("Hi");
    }
    
    string Name { get; set; }
    
    static string Property { get; set; }
    static bool Test {private get; init;}
    event EventHandler statusChanged;
}
