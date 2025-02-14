using CheckersGame.Enums;

namespace CheckersGame.Models
{
    public class CheckersGame
    {
        public SquareStatus[,] Board { get; set; }

        public CheckersGame(int rows, int columns)
        {
            MakeBoardEmpty();
        }

        public void MakeBoardEmpty()
        {
            int rows = Board.GetLength(0);
            int columns = Board.GetLength(1);

            for (int row = 0; row < rows; row++)
            {
                for (int column = 0; column < columns; column++)
                {
                    Board[row, column] = SquareStatus.Empty;
                }
            }
        }
        public void FindAllOptions()
        {

        }
    }
}
