namespace Arv
{
    public class SmartComputerPlayer : Player
    {
        // Creates an instance of Random once and reuses it in the method
        Random rnd = new Random();

        // Constructor for SmartComputerPlayer, which calls the base class constructor with userId
        public SmartComputerPlayer(string userId) : base(userId)
        {
        }

        // Method that determines how many pins the computer takes, based on the board state
        public override int TakePins(Board board)
        {
            // Get the current number of pins remaining on the board
            int tempPins = board.GetNoPins();
            int take;

            // If the number of pins is divisible by 3, make a random choice (1 or 2 pins)
            if (tempPins % 3 == 0)
            {
                take = rnd.Next(1, 3); // Randomly take 1 or 2 pins
            }
            else
            {
                // Otherwise, take enough pins to leave the opponent in a multiple of 3 situation
                take = tempPins % 3;
            }

            // Print the number of pins the computer takes
            Console.WriteLine($"The computer takes {take} pins.");

            // Remove the selected number of pins from the board
            board.RemovePins(take);

            // Return the number of pins taken
            return take;
        }

    }
}
