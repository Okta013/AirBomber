using AirBomber.Exceptions;
using System.Net.Http.Headers;

namespace AirBomber
{
    public class SetBombersGeneric<T>
        where T : class, IEquatable<T>
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
            if (entities.Contains(entity)) return false;
            if (pos >= maxCount) return false;
            entities[pos - 1] = entity;
            return true;
        }

        public bool Insert(T entity)
        {
            if (entities.Count == maxCount) throw new StorageOverflowException(maxCount);
            if (entities.Contains(entity)) return false;
            entities.Add(entity);
            return true;
        }

        public bool Remove(int pos) 
        {
            if (pos >= maxCount) return false;
            if (entities[pos - 1] == null) throw new EntityNotFoundException(pos);
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

        public void SortSet(IComparer<T> comparer)
        {
            if (comparer == default) return;

            entities.Sort(comparer);
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
