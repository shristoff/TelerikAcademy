namespace UnstoppableMickey
{
    using System;

    public abstract class GameObject : ICollidable
    {
        // Fields
        public const string ObjectType = "Object";

        // Constructors
        protected GameObject(Position position, char symbol, ConsoleColor color)
        {
            this.Position = position;
            this.Symbol = symbol;
            this.Color = color;
        }

        // Properties
        public Position Position { get; protected set; }

        public char Symbol { get; protected set; }

        public ConsoleColor Color { get; protected set; }

        // Methods
        public virtual void UpdatePosition()
        {
        }

        public virtual bool CanCollideWith(string anotherObjectType)
        {
            return GameObject.ObjectType == anotherObjectType;
        }

        public virtual string GetObjectType()
        {
            return GameObject.ObjectType;
        }
    }
}
