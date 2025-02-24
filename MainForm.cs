using System;
using VAMP.UI.Forms;

namespace VAMP
{
    public partial class MainForm : LocalizedForm
    {
        public static MainForm Instance { get; private set; }

        public MainForm()
        {
            Instance = this;

            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Core.LoadConfigs();
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            new SettingsForm().ShowDialog();
        }
    }
}