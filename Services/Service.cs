using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.IO;
using VAMP.Services.Enums;
using VAMP.Services.Interfaces;

namespace VAMP.Services
{
    public abstract class Service : IService
    {
        public Status Status { get; protected set; } = Status.Stopped;

        public List<string> Versions { get; protected set; } = new List<string>();

        public bool IsAvailable { get => Versions.Count > 0; }

        public virtual string Key { get; } = string.Empty;

        public virtual void Start()
        {
            Status = Status.Running;
        }

        public virtual void GetVersions()
        {
            if (string.IsNullOrEmpty(Key))
            {
                return;
            }

            if (!Directory.Exists(@"bin\" + Key))
            {
                return;
            }

            var directories = Directory.GetDirectories(@"bin\" + Key);

            Versions.Clear();

            foreach (var directory in directories)
            {
                Versions.Add(directory.Split('\\')[2]);
            }
        }

        public virtual JObject GetConfigs()
        {
            return new JObject(
                new JProperty("version", Versions[0]),
                new JProperty("active", true)
            );
        }
    }
}