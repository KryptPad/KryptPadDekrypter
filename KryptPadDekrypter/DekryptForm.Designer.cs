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
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.DecryptButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DecryptToFileButton = new System.Windows.Forms.Button();
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
            this.SelectFileButton.Location = new System.Drawing.Point(12, 27);
            this.SelectFileButton.Name = "SelectFileButton";
            this.SelectFileButton.Size = new System.Drawing.Size(91, 23);
            this.SelectFileButton.TabIndex = 1;
            this.SelectFileButton.Text = "Select File...";
            this.SelectFileButton.UseVisualStyleBackColor = true;
            this.SelectFileButton.Click += new System.EventHandler(this.SelectFileButton_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBox1.Location = new System.Drawing.Point(109, 27);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(198, 23);
            this.maskedTextBox1.TabIndex = 2;
            this.maskedTextBox1.UseSystemPasswordChar = true;
            // 
            // DecryptButton
            // 
            this.DecryptButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DecryptButton.Enabled = false;
            this.DecryptButton.Location = new System.Drawing.Point(313, 27);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Size = new System.Drawing.Size(75, 23);
            this.DecryptButton.TabIndex = 3;
            this.DecryptButton.Text = "Dekrypt";
            this.DecryptButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(12, 56);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(510, 243);
            this.textBox1.TabIndex = 4;
            // 
            // DecryptToFileButton
            // 
            this.DecryptToFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DecryptToFileButton.Enabled = false;
            this.DecryptToFileButton.Location = new System.Drawing.Point(394, 27);
            this.DecryptToFileButton.Name = "DecryptToFileButton";
            this.DecryptToFileButton.Size = new System.Drawing.Size(128, 23);
            this.DecryptToFileButton.TabIndex = 5;
            this.DecryptToFileButton.Text = "Dekrypt To File...";
            this.DecryptToFileButton.UseVisualStyleBackColor = true;
            // 
            // DekryptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 311);
            this.Controls.Add(this.DecryptToFileButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.DecryptButton);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.SelectFileButton);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(550, 350);
            this.Name = "DekryptForm";
            this.Text = "Krypt Pad Dekrypter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button SelectFileButton;
        private MaskedTextBox maskedTextBox1;
        private Button DecryptButton;
        private TextBox textBox1;
        private Button DecryptToFileButton;
    }
}