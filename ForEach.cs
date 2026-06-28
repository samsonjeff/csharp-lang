class ForEach
{
    public static void Items()
    {
        string[,] userInfo = new string[,]
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
            i++;
            
        }

    }
}