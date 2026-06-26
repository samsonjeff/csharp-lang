using System;

class Program{
                    // goal nito makuha ang same index ng 2 array using same value
                    // input from the user input
    public static void Main(string[] args){
        //for newbie lang po kung pro kana paturo nalang
        // in counting array index or element, it is always starts at 0
        // ex. colors[0] = red // ang output nyan

        string[] colors = {"red", "green", "blue"};
        string[] fruits = {"apple", "avocado", "berry"};

        while(true){ // while true ang input mag rurun lang ng mag rurun

            Console.WriteLine("[1] = red:apple [2] = green:avocado [3] = blue:berry");
            Console.Write("Enter a Number: ");
            
            // TryParse checks if it's a number, and if it is, assigns it to userInput
            if(!int.TryParse(Console.ReadLine(), out int userInput)) // getting the user input 
            // TryPars magandang method para sa: int, double, bool, at DateTime
            {
                Console.Write("Enter a Number: ");
                continue; // jumps right back to ensure it is true
            }


            // to avoid 0 lang at dapat max of lenght lang ng array mo! sakit
            if(userInput >= 1 && userInput <= colors.Length)
                {
                    int inputIndex = userInput -1; // para equal sa index ng array
                    Console.WriteLine("========================================");
                                        // format lang to pag nag execute
                    Console.WriteLine($"{userInput} = {colors[inputIndex]}:{fruits[inputIndex]}");
                    Console.WriteLine("========================================");
                    
                }
            else
                {
                    Console.WriteLine(" Invalid ");
                    break; // pag daw false tigil na ang loop kase naka while true ka sa top
                    
                }
        }
    }
}// code by: samson
