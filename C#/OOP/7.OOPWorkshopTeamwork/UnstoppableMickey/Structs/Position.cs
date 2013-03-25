namespace UnstoppableMickey
{
    using System;

    public struct Position
    {
        // Fields
        private static readonly Random Random = new Random();
        private int row;
        private int col;
        
        // Constructor
        public Position(int row, int col)
        {
            this.row = row;
            this.col = col;
        }

        // Properties
        public int Row
        {
            get
            {
                return this.row;
            }

            set
            {
                this.col = value;
            }
        }

        public int Col
        {
            get
            {
                return this.col;
            }

            set
            {
                this.col = value;
            }
        }

        // Methods
        public static Position RandomDirection()
        {
            int row = 0;
            int col = 0;

            switch (Random.Next(1, 3))
            {
                case 1:
                    {
                        // Horizontal direction (left or right)
                        row = 0;
                        col = Random.Next(0, 2) - 1;
                        if (col == 0)
                        {
                            col = 1;
                        }

                        break;
                    }

                case 2:
                    {
                        // Vertical direction (up or down)
                        row = Random.Next(0, 2) - 1;
                        col = 0;
                        if (row == 0)
                        {
                            row = 1;
                        }

                        break;
                    }
            }

            return new Position(row, col);
        }

        public static Position operator +(Position a, Position b)
        {
            return new Position(a.Row + b.Row, a.Col + b.Col);
        }

        public static Position operator -(Position a, Position b)
        {
            return new Position(a.Row - b.Row, a.Col - b.Col);
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Position))
            {
                return false;
            }

            Position position = (Position)obj;
            return position.Row == this.Row && position.Col == this.Col;
        }

        public override int GetHashCode()
        {
            return (this.Row.GetHashCode() * 7) + this.Col;
        }
    }
}
