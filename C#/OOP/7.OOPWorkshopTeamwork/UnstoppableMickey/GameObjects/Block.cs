namespace UnstoppableMickey
{
    using System;

    public class Block : GameObject
    {
        // Fields
        public new const string ObjectType = "Block";

        // Constructors
        public Block(Position position)
            : base(position, '\u2588', ConsoleColor.DarkGray)
        {
        }

        // Methods
        public override string GetObjectType()
        {
            return Block.ObjectType;
        }
    }
}
