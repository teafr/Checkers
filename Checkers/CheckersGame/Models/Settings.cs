using CheckersGame.Enums;

namespace CheckersGame.Models
{
    public class Settings
    {
        public CheckerInfo CheckerInfo { get; private set; }

        public CheckerInfo? QueenInfo { get; private set; }

        public Settings(CheckerInfo checker, CheckerInfo? queen = null)
        {
            CheckerInfo = checker;
            QueenInfo = queen!;
        }
    }
}
