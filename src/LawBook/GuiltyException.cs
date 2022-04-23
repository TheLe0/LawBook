using System;

namespace LawBook
{
    public class GuiltyException : Exception
    {
        public GuiltyException() { }

        public GuiltyException(string message) : base(message)
        { }
    }
}