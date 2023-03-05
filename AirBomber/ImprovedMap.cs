namespace AirBomber
{
    internal class ImprovedMap : AbstractMap
    {
        private static SolidBrush barrierColor = new (Color.Green);
        private static SolidBrush roadColor = new (Color.Gray);

        protected override void DrawBarrierPart(Graphics g, int i, int j)
        {
            g.FillEllipse(barrierColor, i * _size_x, j * _size_y, (int)_size_x, (int)_size_y * 2);
        }

        [Obsolete]
        protected override void DrawRoadPart(Graphics g, int i, int j)
        {
            g.FillRectangle(roadColor, i * _size_x, j * _size_y, i * (_size_x + 1), j * (_size_y + 1));
        }
        
        protected override Bitmap DrawMapWithObject()
        {
            Bitmap bmp = new(_width, _height);
            if (_drawningObject == null || _map == null)
            {
                return bmp;
            }
            Graphics gr = Graphics.FromImage(bmp);
            for (int i = 0; i < _map.GetLength(0); ++i)
            {
                for (int j = 0; j < _map.GetLength(1); ++j)
                {
                    if (_map[i, j] == _barrier)
                    {
                        DrawBarrierPart(gr, i, j);
                    }
                }
            }
            _drawningObject.DrawningObject(gr);
            return bmp;
        }

        protected override void GenerateMap()
        {
            _map = new int[100, 100];
            _size_x = (float)_width / _map.GetLength(0);
            _size_y = (float)_height / _map.GetLength(1);
            int counter = 0;
            for (int i = 0; i < _map.GetLength(0); ++i)
            {
                for (int j = 0; j < _map.GetLength(1); ++j)
                {
                    _map[i, j] = _freeRoad;
                }
            }
            while (counter < 100)
            {
                int x = _random.Next(0, 100);
                int y = _random.Next(0, 100);
                if (_map[x, y] == _freeRoad && (x >= 20 || y >= 35))
                {
                    _map[x, y] = _barrier;
                    counter++;
                }
            }
        }
    }
}
