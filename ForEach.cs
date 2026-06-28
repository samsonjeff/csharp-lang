class ForEach
{
    public static void Items()
    {
        string[,] userInfo = new string[,] // 2D array
        {
            {"a","1"},
            {"b","2"},
            {"c","3"},
            {"d","4"}
        };

        int i = 1;
        foreach(string u in userInfo)
        {   
            Console.Write(u + " ");
            if(i % userInfo.GetLength(1) == 0) Console.WriteLine();
            i++; // if i = to the legnth of column every iterate console writeline
            
        }

    }
}
