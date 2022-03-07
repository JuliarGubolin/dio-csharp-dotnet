using System;
using System.Runtime.Serialization;

namespace tratamento_exceçoes.Models
{
    [Serializable]
    public class MyClassException : Exception
    {
        public string MyProperty {get;set;}
        public MyClassException()
        {
        }

        public MyClassException(string message) : base(message)
        {
        }

        public MyClassException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected MyClassException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}