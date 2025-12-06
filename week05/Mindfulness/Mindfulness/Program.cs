using System;

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;

        while (choice != 4)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start Breathing Activity");
            Console.WriteLine(" 2. Start Reflection Activity");
            Console.WriteLine(" 3. Start Listing Activity");
            Console.WriteLine(" 4. Quit");
            Console.Write("Select a choice from the menu: ");

            // ---- VALIDAR INPUT ----
            string input = Console.ReadLine();
            if (!int.TryParse(input, out choice) || choice < 1 || choice > 4)
            {
                Console.WriteLine("\nInvalid input. Please enter a number between 1 and 4.");
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
                continue;
            }

            switch (choice)
            {
                case 1:
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.Run();
                    break;

                case 2:
                    ReflectionActivity reflection = new ReflectionActivity();
                    reflection.Run();
                    break;

                case 3:
                    ListingActivity listing = new ListingActivity();
                    listing.Run();
                    break;
            }
        }
    }
}