// Tic-Tac-Toe Game
// Group 2-11
// Mary Catherine Shepherd, Elsie Evans, Levi Speirs, Brit Meek

using System;
using System.Collections.Generic;
using System.Linq; // <-- needed for Select(), ToList(), Contains()
using System.Text;

namespace Mission4
{
    internal class Support
    {
        public void printBoard(List<string> board)
        {
            List<string> normBoard = new List<string>();

            foreach (string letter in board)
            {
                // Protect against null/blank entries so ToUpper() doesn't crash
                string upper = string.IsNullOrWhiteSpace(letter) ? " " : letter.ToUpper();
                normBoard.Add(upper);
            }

            Console.WriteLine($"{normBoard[0]} | {normBoard[1]} | {normBoard[2]}");
            Console.WriteLine("----------");
            Console.WriteLine($"{normBoard[3]} | {normBoard[4]} | {normBoard[5]}");
            Console.WriteLine("----------");
            Console.WriteLine($"{normBoard[6]} | {normBoard[7]} | {normBoard[8]}");
        }

        public bool CheckWinner(List<string> board)
        {
            // Normalize the board (convert strings to uppercase chars)
            // We'll use ' ' (space) to represent an empty cell
            List<char> b = board
                .Select(s => string.IsNullOrWhiteSpace(s) ? ' ' : char.ToUpper(s[0]))
                .ToList();

            // Define all 8 possible winning index combinations
            int[][] winConditions = new int[][]
            {
                new int[] {0, 1, 2}, new int[] {3, 4, 5}, new int[] {6, 7, 8}, // Rows
                new int[] {0, 3, 6}, new int[] {1, 4, 7}, new int[] {2, 5, 8}, // Columns
                new int[] {0, 4, 8}, new int[] {2, 4, 6}                      // Diagonals
            };

            // Check for a Winner
            foreach (var combo in winConditions)
            {
                if (b[combo[0]] != ' ' &&
                    b[combo[0]] == b[combo[1]] &&
                    b[combo[0]] == b[combo[2]])
                {
                    Console.WriteLine(b[combo[0]] == 'X'
                        ? "Player 1 (X) Wins!"
                        : "Player 2 (O) Wins!");
                    return true;
                }
            }

            // Check for a Draw
            if (!b.Contains(' '))
            {
                Console.WriteLine("It's a draw!");
                return true; // game over
            }

            return false; // game still going
        }
        // Validate players choice, check lenght, check if num, check if already taken
        public bool ValidateChoice(string choice, List<string> p1Choices, List<string> p2Choices)
        {
            if (choice.Length != 1 || !"123456789".Contains(choice))
                return false;

            if (p1Choices.Contains(choice) || p2Choices.Contains(choice))
                return false;

            return true;
        }
    }
}

