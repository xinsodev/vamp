using Newtonsoft.Json.Linq;

namespace VAMP.Services
{
    public class Nginx : Service
    {
        public override string Key { get; } = "nginx";

        public override JObject GetConfigs()
        {
            var configs = base.GetConfigs();
            configs.Add(new JProperty("port", new JArray(80, 443)));
            configs.Add(new JProperty("https", true));
            return configs;
        }
    }
}