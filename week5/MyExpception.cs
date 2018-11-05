using System;
using System.Runtime.Serialization;

namespace week5
{
    [Serializable]
    internal class MyExpception : Exception
    {
        public MyExpception()
        {
        }

        public MyExpception(string message) : base(message)
        {
        }

        public MyExpception(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected MyExpception(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}