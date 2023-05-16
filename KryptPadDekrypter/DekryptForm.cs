namespace KryptPadDekrypter
{
    public partial class DekryptForm : Form
    {

        private Stream? _selectedFileStream = null;
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
                    _selectedFileStream = selectFileDialog.OpenFile();
                    // Enable the decryption buttons
                    DecryptButton.Enabled = true;
                    DecryptToFileButton.Enabled = true;
                }
            }
            
        }
    }
}