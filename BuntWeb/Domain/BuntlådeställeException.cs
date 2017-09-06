using System;

namespace BuntWeb.Domain
{
    public class BuntlådeställeException : Exception
    {
        public BuntlådeställeException(string message) : base(message)
        {
        }
    }
}