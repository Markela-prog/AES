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
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            var cipher = new Cipher();
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
    }
}