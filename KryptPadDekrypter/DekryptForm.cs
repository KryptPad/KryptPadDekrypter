using KryptPadWebApp.Models.Entities;
using Newtonsoft.Json;

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

        /// <summary>
        /// Verifies the hash of the passphrase by comparing the input and salt to the Key2 field in the kdf file.
        /// </summary>
        /// <param name="profile"></param>
        /// <param name="passphrase"></param>
        /// <returns></returns>
        private bool VerifyPassphrase(Profile profile, string passphrase)
        {
            // If there is no salt, set empty
            var salt = profile.Key1 ?? string.Empty;

            // Get the salt
            var saltBytes = Convert.FromBase64String(salt);

            // Verify the supplied passphrase
            var hashedPassphrase = Encryption.Hash(passphrase, saltBytes);

            // Compare the hashes
            return hashedPassphrase.Equals(profile.Key2);
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

                    // Read all the contents of the file
                    using (var sr = new StreamReader(_selectedFileStream))
                    {
                        var profileJson = sr.ReadToEnd();

                        if (profileJson != null)
                        {
                            // Next deserialize the profile into a Profile object
                            var profile = JsonConvert.DeserializeObject<Profile>(profileJson);
                            if (profile != null && profile.Categories != null)
                            {
                                // Loop through each category and decrypt it
                                foreach (var category in profile.Categories)
                                {
                                    // If the category is not null, decrypt it and loop through its items
                                    if (category != null)
                                    {
                                        category.Name = Encryption.DecryptFromString(category.Name, passphrase);
                                        // Loop through each item and decrypt it
                                        if (category.Items != null)
                                        {
                                            foreach (var item in category.Items)
                                            {
                                                item.Name = Encryption.DecryptFromString(item.Name, passphrase);
                                                item.Notes = Encryption.DecryptFromString(item.Notes, passphrase);
                                                // Loop through all field values and decrypt them
                                                if (item.Fields != null)
                                                {
                                                    foreach (var field in item.Fields)
                                                    {
                                                        field.Name = Encryption.DecryptFromString(field.Name, passphrase);
                                                        field.Value = Encryption.DecryptFromString(field.Value, passphrase);

                                                    }
                                                }
                                            }
                                        }
                                    }
                                }

                            }

                            // Serialize the decrypted output
                            decryptedText = JsonConvert.SerializeObject(profile);

                        }



                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("An error occurred while decrypting the file. Make sure your passphrase is correct.",
                        "Error Decrypting", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }

            return decryptedText;
        }
    }
}