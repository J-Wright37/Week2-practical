using System.Runtime.InteropServices;
using System.Xml.Serialization;

/*
 * Practical 2
 * Information: Methods demo
 * Version: 1
 * Author: Jay Wright
 * Date: 29/09/26
 */

void Main(string choice)
{
    do {
        PrintMenu();
    } while (choice != "0");
}

void PrintMenu()
{
    Console.WriteLine("Please enter a valid option from below:");
    Console.WriteLine("1. Hello in French?");
    Console.WriteLine("2. Hello in Spanish?");
    Console.WriteLine("3. Hello in German?");
    Console.WriteLine("4. Hello in Italian?");
    Console.WriteLine("0. Exit application");
    string choice = Console.ReadLine();
    int option = InputOption(choice);
    GetMessage(option);
    //check for what is currently stored in choice
    //Console.WriteLine("You selected option: " + choice);

}

static int InputOption(string choice)
{
    int option = 0;
    try
    {

        option = Convert.ToInt32(choice);

    }
    catch
    {
        Console.WriteLine("Invalid input. Please enter a valid option.");

    }
    return option;
}

static int GetMessage(int option)
{
    switch (option)
    {
        case 1:
            Console.WriteLine("Bonjour");
            break;
        case 2:
            Console.WriteLine("Hola");
            break;
        case 3:
            Console.WriteLine("Hallo");
            break;
        case 4:
            Console.WriteLine("Ciao");
            break;
        case 0:
            Console.WriteLine("Goodbye!");
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Invalid option. Please enter a valid option.");
            break;
    }
    return option;
}


Main("");

