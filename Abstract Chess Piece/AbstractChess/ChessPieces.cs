using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Chess
{
    // the following enum allows us to identify a chess piece as black or white
    public enum PlayerType
    {
        BLACK,
        WHITE
    }

    public abstract class AbstractChessPiece
    {
        // the following variables define the AbstractChessPiece

        public String Name;             // "Pawn", "Rook", etc.
        public String Abbreviation;     // "P", "R", etc.

        public PlayerType Player;       // BLACK or WHITE
        public int Col;                 // 0 - 7
        public int Row;                 // 0 - 7
        public bool HasMoved;           // true or false

        // This function should be completed by the student.
        // The AbstractChessPiece initializes the member variables with the
        // provided information.
        public AbstractChessPiece(String newName, String newAbbreviation, PlayerType newPlayer)
        {
            Name = newName;
            Abbreviation = newAbbreviation;
            Player = newPlayer;
            HasMoved = false;
        }

        // This abstract method is defined but not implemented by AbstractChessPiece.
        // Each derived class will have to implement their own version.
        abstract public bool CanMoveToLocation(int targetCol, int targetRow, ChessBoard gameBoard);

        // This method will be implemented by the student.
        // Given a listed of ChessSquares in the path, determine if the indicated
        // targetRow and column can be reached within the number of steps allowed.
        protected bool CanFollowPath(int targetCol, int targetRow, 
                                     LinkedList<ChessSquare> path, int stepsAllowed)
        {
            return true;    // not yet implemented (final project)!
        }

        // This function will be implemented by the student.
        // Override the ToString() method to return some nicer description of the piece.
        override public String ToString()
        {
            switch (Player)
            {
                case PlayerType.WHITE:
                    return "White " + Name + " at (" + Col + ", " + Row + ")";
                case PlayerType.BLACK:
                    return "Black " + Name + " at (" + Col + ", " + Row + ")";
            }
            return "Please contact the programmer that coded this, this shouldn't happen";
        }
    }

    // This class will be implemented by the student.
    public class Pawn : AbstractChessPiece
    {
        public Pawn(PlayerType player) : base("Pawn", "P", player)
        {

        }

        public override bool CanMoveToLocation(int targetCol, int targetRow, ChessBoard gameBoard)
        {
            return true;
        }
    }

    // This class will be implemented by the student.
    public class Rook : AbstractChessPiece
    {
        public Rook(PlayerType player) : base("Rook", "R", player)
        {

        }

        public override bool CanMoveToLocation(int targetCol, int targetRow, ChessBoard gameBoard)
        {
            return true;
        }
    }

    // This class will be implemented by the student.
    public class Knight : AbstractChessPiece
    {
        public Knight(PlayerType player) : base("Knight", "K", player)
        {

        }

        public override bool CanMoveToLocation(int targetCol, int targetRow, ChessBoard gameBoard)
        {
            return true;
        }
    }

    // This class will be implemented by the student.
    public class Bishop : AbstractChessPiece
    {
        public Bishop(PlayerType player) : base("Bishop", "B", player)
        {

        }

        public override bool CanMoveToLocation(int targetCol, int targetRow, ChessBoard gameBoard)
        {
            return true;
        }
    }

    // This class will be implemented by the student.
    public class Queen : AbstractChessPiece
    {
        public Queen(PlayerType player) : base("Queen", "Q", player)
        {

        }

        public override bool CanMoveToLocation(int targetCol, int targetRow, ChessBoard gameBoard)
        {
            return true;
        }
    }

    // This class will be implemented by the student.
    public class King : AbstractChessPiece
    {
        public King(PlayerType player) : base("King", "K", player)
        {

        }

        public override bool CanMoveToLocation(int targetCol, int targetRow, ChessBoard gameBoard)
        {
            return true;
        }
    }

}
