namespace UnstoppableMickey
{
    using System;

    public class ForbiddenKeyException : ApplicationException
    {
        public ForbiddenKeyException(string message = "You can't use this key in this game!", Exception innerException = null)
            : base(message, innerException)
        {
        }
    }
}
