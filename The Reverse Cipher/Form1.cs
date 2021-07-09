using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Reverse_Cipher
{
    public partial class frmReverseCipher : Form
    {
        public frmReverseCipher()
        {
            InitializeComponent();
        }

        string message;
        string encrypted;
        string decrypted;
        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            message = txtMessage.Text;
            int i = message.Length - 1;

            while(i >= 0)
            {
                encrypted = encrypted + message[i];
                i = i - 1;
            }

            txtMessage.Text = encrypted;
            txtEncrypt.Text = encrypted;
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            message = txtMessage.Text;
            int i = message.Length - 1;

            while (i >= 0)
            {
                decrypted = decrypted + message[i];
                i = i - 1;
            }

            txtMessage.Text = decrypted;
            txtDecrypt.Text = decrypted;
        }
    }
}
