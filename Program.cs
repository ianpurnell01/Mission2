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
        ThrowDice td = new ThrowDice();

        int[] rolls = td.RollEm(number);


        //Calculate the percentages and write output
        System.Console.WriteLine("DICE ROLLING SIMULATION RESULTS\n Each \"*\" represents 1% of the total number of rolls.\nTotal number of rolls = " + number);
        for (int i = 2; i <= 12; i++)
        {
            //this doesn't work unless I cast it as a double then back to an int
            int percent = (int)(((double)rolls.Count(x => x == i) / number) * 100);
            string stars = new string('*', percent);
            System.Console.WriteLine($"{i}: {stars}");
        }

        //Dice Roller, Out
        System.Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
    }
}