using System.Runtime.Serialization;

namespace AirBomber.Exceptions
{
    [Serializable]
    public class EntityNotFoundException : ApplicationException
    {
        public EntityNotFoundException(int i) : base($"Не найден объект по позиции {i}") { }
        public EntityNotFoundException() : base() { }
        public EntityNotFoundException(string message) : base(message) { }
        public EntityNotFoundException(string message, Exception innerException) : base(message, innerException) { }
        protected EntityNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
