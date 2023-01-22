using System;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Security;
using static System.Net.Mime.MediaTypeNames;


bool playAgain = true;
int computerPoints = 0;
int playerPoints = 0;
while (playAgain != false)
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.Write("Choose [r]ock, [p]aper or [s]cissors: ", Console.ForegroundColor);
    string input = Console.ReadLine();
    Random rnd = new Random();
    int number = rnd.Next(1, 4);  // computer choice between 1 - 4 /  1, 2, 3 
    bool isWin = false;
    bool isDraw = false;
    string computerChoice = string.Empty;
    bool startAgain = false;
    //1 - rock,  2 - paper, 3 - scissors

    if (number == 1)
    {
        computerChoice = "Rock";
    }
    else if (number == 2)
    {
        computerChoice = "Paper";
    }
    else
    {
        computerChoice = "Scissors";
    }

    switch (input)
    {
        // when the game is loss or draw there aren't any points
        // but when the player win the game his points become + 1
        case "r": // rock
            if (number != 2 && number != 1)
            {
                isWin = true;
                playerPoints++;
            }
            else if (number == 1)
            {
                isDraw = true; 
            }
            else
            {
                computerPoints++;
            }
            break;
        case "p": // paper
            if (number != 3 && number != 2)
            {
                isWin = true;
                playerPoints++;
            }
            else if (number == 2)
            {
                isDraw = true; 
            }
            else
            {
                computerPoints++;
            }
            break;
        case "s": // scissors
            if (number != 1 && number != 3)
            {
                isWin = true;
                playerPoints++; 
            }
            else if (number == 3)
            {
                isDraw = true; 
            }
            else
            {
                computerPoints++;
            }
            break;
        default:
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Invalid Input. Try again...");  // introduced digit is not correct
            Console.ResetColor();
            return;
    }
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine($"The computer chose {computerChoice}."); 
    if (isWin == true)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("You win.");
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine($"{computerPoints} / {playerPoints}");

    }
    else if (isDraw == true) 
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("This game was a draw");
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine($"{computerPoints} / {playerPoints}");
    }
    else // when you loss 
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("You lose.");
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine($"{computerPoints} / {playerPoints}");
    }
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.Write("Do you want to play again? Press [Y] to restart the program or [N] to exit! ");
    Console.ForegroundColor = ConsoleColor.Black;
    char restart = char.Parse(Console.ReadLine());   // determines whether to restart the game or not
    while ((restart != 'y' || restart != 'Y') && (restart != 'n' || restart != 'N'))
    {
        Console.ResetColor();
        switch (restart)
        {
            case 'y':
            case 'Y':
                startAgain = true;
                break;
            case 'n':
            case 'N':
                playAgain = false;
                Console.WriteLine("See you soon! :)");
                return;
            default:
                Console.Write("Try again...");
                Console.ForegroundColor = ConsoleColor.White;
                break;

        }
        if (startAgain == true)   // brakes the while loop after the player press [y] and startin a new game
        {
            Console.ForegroundColor = ConsoleColor.Green;
            break;
        }
    }
}
Console.ResetColor();



