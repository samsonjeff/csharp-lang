
class Parent
{
    // reusable in any class
    public string name, lastName;
    public int age;
    public char gender;

    // This is a Constructor for the Parent class. It acts like a blueprint's setup
    // phase, taking in 4 pieces of data when a new Person is created and instantly
    // saving them into the object's variables.
    public Parent(string a, string b, int c, char d){
        this.name = a;
        this.lastName = b;
        this.age = c;
        this.gender = d; 
    }

    // public = need to set public because the default is private
    // ex. void ShowInfo() // this method is private as default
    // void = show any variable type
    // ex. of method show specific variable only: 
    // string ShowStringOnly(){}
    public void ShowInfo() // Method to show info
    {
        Console.WriteLine($"=====================");       
        Console.WriteLine($"Person Information:");       
        Console.WriteLine($"name: {name}");       
        Console.WriteLine($"name: {name}");      
        Console.WriteLine($"name: {lastName}");       
        Console.WriteLine($"name: {age}");       
        Console.WriteLine($"name: {gender}");
        
    }

    // Inheritance Ex.
    class Child : Parent // Child Inherit from Parent
    {
        public int weight;
      
        public Child(string a, string b, int c, char d, int e) : base(a,b,c,d)
        {
            this.weight = e;                                    // base() for you not to write like this again:
        }  // new from child                                    // this.name = a;
                                                                // this.lastName = b;
                                                                // this.age = c;
                                                                // this.gender = d; 
                                                                // this.weight = e;
        public void ShowChildInfo()
        {
            base.ShowInfo(); // Method to get whats on ShowInfo();
            Console.WriteLine($"name: {weight}");
            // need to console weight because it is not exist on ShowInfo();
        }
    }
    
}// fake ai agent: samson
