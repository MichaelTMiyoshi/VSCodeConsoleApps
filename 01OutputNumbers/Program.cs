namespace _01OutputNumbers;
/*
    Author:     Miyoshi
    Project:    Output numbers using one variable
    Pseudocode: Declare and initialize variable
                Output variable
                Change the variable's value
                Output variable
    Maintenance Log:
        10/25/2025  Started and completed code
        10/25/2025  settings->C#->debugger->externalTerminal
                    go to settings
                    search for external
                    look for C# debugger
                    Set to externalTerminal
    Notes:
        If using externalTerminal, make sure to put the last two lines in Main().
        This code shows two different ways to output the number using formatting.
        This formatting puts the data into a field on the screen that is 5 
        characters wide.  Which is useful.
*/
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Output numbers 1-10 without loop");
        int num = 1;
        Console.WriteLine($"{num,5}");
        num = 2;

        // The rest of the code is up to you.  Remember, no loops for this one.

        Console.WriteLine("{0,5}", num);
        Console.Write("\n\nPress the any key to continue.");
        Console.ReadKey();
    }
}
