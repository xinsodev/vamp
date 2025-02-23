using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using VAMP.Services;
using VAMP.UI.Forms;

namespace VAMP
{
    public static class Core
    {
        public static List<CultureInfo> Languages { get; private set; } = new List<CultureInfo>()
        {
            new CultureInfo("en"),
            new CultureInfo("vi")
        };

        public static List<Service> Services { get; private set; } = new List<Service>()
        {
            new MySQL(),
            new Nginx(),
        };

        public static JObject Configs { get; set; }

        public static CultureInfo Culture
        {
            get { return Thread.CurrentThread.CurrentUICulture; }
            set
            {
                if (Culture.Equals(value) == false)
                {
                    foreach (var form in Application.OpenForms.OfType<LocalizedForm>())
                    {
                        form.Culture = value;
                    }

                    Thread.CurrentThread.CurrentUICulture = value;
                }
            }
        }

        public static void LoadConfigs()
        {
            Configs = Json.Load();

            var cloned = Configs.DeepClone() as JObject;

            LoadServices();
            LoadSettings();

            if (!JToken.DeepEquals(Configs, cloned))
            {
                Json.Save(Configs);
            }
        }

        public static void SaveConfigs()
        {
            Json.Save(Configs);
        }

        private static void LoadServices()
        {
            foreach (var service in Services)
            {
                service.GetVersions();

                if (!service.IsAvailable)
                {
                    if (Configs.ContainsKey(service.Key))
                    {
                        Configs.Remove(service.Key);
                    }
                    continue;
                }

                if (!Configs.ContainsKey(service.Key) || Configs[service.Key].Type != JTokenType.Object)
                {
                    Configs[service.Key] = service.GetConfigs();
                    continue;
                }

                var version = Configs.Value<JObject>(service.Key).Value<string>("version");
                if (!service.Versions.Contains(version))
                {
                    Configs[service.Key]["version"] = service.Versions[0];
                }
            }
        }

        private static void LoadSettings()
        {
            if (!Configs.ContainsKey("general") || Configs["general"].Type != JTokenType.Object)
            {
                Configs["general"] = new JObject();
            }

            // Run settings
            if (!Configs.Value<JObject>("general").ContainsKey("run") ||
                Configs["general"]["run"].Type != JTokenType.Object)
            {
                Configs["general"]["run"] = new JObject();
            }

            if (!Configs.Value<JObject>("general").Value<JObject>("run").ContainsKey("startup") ||
                Configs["general"]["run"]["startup"].Type != JTokenType.Boolean)
            {
                Configs["general"]["run"]["startup"] = true;
            }

            if (!Configs.Value<JObject>("general").Value<JObject>("run").ContainsKey("minimize") ||
                Configs["general"]["run"]["minimize"].Type != JTokenType.Boolean)
            {
                Configs["general"]["run"]["minimize"] = true;
            }

            if (!Configs.Value<JObject>("general").Value<JObject>("run").ContainsKey("auto") ||
                Configs["general"]["run"]["auto"].Type != JTokenType.Boolean)
            {
                Configs["general"]["run"]["auto"] = true;
            }

            // Language settings
            if (!Configs.Value<JObject>("general").ContainsKey("language") ||
                Configs["general"]["language"].Type != JTokenType.String ||
               !Languages.Any(x => x.Name == Configs["general"].Value<string>("language")))
            {
                Configs["general"]["language"] = "en";
            }

            Culture = Languages.FirstOrDefault(x => x.Name == (string)Configs["general"]["language"]);

            // Directory settings
            if (!Configs.Value<JObject>("general").ContainsKey("directories") ||
                Configs["general"]["directories"].Type != JTokenType.Object)
            {
                Configs["general"]["directories"] = new JObject();
            }

            if (!Configs.Value<JObject>("general").Value<JObject>("directories").ContainsKey("root") ||
                Configs["general"]["directories"]["root"].Type != JTokenType.String)
            {
                Configs["general"]["directories"]["root"] = Directory.GetCurrentDirectory() + "\\www";
            }

            if (!Configs.Value<JObject>("general").Value<JObject>("directories").ContainsKey("data") ||
                Configs["general"]["directories"]["data"].Type != JTokenType.String)
            {
                Configs["general"]["directories"]["data"] = Directory.GetCurrentDirectory() + "\\data";
            }

            // Domain settings
            if (!Configs.Value<JObject>("general").ContainsKey("domain") ||
                Configs["general"]["domain"].Type != JTokenType.Object)
            {
                Configs["general"]["domain"] = new JObject();
            }

            if (!Configs.Value<JObject>("general").Value<JObject>("domain").ContainsKey("extension") ||
                Configs["general"]["domain"]["extension"].Type != JTokenType.String)
            {
                Configs["general"]["domain"]["extension"] = ".test";
            }

            if (!Configs.Value<JObject>("general").Value<JObject>("domain").ContainsKey("auto") ||
                Configs["general"]["domain"]["auto"].Type != JTokenType.Boolean)
            {
                Configs["general"]["domain"]["auto"] = true;
            }
        }
    }
}