namespace UnstoppableMickey
{
    using System;

    public class Cat : MovingObject
    {
        // Fields
        public new const string ObjectType = "Cat";

        // Constructors
        public Cat(Position position, Position direction)
            : base(position, '\u00A4', ConsoleColor.Green, direction)
        {
        }

        // Methods
        public override bool CanCollideWith(string anotherObjectType)
        {
            return anotherObjectType == "Block" || anotherObjectType == "Wall";
        }

        public override string GetObjectType()
        {
            return Cat.ObjectType;
        }
    }
}
