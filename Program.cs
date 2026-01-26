using Mission4;
using System.ComponentModel.Design;

support sc = new support();

Console.WriteLine("Welcome to Tic-Tac-Toe");

List<string> choicesPlayerOne = new List<string>();
List<string> choicesPlayerTwo = new List<string>();

// Validate Player Guess
public bool ValidateChoice(string choice,
selection
if (choice.Length != 1)
{
    Console.WriteLine("Guess must be equal to one value");
    choice = false;
}
else if (player1choice != "1" || player1choice != "2" || player1choice != "3" || player1choice != "4" || player1choice != "5" || player1choice != "6" || player1choice != "7"
    || player1choice != "8" || player1choice != "9")
{
    Console.WriteLine("Choice must be 1-9");
    choice = false;
}
else if (choicesPlayerOne.Contains(player1choice || choicesPlayerTwo.Contains(player1choice)
{
    Console.WriteLine("This choice is taken");
}


Console.WriteLine("Player 1, Enter your choice in the array: ");
string player1choice = Console.ReadLine();



Console.WriteLine("Player 2, Enter your choice in the array: ");
string player2choice = Console.ReadLine();


do 
{
    
}
while (!CheckWinner);
