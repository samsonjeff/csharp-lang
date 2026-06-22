// inheritance
// The base class representing a general employee
class Employee
{
    // A field every employee has
    public string name = "Alex"; 
}

// The derived class inheriting 'name' from Employee and adding its own twist
class Manager : Employee
{
    // A field exclusive only to managers
    public int teamSize = 5; 
}

//abstract
// An abstract class that cannot be instantiated on its own
abstract class Appliance
{
    // An abstract method with no body; child classes are forced to write the logic
    public abstract void TurnOn(); 
}

// A concrete class fulfilling the contract of the abstract Appliance
class Oven : Appliance
{
    // The 'override' keyword is mandatory to implement the required TurnOn method
    public override void TurnOn() 
    {
        // The specific implementation of how an oven turns on
        Console.WriteLine("Heating up elements..."); 
    }
}

//encapsulation
class UserProfile
{
    // Private field: locked tight, completely hidden from outside classes
    private int age; 

    // Public property: the controlled gatekeeper to read and write the private 'age'
    public int Age 
    {
        // Getter allows outside code to read the value safely
        get { return age; } 
        
        // Setter intercepts any attempt to change the value and applies a rule
        set { age = (value < 0) ? 0 : value; } // If input is negative, default it to 0
    }
}

//Polymorphism
// Base class with a virtual method open for modification
class Shape
{
    // 'virtual' tells C# this method can be modified by child classes
    public virtual void Draw() { Console.WriteLine("Drawing a shape."); }
}

// Derived class reimagining the Draw method
class Circle : Shape
{
    // 'override' changes the behavior of Draw specifically for Circles
    public override void Draw() { Console.WriteLine("Drawing a circle."); }
}