using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AirBomber
{
    public class DrawningObjectAirBomber : IDrawningObject
    {
        public DrawingMoving _airBomber = null;
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

        public void DrawningObject(Graphics g, int x, int y, int width, int height, int pos) 
        {
            _airBomber.SetPosition(x, y, width, height, pos);
            _airBomber.DrawAirBomber(g);
        }

        public string GetInfo() => _airBomber.GetDataForSave();
        public static IDrawningObject Create(string info) => new DrawningObjectAirBomber(info.CreateEntity());
    }
}
