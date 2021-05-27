using System;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public double tempSize = 0;
        public double tSize = 0;
        public Form1()
        {
            InitializeComponent();
            this.osLabel.Text = Environment.OSVersion.ToString();
            this.razLabel.Text = Environment.Is64BitOperatingSystem ? "64 бита" : "32 бита";
            this.userlabel.Text = Environment.UserName.ToString();
            if (CheckNet())
            {
                this.connectionLabel.Text = "Подключено";
                this.pingLabel.Text = GetPing("google.com");
            }
            else
            {
                this.connectionLabel.Text = "Не подключено";
                MessageBox.Show("Интернет сединение не подключено!");
            }
        }

        [System.Runtime.InteropServices.DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int Description, int ReservedValue);

        public static bool CheckNet()
        {
            return InternetGetConnectedState(out _, 0);
        }

        public string GetPing(string hostName)
        {
            var pingTime = "NONE";
            var ping = new Ping();
            PingReply pingReply = ping.Send(hostName);
            if (pingReply.Status != IPStatus.TimedOut)
            {
                pingTime = pingReply.RoundtripTime.ToString();
            }
            return $"{hostName} - {pingTime} ms";
        }

        private void AnalyzeButtonClick(object sender, EventArgs e)
        {
            this.rubbishLabel.Text = GetTempFolderSize() + " MB";
        }

        public void ClearFolder(string folder)
        {
            int progress;
            DirectoryInfo di = new DirectoryInfo(folder);
            DirectoryInfo[] diA = di.GetDirectories();
            FileInfo[] fi = di.GetFiles();
            foreach (FileInfo f in fi)
            {
                tSize -= f.Length;
                this.deleteLabel.Text = "Удаляется - " + f.Name;
                progress = (int)((tempSize - tSize) / tempSize * 100);
                if (progress > 100)
                {
                    progress = 100;
                }
                this.deleteProgressBar.Value = progress;
                try
                {
                    this.resultLabel.Text = "Результат - УДАЛЕНО!";
                    f.Delete();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Произошла ошибка. Ошибка: " + ex.Message);
                    this.resultLabel.Text = "Результат - " + ex.Message;
                }

            }
            foreach (DirectoryInfo df in diA)
            {
                ClearFolder(df.FullName);
                if (df.GetDirectories().Length == 0 && df.GetFiles().Length == 0)
                {
                    df.Delete();
                }
            }
        }

        private static double SizeOfFolder(string folder, ref double catalogSize)
        {
            try
            {
                DirectoryInfo di = new DirectoryInfo(folder);
                DirectoryInfo[] diA = di.GetDirectories();
                FileInfo[] fi = di.GetFiles();
                foreach (FileInfo f in fi)
                {
                    catalogSize += f.Length;
                }
                foreach (DirectoryInfo df in diA)
                {
                    SizeOfFolder(df.FullName, ref catalogSize);
                }
                return Math.Round((double)(catalogSize / 1024 / 1024), 1);
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine("Директория не найдена. Ошибка: " + ex.Message);
                return 0;
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine("Отсутствует доступ. Ошибка: " + ex.Message);
                return 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Произошла ошибка. Ошибка: " + ex.Message);
                return 0;
            }
        }
        public string GetTempFolderSize()
        {
            double catalogSize = 0;
            string tempPath = Path.GetTempPath();
            catalogSize = SizeOfFolder(tempPath, ref catalogSize);
            tSize = tempSize = catalogSize * 1024 * 1024;
            return catalogSize.ToString();
        }
        private void ClearButtonClick(object sender, EventArgs e)
        {
            ClearFolder(Path.GetTempPath());
            this.deleteProgressBar.Value = 100;
        }

        private void ButtonToDClick(object sender, EventArgs e)
        {
            string t = this.textBoxFromD.Text;
            if (!string.IsNullOrEmpty(t))
            {
                int d = Convert.ToInt32(t);
                this.textBoxToC.Text = Convert.ToString(d, 2);
            }
        }

        private void ButtonToСClick(object sender, EventArgs e)
        {
            string t = this.textBoxFromC.Text;
            if (!string.IsNullOrEmpty(t))
            {
                int d = Convert.ToInt32(t, 2);
                this.textBoxToD.Text = Convert.ToString(d, 10);
            }
        }
    }
}
