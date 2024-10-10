namespace Arv
{
    public abstract class Player
    {
        protected string userId;

        // Constructor to initialize the player with a user ID
        public Player(string userId)
        {
            this.userId = userId;
        }

        // Method to get the user ID of the player
        public string GetUserId()
        {
            return userId;
        }

        // Abstract method to be implemented by subclasses for taking pins
        public abstract int TakePins(Board board);
    }

    // Class representing a human player
    public class HumanPlayer : Player
    {
        public HumanPlayer(string userId) : base(userId) { }

        // Override method to handle taking pins for a human player
        public override int TakePins(Board board)
        {
            int pinsTaken;
            // Loop until a valid number of pins is taken
            do
            {
                Console.WriteLine("How many pins do you want to take? (1 or 2)");
                pinsTaken = Convert.ToInt32(Console.ReadLine());

            } while (pinsTaken < 1 || pinsTaken > 2 || pinsTaken > board.GetNoPins());
            board.RemovePins(pinsTaken);
            return pinsTaken;
        }
    }

    // Class representing a computer player
    public class ComputerPlayer : Player
    {
        private static Random rand = new Random();

        public ComputerPlayer(string userId) : base(userId) { }

        // Override method to handle taking pins for a computer player
        public override int TakePins(Board board)
        {
            // Randomly choose to take 1 or 2 pins
            int pinsTaken = rand.Next(1, Math.Min(2, board.GetNoPins()) + 1);
            board.RemovePins(pinsTaken);
            return pinsTaken;
        }
    }
}
