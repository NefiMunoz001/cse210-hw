using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager gm = new GoalManager();

        int choice = 0;
        while (choice != 6)
        {
            Console.WriteLine("\n=== Eternal Quest ===");
            gm.DisplayScore();

            Console.WriteLine("1. List Goals");
            Console.WriteLine("2. Create Goal");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Quit");

            Console.Write("Choose: ");
            choice = int.Parse(Console.ReadLine());

            Console.Clear();

            if (choice == 1) gm.ListGoals();
            if (choice == 2) gm.CreateGoal();
            if (choice == 3) gm.RecordEvent();
            if (choice == 4) gm.SaveGoals();
            if (choice == 5) gm.LoadGoals();
        }

        Console.WriteLine("Goodbye!");
    }
}
