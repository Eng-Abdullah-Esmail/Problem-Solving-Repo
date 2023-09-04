using System;

class TicTacToe
{
    private char[,] board;
    private char currentPlayer;

    public TicTacToe()
    {
        board = new char[3, 3];
        currentPlayer = 'X';
        InitializeBoard();
    }

    public void Play()
    {
        while (true)
        {
            Console.Clear();
            PrintBoard();
            Console.WriteLine($"Player {currentPlayer}'s turn. Enter row and column (e.g. 1,2): ");
            string input = Console.ReadLine();
            string[] parts = input.Split(',');
            int row = int.Parse(parts[0]) - 1;
            int col = int.Parse(parts[1]) - 1;

            if (IsValidMove(row, col))
            {
                board[row, col] = currentPlayer;
                if (IsWin())
                {
                    Console.Clear();
                    PrintBoard();
                    Console.WriteLine($"Player {currentPlayer} wins!");
                    return;
                }
                else if (IsTie())
                {
                    Console.Clear();
                    PrintBoard();
                    Console.WriteLine("It's a tie!");
                    return;
                }
                SwitchPlayer();
            }
            else
            {
                Console.WriteLine("Invalid move. Press any key to try again...");
                Console.ReadKey();
            }
        }
    }

    private void InitializeBoard()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                board[i, j] = '-';
            }
        }
    }

    private bool IsValidMove(int row, int col)
    {
        if (row < 0 || row > 2 || col < 0 || col > 2)
        {
            return false;
        }
        if (board[row, col] != '-')
        {
            return false;
        }
        return true;
    }

    private bool IsWin()
    {
        // Check rows
        for (int i = 0; i < 3; i++)
        {
            if (board[i, 0] == currentPlayer && board[i, 1] == currentPlayer && board[i, 2] == currentPlayer)
            {
                return true;
            }
        }

        // Check columns
        for (int j = 0; j < 3; j++)
        {
            if (board[0, j] == currentPlayer && board[1, j] == currentPlayer && board[2, j] == currentPlayer)
            {
                return true;
            }
        }

        // Check diagonals
        if (board[0, 0] == currentPlayer && board[1, 1] == currentPlayer && board[2, 2] == currentPlayer)
        {
            return true;
        }
        if (board[0, 2] == currentPlayer && board[1, 1] == currentPlayer && board[2, 0] == currentPlayer)
        {
            return true;
        }

        return false;
    }

    private bool IsTie()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (board[i, j] == '-')
                {
                    return false;
                }
            }
        }
        return true;
    }

    private void SwitchPlayer()
    {
        if (currentPlayer == 'X')
        {
            currentPlayer = 'O';
        }
        else
        {
            currentPlayer = 'X';
        }
    }

    private void PrintBoard()
    {
        Console.WriteLine("  1 2 3");
        for (int i = 0; i < 3; i++)
        {
            Console.Write($"{i + 1} ");
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"{board[i, j]} ");
            }
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        TicTacToe game = new TicTacToe();
        game.Play();
        Console.ReadKey();
    }
}