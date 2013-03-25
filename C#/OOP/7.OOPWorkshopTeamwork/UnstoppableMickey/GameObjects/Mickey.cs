namespace UnstoppableMickey
{
    using System;

    public class Mickey : GameObject
    {
        // Fields
        public new const string ObjectType = "Mickey";

        // Constructors
        public Mickey(Position position)
            : base(position, '\u263B', ConsoleColor.Red)
        {
        }

        // Properties
        public Position LastPosition { get; private set; }

        // Methods
        public virtual void MoveLeft()
        {
            this.LastPosition = this.Position;
            this.Position += new Position(0, -1);
        }

        public virtual void MoveRight()
        {
            this.LastPosition = this.Position;
            this.Position += new Position(0, 1);
        }

        public virtual void MoveUp()
        {
            this.LastPosition = this.Position;
            this.Position += new Position(-1, 0);
        }

        public virtual void MoveDown()
        {
            this.LastPosition = this.Position;
            this.Position += new Position(1, 0);
        }

        public override bool CanCollideWith(string anotherObjectType)
        {
            return anotherObjectType == "Block" || anotherObjectType == "Wall";
        }

        public override string GetObjectType()
        {
            return Mickey.ObjectType;
        }
    }
}
