using Mission4;

Support sc = new Support();

Console.WriteLine("Welcome to Tic-Tac-Toe");

List<string> board = new List<string>();
for (int i = 0; i < 9; i++)
{
    board.Add(" ");
}

List<string> choicesPlayerOne = new List<string>();
List<string> choicesPlayerTwo = new List<string>();

bool gameOver = false;
int currentPlayer = 1;

sc.printBoard(board);

while (!gameOver)
{
    string symbol = (currentPlayer == 1) ? "X" : "O";

    Console.Write($"Player {currentPlayer} ({symbol}), enter your choice (1-9): ");
    string choice = Console.ReadLine() ?? "";

    while (!ValidateChoice(choice, choicesPlayerOne, choicesPlayerTwo))
    {
        Console.WriteLine("Invalid choice. Must be 1-9 and not already taken.");
        Console.Write($"Player {currentPlayer} ({symbol}), enter your choice (1-9): ");
        choice = Console.ReadLine() ?? "";
    }

    if (currentPlayer == 1) choicesPlayerOne.Add(choice);
    else choicesPlayerTwo.Add(choice);

    int index = int.Parse(choice) - 1;
    board[index] = symbol;

    sc.printBoard(board);

    gameOver = sc.CheckWinner(board);

    if (!gameOver)
        currentPlayer = (currentPlayer == 1) ? 2 : 1;
}

bool ValidateChoice(string choice, List<string> p1Choices, List<string> p2Choices)
{
    if (choice.Length != 1 || !"123456789".Contains(choice))
        return false;

    if (p1Choices.Contains(choice) || p2Choices.Contains(choice))
        return false;

    return true;
}


