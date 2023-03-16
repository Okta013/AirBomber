using System.Text;

namespace AirBomber
{
    public static class ExtensionEntity
    {
        private const char separator = ':';
        public static string GetDataForSave(this DrawingMoving airBomber)
        {
            StringBuilder sb = new();
            var entity = airBomber.AirBomber;
            var str = $"{entity.Speed}{separator}{entity.Weight}{separator}{entity.BodyColor.Name}";

            if (entity is not EntityImprovedAirBomber improvedEntity)
            {
                sb.Append(str);
                return sb.ToString();
            }

            sb.Append($"{str}{separator}{improvedEntity.DopColor.Name}{separator}{improvedEntity.FuelTanks}{separator}{improvedEntity.Bombs}");
            return sb.ToString();
        }

        public static DrawingMoving CreateEntity(this string info)
        {
            var strs = info.Split(separator);

            if (strs.Length == 3) 
                return new DrawingMoving(
                    int.Parse(strs[0]), 
                    int.Parse(strs[1]), 
                    Color.FromName(strs[2]));

            else if (strs.Length == 6) 
                return new DrawingImprovedAirBomber(
                    int.Parse(strs[0]), 
                    int.Parse(strs[1]), 
                    Color.FromName(strs[2]), 
                    Color.FromName(strs[3]), 
                    bool.Parse(strs[4]), 
                    bool.Parse(strs[5]));

            return default;
        }
    }
}
