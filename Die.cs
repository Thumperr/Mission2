namespace Mission2;

public class Die
{
    public int RollDie()
    {
        Random rnd = new Random(); // Create a new Random instance
        return rnd.Next(1, 7); // Generate a random number between 1 and 6
    }

    public int[] SimulateRolls(int numRolls)
    {
        // Set up an array to store roll results
        int[] rolls = new int[11];

        for (int i = 0; i < numRolls; i++)
        {
            int result1 = RollDie();  // Roll the first die
            int result2 = RollDie();  // Roll the second die
            int finalResult = result1 + result2;  // Combine the two die results
            rolls[finalResult - 2] += 1;  // Store the result in the array
        }

        return rolls;  // Return the array
    }
}