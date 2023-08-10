using System.Diagnostics;

namespace switcherWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string userPass = switcher.Default.pass;
        public string userlocale = switcher.Default.locale;
        public string loc = "--locale=";

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBox1.Text = folderDlg.SelectedPath;
                Environment.SpecialFolder root = folderDlg.RootFolder;
                userPass = folderDlg.SelectedPath;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            userlocale = comboBox1.SelectedItem.ToString();
            switch (comboBox1.SelectedItem.ToString())
            {
                case "Австралийский вариант английского языка":
                    loc += "en_AU";
                    break;
                case "Американский вариант английского языка":
                    loc += "en_US";
                    break;
                case "Aргентинский вариант испанского языка":
                    loc += "es_AR";
                    break;
                case "Бразильский вариант португальского языка":
                    loc += "pt_BR";
                    break;
                case "Британский вариант английского языка":
                    loc += "en_GB";
                    break;
                case "Венгерский язык":
                    loc += "hu_HU";
                    break;
                case "Вьетнамский язык":
                    loc += "vn_VN";
                    break;
                case "Греческий язык":
                    loc += "el_GR";
                    break;
                case "Индонезийский язык":
                    loc += "id_ID";
                    break;
                case "Испанский язык":
                    loc += "es_ES";
                    break;
                case "Итальянский язык":
                    loc += "it_IT";
                    break;
                case "Китайский язык":
                    loc += "zh_CN";
                    break;
                case "Корейский язык":
                    loc += "ko_KR";
                    break;
                case "Малайзийский язык":
                    loc += "ms_MY";
                    break;
                case "Мексиканский вариант испанского языка":
                    loc += "es_MX";
                    break;
                case "Немецкий язык":
                    loc += "de_DE";
                    break;
                case "Польский язык":
                    loc += "pl_PL";
                    break;
                case "Португальский язык":
                    loc += "pt_BR";
                    break;
                case "Румынский язык":
                    loc += "pl_PL";
                    break;
                case "Русский язык":
                    loc += "ru_RU";
                    break;
                case "Сингапурский вариант английского языка":
                    loc += "en_SG";
                    break;
                case "Тайваньский язык":
                    loc += "zh_TW";
                    break;
                case "Тайский язык":
                    loc += "th_TH";
                    break;
                case "Турецкий язык":
                    loc += "tr_TR";
                    break;
                case "Филиппинский вариант английского языка":
                    loc += "en_PH";
                    break;
                case "Французский язык":
                    loc += "fr_FR";
                    break;
                case "Чешский язык":
                    loc += "cs_CZ";
                    break;
                case "Японский язык":
                    loc += "ja_JP";
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = switcher.Default.pass;
            comboBox1.SelectedItem = switcher.Default.locale;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string call = userPass + "\\LeagueClient.exe";
            var proc = new ProcessStartInfo()
            {
                UseShellExecute = true,
                FileName = call,
                Arguments = loc,
            };
            MessageBox.Show("Запускаю лол, выбранный язык: " + userlocale);
            Process.Start(proc);
            switcher.Default.pass = userPass;
            switcher.Default.locale = userlocale;
            switcher.Default.Save();
            Environment.Exit(0);
        }
    }
}