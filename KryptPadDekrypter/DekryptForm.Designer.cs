namespace KryptPadDekrypter
{
    partial class DekryptForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.SelectFileButton = new System.Windows.Forms.Button();
            this.DecryptButton = new System.Windows.Forms.Button();
            this.DecryptedContentsTextBox = new System.Windows.Forms.TextBox();
            this.DecryptToFileButton = new System.Windows.Forms.Button();
            this.PassphraseTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select a Krypt Pad (kdf) file and enter your passphrase to decrypt.";
            // 
            // SelectFileButton
            // 
            this.SelectFileButton.Location = new System.Drawing.Point(12, 28);
            this.SelectFileButton.Name = "SelectFileButton";
            this.SelectFileButton.Size = new System.Drawing.Size(91, 23);
            this.SelectFileButton.TabIndex = 1;
            this.SelectFileButton.Text = "Select File...";
            this.SelectFileButton.UseVisualStyleBackColor = true;
            this.SelectFileButton.Click += new System.EventHandler(this.SelectFileButton_Click);
            // 
            // DecryptButton
            // 
            this.DecryptButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DecryptButton.Enabled = false;
            this.DecryptButton.Location = new System.Drawing.Point(413, 28);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Size = new System.Drawing.Size(75, 23);
            this.DecryptButton.TabIndex = 3;
            this.DecryptButton.Text = "Dekrypt";
            this.DecryptButton.UseVisualStyleBackColor = true;
            this.DecryptButton.Click += new System.EventHandler(this.DecryptButton_Click);
            // 
            // DecryptedContentsTextBox
            // 
            this.DecryptedContentsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DecryptedContentsTextBox.Location = new System.Drawing.Point(12, 57);
            this.DecryptedContentsTextBox.Multiline = true;
            this.DecryptedContentsTextBox.Name = "DecryptedContentsTextBox";
            this.DecryptedContentsTextBox.ReadOnly = true;
            this.DecryptedContentsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DecryptedContentsTextBox.Size = new System.Drawing.Size(610, 342);
            this.DecryptedContentsTextBox.TabIndex = 4;
            // 
            // DecryptToFileButton
            // 
            this.DecryptToFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DecryptToFileButton.Enabled = false;
            this.DecryptToFileButton.Location = new System.Drawing.Point(494, 28);
            this.DecryptToFileButton.Name = "DecryptToFileButton";
            this.DecryptToFileButton.Size = new System.Drawing.Size(128, 23);
            this.DecryptToFileButton.TabIndex = 5;
            this.DecryptToFileButton.Text = "Dekrypt To File...";
            this.DecryptToFileButton.UseVisualStyleBackColor = true;
            // 
            // PassphraseTextBox
            // 
            this.PassphraseTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PassphraseTextBox.Enabled = false;
            this.PassphraseTextBox.Location = new System.Drawing.Point(218, 28);
            this.PassphraseTextBox.Name = "PassphraseTextBox";
            this.PassphraseTextBox.Size = new System.Drawing.Size(189, 23);
            this.PassphraseTextBox.TabIndex = 6;
            this.PassphraseTextBox.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Passphrase:";
            // 
            // DekryptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 411);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PassphraseTextBox);
            this.Controls.Add(this.DecryptToFileButton);
            this.Controls.Add(this.DecryptedContentsTextBox);
            this.Controls.Add(this.DecryptButton);
            this.Controls.Add(this.SelectFileButton);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(650, 200);
            this.Name = "DekryptForm";
            this.Text = "Krypt Pad Dekrypter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button SelectFileButton;
        private Button DecryptButton;
        private TextBox DecryptedContentsTextBox;
        private Button DecryptToFileButton;
        private TextBox PassphraseTextBox;
        private Label label2;
    }
}