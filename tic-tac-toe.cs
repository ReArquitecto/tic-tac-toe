namespace tic_tac_toe
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Tic-Tac-Toe!");
                        
            list boardValues = new List<string> {"1", "2", "3", "4", "5", "6", "7", "8", "9" };
            
            list rowOne = {boardValues[0], boardValues[1], boardValues[2]};
            list rowTwo = {boardValues[3], boardValues[4], boardValues[5]};
            list rowThree = {boardValues[6], boardValues[7], boardValues[8]};
            list columnOne = {boardValues[0], boardValues[3], boardValues[6]};
            list columnTwo = {boardValues[1], boardValues[4], boardValues[7]};
            list columnThree = {boardValues[2], boardValues[5], boardValues[8]};
            list diagonalOne = {boardValues[0], boardValues[4], boardValues[8]};
            list diagonalTwo = {boardValues[2], boardValues[4], boardValues[6]};
            
            list winningCombos = {rowOne, rowTwo, rowThree, columnOne, columnTwo, columnThree, diagonalOne, diagonalTwo};

            playerOne = "x";
            playerTwo = "o";
            currentPlayer = playerOne;
            
            bool isGameOver = false;
            while (!isGameOver)
            {
                PrintBoard(rowOne, rowTwo, rowThree);                
                list boardValues = MakeMove(currentPlayer, boardValues);
                isGameOver = IsGameOver(boardValues, winningCombos);
            }

            if (currentPlayer == playerOne)
            {
                Console.WriteLine("Player x wins!");
            }
            else
            {
                Console.WriteLine("Player o wins!");
            }

        }

        static void MakeMove(string currentPlayer, list boardValues)
        {
            Console.WriteLine($"Player {currentPlayer}, please enter a number to place your {currentPlayer} in that spot.");

            string move = Console.ReadLine();
            if (boardValues.Contains(move))
            {
                boardValues[boardValues.IndexOf(move)] = currentPlayer;
            }
            else
            {
                Console.WriteLine("That is not a valid move. Please try again.");
                MakeMove(currentPlayer, boardValues);
            }

            return boardValues;
            

        }

        static void PrintBoard(list rowOne, list rowTwo, list rowThree)
        {
            Console.WriteLine($"{rowOne[0]}|{rowOne[1]}|{rowOne[2]}");
            Console.WriteLine("-+-+-");
            Console.WriteLine($"{rowTwo[0]}|{rowTwo[1]}|{rowTwo[2]}");
            Console.WriteLine("-+-+-");
            Console.WriteLine($"{rowThree[0]}|{rowThree[1]}|{rowThree[2]}");
        }
        

    }
}