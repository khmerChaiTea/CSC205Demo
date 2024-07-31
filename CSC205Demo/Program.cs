using System;

interface ISampleInterface //good practice to start with an "I"
{
    void SampleMethod();
}

class ImplementationClass : ISampleInterface
{
    // Explicit interface member implementation:
    void ISampleInterface.SampleMethod()
    {
        Console.WriteLine("I'm an implementation of interface method!");
    }

    static void Main()
    {
        // Declare an interface instance.
        //ISampleInterface obj = new ImplementationClass();
        var obj = new ImplementationClass();

        // Call the member.
        //obj.SampleMethod();
        ((ISampleInterface)obj).SampleMethod();
    }
}
