using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

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

        public void AddMap(string name, AbstractMap map) => mapStorage.Add(name, new MapWithSetBombersGeneric<IDrawningObject, AbstractMap>(pictureWidth, pictureHeight, map));

        public void RemoveMap(string name) => mapStorage.Remove(name); // обработка исключений? если попытаться удалить запись по ключу, которого не существует => дропнет исключение

        public MapWithSetBombersGeneric<IDrawningObject, AbstractMap> this[string name] => mapStorage[name] ?? null;

        public static void WriteToFile(string text, FileStream stream)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(text);
            stream.Write(info, 0, info.Length);
        }

        public bool SaveData(string filePath)
        {
            if (File.Exists(filePath)) File.Delete(filePath);

            try
            {
                using (FileStream fs = new(filePath, FileMode.Create))
                {
                    WriteToFile($"MapsCollection{Environment.NewLine}", fs);

                    foreach (var storage in mapStorage)
                    {
                        WriteToFile($"{storage.Key}{separatorDict}{storage.Value.GetData(separatorDict, separatorData)}{Environment.NewLine}", fs);
                    }

                    return true;
                }
            }
            catch { return false; }
        }

        public bool LoadData(string filePath)
        {
            if (!File.Exists(filePath)) return false;

            string bufferTextFromFile = "";

            try
            {
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

                if (!strs[0].Contains("MapsCollection")) return false;

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

                return true;
            }
            catch { return false; }
        }
    }
}
