using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;

namespace VAMP
{
    public static class Json
    {
        public static JObject Load(string path = "vamp.json")
        {
            if (!File.Exists(path))
            {
                return new JObject();
            }

            using (var file = File.OpenText(path))
            using (var reader = new JsonTextReader(file))
            {
                return (JObject)JToken.ReadFrom(reader);
            }
        }

        public static void Save(JObject config, string path = "vamp.json")
        {
            using (var file = File.CreateText(path))
            using (var writer = new JsonTextWriter(file) { Formatting = Formatting.Indented })
            {
                config.WriteTo(writer);
            }
        }
    }
}