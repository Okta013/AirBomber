namespace AirBomber
{
    public class SetBombersGeneric<T>
        where T : class
    {
        private readonly T[] entities;
        public int Count => entities.Length;

        public SetBombersGeneric(int count)
        {
            entities = new T[count];
        }

        public bool Insert(T entity, int pos)
        {
            entities[pos] = entity;
            return true;
        }

        public bool Remove(int pos) 
        {
            entities[pos] = null;
            return true;
        }

        public T Get(int pos) 
        {
            return entities[pos];
        }
    }
}
