namespace UnstoppableMickey
{
    using System;

    public interface ICollidable
    {
        string GetObjectType();

        bool CanCollideWith(string objectType);
    }
}
