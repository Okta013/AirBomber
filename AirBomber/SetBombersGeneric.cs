namespace AirBomber
{
    public class SetBombersGeneric<T>
        where T : class
    {
        private readonly List<T> entities;
        public int Count => entities.Count;
        private readonly int maxCount;

        public SetBombersGeneric(int maxCount)
        {
            this.maxCount = maxCount;
            entities = new();
        }

        [Obsolete]
        public bool Insert(T entity, int pos)
        {
            if (pos >= maxCount) return false;
            entities[pos - 1] = entity;
            return true;
        }

        public bool Insert(T entity)
        {
            if (entities.Count == maxCount) return false;
            entities.Add(entity);
            return true;
        }

        public bool Remove(int pos) 
        {
            if (pos >= maxCount) return false;
            if (entities[pos - 1] == null) return false;
            entities.RemoveAt(pos - 1);
            return true;
        }

        public T this[int pos]
        {
            get
            {
                if (pos < maxCount) return entities[pos];
                return null;
            }
            set
            {
                if (pos < maxCount) entities[pos] = value;
            }
        }

        public IList<T> GetEntities()
        {
            return entities;
        }

        //[Obsolete] // метод не имеет смысла, тк удаление с помощью RemoveAt сдвигает список
        //public IEnumerable<T> GetEntities()
        //{
        //    foreach (var entity in entities)
        //    {
        //        if (entity != null) yield return entity;
        //        else yield break;
        //    }
        //}
    }
}
