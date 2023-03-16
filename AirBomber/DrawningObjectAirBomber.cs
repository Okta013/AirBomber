namespace AirBomber
{
    public class DrawningObjectAirBomber : IDrawningObject
    {
        public DrawingMoving _airBomber = null;
        public float Step => _airBomber?.AirBomber?.Step ?? 0;

        public DrawningObjectAirBomber(DrawingMoving airBomber)
        {
            _airBomber = airBomber;
        }

        public DrawingMoving GetEntity => _airBomber;

        public bool Equals(IDrawningObject? other)
        {
            if (other == default) return false;

            var otherEntity = other as DrawningObjectAirBomber;

            if (otherEntity == default) return false;

            var entity = _airBomber.AirBomber;
            var otherEntityEntity = otherEntity._airBomber.AirBomber;

            if (entity.Speed != otherEntityEntity.Speed) return false;
            if (entity.Weight != otherEntityEntity.Weight) return false;
            if (entity.BodyColor != otherEntityEntity.BodyColor) return false;

            if (entity is not EntityImprovedAirBomber && otherEntityEntity is not EntityImprovedAirBomber) return true;
            if (entity is not EntityImprovedAirBomber || otherEntityEntity is not EntityImprovedAirBomber)
            {
                if (entity is EntityImprovedAirBomber improvedEntity)
                {
                    if (!improvedEntity.Bombs && !improvedEntity.FuelTanks) return true;
                }
                if (otherEntityEntity is EntityImprovedAirBomber otherImprovedEntity)
                {
                    if (!otherImprovedEntity.Bombs && !otherImprovedEntity.FuelTanks) return true;
                }

                return false;
            }

            var improved = entity as EntityImprovedAirBomber;
            var otherImproved = otherEntityEntity as EntityImprovedAirBomber;

            if (improved.Bombs != otherImproved.Bombs) return false;
            if (improved.FuelTanks != otherImproved.FuelTanks) return false;
            if (improved.DopColor != otherImproved.DopColor) return false;

            return true;
        }

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
