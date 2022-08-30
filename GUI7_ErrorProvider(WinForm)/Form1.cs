using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI7_ErrorProvider_WinForm_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKydt_Click(object sender, EventArgs e)
        {
            if (txtVatandaslıkNO.Text.Length != 11)
            {
                MessageBox.Show("Vatandaşlık numarası 11 dijit olmalı");
            }
        }

        private void txtVatandaslıkNO_KeyPress(object sender, KeyPressEventArgs e)
        {
            //switch (e.KeyChar)
            //{
            //    case '0':
            //    case '1':
            //    case '2':
            //    case '3':
            //    case '4':
            //    case '5':
            //    case '6':
            //    case '7':
            //    case '8':
            //    case '9':
            //        errTCNoSına.Clear();
            //        ((TextBox)sender).BackColor = Color.White;
            //        break;
            //    default:
            //        errTCNoSına.SetError(txtVatandaslıkNO, "Bu alana sadece sayı girmelisiniz");
            //        ((TextBox)sender).BackColor = Color.Red;
            //        break;
            //}

            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                errTCNoSına.Clear();
                ((TextBox)sender).BackColor = Color.White;

                if (txtVatandaslıkNO.Text.Length + 1 > 11)
                {
                    errBasmakSayisi.SetError(txtVatandaslıkNO, "Vatandaşlık numarası 11'Den büyük olamaz");
                }
                else if (txtVatandaslıkNO.Text.Length + 1 <= 11)
                {
                    errBasmakSayisi.Clear();
                }
                else
                {
                    errBasmakSayisi.Clear();
                }
            }
            else
            {
                e.Handled = true;
                errTCNoSına.SetError(txtVatandaslıkNO, "Bu alana sadece sayı girmelisiniz");
                ((TextBox)sender).BackColor = Color.Red;
            }
        }
    }
}
