namespace AirBomber
{
    public class MapWithSetBombersGeneric <T, U>
        where T : class, IDrawningObject
        where U : AbstractMap
    {
        private readonly int pictureWidth;
        private readonly int pictureHeight;
        private readonly int placeSizeWidth = 210;
        private readonly int placeSizeHeight = 90;

        private readonly SetBombersGeneric<T> setBombers;
        private readonly U map;

        public MapWithSetBombersGeneric(int pictureWidth, int pictureHeight, U map)
        {
            int width = pictureWidth / placeSizeWidth;
            int height = pictureHeight / placeSizeHeight;
            setBombers = new SetBombersGeneric<T>(width * height);
            this.pictureHeight = pictureHeight;
            this.pictureWidth = pictureWidth;
            this.map = map;
        }

        public static bool operator +(MapWithSetBombersGeneric<T, U> map, T entity)
        {
            return map.setBombers.Insert(entity);
        }

        public static bool operator -(MapWithSetBombersGeneric<T, U> map, int pos)
        {
            return map.setBombers.Remove(pos);
        }

        public Bitmap ShowSet()
        {
            Bitmap bitmap = new(pictureWidth, pictureHeight);
            Graphics gr = Graphics.FromImage(bitmap);
            DrawBackground(gr);
            DrawEntities(gr);
            return bitmap;
        }

        public Bitmap ShowOnMap()
        {
            Shaking();
            foreach (var entity in setBombers.GetEntities())
            {
                return map.CreateMap(pictureWidth, pictureHeight, entity);
            }

            return new (pictureWidth, pictureHeight);
        }

        public Bitmap MoveObject(Direction direction)
        {
            if (map != null) 
            {
                return map.MoveObject(direction);
            }
            return new(pictureWidth, pictureHeight);
        }

        private void Shaking() 
        {
            var j = setBombers.Count - 1;
            for (int i = 0; i < setBombers.Count; i++)
            {
                if (setBombers[i] == null)
                {
                    for (; j > i; j--)
                    {
                        var bomber = setBombers[j];
                        if (bomber != null)
                        {
                            setBombers.Insert(bomber, j);
                            setBombers.Remove(j);
                            break;
                        }
                    }
                    if (j <= i)
                    {
                        return;
                    }
                }
            }
        }

        private void DrawEntities(Graphics graphics)
        {
            for (int i = 0; i < setBombers.Count; i++)
            {
                setBombers[i]?.DrawningObject(graphics);
            }
        }

        private void DrawBackground(Graphics graphics)
        {
            Pen pen = new (Color.Black, 3);
            for (int i = 0; i < pictureWidth / placeSizeWidth; i++)
            {
                for (int j = 0; j < pictureHeight / placeSizeHeight + 1; ++j)
                {
                    graphics.DrawLine(pen, i * placeSizeWidth, j * placeSizeHeight, i * placeSizeWidth + placeSizeWidth / 2, j * placeSizeHeight);
                }
                graphics.DrawLine(pen, i * placeSizeWidth, 0, i * placeSizeWidth, (pictureHeight / placeSizeHeight) * placeSizeHeight);
            }
        }
    }
}
