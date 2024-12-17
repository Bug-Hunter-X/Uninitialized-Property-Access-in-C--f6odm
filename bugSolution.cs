public class ExampleClass
{
    public int MyProperty { get; set; }

    public ExampleClass()
    {
        // Initialize the property in the constructor.
        MyProperty = 0; // Or another suitable default value
    }

    public void MyMethod()
    {
        int value = MyProperty * 2; 
    }
}