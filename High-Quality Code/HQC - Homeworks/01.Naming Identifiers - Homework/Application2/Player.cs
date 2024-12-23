namespace Minesweeper
{
    public class Player
    {
        private string name;

        private int points;

        public Player()
        {
        }

        public Player(string name, int scores)
        {
            this.name = name;
            this.points = scores;
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public int Points
        {
            get
            {
                return points;
            }

            set
            {
                points = value;
            }
        }
    }
}
