using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Chess;

// THIS FILE DOES NOT NEED TO BE CHANGED BY THE STUDENT
// This program will create an instance of each type of
// chess piece and then display some basic information to indicate
// the piece has been initialized properly.

namespace ChessPieceDemo
{
    public partial class ChessForm : Form
    {
        public ChessForm()
        {
            InitializeComponent();

        }

        private String queryPiece(AbstractChessPiece piece)
        {
            String display = "Name = " + piece.Name + ",\t";
            display += "Abbreviation = " + piece.Abbreviation + ",\t";
            display += "ToString() = " + piece.ToString() + ",\t";
            display += "HasMoved = " + piece.HasMoved.ToString() + "\r\n";

            return display;
        }

        private void ChessForm_Load(object sender, EventArgs e)
        {
            // validate that each of the chess pieces can be created and
            // are properly initialized
            StringBuilder builder = new StringBuilder();

            builder.Append(queryPiece(new Chess.Pawn(PlayerType.WHITE)));
            builder.Append(queryPiece(new Chess.Rook(PlayerType.WHITE)));
            builder.Append(queryPiece(new Chess.Knight(PlayerType.WHITE)));
            builder.Append(queryPiece(new Chess.Bishop(PlayerType.WHITE)));
            builder.Append(queryPiece(new Chess.Queen(PlayerType.WHITE)));
            builder.Append(queryPiece(new Chess.King(PlayerType.WHITE)));
            
            textBox1.Text = builder.ToString();
            
        }

    }
}
