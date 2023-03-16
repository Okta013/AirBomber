using System.Xml;

namespace AirBomber
{
    public class EntityCompareByColor : IComparer<IDrawningObject>
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

            if (xEntity.GetEntity.AirBomber.BodyColor != yEntity._airBomber.AirBomber.BodyColor)
            {
                return xEntity.GetEntity.AirBomber.BodyColor.Name.CompareTo(yEntity.GetEntity.AirBomber.BodyColor.Name);
            }
            if (xEntity.GetEntity.GetType().Name != yEntity._airBomber.GetType().Name)
            {
                if (xEntity.GetEntity.GetType().Name == "DrawingMoving") return -1;
                return 1;
            }

            if (xEntity.GetEntity.GetType().Name == yEntity._airBomber.GetType().Name && xEntity.GetEntity.GetType().Name == "DrawingMoving") return CompareByOther(xEntity, yEntity);

            var xImprovedEntity = xEntity.GetEntity.AirBomber as EntityImprovedAirBomber;
            var yImprovedEntity = yEntity.GetEntity.AirBomber as EntityImprovedAirBomber;

            if (xImprovedEntity.DopColor != yImprovedEntity.DopColor)
            {
                return xImprovedEntity.DopColor.Name.CompareTo(yImprovedEntity.DopColor.Name);
            }

            return CompareByOther(xEntity, yEntity);
        }

        public int CompareByOther(DrawningObjectAirBomber xEntity, DrawningObjectAirBomber yEntity)
        {
            var speedCompare = xEntity.GetEntity.AirBomber.Speed.CompareTo(yEntity.GetEntity.AirBomber.Speed);
            if (speedCompare != 0) return speedCompare;
            return xEntity.GetEntity.AirBomber.Weight.CompareTo(yEntity.GetEntity.AirBomber.Weight);
        }
    }
}
