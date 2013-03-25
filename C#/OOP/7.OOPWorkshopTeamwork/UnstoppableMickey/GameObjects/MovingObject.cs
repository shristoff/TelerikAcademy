namespace UnstoppableMickey
{
    using System;

    public abstract class MovingObject : GameObject
    {
        // Constructors
        public MovingObject(Position position, char symbol, ConsoleColor color, Position direction)
            : base(position, symbol, color)
        {
            this.Direction = direction;
        }

        // Properties
        public Position Direction { get; set; }

        // Methods
        public override void UpdatePosition()
        {
            this.Position += this.Direction;
        }
    }
}
