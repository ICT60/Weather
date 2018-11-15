using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Net.Http;
using System.Threading.Tasks;

namespace Weather
{
    public partial class MainForm : Form
    {
        Request request;
        Respond respond;

        public MainForm()
        {
            InitializeComponent();
        }

        void MainForm_Load(object sender, EventArgs e)
        {
            Initialize();
            Program.SettingForm.LoadSetting();
        }

        void Initialize()
        {
            respond = new Respond();
            request = new Request();
            lblWeather.Text = string.Empty;
        }

        void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.SettingForm.ShowDialog();
        }

        async void btnSync_Click(object sender, EventArgs e)
        {
            try
            {
                toolStripLabel.Text = "Connecting...";

                request
                    .ResetParameters()
                    .SetCityID(Setting.SaveInfo.SelectedCityID)
                    .SetTemperatureUnit(TemperatureUnit.CELSIUS)
                    .SetAPIKey(Setting.SaveInfo.APIKEY);

                respond = await request.GetRespond();
                await UpdateWeatherUI(respond);
            }
            catch (HttpRequestException exception)
            {
                NotifyErrorInUI();
            }
            catch (Exception exception)
            {
                NotifyErrorInUI();
            }
        }

        async Task<Image> GetWeatherIcon(string icon)
        {
            string weatherIconUriFormat = "http://openweathermap.org/img/w/{0}.png";
            Image image = null;

            try
            {
                HttpClient client = new HttpClient();
                Stream stream = await client.GetStreamAsync(string.Format(weatherIconUriFormat, icon));
                image = Image.FromStream(stream);
            }
            catch (Exception e)
            {
                NotifyErrorInUI();
            }

            return image;
        }

        async Task UpdateWeatherUI(Respond respond)
        {
            if (respond == null) {
                NotifyErrorInUI();
                return;
            }

            string titleBarTextFormat = "Weather : ({0})";
            Text = string.Format(titleBarTextFormat, Setting.SaveInfo.SelectedCityName);

            lblWeather.Text = (respond.Weather?.Main?.ToString());

            rchWeatherInfo.Text = ("[ City ]" + Environment.NewLine);
            rchWeatherInfo.Text += (Setting.SaveInfo.SelectedCityName + Environment.NewLine);
            rchWeatherInfo.Text += (Environment.NewLine);
            rchWeatherInfo.Text += (respond.Weather?.ToString() + Environment.NewLine);
            rchWeatherInfo.Text += (respond.Wind?.ToString() + Environment.NewLine);
            rchWeatherInfo.Text += (respond.Main?.ToString() + Environment.NewLine);
            rchWeatherInfo.Text += (respond.Cloud?.ToString() + Environment.NewLine);
            rchWeatherInfo.Text += (respond.SnowVolume?.ToString() + Environment.NewLine);
            rchWeatherInfo.Text += (respond.SystemInfo?.ToString() + Environment.NewLine);
            rchWeatherInfo.Text += (respond.RainVolume?.ToString() + Environment.NewLine);

            pictureBox.Image = await GetWeatherIcon(respond.Weather.Icon);
            toolStripLabel.Text = ("Last Sync : " + DateTime.Now.ToString("MM/d/yyyy (HH:mm:ss tt)"));
        }

        void NotifyErrorInUI()
        {
            Text = "Weather";
            lblWeather.Text = "";
            pictureBox.Image = null;
            rchWeatherInfo.Text = ("Error : Can't get data from server," + Environment.NewLine);
            rchWeatherInfo.Text += ("Please check if api key is valid," + Environment.NewLine);
            rchWeatherInfo.Text += ("And check internet connection." + Environment.NewLine);
            toolStripLabel.Text = ("Failed to sync..." + Environment.NewLine);
        }
    }
}
