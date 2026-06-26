using System;

class Program{

    public static void Main(string[] args){
        
        string[] colors = {"red", "green", "blue"};
        string[] fruits = {"apple", "avocado", "berry"};

        while(true){

            Console.WriteLine("[1] = red:apple [2] = green:avocado [3] = blue:berry");
            Console.Write("Enter a Number: ");
            
            // TryParse checks if it's a number, and if it is, assigns it to userInput
            if(!int.TryParse(Console.ReadLine(), out int userInput))
            {
                Console.Write("Enter a Number: ");
                continue;
            }

            if(userInput >= 1 && userInput <= colors.Length)
                {
                    int inputIndex = userInput -1; // to compliment user input on the exact index or array element
                    Console.WriteLine("========================================");
                    Console.WriteLine($"{userInput} = {colors[inputIndex]}:{fruits[inputIndex]}");
                    Console.WriteLine("========================================");
                    
                }
            else
                {
                    Console.WriteLine(" Invalid ");
                    break;
                    
                }
        }
    }
}// code by: samson
