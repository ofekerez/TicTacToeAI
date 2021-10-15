using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TICTACTOE
{
   public class Program
    {
		public  char Bot = 'O';
		public  Stack<int> PlayerMove = new Stack<int>();
		public	Stack<int> BotMoves = new Stack<int>();
		public  char player = 'X';
		public  char undo = 'N';
		

		 void clearScreen()//Adds 2 empty lines which give an effect of a clean board/
		{
			for (int i = 0; i < 2; i++)
				Console.WriteLine();
		}

		 void Generateboard(char[] board)// Receives a char array and creates a Tic Tac Toe board from its initial values.
		{
			for (int i = 1; i <= board.Length; i++)//Starts from 1 so we could check if 3 is one of i's prime numbers.
			{
				Console.Write("|" + board[i - 1] + "| ");
				if (i % 3 == 0)
					Console.WriteLine();
			}
		}

		 bool PositionEmpty(Board board, int position)// Recieves the TicTacToe board & a certain position and returns wether if the position is empty or not.
		{
			if (board.Getboard()[position] == 'X' || board.Getboard()[position] == 'O')
				return false;
			return true;
		}

		 bool HasWon(Board board, char input)
		{
			return ((board.Getboard()[0] == input && board.Getboard()[1] == input && board.Getboard()[2] == input) ||// If the First line is full of the same character.
				 (board.Getboard()[3] == input && board.Getboard()[4] == input && board.Getboard()[5] == input) ||// If the Second line is full of the same character
				 (board.Getboard()[6] == input && board.Getboard()[7] == input && board.Getboard()[8] == input) ||// If the Third line is full of the same character.
				 (board.Getboard()[0] == input && board.Getboard()[3] == input && board.Getboard()[6] == input) ||// If the First row is full of the same character.
				 (board.Getboard()[1] == input && board.Getboard()[4] == input && board.Getboard()[7] == input) ||// If the Second row is full of the same character.
				 (board.Getboard()[2] == input && board.Getboard()[5] == input && board.Getboard()[8] == input) ||// If the Third row is full of the same character
				 (board.Getboard()[0] == input && board.Getboard()[4] == input && board.Getboard()[8] == input) ||// If the First diagonal is full of the same character.
				 (board.Getboard()[2] == input && board.Getboard()[4] == input && board.Getboard()[6] == input)); //If the Second diagonal is full of the same character.


		}

		 int CheckWin(Board board)
		{
			if ((board.Getboard()[0] == Bot && board.Getboard()[1] == Bot && board.Getboard()[2] == Bot) ||// If the First line is full of the bot's character.
				 (board.Getboard()[3] == Bot && board.Getboard()[4] == Bot && board.Getboard()[5] == Bot) ||// If the Second line is full of the bot's character.
				 (board.Getboard()[6] == Bot && board.Getboard()[7] == Bot && board.Getboard()[8] == Bot) ||// If the Third line is full of the bot's character.
				 (board.Getboard()[0] == Bot && board.Getboard()[3] == Bot && board.Getboard()[6] == Bot) ||// If the First row is full of the bot's character.
				 (board.Getboard()[1] == Bot && board.Getboard()[4] == Bot && board.Getboard()[7] == Bot) ||// If the Second row is full of the bot's character.
				 (board.Getboard()[2] == Bot && board.Getboard()[5] == Bot && board.Getboard()[8] == Bot) ||// If the Third row is full of the bot's character.
				 (board.Getboard()[0] == Bot && board.Getboard()[4] == Bot && board.Getboard()[8] == Bot) ||// If the First diagonal is full of the bot's character.
				 (board.Getboard()[2] == Bot && board.Getboard()[4] == Bot && board.Getboard()[6] == Bot))// If the Second diagonal is full of the bot's character.
				return -10;
			else if ((board.Getboard()[0] == player && board.Getboard()[1] == player && board.Getboard()[2] == player) ||// If the First line is full of the player's character.
				   (board.Getboard()[3] == player && board.Getboard()[4] == player && board.Getboard()[5] == player) ||// If the Second line is full of the playeer's character.
				   (board.Getboard()[6] == player && board.Getboard()[7] == player && board.Getboard()[8] == player) ||// If the Third line is full of the player's character.
				   (board.Getboard()[0] == player && board.Getboard()[3] == player && board.Getboard()[6] == player) ||// If the First row is full of the player's character.
				   (board.Getboard()[1] == player && board.Getboard()[4] == player && board.Getboard()[7] == player) ||// If the Second row is full of the player's character.
				   (board.Getboard()[2] == player && board.Getboard()[5] == player && board.Getboard()[8] == player) ||// If the Third row is full of the player's character.
				   (board.Getboard()[0] == player && board.Getboard()[4] == player && board.Getboard()[8] == player) ||// If the First diagonal is full of the player's character.
				   (board.Getboard()[2] == player && board.Getboard()[4] == player && board.Getboard()[6] == player))// If the Second diagonal is full of the player's character.
				return 10;
			return 0;
		}
		 int minimax(Board board, int depth, char input)
		{
			int score = CheckWin(board);// checks if the move is an end to the game.

			if (CheckWin(board) == 10) return score - depth; //Substracts the number of the moves needed to get to the victory.
			else if (CheckWin(board) == -10) return score + depth; //Substracts the number of the moves needed to get to the victory.

			if (!board.CheckMovesleft()) return 0;//If the game is over & there is a tie.

			if (input == Bot)
			{
				int bestValue = 99999999;
				for (int i = 0; i < board.Getboard().Length; i++)
				{
					if (board.Getboard()[i] != 'X' && board.Getboard()[i] != 'O')
					{
						char before = board.Getboard()[i];
						board.Getboard()[i] = Bot;

						int value = minimax(board, depth++, player);
						bestValue = Math.Min(bestValue, value);

						board.Getboard()[i] = before;
					}
				}
				return bestValue;
			}
			else
			{
				int bestValue = -99999999;
				for (int i = 0; i < board.Getboard().Length; i++)
				{
					if (board.Getboard()[i] != 'X' && board.Getboard()[i] != 'O')
					{
						char before = board.Getboard()[i];
						board.Getboard()[i] = player;

						int value = minimax(board, depth++, Bot);
						bestValue = Math.Max(bestValue, value);

						board.Getboard()[i] = before;
					}
				}
				return bestValue;
			}

		}

		 int GetbestMove(Board board)
		{
			int bestMoveValues = 999999999;
			int bestMove = -1;

			for (int i = 0; i < board.Getboard().Length; i++)
			{
				if (board.Getboard()[i] != 'X' && board.Getboard()[i] != 'O')
				{
					char before = board.Getboard()[i];
					board.Getboard()[i] = Bot;

					int bestValue = minimax(board, 0, player);

					board.Getboard()[i] = before;

					if (bestValue < bestMoveValues)
					{
						bestMoveValues = bestValue;
						bestMove = i;
					}
				}
			}

			return bestMove;
		}

		public  void Game()
		{
			char[] cells = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };//An array which contains the initial text of each cell in the board

			int position;
			Board board = new Board(cells);// Creates a board Object that every cell in it consists the matching character of the char array.
			board.InitializeBoard(cells);//Converts the Object board to a char array.

			while (true)
			{
				clearScreen();
				if (BotMoves.Count != 0)
					Console.WriteLine("\n" + "Computer: I  chose this cell:" + (BotMoves.Peek() + 1));
				if (HasWon(board, player))
				{
					Console.WriteLine("{0}" + "Won", player);
					Console.WriteLine("Do you want To start a new Game? Press s to start");
					player = char.Parse(Console.ReadLine());
					if (player == 's' || player == 'S')
					{
					
							Application.Restart();
					}
						
					
					else
						break;

				}
				else if (HasWon(board, Bot))
				{
					Generateboard(board.InitializeBoard(cells));
					Console.WriteLine("{0}" + " " + "Won", Bot);
					Console.WriteLine("Do you want To start a new Game? Press s to start");
					player = char.Parse(Console.ReadLine());
					if (player == 's' || player == 'S')
					{
						Application.Restart();
				
					}
					else
						break;
				}

				if (!board.CheckMovesleft())
				{
					Console.WriteLine("It is a Tie !");
					Console.WriteLine("Do you want To start a new Game? Press s to start");
					player = char.Parse(Console.ReadLine());
					if (player == 's' || player == 'S')
					{
						
						Application.Restart();
					}
					else
						break;
				}

				Generateboard(board.InitializeBoard(cells));

				do// Excutes the commands in it once, then checks the entry condition, if it is true, then it does the commands once again until the entry condition is false.
				{
					try
					{// Makes sure that there is no problem with the input entered by the user.

						if (PlayerMove.Count != 0)
						{
							Console.WriteLine("\n" + "Do you want to undo the last move? Enter Y if you do and any other character if you do not.");
							undo = char.Parse(Console.ReadLine());
							if (undo == 'Y' || undo == 'y' && PlayerMove != null)
							{
								board.SetBoardPosition(BotMoves.Pop(), '_');
								board.SetBoardPosition(PlayerMove.Pop(), '_');
								Generateboard(board.InitializeBoard(cells));
								while (undo == 'y' && PlayerMove.Count != 0)
								{
									Console.WriteLine("Do you want to undo another move?");
									undo = char.Parse(Console.ReadLine());
									if (undo == 'Y' || undo == 'y')
									{
										board.SetBoardPosition(BotMoves.Pop(), '_');
										board.SetBoardPosition(PlayerMove.Pop(), '_');
										Generateboard(board.InitializeBoard(cells));
									}
									else
										break;
								}
							}
						}
						Console.Write("Place your move [1-9] : ");
						position = int.Parse(Console.ReadLine());
						while (!PositionEmpty(board, position - 1))
						{
							Console.WriteLine("Enter a cell that is not already filled !");
							position = int.Parse(Console.ReadLine());

						}
					}
					catch
					{
						Console.WriteLine("Enter only a number from 1 to 9 included");
						position = int.Parse(Console.ReadLine());

					}
					PlayerMove.Push(position - 1);

				} while (position < 1 || position > 9 || !PositionEmpty(board, position - 1));
				board.SetBoardPosition(position - 1, player);

				if (!board.CheckMovesleft())
				{
					Console.WriteLine("Tie !");
					break;
				}
				int bestMove = GetbestMove(board);
				BotMoves.Push(bestMove);
				board.SetBoardPosition(bestMove, Bot);

			}
		}
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
        static void Main()
		{
			string Wantto;
			Console.WriteLine("Do you want to play 1V1 Or Vs the computer? Enter 1v1 for the first option and anything else in order to play against my unbeatable AI");
			Wantto = Console.ReadLine();
			if (Wantto == "1v1" || Wantto == "1V1")
			{
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);
				Application.Run(new Form1());
			}
			else
			{
				new Program();
			}
        }
		public Program()
		{
			Console.WriteLine("Choose X or O");
			player = char.Parse(Console.ReadLine());
			while (player != 'X' && player != 'O' && player != 'x' && player != 'o')
			{
				Console.WriteLine("Enter only X or O son of a witch");
				player = char.Parse(Console.ReadLine());
			}

			if (player == 'X' || player == 'x')
			{
				Bot = 'O';
				player = 'X';
			}
			else
			{
				Bot = 'X';
				player = 'O';
			}
			Game();
		}
	}
}
