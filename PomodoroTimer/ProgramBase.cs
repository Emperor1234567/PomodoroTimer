using System;

namespace PomodoroTimer
{
    internal class ProgramBase
    {

        static void Main()
        {
            Console.WriteLine("Welcome to Pomodoro Timer!");

            while (true)
            {
                ProgramHelpers.PlayBeep();
                ProgramHelpers.StartRest();
                ProgramHelpers.PlayBeep();

            }
        }

        private static void StartRest() => throw new NotImplementedException();

        private static void PlayBeep()
        {
            throw new NotImplementedException();
        }
    }
}