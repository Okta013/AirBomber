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

        public void AddMap(string name) 
        {

        }
    }
}
