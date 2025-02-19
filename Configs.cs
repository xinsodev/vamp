using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;

namespace VAMP
{
    public static class Configs
    {
        public static string FilePath { get; } = @"vamp.json";

        public static JObject Load()
        {
            using (var file = File.OpenText(FilePath))
            using (var reader = new JsonTextReader(file))
            {
                return (JObject)JToken.ReadFrom(reader);
            }
        }

        public static void Save(JObject obj)
        {
            using (var file = File.CreateText(FilePath))
            using (var writer = new JsonTextWriter(file) { Formatting = Formatting.Indented })
            {
                obj.WriteTo(writer);
            }
        }
    }
}