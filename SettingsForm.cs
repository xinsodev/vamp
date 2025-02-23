using System.Linq;
using System.Windows.Forms;
using VAMP.UI.Forms;

namespace VAMP
{
    public partial class SettingsForm : LocalizedForm
    {
        public static SettingsForm Instance { get; private set; }

        private bool _settingsLoaded;

        public SettingsForm()
        {
            Instance = this;

            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, System.EventArgs e)
        {
            LoadSettings();
        }

        private void LoadSettings()
        {
            Core.LoadConfigs();

            LoadGeneralSettings();
            LoadServiceSettings();

            _settingsLoaded = true;
        }

        private void SaveSettings()
        {
            if (!_settingsLoaded)
            {
                return;
            }

            Core.SaveConfigs();
        }

        private void LoadGeneralSettings()
        {
            RunOnStartupCheckBox.Checked = Core.Configs["general"]["run"].Value<bool>("startup");
            MinimizeOnRunCheckBox.Checked = Core.Configs["general"]["run"].Value<bool>("minimize");
            AutoStartCheckBox.Checked = Core.Configs["general"]["run"].Value<bool>("auto");

            var language = Core.Configs["general"].Value<string>("language");
            foreach (var item in Core.Languages)
            {
                LanguageComboBox.Items.Add(new ComboBoxItem() { Text = item.DisplayName, Value = item.Name });

                if (item.Name == language)
                {
                    LanguageComboBox.SelectedItem = LanguageComboBox.Items[LanguageComboBox.Items.Count - 1];
                }
            }

            RootDirectoryTextBox.Text = Core.Configs["general"]["directories"].Value<string>("root");
            DataDirectoryTextBox.Text = Core.Configs["general"]["directories"].Value<string>("data");

            AutoHostsCheckBox.Checked = Core.Configs["general"]["domain"].Value<bool>("auto");
            DomainExtTextBox.Text = Core.Configs["general"]["domain"].Value<string>("extension");
        }

        private void LoadServiceSettings()
        {
            // TODO
        }

        private void RunOnStartupCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            Core.Configs["general"]["run"]["startup"] = RunOnStartupCheckBox.Checked;
            SaveSettings();
        }

        private void MinimizeOnRunCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            Core.Configs["general"]["run"]["minimize"] = MinimizeOnRunCheckBox.Checked;
            SaveSettings();
        }

        private void AutoStartCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            Core.Configs["general"]["run"]["auto"] = AutoStartCheckBox.Checked;
            SaveSettings();
        }

        private void LanguageComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            var language = (string)(LanguageComboBox.SelectedItem as ComboBoxItem).Value;
            Core.Culture = Core.Languages.FirstOrDefault(x => x.Name == language);
            Core.Configs["general"]["language"] = language;
            SaveSettings();
        }

        private void RootDirectoryTextBox_Click(object sender, System.EventArgs e)
        {
            var folder = new FolderBrowserDialog();
            if (folder.ShowDialog() == DialogResult.OK)
            {
                RootDirectoryTextBox.Text = folder.SelectedPath;
            }
        }

        private void RootDirectoryButton_Click(object sender, System.EventArgs e)
        {
            var folder = new FolderBrowserDialog();
            if (folder.ShowDialog() == DialogResult.OK)
            {
                RootDirectoryTextBox.Text = folder.SelectedPath;
            }
        }

        private void RootDirectoryTextBox_TextChanged(object sender, System.EventArgs e)
        {
            Core.Configs["general"]["directories"]["root"] = RootDirectoryTextBox.Text.Trim();
            SaveSettings();
        }

        private void DataDirectoryTextBox_Click(object sender, System.EventArgs e)
        {
            var folder = new FolderBrowserDialog();
            if (folder.ShowDialog() == DialogResult.OK)
            {
                DataDirectoryTextBox.Text = folder.SelectedPath;
            }
        }

        private void DataDirectoryButton_Click(object sender, System.EventArgs e)
        {
            var folder = new FolderBrowserDialog();
            if (folder.ShowDialog() == DialogResult.OK)
            {
                DataDirectoryTextBox.Text = folder.SelectedPath;
            }
        }

        private void DataDirectoryTextBox_TextChanged(object sender, System.EventArgs e)
        {
            Core.Configs["general"]["directories"]["data"] = DataDirectoryTextBox.Text.Trim();
            SaveSettings();
        }

        private void AutoHostsChecBox_CheckedChanged(object sender, System.EventArgs e)
        {
            Core.Configs["general"]["domain"]["auto"] = AutoHostsCheckBox.Checked;
            SaveSettings();
        }

        private void DomainExtTextBox_TextChanged(object sender, System.EventArgs e)
        {
            Core.Configs["general"]["domain"]["extension"] = DomainExtTextBox.Text.Trim();
            SaveSettings();
        }

        private void DomainExtTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}