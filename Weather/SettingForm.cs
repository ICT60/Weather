using System;
using System.IO;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace Weather
{
    public partial class SettingForm : Form
    {
        public string selectedCityID;
        public string selectedCity;
        public string selectedCountry;

        List<City> cityList;
        List<string> countryNames;

        SaveInfo saveInfo;


        public SettingForm()
        {
            InitializeComponent();
            Initialize();
        }

        void SettingForm_Load(object sender, EventArgs e)
        {
            //File.Delete(Setting.SAVE_PATH);
        }

        void SettingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        void cmbCountryName_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstCityName.Items.Clear();

            selectedCountry = cmbCountryName.Items[cmbCountryName.SelectedIndex].ToString();
            saveInfo.SelectedCountryCode = selectedCountry;

            foreach (City city in cityList)
            {
                if (city.Country != selectedCountry)
                    continue;

                lstCityName.Items.Add(city.Name);
            }
        }

        void btnApplySetting_Click(object sender, EventArgs e)
        {
            if (lstCityName.SelectedIndex < 0) {
                MessageBox.Show("Please select a city.", "Error");
                return;
            }

            if (string.IsNullOrEmpty(txtApiKey.Text)) {
                MessageBox.Show("Please insert an API Key.", "Error");
                return;
            }

            selectedCity = lstCityName.Items[lstCityName.SelectedIndex].ToString();
            saveInfo.SelectedCityName = selectedCity;

            foreach (City city in cityList)
            {
                if (city.Country != selectedCountry)
                    continue;

                if (city.Name != selectedCity)
                    continue;

                selectedCityID = city.ID;
                saveInfo.SelectedCityID = selectedCityID;
                break;
            }

            saveInfo.APIKEY = txtApiKey.Text;
            Setting.Save(Setting.SAVE_PATH, saveInfo);

            Hide();
        }

        void Initialize()
        {
            saveInfo = new SaveInfo();

            string cityListJson = string.Empty;
            byte[] cityListFile = Properties.Resources.CityList;

            Assembly assembly = Assembly.GetExecutingAssembly();

            using (Stream resourceStream = new MemoryStream(cityListFile))
            {
                using (StreamReader streamReader = new StreamReader(resourceStream))
                {
                    cityListJson = streamReader.ReadToEnd();
                }
            }

            cityList = new List<City>();
            countryNames = new List<string>();

            try
            {
                JArray cityListArray = JArray.Parse(cityListJson);

                for (int i = 0; i < cityListArray.Count; ++i)
                {
                    City city = cityListArray[i].ToObject<City>();

                    if (!countryNames.Contains(city.Country)) {
                        countryNames.Add(city.Country);
                    }

                    cityList.Add(city);
                }

                string[] countryArray = countryNames.ToArray();
                Array.Sort(countryArray);

                foreach (string name in countryArray)
                {
                    cmbCountryName.Items.Add(name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex.ToString());
            }
        }

        public void LoadSetting()
        {
            if (Setting.IsSaveFileExist()) {
                saveInfo = Setting.Load(Setting.SAVE_PATH);
                UpdateUI(saveInfo);
                Hide();
            }
            else {
                MessageBox.Show("No save found.\nPlease enter a valid API Key,\nSelect Country Code and City Name", "Error..");
                ShowDialog();
            }
        }

        void UpdateUI(SaveInfo info)
        {
            cmbCountryName.Text = info.SelectedCountryCode;
            lstCityName.Items.Clear();

            foreach (City city in cityList)
            {
                if (city.Country != info.SelectedCountryCode)
                    continue;

                lstCityName.Items.Add(city.Name);

                if (city.ID == info.SelectedCityID)
                    lstCityName.SelectedIndex = (lstCityName.Items.Count - 1);
            }

            txtApiKey.Text = info.APIKEY;
        }
    }
}
