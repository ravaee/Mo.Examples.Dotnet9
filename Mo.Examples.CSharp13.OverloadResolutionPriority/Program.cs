// new Overload Resolution Priority
// Link: https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-13#params-collections:~:text=partial%20members.-,Overload%20resolution%20priority,-In%20C%23%2013


using System.Runtime.CompilerServices;

///Imagine you are maintaining a library and want to introduce a new overload for a method without breaking existing behavior. 
///You can use OverloadResolutionPriority to ensure backward compatibility.

PrintAssist.PrintMessage("Hello, World!");        // Calls the new optimized string overload
PrintAssist.PrintMessage("Hello, World!", 2);



class PrintAssist
{
    // Original method (for backward compatibility)
    public static void PrintMessage(string message, int repeat)
    {
        for (int i = 0; i < repeat; i++)
        {
            Console.WriteLine($"Legacy: {message}");
        }
    }

    // New method (optimized for single calls)
    [OverloadResolutionPriority(1)] // Higher priority
    public static void PrintMessage(string message)
    {
        Console.WriteLine($"Optimized: {message}");
    }
}