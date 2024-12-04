public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Accessing a property that has not been initialized can lead to unexpected behavior
        int value = MyProperty; // This may return 0, depending on the context
    }
}