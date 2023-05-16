namespace KryptPadDekrypter
{
    public partial class DekryptForm : Form
    {

        private FileStream? _selectedFileStream = null;
        public DekryptForm()
        {
            InitializeComponent();
        }

        private void SelectFileButton_Click(object sender, EventArgs e)
        {
            using (var selectFileDialog = new OpenFileDialog())
            {
                selectFileDialog.Filter = "Krypt Pad Document|*.kdf";
                var result = selectFileDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    _selectedFileStream = (FileStream)selectFileDialog.OpenFile();
                    if (_selectedFileStream != null)
                    {
                        // Enable the decryption buttons
                        DecryptButton.Enabled = true;
                        DecryptToFileButton.Enabled = true;
                    }
                }
            }
            
        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            // Decrypt the file and output its content into the textbox
            DecryptedContentsTextBox.Text = DecryptFile();
        }

        private string? DecryptFile()
        {
            string? decryptedText = null;
            string passphrase = PassphraseTextBox.Text;
            // Decrypt the file and output its content into the textbox
            if (_selectedFileStream != null)
            {
                try
                {
                    // Read the file into a memory stream
                    using (var ms = new MemoryStream())
                    {
                        // Reset file position
                        _selectedFileStream.Position = 0;
                        _selectedFileStream.CopyTo(ms);
                        ms.Flush();
                        var cypherBytes = ms.ToArray();
                        // Decrypt
                        decryptedText = Encryption.Decrypt(cypherBytes, passphrase);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while decrypting the file. Make sure your passphrase is correct.",
                        "Error Decrypting", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                

            }

            return decryptedText;
        }
    }
}