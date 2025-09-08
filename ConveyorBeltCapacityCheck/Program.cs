using System;

class Program
{
    static void Main()
    {
        // Prompt 1: antal motorer
        Console.Write("How many motors are carrying the packages? ");
        int motors = int.Parse(Console.ReadLine());

        // Prompt 2: samlet vægt
        Console.Write("How many kg of packages do we expect? ");
        double packagesWeight = double.Parse(Console.ReadLine());

        // Beregning: vægt pr. motor
        if (motors > 0 && (packagesWeight / motors) <= 5.6)
        {
            Console.WriteLine("Yes! The conveyor belt can carry the packages.");
        }
        else
        {
            Console.WriteLine("No. The conveyor belt cannot carry the packages.");
        }
    }
}