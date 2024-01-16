using IPMission2;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        //Start and gather input
        int number = 0;
        System.Console.WriteLine("Welcome to the dice throwing simulator!");
        System.Console.WriteLine("How many dice rolls would you like to simulate?");
        number = int.Parse(System.Console.ReadLine());

        //Roll the dice
        ThrowDice.RollEm(number);


        //Calculate the percentages
        int twos = rolls.Count(x => x == 2) / num;
        int threes = rolls.Count(x => x == 3) / num;
        int fours = rolls.Count(x => x == 4) / num;
        int fives = rolls.Count(x => x == 5) / num;
        int sixes = rolls.Count(x => x == 6) / num;
        int sevens = rolls.Count(x => x == 7) / num;
        int eights = rolls.Count(x => x == 8) / num;
        int nines = rolls.Count(x => x == 9) / num;
        int tens = rolls.Count(x => x == 10) / num;
        int elevens = rolls.Count(x => x == 11) / num;
        int twelves = rolls.Count(x => x == 12) / num;

        System.Console.WriteLine("DICE ROLLING SIMULATION RESULTS\n Each \"*\" represents 1% of the total number of rolls.\nTotal number of rolls = " + num);
        System.Console.WriteLine("2: " + twos);
        System.Console.WriteLine("3: " + threes);
        System.Console.WriteLine("4: " + fours);
        System.Console.WriteLine("5: " + twos);
        System.Console.WriteLine("6: " + twos);
        System.Console.WriteLine("7: " + twos);
        System.Console.WriteLine("8: " + twos);
        System.Console.WriteLine("9: " + twos);
        System.Console.WriteLine("10: " + twos);
        System.Console.WriteLine("11: " + twos);
        System.Console.WriteLine("12: " + twos);
    }
}