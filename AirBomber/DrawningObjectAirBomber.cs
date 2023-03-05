using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirBomber
{
    internal class DrawningObjectAirBomber : IDrawningObject
    {
        private DrawingMoving _airBomber = null;
        public DrawningObjectAirBomber(DrawingMoving airBomber)
        {
            _airBomber = airBomber;
        }
        public float Step => _airBomber?.AirBomber?.Step ?? 0;
        public (float Left, float Right, float Top, float Bottom) GetCurrentPosition()
        {
            return _airBomber?.GetCurrentPosition() ?? default;
        }
        public void MoveObject(Direction direction, int[,] _map)
        {
            _airBomber?.MoveAirBomber(direction, _map);
        }
        public void SetObject(int x, int y, int width, int height)
        {
            _airBomber.SetPosition(x, y, width, height);
        }
        public void DrawningObject(Graphics g)
        {
            _airBomber.DrawAirBomber(g);
        }
    }
}
