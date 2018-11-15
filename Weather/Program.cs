using System;
using System.Windows.Forms;

namespace Weather
{
    static class Program
    {
        public static MainForm MainForm { get; set; }
        public static SettingForm SettingForm { get; set; }
        public static AboutForm AboutForm { get; set; }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainForm = new MainForm();
            SettingForm = new SettingForm();
            AboutForm = new AboutForm();

            Application.Run(MainForm);
        }
    }
}
