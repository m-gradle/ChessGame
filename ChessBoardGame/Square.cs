using System;

public class Square
{
	public char color;
	public bool isOccupied;
	public Piece piece;

	public Square(char color)
	{
		this.color = color; 
		this.isOccupied = false;
		this.piece = null; 

	}

	public void CreatePawns(char color) 
	{
		piece = new Pawn(color);
		isOccupied = true;
	}
}
