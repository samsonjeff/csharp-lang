using System;
class Program{

    public static void Main(string[] args){
        // I just think of a scenario where I can use that sample method I made

        Console.Write("Enter username: ");
        string? userInput = Console.ReadLine();
                                                        // validation if input = int
        while (string.IsNullOrWhiteSpace(userInput) || int.TryParse(userInput, out _))
        {
            Console.Write("Enter username: ");
            userInput = Console.ReadLine();
        }
        
        Greet(userInput); // to call the method
    }
    static void Greet(string userName)  // this is the method
    {        
        Console.WriteLine($"Hello {userName}");
    }
}
