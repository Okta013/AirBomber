namespace AirBomber
{
    public abstract class AbstractMap : IEquatable<AbstractMap>
    {
        protected IDrawningObject _drawningObject = null;
        public int[,] _map = null;
        protected int _width;
        protected int _height;
        protected float _size_x;
        protected float _size_y;
        protected readonly Random _random = new();
        protected readonly int _freeRoad = 0;
        protected readonly int _barrier = 1;
        public Bitmap CreateMap(int width, int height, IDrawningObject drawningObject, int x = 20, int y = 30)
        {
            _width = width;
            _height = height;
            _drawningObject = drawningObject;
            GenerateMap();
            while (!SetObjectOnMap(x, y))
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
        private bool SetObjectOnMap(int x = 20, int y = 30)
        {
            if (_drawningObject == null || _map == null)
            {
                return false;
            }
            _drawningObject.SetObject(x, y, _width, _height);
            // TODO првоерка, что объект не "накладывается" на закрытые участки
            return true;
        }
        protected abstract Bitmap DrawMapWithObject();
        protected abstract void GenerateMap();
        protected abstract void DrawRoadPart(Graphics g, int i, int j);
        protected abstract void DrawBarrierPart(Graphics g, int i, int j);

        public bool Equals(AbstractMap? other)
        {
            if (other._width != _width) return false;
            if (other._height != _height) return false;
            if (other._size_x != _size_x) return false;
            if (other._size_y != _size_y) return false;

            for (int i = 0; i < _map.GetLength(0); i++)
            {
                for (int j = 0; j < _map.GetLength(1); j++)
                {
                    if (other._map[i, j] != _map[i, j]) return false;
                }
            }

            return true;
        }
    }
}
