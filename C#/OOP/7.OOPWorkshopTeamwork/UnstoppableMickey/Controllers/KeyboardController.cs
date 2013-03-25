namespace UnstoppableMickey
{
    using System;

    public class KeyboardController : IGameController
    {
        public event EventHandler OnMoveLeft;

        public event EventHandler OnMoveRight;

        public event EventHandler OnMoveUp;

        public event EventHandler OnMoveDown;

        public event EventHandler ForbiddenKey;

        public void Command()
        {
            if (Console.KeyAvailable)
            {
                var keyInfo = Console.ReadKey(true);
                while (Console.KeyAvailable)
                {
                    Console.ReadKey(true);
                }

                if (keyInfo.Key.Equals(ConsoleKey.LeftArrow))
                {
                    if (this.OnMoveLeft != null)
                    {
                        this.OnMoveLeft(this, new EventArgs());
                    }
                }

                if (keyInfo.Key.Equals(ConsoleKey.RightArrow))
                {
                    if (this.OnMoveRight != null)
                    {
                        this.OnMoveRight(this, new EventArgs());
                    }
                }

                if (keyInfo.Key.Equals(ConsoleKey.UpArrow))
                {
                    if (this.OnMoveUp != null)
                    {
                        this.OnMoveUp(this, new EventArgs());
                    }
                }

                if (keyInfo.Key.Equals(ConsoleKey.DownArrow))
                {
                    if (this.OnMoveDown != null)
                    {
                        this.OnMoveDown(this, new EventArgs());
                    }
                }

                if (keyInfo.Key.Equals(ConsoleKey.Enter))
                {
                    if (this.ForbiddenKey != null)
                    {
                        this.ForbiddenKey(this, new EventArgs());
                    }
                }
            }
        }
    }
}
