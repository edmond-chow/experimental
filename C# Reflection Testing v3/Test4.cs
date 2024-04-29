abstract class MyClass
{
    private static void MyMethod() { Console.WriteLine("MyClass.MyMethod"); }
}
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            AppDomain.CurrentDomain.GetAssemblies()[1].GetType("MyClass").GetMethod("MyMethod", BindingFlags.NonPublic | BindingFlags.Static, null, new Type[] { }, null).Invoke(null, new object[] { });
            // MyClass myClass = new MyClass();
        }
    }
}