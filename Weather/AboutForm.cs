using System.Diagnostics;
using System.Windows.Forms;

namespace Weather
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        void linkToOpenWeatherMap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(linkToOpenWeatherMap.Text);
            Hide();
        }

        void AboutForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
    }
}
