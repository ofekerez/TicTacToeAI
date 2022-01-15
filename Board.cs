using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TICTACTOE
{
    class Board
    {
		private char[] board = new char[9];
		public Board(char[] board) { this.board = board;}
		

		public char[] InitializeBoard(char[] board)
		{
			for (int i = 0; i < 9; i++)
				this.board[i] = board[i];
			return this.board;
		}

		public bool CheckMovesleft()
		{
			for (int i = 0; i < this.board.Length; i++)
			{
				if (this.board[i] != 'X' && this.board[i] != 'O')
					return true;
			}

			return false;
		}
		public char[] Getboard() => this.board;
		public void SetBoard(char[] board) {this.board = board;}
		public void SetBoardPosition(int position, char player) {this.board[position] = player;}
	}
}

