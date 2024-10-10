namespace Arv
{
    // Class representing the game board
    public class Board
    {
        private int noPins;

        // Constructor to initialize the board with a certain number of pins
        public void SetPins(int initialPins)
        {
            noPins = initialPins;
        }

        // Method to get the current number of pins on the board
        public int GetNoPins()
        {
            return noPins;
        }

        // Method to remove a certain number of pins from the board
        public void RemovePins(int pins)
        {
            noPins -= pins;
        }
    }
}
