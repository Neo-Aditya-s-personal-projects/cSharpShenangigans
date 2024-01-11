class PaperAndPencilGamesSubCategory {
    public static void Run() {
        Console.WriteLine("The options are: \n \n");
        string[] Programs = { "Tic-tac-toe" };
        for (int i = Programs.Length - 1; i >= 0; i--)
        {
            Console.WriteLine("** " + Programs[i]);
        }
        Console.WriteLine("Which option do you choose?");
        string Program = Console.ReadLine();
        if (Program == "TicTacToe") {
            TicTacToe.Run();
        }
        if (Program == "Hexapawn") {
            HexapawnBoardGames.Run();
        }
    }
}