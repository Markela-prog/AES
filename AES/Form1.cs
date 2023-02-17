using System.Security.Cryptography;
namespace AES
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            var cipher = new Cipher();

            string plainText = textInput.Text;
            string key = keyInput.Text;
            CipherMode mode = 0;
            
            if (radioCBC.Checked)
            {
                mode = CipherMode.CBC;
            }
            else if (radioCFB.Checked) 
            {
                mode = CipherMode.CFB;
            }
            else if (radioECB.Checked)
            {
                mode = CipherMode.ECB;
            }

            if (mode != 0)
            {
                result.Text = cipher.Encrypt(plainText, key, mode);
            }


        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            var cipher = new Cipher();

            string encryptedText = textInput.Text;
            string key = keyInput.Text;

            CipherMode mode = 0;

            if (radioCBC.Checked)
            {
                mode = CipherMode.CBC;
            }
            else if (radioCFB.Checked)
            {
                mode = CipherMode.CFB;
            }
            else if (radioECB.Checked)
            {
                mode = CipherMode.ECB;
            }

            if (mode != 0)
            {
                result.Text = cipher.Decrypt(encryptedText, key, mode);
            }


        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            textInput.Text = result.Text;
        }

        private void radioECB_CheckedChanged(object sender, EventArgs e)
        {
            modeSelected.Text = "ECB mode selected!";
            modeSelected.Show();
        }

        private void radioCBC_CheckedChanged(object sender, EventArgs e)
        {
            modeSelected.Text = "CBC mode selected!";
            modeSelected.Show();
        }

        private void radioCFB_CheckedChanged(object sender, EventArgs e)
        {
            modeSelected.Text = "CFB mode selected!";
            modeSelected.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            modeSelected.Hide();
        }

        private void btnSaveToFile_Click(object sender, EventArgs e)
        {
            var cipher = new Cipher();

            string plainText = textInput.Text;
            string key = keyInput.Text;
            string encryptedText;
            CipherMode mode = 0;

            if (radioCBC.Checked)
            {
                mode = CipherMode.CBC;
            }
            else if (radioCFB.Checked)
            {
                mode = CipherMode.CFB;
            }
            else if (radioECB.Checked)
            {
                mode = CipherMode.ECB;
            }

            if (mode != 0)
            {
                encryptedText = cipher.Encrypt(plainText, key, mode);
                cipher.SaveToFile(encryptedText, @"C:\Users\Markela\Desktop\Paskaitos\Informacijos saugumas\2 praktinis darbas\AES\AES\bin\Debug\net6.0-windows\encryptedText.txt");
                MessageBox.Show("Encrypted text was successfully saved in file");
            }
        }

        private void btnDecryptFromFile_Click(object sender, EventArgs e)
        {
            var cipher = new Cipher();
            string key = keyInput.Text;

            CipherMode mode = 0;

            if (radioCBC.Checked)
            {
                mode = CipherMode.CBC;
            }
            else if (radioCFB.Checked)
            {
                mode = CipherMode.CFB;
            }
            else if (radioECB.Checked)
            {
                mode = CipherMode.ECB;
            }

            if (mode != 0)
            {
                result.Text = cipher.DecryptFromFile(@"C:\Users\Markela\Desktop\Paskaitos\Informacijos saugumas\2 praktinis darbas\AES\AES\bin\Debug\net6.0-windows\encryptedText.txt",
                    key, mode);
            }
        }
    }
}