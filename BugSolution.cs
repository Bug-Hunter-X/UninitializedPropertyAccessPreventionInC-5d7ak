public class ExampleClass
{
    public int MyProperty { get; set; } = 0; // Initialized to 0

    public ExampleClass()
    {
        // Alternatively initialize in the constructor
        MyProperty = 10; 
    }

    public void MyMethod()
    {
        int value = MyProperty; // Now guaranteed to have a defined value 
    }
}