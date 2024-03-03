using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace PomodoroTimer
    {
        internal class ProgramHelpers
        {
            public static void StartPomodoro()   
            
            {
                Console.WriteLine("\nGet ready for 25 minutes of focused work!");

                int workDurationMinutes = 25;
                Countdown(workDurationMinutes);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nGreat job! Pomodoro completed!");
                Console.ResetColor();
            }

            public static void StartRest()
            {
                Console.WriteLine("\nTake a 5-minute break!");

                int restDurationMinutes = 5;
                Countdown(restDurationMinutes);

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nBreak time over. Get back to work!");
                Console.ResetColor();
            }

            public static void PlayBeep()
            {
                Console.Beep();
            }

            private static void Countdown(int minutes)
            {
                int seconds = minutes * 60;

                while (seconds > 0)
                {
                    Console.Write($"\rTime left: {TimeSpan.FromSeconds(seconds).ToString(@"mm\:ss")}");
                    Thread.Sleep(1000);
                    seconds--;
                }

                Console.WriteLine();
            }
        }

        internal class Program
        {
            public  void Main()
            {
                Console.WriteLine("Welcome to Pomodoro Timer!");

            try
            {
                while (true)
                {
                    ProgramHelpers.StartPomodoro();
                    ProgramHelpers.PlayBeep();
                    ProgramHelpers.StartRest();
                    ProgramHelpers.PlayBeep();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            
}
    }
        }
    


