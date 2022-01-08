using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace hashcoding
{
    public partial class Form1 : Form
    {
        private SecurityController _sifreleyici;
        public Form1()
        {
            InitializeComponent();
        _sifreleyici = new SecurityController();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string veri = EncriptEdilecek.Text;
            string password = PrivateKeyTextBox.Text;
            string encryptedstring =_sifreleyici.Encrypt(password, veri);
            Decriptedilecek.Text = encryptedstring;
            string message = "Encrypted Message = "+encryptedstring;
            string title = "Encrypted!";
            MessageBox.Show(message, title);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string veri = Decriptedilecek.Text;
            string password = PrivateKeyTextBox.Text;
            string decryptedstring = _sifreleyici.Decrypt(password, veri);
            EncriptEdilecek.Text = decryptedstring;
            string message = "Decrypted Message = " + decryptedstring;
            string title = "Decrypted!";
            MessageBox.Show(message, title);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            EncriptEdilecek.Clear();
        }

        private void clearbutton2_Click(object sender, EventArgs e)
        {
            Decriptedilecek.Clear();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
