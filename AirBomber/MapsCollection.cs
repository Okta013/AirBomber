using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBomber
{
    public class MapsCollection
    {
        readonly Dictionary<string, MapWithSetBombersGeneric<DrawningObjectAirBomber, AbstractMap>> mapStorage;
        public IList<string> Keys => mapStorage.Keys.ToList();
        private readonly int pictureWidth;
        private readonly int pictureHeight;

        public MapsCollection(int pictureWidth, int pictureHeight)
        {
            mapStorage = new();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
        }

        public void AddMap(string name, AbstractMap map) => mapStorage.Add(name, new MapWithSetBombersGeneric<DrawningObjectAirBomber, AbstractMap>(pictureWidth, pictureHeight, map));

        public void RemoveMap(string name) => mapStorage.Remove(name); // обработка исключений? если попытаться удалить запись по ключу, которого не существует => дропнет исключение

        public MapWithSetBombersGeneric<DrawningObjectAirBomber, AbstractMap> this[string name] => mapStorage[name] ?? null;
    }
}
