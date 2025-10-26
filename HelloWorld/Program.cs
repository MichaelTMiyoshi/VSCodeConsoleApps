namespace HelloWorld;
/*
    Author:     Miyoshi
    Project:    Hello World
    Pseudocode: Output message(s) to screen
    Maintenance Log:
        10/25/2025  Started and completed code
        10/25/2025  settings->C#->debugger->externalTerminal
                    go to settings
                    search for external
                    look for C# debugger
                    Set to externalTerminal
    Notes:
        If using externalTerminal, make sure to put the last two lines in Main().
*/
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();    // I needed to clear the terminal screen on my mac.

        Console.WriteLine("Hello, World!");
        Console.Write("This\n\tis\n\t\ta\n\t\t\ttest...");
        Console.WriteLine("\n\nPress the any key to continue.");
        Console.ReadKey();
    }
}
