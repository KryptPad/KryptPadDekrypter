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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DekryptForm));
            this.label1 = new System.Windows.Forms.Label();
            this.SelectFileButton = new System.Windows.Forms.Button();
            this.DecryptedContentsTextBox = new System.Windows.Forms.TextBox();
            this.FileControlGroupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PassphraseTextBox = new System.Windows.Forms.TextBox();
            this.DecryptToFileButton = new System.Windows.Forms.Button();
            this.DecryptButton = new System.Windows.Forms.Button();
            this.FileControlGroupBox.SuspendLayout();
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
            this.SelectFileButton.Location = new System.Drawing.Point(12, 35);
            this.SelectFileButton.Name = "SelectFileButton";
            this.SelectFileButton.Size = new System.Drawing.Size(91, 54);
            this.SelectFileButton.TabIndex = 1;
            this.SelectFileButton.Text = "Select File...";
            this.SelectFileButton.UseVisualStyleBackColor = true;
            this.SelectFileButton.Click += new System.EventHandler(this.SelectFileButton_Click);
            // 
            // DecryptedContentsTextBox
            // 
            this.DecryptedContentsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DecryptedContentsTextBox.Location = new System.Drawing.Point(12, 95);
            this.DecryptedContentsTextBox.Multiline = true;
            this.DecryptedContentsTextBox.Name = "DecryptedContentsTextBox";
            this.DecryptedContentsTextBox.ReadOnly = true;
            this.DecryptedContentsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DecryptedContentsTextBox.Size = new System.Drawing.Size(610, 304);
            this.DecryptedContentsTextBox.TabIndex = 4;
            this.DecryptedContentsTextBox.Text = "Select a file and decrypt it to view its contents.";
            // 
            // FileControlGroupBox
            // 
            this.FileControlGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FileControlGroupBox.Controls.Add(this.label2);
            this.FileControlGroupBox.Controls.Add(this.PassphraseTextBox);
            this.FileControlGroupBox.Controls.Add(this.DecryptToFileButton);
            this.FileControlGroupBox.Controls.Add(this.DecryptButton);
            this.FileControlGroupBox.Enabled = false;
            this.FileControlGroupBox.Location = new System.Drawing.Point(109, 28);
            this.FileControlGroupBox.Name = "FileControlGroupBox";
            this.FileControlGroupBox.Size = new System.Drawing.Size(513, 61);
            this.FileControlGroupBox.TabIndex = 8;
            this.FileControlGroupBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Passphrase:";
            // 
            // PassphraseTextBox
            // 
            this.PassphraseTextBox.Location = new System.Drawing.Point(80, 22);
            this.PassphraseTextBox.Name = "PassphraseTextBox";
            this.PassphraseTextBox.Size = new System.Drawing.Size(212, 23);
            this.PassphraseTextBox.TabIndex = 10;
            this.PassphraseTextBox.UseSystemPasswordChar = true;
            // 
            // DecryptToFileButton
            // 
            this.DecryptToFileButton.Location = new System.Drawing.Point(379, 22);
            this.DecryptToFileButton.Name = "DecryptToFileButton";
            this.DecryptToFileButton.Size = new System.Drawing.Size(128, 23);
            this.DecryptToFileButton.TabIndex = 9;
            this.DecryptToFileButton.Text = "Dekrypt To File...";
            this.DecryptToFileButton.UseVisualStyleBackColor = true;
            this.DecryptToFileButton.Click += new System.EventHandler(this.DecryptToFileButton_Click);
            // 
            // DecryptButton
            // 
            this.DecryptButton.Location = new System.Drawing.Point(298, 22);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Size = new System.Drawing.Size(75, 23);
            this.DecryptButton.TabIndex = 8;
            this.DecryptButton.Text = "Dekrypt";
            this.DecryptButton.UseVisualStyleBackColor = true;
            this.DecryptButton.Click += new System.EventHandler(this.DecryptButton_Click);
            // 
            // DekryptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 411);
            this.Controls.Add(this.FileControlGroupBox);
            this.Controls.Add(this.DecryptedContentsTextBox);
            this.Controls.Add(this.SelectFileButton);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(650, 300);
            this.Name = "DekryptForm";
            this.Text = "Krypt Pad Dekrypter";
            this.FileControlGroupBox.ResumeLayout(false);
            this.FileControlGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button SelectFileButton;
        private TextBox DecryptedContentsTextBox;
        private GroupBox FileControlGroupBox;
        private Label label2;
        private TextBox PassphraseTextBox;
        private Button DecryptToFileButton;
        private Button DecryptButton;
    }
}