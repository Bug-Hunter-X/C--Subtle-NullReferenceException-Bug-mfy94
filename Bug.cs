public class MyClass
{
    public int MyProperty { get; set; }

    public MyClass(int value)
    {
        MyProperty = value;
    }

    public static void Main(string[] args)
    {
        MyClass instance = new MyClass(10);
        Console.WriteLine(instance.MyProperty); // Output: 10

        // The following line causes a subtle bug
        instance = null;

        Console.WriteLine(instance.MyProperty); // NullReferenceException
    }
}