namespace AirBomber
{
    public class EntityCompareByType : IComparer<IDrawningObject>
    {
        public int Compare(IDrawningObject? x, IDrawningObject? y)
        {
            if (x == default && y == default) return 0;
            if (x == default && y != default) return 1;
            if (x != default && y == default) return -1;

            var xEntity = x as DrawningObjectAirBomber;
            var yEntity = y as DrawningObjectAirBomber;

            if (xEntity == default && yEntity == default) return 0;
            if (xEntity == default && yEntity != default) return 1;
            if (xEntity != default && yEntity == default) return -1;

            if (xEntity.GetEntity.GetType().Name != yEntity._airBomber.GetType().Name)
            {
                if (xEntity.GetEntity.GetType().Name == "DrawingMoving") return -1;
                return 1;
            }

            var speedCompare = xEntity.GetEntity.AirBomber.Speed.CompareTo(yEntity.GetEntity.AirBomber.Speed);
            if (speedCompare != 0) return speedCompare;
            return xEntity.GetEntity.AirBomber.Weight.CompareTo(yEntity.GetEntity.AirBomber.Weight);
        }
    }
}
