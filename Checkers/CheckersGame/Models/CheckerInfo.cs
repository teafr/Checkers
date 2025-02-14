using CheckersGame.Enums;

namespace CheckersGame.Models
{
    public class CheckerInfo
    {
        public List<Direction> WalkDirections { get; set; }

        public List<Direction> KillDirections { get; set; }

        public bool KillOnce { get; set; }

        public int WalkRange { get; set; }

        public CheckerInfo(List<Direction>? walkDirections, int walkRange, bool killOnce)
        {
            KillOnce = killOnce;
            WalkRange = walkRange;
        }
    }
}