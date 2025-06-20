﻿using System;
using System.Timers;
using System.Text;
using System.Threading.Tasks;

   
      SetTimer();

      Console.WriteLine("\nPress the Enter key to exit the application...\n");
      Console.WriteLine("The application started at {0:HH:mm:ss.fff}", DateTime.Now);
      Console.ReadLine();
      aTimer.Stop();
      aTimer.Dispose();
      
      Console.WriteLine("Terminating the application...");

   private static void SetTimer()
   {
        // Create a timer with a two second interval.
        aTimer = new System.Timers.Timer(2000);
        // Hook up the Elapsed event for the timer. 
        aTimer.Elapsed += OnTimedEvent;
        aTimer.AutoReset = true;
        aTimer.Enabled = true;
    }

    private static void OnTimedEvent(Object source, ElapsedEventArgs e)
    {
        Console.WriteLine("The Elapsed event was raised at {0:HH:mm:ss.fff}",
                          e.SignalTime);
    }
// The example displays output like the following:
//       Press the Enter key to exit the application...
//
//       The application started at 09:40:29.068
//       The Elapsed event was raised at 09:40:31.084
//       The Elapsed event was raised at 09:40:33.100
//       The Elapsed event was raised at 09:40:35.100
//       The Elapsed event was raised at 09:40:37.116
//       The Elapsed event was raised at 09:40:39.116
//       The Elapsed event was raised at 09:40:41.117
//       The Elapsed event was raised at 09:40:43.132
//       The Elapsed event was raised at 09:40:45.133
//       The Elapsed event was raised at 09:40:47.148
//
//       Terminating the application...
//
//[!TODO]
//  [] https://learn.microsoft.com/en-us/dotnet/api/system.timers.timer?view=net-9.0
//  [] https://www.geeksforgeeks.org/main-method-in-c-sharp/
//  [] https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/program-structure/main-command-line
//  [] Timers.timer 
//  [] Missing import statments?
//
// Find Solution for:
//
// $ dotnet run
// CSC : error CS5001: Program does not contain a static 'Main' method suitable for an entry point
//
// The build failed. Fix the build errors and run again.
// [23:45:02] [cost 2.634s] dotnet run                                                                       
