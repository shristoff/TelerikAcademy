namespace UnstoppableMickey
{
    using System;

    public interface IGameController
    {
        event EventHandler OnMoveLeft;

        event EventHandler OnMoveRight;

        event EventHandler OnMoveUp;

        event EventHandler OnMoveDown;

        event EventHandler ForbiddenKey;

        void Command();
    }
}
