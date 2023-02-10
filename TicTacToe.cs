using System;

namespace TicTacToe
{
    class Game
    {
        private char[] board = new char[9];
        private int currentPlayer = 1;
        private int player1Wins = 0;
        private int player2Wins = 0;
        private int draws = 0;

        public void Play()
        {
            InitializeBoard();

            while (true)
            {
                Console.Clear();
                DrawBoard();

                int move = GetPlayerMove();
                if (!MakeMove(move))
                {
                    continue;
                }

                

                if (IsWinningMove(move))
                {
                    Console.Clear();
                    DrawBoard();
                    Console.WriteLine("Player " + currentPlayer + " wins!");
                    if (currentPlayer == 1)
                    {
                        player1Wins++;
                    }
                    else
                    {
                        player2Wins++;
                    }
                    RestartGame();
                    break;
                }
                else if (IsDraw())
                {
                    Console.Clear();
                    DrawBoard();
                    Console.WriteLine("It's a draw!");
                    draws++;
                    RestartGame();
                    break;
                }               
                SwitchPlayer();
            }
        }

        private void InitializeBoard()
        {
            for (int i = 0; i < 9; i++)
            {
                board[i] = (char)('0' + i + 1);
            }
        }

        private void DrawBoard()
        {
            Console.WriteLine("Let's play Tic Tac Toe!");
            Console.WriteLine("Player 1: X");
            Console.WriteLine("Player 2: O");
            Console.WriteLine();
            Console.WriteLine("Player 1 wins: " + player1Wins);
            Console.WriteLine("Player 2 wins: " + player2Wins);
            Console.WriteLine("Draws: " + draws);
            Console.WriteLine();
            Console.WriteLine("Player " + currentPlayer + "'s turn. Select a cell from 1 to 9.");
            Console.WriteLine();

            Console.WriteLine(" " + board[0] + " | " + board[1] + " | " + board[2]);
            Console.WriteLine("---+---+---");
            Console.WriteLine(" " + board[3] + " | " + board[4] + " | " + board[5]);
            Console.WriteLine("---+---+---");
            Console.WriteLine(" " + board[6] + " | " + board[7] + " | " + board[8]);
        }

        private int GetPlayerMove()
        {
            while (true)
            {
                Console.Write("Enter a cell number: ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out int move))
                {
                    Console.WriteLine("Please enter a valid number between 1 and 9.");
                    continue;
                }

                if (move < 1 || move > 9)
                {
                    Console.WriteLine("There is no cell " + move + " on the field.");
                    continue;
                }

                if (board[move - 1] == 'X' || board[move - 1] == 'O')
                {
                    Console.WriteLine("Cell " + move + " is already set.");
                    continue;
                }

                return move;
            }
        }

        private bool MakeMove(int move)
        {
            board[move - 1] = currentPlayer == 1 ? 'X' : 'O';
            return true;
        }

        private bool IsWinningMove(int move)
        {
            int[] winningCombinations =
            {
                0,
                1,
                2,
                3,
                4,
                5,
                6,
                7,
                8,
                0,
                3,
                6,
                1,
                4,
                7,
                2,
                5,
                8,
                0,
                4,
                8,
                2,
                4,
                6
            };

            for (int i = 0; i < winningCombinations.Length; i += 3)
            {
                if (
                    board[winningCombinations[i]] == board[winningCombinations[i + 1]]
                    && board[winningCombinations[i + 1]] == board[winningCombinations[i + 2]]
                )
                {
                    return true;
                }
            }

            return false;
        }

        private bool IsDraw()
        {
            for (int i = 0; i < 9; i++)
            {
                if (board[i] != 'X' && board[i] != 'O')
                {
                    return false;
                }
            }

            return true;
        }

        private void SwitchPlayer()
        {
            currentPlayer = currentPlayer == 1 ? 2 : 1;
        }

        // add a function to restart the game after a win or a draw 
        private void RestartGame()
        {
            Console.WriteLine("Would you like to play again? (Y/N)");
            string input = Console.ReadLine();
            if (input == "Y" || input == "y")
            {
                Play();
            }
            else
            {
                Environment.Exit(0);
            }
        }

        

    }

    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.Play();
        }
    }
}
