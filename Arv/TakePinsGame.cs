namespace Arv
{
    // Main class containing the entry point of the program
    class TakePinsGame
    {
        static void Main(string[] args)
        {
            // Initialize the game board with 10 pins
            Board board = new Board();
            board.SetPins(10);

            // Create human and computer players
            Player human = new HumanPlayer("Human");
            Player computer = new SmartComputerPlayer("Computer");

            Console.WriteLine("Welcome to the Take Pins Game!");

            Player currentPlayer = human;

            // Game loop until there are no pins left
            while (board.GetNoPins() > 0)
            {
                Console.WriteLine($"Current number of pins: {board.GetNoPins()}");
                int pinsTaken = currentPlayer.TakePins(board);
                Console.WriteLine($"{currentPlayer.GetUserId()} took {pinsTaken} pin(s)");

                // Check if the game is over
                if (board.GetNoPins() == 0)
                {
                    Console.WriteLine($"{currentPlayer.GetUserId()} wins!");
                    break;
                }

                // Switch players
                currentPlayer = (currentPlayer == human) ? computer : human;
            }

            Console.WriteLine("Game over. Thanks for playing!");
        }
    }
}

