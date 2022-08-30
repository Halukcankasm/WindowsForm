using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace GUI9_REGISTERUSER
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            chckIkBtn.CheckedChanged += Chck_Change;
            chckDeveloperBtn.CheckedChanged += Chck_Change;
            chckItButton.CheckedChanged += Chck_Change;
        }

        private void Chck_Change(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                lblEmploye.Text += ((CheckBox)sender).Text+" ";
            }
            else
            {
                lblEmploye.Text = lblEmploye.Text.Replace(((CheckBox)sender).Text, "");
            }
        }

        private void linkAddress(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = @"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe";
            psi.Arguments = "http://www.google.com";

            Process crome = Process.Start(psi);

            crome.Start();
        }
    }
}
