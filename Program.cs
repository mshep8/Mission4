using Mission4;

support sc = new support();

Console.WriteLine("Welcome to Tic-Tac-Toe");

List<string> choicesPlayerOne = new List<string>();
List<string> choicesPlayerTwo = new List<string>();

Console.WriteLine("Player 1, Enter your choice in the array: ");
string player1choice = Console.ReadLine();
if (player1choice.Length != 1)
{
    Console.WriteLine("Guess must be equal to one value");

}

Console.WriteLine("Player 2, Enter your choice in the array: ");
string player2choice = Console.ReadLine();

do 
{
    
}
while (!CheckWinner);
