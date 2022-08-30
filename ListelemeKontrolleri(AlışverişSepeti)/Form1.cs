using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListelemeKontrolleri_AlışverişSepeti_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboKategoriler.SelectedIndex = 0;
            lstBoxUrunler.Items.Clear();
        }

        private void cboKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstBoxUrunler.Items.Clear();

            switch (((ComboBox)sender).SelectedItem.ToString())
            {
                case "Atıştırmalık":
                    lstBoxUrunler.Items.Add("Gofret");
                    lstBoxUrunler.Items.Add("Cekirdek");
                    lstBoxUrunler.Items.Add("Cips");
                    break;
                case "HamurÜrünleri":
                    lstBoxUrunler.Items.Add("Ekmek");
                    lstBoxUrunler.Items.Add("Börek");
                    lstBoxUrunler.Items.Add("Simit");
                    break;
                case "Meyve/Sebze":
                    lstBoxUrunler.Items.Add("Domates");
                    lstBoxUrunler.Items.Add("Salatalık");
                    lstBoxUrunler.Items.Add("Havuc");
                    lstBoxUrunler.Items.Add("Biber");
                    lstBoxUrunler.Items.Add("Saoğan");
                    break;
                case "SütÜrünleri":
                    lstBoxUrunler.Items.Add("Süt");
                    lstBoxUrunler.Items.Add("Ayran");
                    lstBoxUrunler.Items.Add("Yoğur");
                    lstBoxUrunler.Items.Add("Peynir");
                    break;
                case "TemizlikMalzemesi":
                    lstBoxUrunler.Items.Add("Çamaşır Suyu");
                    lstBoxUrunler.Items.Add("Sıvı Sabun");
                    lstBoxUrunler.Items.Add("Deterjan");
                    lstBoxUrunler.Items.Add("Dezenfektan");
                    break;
                default:
                    break;
            };
        }

        private void lstBoxUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            btnClear.Enabled = true;
            btnRemove.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblSelectedItems.Text += "\n"+"->"+lstBoxUrunler.SelectedItem.ToString();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            lblSelectedItems.Text = lblSelectedItems.Text.Replace(("->"+lstBoxUrunler.SelectedItem.ToString()), "");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblSelectedItems.Text = "Sepetiniz:";
        }
    }
}
