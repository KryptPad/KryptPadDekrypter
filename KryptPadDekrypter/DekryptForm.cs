using KryptPadWebApp.Models.Entities;
using Newtonsoft.Json;

namespace KryptPadDekrypter
{
    public partial class DekryptForm : Form
    {
        private const string KDF_FILTER = "Krypt Pad Document|*.kdf";
        private const string JSON_FILTER = "JSON Text File|*.json";
        private Stream? _selectedFileStream = null;

        public DekryptForm()
        {
            InitializeComponent();
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

        /// <summary>
        /// Resets the stream position and reads the file to the end
        /// </summary>
        /// <returns></returns>
        private string? ReadFileContents()
        {
            string? encryptedJSON = null;
            if (_selectedFileStream != null)
            {
                // Reset stream position
                _selectedFileStream.Position = 0;
                // Read stream to its end
                using var sr = new StreamReader(_selectedFileStream, leaveOpen: true);
                encryptedJSON = sr.ReadToEnd();
            }

            return encryptedJSON;
        }

        /// <summary>
        /// Decrypts the contents of the JSON file
        /// </summary>
        /// <returns></returns>
        private string? DecryptFile()
        {
            string? decryptedText = null;
            string passphrase = PassphraseTextBox.Text;

            // Decrypt the file and output its content into the textbox
            if (_selectedFileStream != null)
            {

                var encryptedJSON = ReadFileContents();
                if (encryptedJSON != null)
                {
                    // Next deserialize the profile into a Profile object
                    var profile = JsonConvert.DeserializeObject<Profile>(encryptedJSON);
                    if (profile != null && profile.Categories != null)
                    {
                        // Check if the supplied passphrase matches the hash in the document
                        if (!VerifyPassphrase(profile, passphrase))
                        {
                            throw new Exception("The passphrase you entered is not correct. Please try again.");
                        }


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
                    decryptedText = JsonConvert.SerializeObject(profile, Formatting.Indented);


                }

            }

            return decryptedText;
        }

        #region Events
        private void SelectFileButton_Click(object sender, EventArgs e)
        {
            using var ofd = new OpenFileDialog();
            ofd.Filter = KDF_FILTER;
            var result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                _selectedFileStream = ofd.OpenFile();
                if (_selectedFileStream != null)
                {
                    // Enable the decryption buttons
                    FileControlGroupBox.Enabled = true;
                    FileControlGroupBox.Text = ofd.SafeFileName;

                }
            }

        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Decrypt the file and output its content into the textbox
                DecryptedContentsTextBox.Text = DecryptFile();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while decrypting the file. {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void DecryptToFileButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Decrypt the file and output its content into the textbox
                var decryptedJSON = DecryptFile();
                DecryptedContentsTextBox.Text = decryptedJSON;

                // Write the decrypted contents to a file
                using var sfd = new SaveFileDialog();
                sfd.Filter = JSON_FILTER;
                var result = sfd.ShowDialog();
                if (result == DialogResult.OK)
                {
                    // Open the file and write the contents
                    using var sw = new StreamWriter(sfd.OpenFile());
                    sw.Write(decryptedJSON);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while decrypting the file anmd writing to a new file. {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion


    }
}