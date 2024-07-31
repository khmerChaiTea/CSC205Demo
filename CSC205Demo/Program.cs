using System;
interface IAnimal // Interface
{
    void animalSound(); // interface method (empty body)
}
class Pig : IAnimal
{  // Pig "implements" the IAnimal interface
    public void animalSound()
    {
        Console.WriteLine("The pig says: wee wee");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Pig myPig = new Pig();  // Create a Pig object
        myPig.animalSound();

        Dog myDog = new Dog();  // Create a Pig object
        myDog.animalSound();
    }
}

class Dog : IAnimal
{
    public void animalSound()
    {
        Console.WriteLine("The dog says: ruff ruff");
    }
}