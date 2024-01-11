class HexapawnBoardGames
{
    private static char player1 = '0';
    private static char[] boardPositions = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    private static string[] board = { "/ ", "/ ", "/ ", "/ ", "/ ", "/ ", "/ ", "/ ", "/ ", "/ " };
    private static Boolean playerFirst = true;
    private static int choice = 10;
    private static string status = "ongoing";
    public static void Run()
    {
        Board();
        Console.WriteLine("Enter the radius:");
        
        Console.WriteLine("Do you want to play again with a naturally selected number of beads? Y/N");
        string repeat = Console.ReadLine();
        while (repeat != "Y" && repeat != "N")
        {
            Console.WriteLine("Please enter either a capital Y or a capital N");
            repeat = Console.ReadLine();
        }
        if (repeat == "Y") {
            Run();
        }
    }
    private static void UpdateBoard() 
    {

    }
    private static void Board()
    {
        Console.WriteLine("       |       |        ");
        Console.WriteLine("  {0}  |  {1}  |  {2}", board[1] + boardPositions[1], board[2] + boardPositions[2], board[3] + boardPositions[3]);
        Console.WriteLine("_______|_______|_______ ");
        Console.WriteLine("       |       |        ");
        Console.WriteLine("  {0}  |  {1}  |  {2}", board[4] + boardPositions[4], board[5], board[6]);
        Console.WriteLine("_______|_______|_______ ");
        Console.WriteLine("       |       |        ");
        Console.WriteLine("  {0}  |  {1}  |  {2}", board[7], board[8], board[9]);
        Console.WriteLine("       |       |         ");
    }
}