﻿namespace OsrsFlipper;

public static class Logger
{
    public static void Warn(object message)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"Flipper@[{DateTime.Now}]: {message}");
        Console.ResetColor();
    }
    
    
    public static void Error(object message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Flipper@[{DateTime.Now}]: {message}");
        Console.ResetColor();
    }
    
    
    public static void Info(object message)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"Flipper@[{DateTime.Now}]: {message}");
        Console.ResetColor();
    }
}