namespace UnstoppableMickey
{
    using System;

    public class Wall : GameObject
    {
        // Fields
        public new const string ObjectType = "Wall";

        // Constructors
        public Wall(Position position)
            : base(position, '\u2588', ConsoleColor.DarkBlue)
        {
        }

        // Methods
        public override string GetObjectType()
        {
            return Wall.ObjectType;
        }
    }
}
