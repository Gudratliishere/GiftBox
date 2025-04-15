using Newtonsoft.Json;
using System.IO;

namespace GiftBox
{
    internal class GiftService
    {
        private string FilePath = "";

        public GiftService()
        {
            FilePath = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "GiftBox", "gifts.json"
            );
            Directory.CreateDirectory(Path.GetDirectoryName(FilePath));
        }

        public List<Gift> ReadGifts()
        {
            if (File.Exists(FilePath))
            {
                var json = File.ReadAllText(FilePath);
                return JsonConvert.DeserializeObject<List<Gift>>(json);
            }
            return new List<Gift>();
        }

        public void SaveGifts(List<Gift> gifts)
        {
            var json = JsonConvert.SerializeObject(gifts, Formatting.Indented);
            File.WriteAllText(FilePath, json);
        }
    }

    public class Gift
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Period { get; set; }
        public int Priority { get; set; }
        public GiftType GiftType { get; set; }

        public override string ToString()
        {
            return $"Gift: {Name} (ID: {Id}) | Period: {Period} | Priority: {Priority} | Type: {GiftType}";
        }
    }

    public enum GiftTypeEnum
    {
        LOSE, SILVER, WIN
    }

    public class GiftType
    {
        public GiftTypeEnum Type { get; set; }
        public string DisplayName { get; set; }
    }

}
