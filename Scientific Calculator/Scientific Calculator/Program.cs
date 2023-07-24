// See https://aka.ms/new-console-template for more information
string input;

while (true)
{
    Console.WriteLine("Welcome to Coding with Jenny!!\nScientific Calculator");

    input = Console.ReadLine();

    if (input.ToLower() == "exit")
    {
        Console.WriteLine("Exiting the program...");
        break; // Exit the while loop
    }
    // Place your program logic here (what the program does while running)
}