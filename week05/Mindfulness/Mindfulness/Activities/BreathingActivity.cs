using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by guiding your breathing.";
    }

    public void Run()
    {
        DisplayStartingMessage();

        int cycles = _duration / 10;

        for (int i = 0; i < cycles; i++)
        {
            Console.Write("Breathe in...");
            Pause(4);

            Console.Write("Now breathe out...");
            Pause(6);
        }

        DisplayEndingMessage();
    }
}
