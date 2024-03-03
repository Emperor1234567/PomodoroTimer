using System;

internal static class ProgramHelpers
{

    static void StartPomodoro()
    {
        Console.WriteLine("\nGet ready for 25 minutes of focused work!");

        int workDurationMinutes = 25;
        Countdown(workDurationMinutes);

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\nGreat job! Pomodoro completed!");
        Console.ResetColor();
    }

    private static void Countdown(int workDurationMinutes)
    {
        throw new NotImplementedException();
    }

    internal static void PlayBeep()
    {
        throw new NotImplementedException();
    }

    internal static void StartRest()
    {
        throw new NotImplementedException();
    }
}