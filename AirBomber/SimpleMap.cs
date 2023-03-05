using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBomber
{
    internal class SimpleMap : AbstractMap
    {
        /// <summary>
        /// Цвет участка закрытого
        /// </summary>
        private readonly Brush barrierColor = new SolidBrush(Color.Black);
        /// <summary>
        /// Цвет участка открытого
        /// </summary>
        private readonly Brush roadColor = new SolidBrush(Color.Gray);
        protected override void DrawBarrierPart(Graphics g, int i, int j)
        {
            g.FillRectangle(barrierColor, i * _size_x, j * _size_y, i * (_size_x +
           1), j * (_size_y + 1));
        }
        protected override void DrawRoadPart(Graphics g, int i, int j)
        {
            g.FillRectangle(roadColor, i * _size_x, j * _size_y, i * (_size_x +
           1), j * (_size_y + 1));
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
            while (counter < 50)
            {
                int x = _random.Next(0, 100);
                int y = _random.Next(0, 100);
                if (_map[x, y] == _freeRoad)
                {
                    _map[x, y] = _barrier;
                    counter++;
                }
            }
        }
    }
}