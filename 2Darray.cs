
class Users
{
    public static void retrieveUser()
    {
        string[,] userInfo = new string[,] // 2D array "," represent as 2D array
        {
            {"a","1"},
            {"b","2"},
            {"c","3"},
            {"d","4"}
        };

        for(int i = 0;i < userInfo.GetLength(0); i++)
        {
            for(int j = 0;j < userInfo.GetLength(1); j++)
            {
                Console.Write($"{userInfo[i,j]} ");
            }
            Console.WriteLine();
        }

    }
}
