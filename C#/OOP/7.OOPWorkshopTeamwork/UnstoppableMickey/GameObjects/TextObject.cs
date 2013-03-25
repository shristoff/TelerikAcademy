namespace UnstoppableMickey
{
    using System;

    public abstract class TextObject
    {
        // Constructors
        public TextObject(Position position, string text, ConsoleColor color)
        {
            this.Position = position;
            this.Text = text;
            this.Color = color;
        }

        // Properties
        public Position Position { get; protected set; }

        public ConsoleColor Color { get; protected set; }

        public string Text { get; private set; }

        public int Value { get; set; }

        // Methods
        public override string ToString()
        {
            return string.Format("{0}: {1}", this.Text, this.Value);
        }
    }
}
