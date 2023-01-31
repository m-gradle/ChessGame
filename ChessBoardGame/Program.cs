using System;

public class Program
{
	private static Square[,] board;

    public static void Main(string[] args)
	{
		board = new Square[8,8];
		GenSquares();
		
		for (int i = 0; i < 8; i++)
		{
			board[1, i].CreatePawns('w');
		}

        for (int i = 0; i < 8; i++)
        {
            board[6, i].CreatePawns('b');
        }

        PrintBoard();

	}

	public static void GenSquares()
	{
		for (int i = 0; i < 8; i++)
		{
			for (int j = 0; j < 8; j++)
			{
				if ((i + j) % 2 == 0)
				{
					board[i,j] = new Square('W');
				}
				else
				{
					board[i,j] = new Square('B');
				} 
					
			}
		}
	}

	public static void PrintBoard()
	{
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
				if (board[i,j].isOccupied)
				{
					Console.Write('P' + board[i,j].piece.GetPieceColor());
				}
				else 
				{
                    Console.Write(board[i, j].color);

                }

            }

			Console.WriteLine();
        }

		Console.ReadLine();
    }
}
