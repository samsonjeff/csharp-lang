using System;

class Program{

    // ======= this is the "Method" ========
    static void Greet(string userName){
    // Sample function. Feel free to adapt or improve this logic for your own use case.
        Console.WriteLine($"Hello {userName}");
    }
    // =====================================

    // =====================================
     // Methods with returning value and method overloading
    static int SumOf(int x, int y)
    {        
        int add = y + x;

        return add;

    }

    // method overload (changing the variable type)
    static float SumOf(float x, float y)
    {        
        float add = x + y;

        return add;

    }
    // method overload
    /*public*/ /*only need if use main in separate file */static int SumOf(int x, int y, int z)
    {        
        int add = y + x + z;

        return add;

    }

    static string UsersInfo(string x, string y)
    {        
        string fullName = x + " " + y;

        return fullName;

    }
    // =====================================

    
    public static void Main(string[] args){
        // I just think of a case where I can use that sample method I made

        Console.Write("Enter username: ");
        string? userInput = Console.ReadLine();
                                                        // validation if input = int
        while (string.IsNullOrWhiteSpace(userInput) || int.TryParse(userInput, out _))
        {
            Console.Write("Enter username: ");
            userInput = Console.ReadLine();
        }
        // ======================================
        Greet(userInput); // to call the method
        // ======================================
    }
}
