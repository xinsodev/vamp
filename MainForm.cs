using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using VAMP.Services;

namespace VAMP
{
    public partial class MainForm : Form
    {
        public static MainForm Instance { get; private set; }

        public JObject Configs { get; set; } = new JObject();

        public List<Service> Services { get; private set; } = new List<Service>();

        public MainForm()
        {
            Instance = this;

            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CreateServices();
            LoadConfigs();
        }

        private void CreateServices()
        {
            this.Services.Add(new MySQL());
            this.Services.Add(new Nginx());
        }

        private void LoadConfigs()
        {
            if (!File.Exists(VAMP.Configs.FilePath))
            {
                foreach (var service in this.Services)
                {
                    if (service.IsAvailable)
                    {
                        this.Configs.Add(new JProperty(service.Key, service.GetDefaultConfigs()));
                    }
                }

                VAMP.Configs.Save(Configs);
            }
            else
            {
                this.Configs = VAMP.Configs.Load();
            }
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            new SettingsForm().ShowDialog();
        }
    }
}