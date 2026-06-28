
class Tuples{

    public static void ShowTuples(){

        var items = new (string Color, string Fruit, float Weight)[] 
        {
            ("red", "apple", 2.2f),
            ("green", "avocado", 2.4f),
            ("blue", "berry", 2.5f)
        };

        while(true){

            Console.WriteLine("fruits details.");
            Console.WriteLine("[1] = apple [2] = avocado  [3] = berry ");
            Console.Write("Enter a Number: ");
            
            // TryParse checks if it's a number, and if it is, assigns it to userInput
            if(!int.TryParse(Console.ReadLine(), out int userInput))
            {
                Console.Write("Enter a Number: ");
                continue;
            }

            if(userInput >= 1 && userInput <= items.Length)
                {
                    int inputIndex = userInput -1; // to compliment user input on the exact index or array element
                    Console.WriteLine("========================================");
                    Console.WriteLine($"{userInput} = {items[inputIndex].Fruit} : {items[inputIndex].Color} : {items[inputIndex].Weight}g");
                    Console.WriteLine("========================================");
                    
                }
            else
                {
                    Console.WriteLine(" Invalid ");
                    break;
                    
                }
        }
    }
}
