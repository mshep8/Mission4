// Tic-Tac-Toe Game
// Group 2-11
// Mary Catherine Shepherd, Elsie Evans, Levi Speirs, Brit Meek

// This program leads two users through a simple Tic-Tac-Toe game and announces
// a winner at the end based off what positions they choose in this back and 
// forth game.

using Mission4;

// Initate new supprt instance
Support sc = new Support();

Console.WriteLine("Welcome to Tic-Tac-Toe");

// Create new list with 9 spots, 0-8
List<string> board = new List<string>();
for (int i = 0; i < 9; i++)
{
    board.Add(" ");
}

// Store player's choice in two separate strings
List<string> choicesPlayerOne = new List<string>();
List<string> choicesPlayerTwo = new List<string>();

// Initiate variables for gameplay
bool gameOver = false;
int currentPlayer = 1;

// Print inital empty board
sc.printBoard(board);

// Play the game as long as the gameOver variable is false
while (!gameOver)
{
    // Set symbol for both players
    string symbol = (currentPlayer == 1) ? "X" : "O";

    // Prompt user to make their move. Store player entry in a choice variable
    Console.Write($"Player {currentPlayer} ({symbol}), enter your choice (1-9): ");
    string choice = Console.ReadLine() ?? "";

    // Check choice in the Validate Choice method. If not valid, prompt user to try again
    while (!sc.ValidateChoice(choice, choicesPlayerOne, choicesPlayerTwo))
    {
        Console.WriteLine("Invalid choice. Must be 1-9 and not already taken.");
        Console.Write($"Player {currentPlayer} ({symbol}), enter your choice (1-9): ");
        choice = Console.ReadLine() ?? "";
    }

    // Add players choice to array
    if (currentPlayer == 1) choicesPlayerOne.Add(choice);
    else choicesPlayerTwo.Add(choice);

    // Subtract 1 from player choice to store in printable array
    int index = int.Parse(choice) - 1;
    board[index] = symbol;

    // Re - print board after each move
    sc.printBoard(board);

    // Check if game had ended
    gameOver = sc.CheckWinner(board);

    if (!gameOver)
        currentPlayer = (currentPlayer == 1) ? 2 : 1;
}