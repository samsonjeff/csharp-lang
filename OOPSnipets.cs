using System;

// ========== INHERITANCE ==========
class Employee
{
    public string Name { get; set; }
    
    public Employee(string name)
    {
        Name = name;
    }
}

class Manager : Employee
{
    public int TeamSize { get; set; }
    
    // Constructor that calls the parent class constructor
    public Manager(string name, int teamSize) : base(name)
    {
        TeamSize = teamSize;
    }
}

// ========== ABSTRACT ==========
abstract class Appliance
{
    public abstract void TurnOn();
}

class Oven : Appliance
{
    public override void TurnOn()
    {
        Console.WriteLine("Heating up elements...");
    }
}

// ========== ENCAPSULATION ==========
class UserProfile
{
    private int age;
    
    public int Age
    {
        get { return age; }
        set { age = (value < 0) ? 0 : value; }
    }
}

// ========== POLYMORPHISM ==========
class Shape
{
    public virtual void Draw() 
    { 
        Console.WriteLine("Drawing a shape."); 
    }
}

class Circle : Shape
{
    public override void Draw() 
    { 
        Console.WriteLine("Drawing a circle."); 
    }
}

// ========== MAIN PROGRAM ==========
class Program
{
    static void Main()
    {
        // Test Inheritance
        Manager mgr = new Manager("Alex", 5);
        Console.WriteLine($"Manager: {mgr.Name}, Team: {mgr.TeamSize}");
        
        // Test Abstract Class
        Oven oven = new Oven();
        oven.TurnOn();
        
        // Test Encapsulation
        UserProfile user = new UserProfile();
        user.Age = -10;
        Console.WriteLine($"Age: {user.Age}");
        
        // Test Polymorphism
        Shape circle = new Circle();
        circle.Draw();
    }
}
