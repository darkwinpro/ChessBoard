using System;
using NUnit.Framework;
using FluentAssertions;

namespace ChessBoardTask
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void WhenWriteChessBoard_AndDataIsCorrect_ThenCorrectChessBoard()
        {
            // Arrange. 
            var redColor = new byte[500, 500];
            var blueColor = new byte[500, 500];
            var greenColor = new byte[500, 500];
            
            // Act. 
            Program.CellSize = 50;
            Program.DrawChessBoard(redColor, blueColor, greenColor);
            
            // Assert. 
            ImageHelper.ReadImage("ChessBoard.bmp",
                out var expectedRedColor,
                out var expectedGreenColor,
                out var expectedBlueColor);
            
            expectedRedColor.Should().Equal(redColor);
            expectedBlueColor.Should().Equal(blueColor);
            expectedGreenColor.Should().Equal(greenColor);
        }

        [Test]
        public void WhenWriteRedDiagonal_AndDataIsCorrect_ThenCorrectChessBoardWithRedDiagonal()
        {
            // Arrange. 
            var redColor = new byte[500, 500];
            var blueColor = new byte[500, 500];
            var greenColor = new byte[500, 500];
            
            // Act. 
            Program.CellSize = 50;
            Program.DrawChessBoard(redColor, blueColor, greenColor);
            Program.WriteRedDiagonal(redColor, blueColor, greenColor);
            
            // Assert. 
            ImageHelper.ReadImage("ChessBoardWithRedDiagonals.bmp",
                out var expectedRedColor,
                out var expectedGreenColor,
                out var expectedBlueColor);
            
            expectedRedColor.Should().Equal(redColor);
            expectedBlueColor.Should().Equal(blueColor);
            expectedGreenColor.Should().Equal(greenColor);
        }
    }
}