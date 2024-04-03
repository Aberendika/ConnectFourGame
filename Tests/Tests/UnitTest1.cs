using Xunit;
using ConnectFour;

namespace Tests
{
    public class GameStateTests
    {
        [Fact]
        public void CheckForWin_NoWinner_EmptyBoard()
        {
            //B�rja med de tre stora A, Arrange, Act och Assert.
            // Arrange
            var gameState = new GameState(); // Skapar ny GameState

            // Act
            var result = gameState.CheckForWin(); // Hittar metoden CheckForWin i Gamestate

            // Assert
            Assert.Equal(GameState.WinState.No_Winner, result); // Visar genom assert att det �r NoWinner.
        }

        [Fact]
        public void CheckForWin_TieGame()
        {
            // Arrange
            var gameState = new GameState(); // Skapar ny GameState

            // Fyller i hela br�dan s� man ser att det �r oavgjort.
            for (int col = 0; col < 7; col++)
            {
                gameState.PlayPiece(col); // Spelar en pj�s i varje kolumn.
            }

            // Act
            var result = gameState.CheckForWin(); // Hittar CheckForWin i GameState

            // Assert
            Assert.Equal(GameState.WinState.Tie, result); // Visar genom assert att det �r oavgjort.
        }
    }
}
