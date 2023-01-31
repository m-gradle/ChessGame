using System;

public abstract class Piece
{
	protected char _color;
	
	public abstract void move();

	public char GetPieceColor()
	{
		return _color;
	}

}
