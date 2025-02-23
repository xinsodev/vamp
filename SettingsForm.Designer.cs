namespace VAMP
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.SettingsPanel = new System.Windows.Forms.Panel();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.GeneralPage = new System.Windows.Forms.TabPage();
            this.DomainExtTextBox = new System.Windows.Forms.TextBox();
            this.DomainExtLabel = new System.Windows.Forms.Label();
            this.DataDirectoryButton = new System.Windows.Forms.Button();
            this.RootDirectoryButton = new System.Windows.Forms.Button();
            this.DataDirectoryTextBox = new System.Windows.Forms.TextBox();
            this.DataDirectoryLabel = new System.Windows.Forms.Label();
            this.RootDirectoryTextBox = new System.Windows.Forms.TextBox();
            this.RootDirectoryLabel = new System.Windows.Forms.Label();
            this.LanguageComboBox = new System.Windows.Forms.ComboBox();
            this.LanguageLabel = new System.Windows.Forms.Label();
            this.AutoStartCheckBox = new System.Windows.Forms.CheckBox();
            this.MinimizeOnRunCheckBox = new System.Windows.Forms.CheckBox();
            this.AutoHostsCheckBox = new System.Windows.Forms.CheckBox();
            this.RunOnStartupCheckBox = new System.Windows.Forms.CheckBox();
            this.ServicesPage = new System.Windows.Forms.TabPage();
            this.SettingsPanel.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.GeneralPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // SettingsPanel
            // 
            this.SettingsPanel.Controls.Add(this.TabControl);
            resources.ApplyResources(this.SettingsPanel, "SettingsPanel");
            this.SettingsPanel.Name = "SettingsPanel";
            // 
            // TabControl
            // 
            resources.ApplyResources(this.TabControl, "TabControl");
            this.TabControl.Controls.Add(this.GeneralPage);
            this.TabControl.Controls.Add(this.ServicesPage);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            // 
            // GeneralPage
            // 
            this.GeneralPage.Controls.Add(this.DomainExtTextBox);
            this.GeneralPage.Controls.Add(this.DomainExtLabel);
            this.GeneralPage.Controls.Add(this.DataDirectoryButton);
            this.GeneralPage.Controls.Add(this.RootDirectoryButton);
            this.GeneralPage.Controls.Add(this.DataDirectoryTextBox);
            this.GeneralPage.Controls.Add(this.DataDirectoryLabel);
            this.GeneralPage.Controls.Add(this.RootDirectoryTextBox);
            this.GeneralPage.Controls.Add(this.RootDirectoryLabel);
            this.GeneralPage.Controls.Add(this.LanguageComboBox);
            this.GeneralPage.Controls.Add(this.LanguageLabel);
            this.GeneralPage.Controls.Add(this.AutoStartCheckBox);
            this.GeneralPage.Controls.Add(this.MinimizeOnRunCheckBox);
            this.GeneralPage.Controls.Add(this.AutoHostsCheckBox);
            this.GeneralPage.Controls.Add(this.RunOnStartupCheckBox);
            resources.ApplyResources(this.GeneralPage, "GeneralPage");
            this.GeneralPage.Name = "GeneralPage";
            this.GeneralPage.UseVisualStyleBackColor = true;
            // 
            // DomainExtTextBox
            // 
            resources.ApplyResources(this.DomainExtTextBox, "DomainExtTextBox");
            this.DomainExtTextBox.Name = "DomainExtTextBox";
            this.DomainExtTextBox.TextChanged += new System.EventHandler(this.DomainExtTextBox_TextChanged);
            this.DomainExtTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DomainExtTextBox_KeyDown);
            // 
            // DomainExtLabel
            // 
            resources.ApplyResources(this.DomainExtLabel, "DomainExtLabel");
            this.DomainExtLabel.Name = "DomainExtLabel";
            // 
            // DataDirectoryButton
            // 
            resources.ApplyResources(this.DataDirectoryButton, "DataDirectoryButton");
            this.DataDirectoryButton.Name = "DataDirectoryButton";
            this.DataDirectoryButton.UseVisualStyleBackColor = true;
            this.DataDirectoryButton.Click += new System.EventHandler(this.DataDirectoryButton_Click);
            // 
            // RootDirectoryButton
            // 
            resources.ApplyResources(this.RootDirectoryButton, "RootDirectoryButton");
            this.RootDirectoryButton.Name = "RootDirectoryButton";
            this.RootDirectoryButton.UseVisualStyleBackColor = true;
            this.RootDirectoryButton.Click += new System.EventHandler(this.RootDirectoryButton_Click);
            // 
            // DataDirectoryTextBox
            // 
            this.DataDirectoryTextBox.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.DataDirectoryTextBox, "DataDirectoryTextBox");
            this.DataDirectoryTextBox.Name = "DataDirectoryTextBox";
            this.DataDirectoryTextBox.ReadOnly = true;
            this.DataDirectoryTextBox.Click += new System.EventHandler(this.DataDirectoryTextBox_Click);
            this.DataDirectoryTextBox.TextChanged += new System.EventHandler(this.DataDirectoryTextBox_TextChanged);
            // 
            // DataDirectoryLabel
            // 
            resources.ApplyResources(this.DataDirectoryLabel, "DataDirectoryLabel");
            this.DataDirectoryLabel.Name = "DataDirectoryLabel";
            // 
            // RootDirectoryTextBox
            // 
            this.RootDirectoryTextBox.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.RootDirectoryTextBox, "RootDirectoryTextBox");
            this.RootDirectoryTextBox.Name = "RootDirectoryTextBox";
            this.RootDirectoryTextBox.ReadOnly = true;
            this.RootDirectoryTextBox.Click += new System.EventHandler(this.RootDirectoryTextBox_Click);
            this.RootDirectoryTextBox.TextChanged += new System.EventHandler(this.RootDirectoryTextBox_TextChanged);
            // 
            // RootDirectoryLabel
            // 
            resources.ApplyResources(this.RootDirectoryLabel, "RootDirectoryLabel");
            this.RootDirectoryLabel.Name = "RootDirectoryLabel";
            // 
            // LanguageComboBox
            // 
            this.LanguageComboBox.DisplayMember = "Text";
            this.LanguageComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LanguageComboBox.FormattingEnabled = true;
            resources.ApplyResources(this.LanguageComboBox, "LanguageComboBox");
            this.LanguageComboBox.Name = "LanguageComboBox";
            this.LanguageComboBox.ValueMember = "Value";
            this.LanguageComboBox.SelectedIndexChanged += new System.EventHandler(this.LanguageComboBox_SelectedIndexChanged);
            // 
            // LanguageLabel
            // 
            resources.ApplyResources(this.LanguageLabel, "LanguageLabel");
            this.LanguageLabel.Name = "LanguageLabel";
            // 
            // AutoStartCheckBox
            // 
            resources.ApplyResources(this.AutoStartCheckBox, "AutoStartCheckBox");
            this.AutoStartCheckBox.Name = "AutoStartCheckBox";
            this.AutoStartCheckBox.UseVisualStyleBackColor = true;
            this.AutoStartCheckBox.CheckedChanged += new System.EventHandler(this.AutoStartCheckBox_CheckedChanged);
            // 
            // MinimizeOnRunCheckBox
            // 
            resources.ApplyResources(this.MinimizeOnRunCheckBox, "MinimizeOnRunCheckBox");
            this.MinimizeOnRunCheckBox.Name = "MinimizeOnRunCheckBox";
            this.MinimizeOnRunCheckBox.UseVisualStyleBackColor = true;
            this.MinimizeOnRunCheckBox.CheckedChanged += new System.EventHandler(this.MinimizeOnRunCheckBox_CheckedChanged);
            // 
            // AutoHostsCheckBox
            // 
            resources.ApplyResources(this.AutoHostsCheckBox, "AutoHostsCheckBox");
            this.AutoHostsCheckBox.Name = "AutoHostsCheckBox";
            this.AutoHostsCheckBox.UseVisualStyleBackColor = true;
            this.AutoHostsCheckBox.CheckedChanged += new System.EventHandler(this.AutoHostsChecBox_CheckedChanged);
            // 
            // RunOnStartupCheckBox
            // 
            resources.ApplyResources(this.RunOnStartupCheckBox, "RunOnStartupCheckBox");
            this.RunOnStartupCheckBox.Name = "RunOnStartupCheckBox";
            this.RunOnStartupCheckBox.UseVisualStyleBackColor = true;
            this.RunOnStartupCheckBox.CheckedChanged += new System.EventHandler(this.RunOnStartupCheckBox_CheckedChanged);
            // 
            // ServicesPage
            // 
            resources.ApplyResources(this.ServicesPage, "ServicesPage");
            this.ServicesPage.Name = "ServicesPage";
            this.ServicesPage.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SettingsPanel);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.SettingsPanel.ResumeLayout(false);
            this.TabControl.ResumeLayout(false);
            this.GeneralPage.ResumeLayout(false);
            this.GeneralPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SettingsPanel;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage GeneralPage;
        private System.Windows.Forms.TabPage ServicesPage;
        private System.Windows.Forms.CheckBox RunOnStartupCheckBox;
        private System.Windows.Forms.CheckBox MinimizeOnRunCheckBox;
        private System.Windows.Forms.CheckBox AutoStartCheckBox;
        private System.Windows.Forms.Label LanguageLabel;
        private System.Windows.Forms.ComboBox LanguageComboBox;
        private System.Windows.Forms.Label RootDirectoryLabel;
        private System.Windows.Forms.TextBox RootDirectoryTextBox;
        private System.Windows.Forms.Button RootDirectoryButton;
        private System.Windows.Forms.Button DataDirectoryButton;
        private System.Windows.Forms.TextBox DataDirectoryTextBox;
        private System.Windows.Forms.Label DataDirectoryLabel;
        private System.Windows.Forms.CheckBox AutoHostsCheckBox;
        private System.Windows.Forms.Label DomainExtLabel;
        private System.Windows.Forms.TextBox DomainExtTextBox;
    }
}