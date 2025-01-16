using Mission2;

internal class Program
{
    public static void Main(string[] args)
    {
        // Introduction
        Console.WriteLine("Welcome to the dice throwing simulator!");
        Console.WriteLine("How many dice rolls would you like to simulate?");
        
        // Get Number of Rolls
        int numRolls = int.Parse(Console.ReadLine());

        // Create a Die object
        Die die = new Die();
        
        // Simulate the dice rolls and get the result array
        int[] rolls = die.SimulateRolls(numRolls);

        // Text Output
        Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each '*' represents 1% of the total number of rolls.");
        Console.WriteLine($"Total number of rolls: {numRolls}.");
        
        // Post-Roll Histogram
        for (int i = 2; i <= 12; i++)
        {
            string outputLine = $"{i}: ";

            // Calculate the percentage of times the number was rolled
            int asteriskCount = (int)((double)rolls[i - 2] / numRolls * 100);
            
            // Append an asterisk to the output line according to the count
            for (int j = 1; j <= asteriskCount; j++)
            {
                outputLine += "*";
            }
            
            // Print the line
            Console.WriteLine(outputLine);
        }
        
        Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
    }
}