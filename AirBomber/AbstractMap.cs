using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBomber
{
    public abstract class AbstractMap
    {
        protected IDrawningObject _drawningObject = null;
        protected int[,] _map = null;
        protected int _width;
        protected int _height;
        protected float _size_x;
        protected float _size_y;
        protected readonly Random _random = new();
        protected readonly int _freeRoad = 0;
        protected readonly int _barrier = 1;
        public Bitmap CreateMap(int width, int height, IDrawningObject drawningObject)
        {
            _width = width;
            _height = height;
            _drawningObject = drawningObject;
            GenerateMap();
            while (!SetObjectOnMap())
            {
                GenerateMap();
            }
            return DrawMapWithObject();
        }
        
        public Bitmap MoveObject(Direction direction)
        {
            // TODO проверка, что объект может переместится в требуемом направлении
            if (true)
            {
                _drawningObject.MoveObject(direction, _map);
            }
            return DrawMapWithObject();

        }
        private bool SetObjectOnMap()
        {
            if (_drawningObject == null || _map == null)
            {
                return false;
            }
            int x = _random.Next(0, 10);
            int y = _random.Next(0, 10);
            _drawningObject.SetObject(x, y, _width, _height);
            // TODO првоерка, что объект не "накладывается" на закрытые участки
            return true;
        }
        protected abstract Bitmap DrawMapWithObject();
        protected abstract void GenerateMap();
        protected abstract void DrawRoadPart(Graphics g, int i, int j);
        protected abstract void DrawBarrierPart(Graphics g, int i, int j);
    }
}
