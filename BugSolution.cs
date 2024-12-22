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

        // Solution: Check for null before accessing the property
        if (instance != null)
        {
            int value = instance.MyProperty; // Access the property safely
            instance = null; // Now it's safe to assign null
        }
        else
        {
            Console.WriteLine("Instance is null");
        }
    }
}