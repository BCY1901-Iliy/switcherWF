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
                case "������������� ������� ����������� �����":
                    loc += "en_AU";
                    break;
                case "������������ ������� ����������� �����":
                    loc += "en_US";
                    break;
                case "A����������� ������� ���������� �����":
                    loc += "es_AR";
                    break;
                case "����������� ������� �������������� �����":
                    loc += "pt_BR";
                    break;
                case "���������� ������� ����������� �����":
                    loc += "en_GB";
                    break;
                case "���������� ����":
                    loc += "hu_HU";
                    break;
                case "����������� ����":
                    loc += "vn_VN";
                    break;
                case "��������� ����":
                    loc += "el_GR";
                    break;
                case "������������� ����":
                    loc += "id_ID";
                    break;
                case "��������� ����":
                    loc += "es_ES";
                    break;
                case "����������� ����":
                    loc += "it_IT";
                    break;
                case "��������� ����":
                    loc += "zh_CN";
                    break;
                case "��������� ����":
                    loc += "ko_KR";
                    break;
                case "������������ ����":
                    loc += "ms_MY";
                    break;
                case "������������ ������� ���������� �����":
                    loc += "es_MX";
                    break;
                case "�������� ����":
                    loc += "de_DE";
                    break;
                case "�������� ����":
                    loc += "pl_PL";
                    break;
                case "������������� ����":
                    loc += "pt_BR";
                    break;
                case "��������� ����":
                    loc += "pl_PL";
                    break;
                case "������� ����":
                    loc += "ru_RU";
                    break;
                case "������������ ������� ����������� �����":
                    loc += "en_SG";
                    break;
                case "����������� ����":
                    loc += "zh_TW";
                    break;
                case "������� ����":
                    loc += "th_TH";
                    break;
                case "�������� ����":
                    loc += "tr_TR";
                    break;
                case "������������ ������� ����������� �����":
                    loc += "en_PH";
                    break;
                case "����������� ����":
                    loc += "fr_FR";
                    break;
                case "������� ����":
                    loc += "cs_CZ";
                    break;
                case "�������� ����":
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
            MessageBox.Show("�������� ���, ��������� ����: " + userlocale);
            Process.Start(proc);
            switcher.Default.pass = userPass;
            switcher.Default.locale = userlocale;
            switcher.Default.Save();
            Environment.Exit(0);
        }
    }
}