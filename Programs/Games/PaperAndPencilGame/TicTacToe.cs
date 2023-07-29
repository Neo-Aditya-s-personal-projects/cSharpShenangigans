class TicTacToe
{
    private static char player1 = 0;
    private static char player2 = 0;
    private static char[] board = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    private static Boolean isPlayer1 = true;
    private static int choice = 10;
    private static string status = "ongoing";
    public static void Run()
    {
        Console.WriteLine("Neither player can have a number as their symbol nor can they have the same symbol as the other player. \n \n");
        Console.WriteLine("Player 2 choose your symbol:");
        player2 = Console.ReadLine();
        Console.WriteLine("Player 1 choose your symbol");
        player1 = Console.ReadLine();
        if (player2 == player1 || (player1 >= 48 && player1 <= 57) || (player2 >= 48 && player2 <= 57))
        {
            "Try again"
            Run();
        }
        board = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
        isPlayer1 = true;
        status = "ongoing";
        while (status == "ongoing")
        {
            UpdateBoard();
            UpdateStatus();
        }
        Console.WriteLine(status);
        Console.WriteLine("Do you want to play again? Y/N");
        char repeat = Console.ReadLine();
        while (repeat != 'Y' && repeat != 'N')
        {
            Console.WriteLine("Please enter either a capital Y or a capital N");
            repeat = Console.ReadLine();
        }
        if (repeat == 'Y') [
            Run();
        ]
    }

    private static void UpdateBoard()
    {
        if (isPlayer1)
        {
            Console.WriteLine("Player 1's turn");
        }
        else
        {
            Console.WriteLine("Player 2'S turn");
        }
        Console.WriteLine("\n");
        Board();
        choice = Convert.ToInt32(Console.ReadLine());
        if (board != player1 && board != player2)
        {
            if (isPlayer1)
            {
                board[choice] = player1;
                isPlayer1 = false;
            }
            else
            {
                board[choice] = player2;
                isPlayer1 = true;
            }
        }
        else {
            Console.WriteLine("Taken Try Again");
            UpdateBoard();
        }
    }
    private static void Board()
    {
        Console.WriteLine("     |     |      ");
        Console.WriteLine("  {0}  |  {1}  |  {2}", board[1], board[2], board[3]);
        Console.WriteLine("_____|_____|_____ ");
        Console.WriteLine("     |     |      ");
        Console.WriteLine("  {0}  |  {1}  |  {2}", board[4], board[5], board[6]);
        Console.WriteLine("_____|_____|_____ ");
        Console.WriteLine("     |     |      ");
        Console.WriteLine("  {0}  |  {1}  |  {2}", board[7], board[8], board[9]);
        Console.WriteLine("     |     |      ");
    }
    private static void UpdateStatus() {
        boolean win = false;
        if (board[1] == board[2] && board[2] == board[3])
            {
                win = true;
            }
            else if (board[4] == board[5] && board[5] == board[6])
            {
                win = true;
            }
            else if (board[6] == board[7] && board[7] == board[8])
            {
                win = true;
            }
            else if (board[1] == board[4] && board[4] == board[7])
            {
                win = true;
            }
            else if (board[2] == board[5] && board[5] == board[8])
            {
                win = true;
            }
            else if (board[3] == board[6] && board[6] == board[9])
            {
                win = true;
            }
            else if (board[1] == board[5] && board[5] == board[9])
            {
                win = true;
            }
            else if (board[3] == board[5] && board[5] == board[7])
            {
                win = true;
            }
            else if (board[1] != '1' && board[2] != '2' && board[3] != '3' && board[4] != '4' && board[5] != '5' && board[6] != '6' && board[7] != '7' && board[8] != '8' && board[9] != '9')
            {
                status = "Draw! Nobody Wins!";
            }
            if (win && isPlayer1) {
                status = "Player 2 Wins! Better Luck next time Player 1";
            }
            else if (win && !isPlayer1) {
                status = "Player 1 Wins! better Lcuk Next time Player 2"
            }
    }
}