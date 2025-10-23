using System.Windows.Forms;

namespace shash
{
    public partial class Form1 : Form
    {
        private Cipher cipher = new Cipher();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // initial status
            UpdateStatus("Ready");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pass = textBox1.Text ?? string.Empty;

            try
            {
                if (radioButton1.Checked)
                {
                    // text -> cipher
                    string plain = richTextBox1.Text ?? string.Empty;
                    string cipherText = cipher.encrypt(plain, pass);
                    richTextBox2.Text = cipherText;
                    UpdateStatus("Encrypted");
                }
                else if (radioButton2.Checked)
                {
                    // cipher -> text
                    string cipherText = richTextBox1.Text ?? string.Empty;
                    string plain = cipher.decrypt(cipherText, pass);
                    richTextBox2.Text = plain;
                    UpdateStatus("Decrypted");
                }
            }
            catch (Exception ex)
            {
                UpdateStatus("Error");
                MessageBox.Show("Error: " + ex.Message, "shash", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            try
            {
                var text = richTextBox2.Text ?? string.Empty;
                if (string.IsNullOrEmpty(text))
                {
                    UpdateStatus("Nothing to copy");
                    return;
                }
                Clipboard.SetText(text);
                UpdateStatus("Output copied to clipboard");
            }
            catch (Exception ex)
            {
                UpdateStatus("Copy failed");
                MessageBox.Show("Unable to copy to clipboard: " + ex.Message, "shash", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox2.Clear();
            textBox1.Clear();
            UpdateStatus("Cleared");
        }

        private void UpdateStatus(string message)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action(() => statusLabel.Text = message));
            }
            else
            {
                statusLabel.Text = message;
            }
        }
    }
}