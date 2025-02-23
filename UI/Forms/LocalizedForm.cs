using System.ComponentModel;
using System.Globalization;
using System.Windows.Forms;

namespace VAMP.UI.Forms
{
    public class LocalizedForm : Form
    {
        protected CultureInfo _culture;
        protected ComponentResourceManager _resourceManager;

        /// <summary>
        /// Gets or sets the current culture of this form.
        /// </summary>
        [Browsable(false)]
        [Description("Current culture of this form")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public CultureInfo Culture
        {
            get { return _culture; }
            set
            {
                if (_culture != value)
                {
                    _culture = value;

                    ApplyResources(this, value);
                }
            }
        }

        public LocalizedForm()
        {
            _resourceManager = new ComponentResourceManager(GetType());
        }

        private void ApplyResources(Control parent, CultureInfo culture)
        {
            if (parent is Form)
            {
                parent.Text = _resourceManager.GetString("$this.Text", culture);
            }
            else
            {
                _resourceManager.ApplyResources(parent, parent.Name, culture);
            }

            foreach (Control control in parent.Controls)
            {
                ApplyResources(control, culture);
            }
        }
    }
}