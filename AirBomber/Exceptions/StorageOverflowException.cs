using System.Runtime.Serialization;

namespace AirBomber.Exceptions
{
    [Serializable]
    public class StorageOverflowException : ApplicationException
    {
        public StorageOverflowException(int i) : base($"В наборе превышено допустимое количество: {i}") { }
        public StorageOverflowException() : base() { }
        public StorageOverflowException(string message) : base(message) { }
        public StorageOverflowException(string message, Exception innerException) : base(message, innerException) { }
        protected StorageOverflowException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
