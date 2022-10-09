using System;
namespace tictactoe
{
    class Program
    {
static void Main(string[] args)
        {
            List<string> boardlist = GetNewBoard();
            string currentPlayer = "x";

            while (!IsGameOver(boardlist))
            {
                DisplayBoard(boardlist);
                int choice = GetMove(currentPlayer);
                MakeMove(boardlist, choice, currentPlayer);
                currentPlayer = NextPerson(currentPlayer);
            }
            DisplayBoard(boardlist);
            Console.WriteLine("Game over");
        }
        static List<string> GetNewBoard()
        {
            List<string> boardlist = new List<string>();
            for (int e = 1; e <= 9; e++)
            {
                boardlist.Add(e.ToString());
            }
            return boardlist;
        }
        static void DisplayBoard(List<string> boardlist)
        {
            Console.WriteLine($"{boardlist[0]}|{boardlist[1]}|{boardlist[2]}");
            Console.WriteLine("-|-|-");
            Console.WriteLine($"{boardlist[3]}|{boardlist[4]}|{boardlist[5]}");
            Console.WriteLine("-|-|-");
            Console.WriteLine($"{boardlist[6]}|{boardlist[7]}|{boardlist[8]}");
        }
        static bool IsGameOver(List<string> boardlist)
        {
            bool isGameOver = false;
            if (IsWin(boardlist, "x") || IsWin(boardlist, "o") || IsTie(boardlist))
            {
                isGameOver = true;
            }
            return isGameOver;
        } 
        static bool IsWin(List<string> boardlist, string player)
        {
            bool isWin = false;
            if ((boardlist[0] == player && boardlist[1] == player && boardlist[2] == player)
                || (boardlist[1] == player && boardlist[4] == player && boardlist[7] == player)
                || (boardlist[2] == player && boardlist[5] == player && boardlist[8] == player)
                || (boardlist[0] == player && boardlist[4] == player && boardlist[8] == player)
                || (boardlist[2] == player && boardlist[4] == player && boardlist[6] == player)
                || (boardlist[3] == player && boardlist[4] == player && boardlist[5] == player)
                || (boardlist[6] == player && boardlist[7] == player && boardlist[8] == player)
                || (boardlist[0] == player && boardlist[3] == player && boardlist[6] == player)
                )
            {
                isWin = true;
            }
            return isWin; 
        }
        static bool IsTie(List<string> boardlist)
        {
            bool findDig = false;
            foreach (string value in boardlist)
            {
                if (char.IsDigit(value[0]))
                {
                    findDig = true;
                    break;
                }
            }
            return !findDig;
        }
        static string NextPerson(string currentPlayer)
        {
            string nextPlayer = "x";

            if (currentPlayer == "x")
            {
                nextPlayer = "o";
            }

            return nextPlayer;
        }
        static void MakeMove(List<string> boardlist, int choice, string currentPlayer)
        {
            int index = choice - 1;
            boardlist[index] = currentPlayer;
        }
        static int GetMove(string currentPlayer)
        {
            Console.Write($"{currentPlayer} turn to choose a square: ");
            string move_string = Console.ReadLine();
            int choice = int.Parse(move_string);
            return choice;
        }
    } 
}