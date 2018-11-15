using System;
using System.IO;
using System.Windows.Forms;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Weather
{
    class SaveInfo
    {
        public string SelectedCountryCode { get; set; }
        public string SelectedCityID { get; set; }
        public string SelectedCityName { get; set; }
        public string APIKEY { get; set; }
    }

    class Setting
    {
        public static string SAVE_FILE_NAME = "weatherSetting.json";
        public static string SAVE_PATH = (Application.UserAppDataPath + "\\" + SAVE_FILE_NAME);

        public static SaveInfo SaveInfo { get; private set; }


        public static bool IsSaveFileExist()
        {
            return File.Exists(SAVE_PATH);
        }
        
        public static void Save(string path, SaveInfo info)
        {
            try
            {
                SaveInfo = info;
                string json = JsonConvert.SerializeObject(info);

                if (json == null) {
                    throw new Exception("Empty save info...");
                }

                if (!File.Exists(path)) {
                    using (FileStream fileStream = File.Create(path))
                    {
                        Byte[] byteInfo = new UTF8Encoding(true).GetBytes(json);
                        fileStream.Write(byteInfo, 0, byteInfo.Length);
                    }
                }
                else {
                    File.WriteAllText(path, json);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Can't save setting, " + e.ToString());
            }
        }

        public static SaveInfo Load(string path)
        {
            bool isFileExist = File.Exists(path);

            try
            {
                if (!isFileExist) {
                    throw new FileNotFoundException();
                }

                string json = File.ReadAllText(path);
                JObject saveObject = JObject.Parse(json);
                SaveInfo = saveObject.ToObject<SaveInfo>();
            }
            catch (Exception e)
            {
                MessageBox.Show("Can't load setting, " + e.ToString());
            }

            return SaveInfo;
        }
    }
}
