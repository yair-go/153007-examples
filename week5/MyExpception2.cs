using System;
using System.Runtime.Serialization;

namespace week5
{
    [Serializable]
    internal class MyExpception2 : Exception
    {
        public MyExpception2()
        {
        }

        public MyExpception2(string message) : base(message)
        {
        }

        public MyExpception2(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected MyExpception2(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}