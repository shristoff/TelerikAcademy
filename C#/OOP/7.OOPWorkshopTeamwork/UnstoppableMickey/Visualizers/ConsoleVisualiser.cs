namespace UnstoppableMickey
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ConsoleVisualizer : IVisualizer
    {
        // Fields
        private const int DefaultGameWindowRows = 33;
        private const int DefaultGameWindowCols = 42;

        // Constructors
        public ConsoleVisualizer()
        {
            Console.SetWindowSize(DefaultGameWindowCols, DefaultGameWindowRows);
            Console.SetBufferSize(DefaultGameWindowCols, DefaultGameWindowRows);
            Console.CursorVisible = false;
        }

        // Methods
        // Visualize any object type
        public void Visualize(GameObject obj)
        {
            Console.SetCursorPosition(obj.Position.Col, obj.Position.Row);
            Console.ForegroundColor = obj.Color;
            Console.Write(obj.Symbol);
        }

        // Visualize only text objects
        public void VisualizeText(TextObject obj)
        {
            Console.SetCursorPosition(obj.Position.Col, obj.Position.Row);
            Console.ForegroundColor = obj.Color;
            Console.Write(obj);
        }

        // Visualize end of game (Game Over)
        public void EndOfGame()
        {
            Console.SetCursorPosition(15, 15);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Game Over!");
            Console.ReadLine();
        }

        // Clears only moving and controlled object
        public void Clear(List<GameObject> allObjects)
        {
            foreach (var obj in allObjects.Where(x => x is MovingObject || x is Mickey))
            {
                var mickeyObject = obj as Mickey;
                if (mickeyObject != null)
                {
                    Console.SetCursorPosition(mickeyObject.LastPosition.Col, mickeyObject.LastPosition.Row);
                    Console.Write(" ");
                }
                else
                {
                    Console.SetCursorPosition(obj.Position.Col, obj.Position.Row);
                    Console.Write(" ");
                }
            }
        }
    }
}
