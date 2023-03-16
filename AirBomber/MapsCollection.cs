using System.Text;

namespace AirBomber
{
    public class MapsCollection
    {
        readonly Dictionary<string, MapWithSetBombersGeneric<IDrawningObject, AbstractMap>> mapStorage;
        public IList<string> Keys => mapStorage.Keys.ToList();
        private readonly int pictureWidth;
        private readonly int pictureHeight;
        private readonly char separatorDict = '|';
        private readonly char separatorData = ';';

        public MapsCollection(int pictureWidth, int pictureHeight)
        {
            mapStorage = new();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
        }

        public void AddMap(string name, AbstractMap map)
        {
            if (mapStorage.ContainsKey(name)) return;

            mapStorage.Add(name, new MapWithSetBombersGeneric<IDrawningObject, AbstractMap>(pictureWidth, pictureHeight, map));
        }

        public void RemoveMap(string name)
        {
            if (!mapStorage.ContainsKey(name)) return;

            mapStorage.Remove(name);
        }

        public MapWithSetBombersGeneric<IDrawningObject, AbstractMap> this[string name] => mapStorage[name] ?? null;

        public static void WriteToFile(string text, FileStream stream)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(text);
            stream.Write(info, 0, info.Length);
        }

        public void SaveData(string filePath)
        {
            if (File.Exists(filePath)) File.Delete(filePath);

            using (FileStream fs = new(filePath, FileMode.Create))
            {
                WriteToFile($"MapsCollection{Environment.NewLine}", fs);

                foreach (var storage in mapStorage)
                {
                    WriteToFile($"{storage.Key}{separatorDict}{storage.Value.GetData(separatorDict, separatorData)}{Environment.NewLine}", fs);
                }
            }
        }

        public void LoadData(string filePath)
        {
            if (!File.Exists(filePath)) throw new FileNotFoundException("Файл не найден");

            string bufferTextFromFile = "";

            using (FileStream fs = new(filePath, FileMode.Open))
            {
                byte[] b = new byte[fs.Length];
                UTF8Encoding temp = new(true);

                while (fs.Read(b, 0, b.Length) > 0)
                {
                    bufferTextFromFile += temp.GetString(b);
                }
            }
            var strs = bufferTextFromFile.Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            if (!strs[0].Contains("MapsCollection")) throw new FileFormatException("Формат данных в фалйе неправильный");

            mapStorage.Clear();

            for (int i = 1; i < strs.Length; i++)
            {
                var elem = strs[i].Split(separatorDict);

                AbstractMap map = elem[1] switch
                {
                    "SimpleMap" => new SimpleMap(),
                    "ImprovedMap" => new ImprovedMap()
                };

                mapStorage.Add(elem[0], new MapWithSetBombersGeneric<IDrawningObject, AbstractMap>(pictureWidth, pictureHeight, map));
                mapStorage[elem[0]].LoadData(elem[2].Split(separatorData, StringSplitOptions.RemoveEmptyEntries));
            }
        }
    }
}
