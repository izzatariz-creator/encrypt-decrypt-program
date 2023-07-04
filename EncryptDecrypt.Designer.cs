namespace EncryptDecryptProgram
{
    partial class EncryptDecrypt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblText = new Label();
            txtBoxMainText = new TextBox();
            lblKey = new Label();
            txtBoxKey = new TextBox();
            gBoxEncrypt = new GroupBox();
            txtBoxEncrypt = new TextBox();
            gBoxDecrypt = new GroupBox();
            txtBoxDecrypt = new TextBox();
            btnEncrypt = new Button();
            btnDecrypt = new Button();
            btnReset = new Button();
            gBoxEncrypt.SuspendLayout();
            gBoxDecrypt.SuspendLayout();
            SuspendLayout();
            // 
            // lblText
            // 
            lblText.AutoSize = true;
            lblText.Location = new Point(34, 50);
            lblText.Name = "lblText";
            lblText.Size = new Size(28, 15);
            lblText.TabIndex = 0;
            lblText.Text = "Text";
            // 
            // txtBoxMainText
            // 
            txtBoxMainText.Location = new Point(97, 47);
            txtBoxMainText.Name = "txtBoxMainText";
            txtBoxMainText.Size = new Size(428, 23);
            txtBoxMainText.TabIndex = 1;
            // 
            // lblKey
            // 
            lblKey.AutoSize = true;
            lblKey.Location = new Point(34, 112);
            lblKey.Name = "lblKey";
            lblKey.Size = new Size(26, 15);
            lblKey.TabIndex = 2;
            lblKey.Text = "Key";
            // 
            // txtBoxKey
            // 
            txtBoxKey.Location = new Point(97, 109);
            txtBoxKey.Name = "txtBoxKey";
            txtBoxKey.Size = new Size(428, 23);
            txtBoxKey.TabIndex = 3;
            // 
            // gBoxEncrypt
            // 
            gBoxEncrypt.Controls.Add(txtBoxEncrypt);
            gBoxEncrypt.Location = new Point(97, 217);
            gBoxEncrypt.Name = "gBoxEncrypt";
            gBoxEncrypt.Size = new Size(428, 185);
            gBoxEncrypt.TabIndex = 4;
            gBoxEncrypt.TabStop = false;
            gBoxEncrypt.Text = "Encrypt";
            // 
            // txtBoxEncrypt
            // 
            txtBoxEncrypt.Location = new Point(15, 35);
            txtBoxEncrypt.Multiline = true;
            txtBoxEncrypt.Name = "txtBoxEncrypt";
            txtBoxEncrypt.Size = new Size(391, 132);
            txtBoxEncrypt.TabIndex = 0;
            // 
            // gBoxDecrypt
            // 
            gBoxDecrypt.Controls.Add(txtBoxDecrypt);
            gBoxDecrypt.Location = new Point(97, 505);
            gBoxDecrypt.Name = "gBoxDecrypt";
            gBoxDecrypt.Size = new Size(428, 185);
            gBoxDecrypt.TabIndex = 5;
            gBoxDecrypt.TabStop = false;
            gBoxDecrypt.Text = "Decrypt";
            // 
            // txtBoxDecrypt
            // 
            txtBoxDecrypt.Location = new Point(15, 33);
            txtBoxDecrypt.Multiline = true;
            txtBoxDecrypt.Name = "txtBoxDecrypt";
            txtBoxDecrypt.Size = new Size(391, 132);
            txtBoxDecrypt.TabIndex = 1;
            // 
            // btnEncrypt
            // 
            btnEncrypt.BackColor = Color.PaleGreen;
            btnEncrypt.Location = new Point(242, 158);
            btnEncrypt.Name = "btnEncrypt";
            btnEncrypt.Size = new Size(96, 35);
            btnEncrypt.TabIndex = 6;
            btnEncrypt.Text = "ENCRYPT";
            btnEncrypt.UseVisualStyleBackColor = false;
            btnEncrypt.Click += btnEncrypt_Click;
            // 
            // btnDecrypt
            // 
            btnDecrypt.BackColor = Color.LightPink;
            btnDecrypt.Location = new Point(159, 435);
            btnDecrypt.Name = "btnDecrypt";
            btnDecrypt.Size = new Size(96, 35);
            btnDecrypt.TabIndex = 7;
            btnDecrypt.Text = "DECRYPT";
            btnDecrypt.UseVisualStyleBackColor = false;
            btnDecrypt.Click += btnDecrypt_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.Crimson;
            btnReset.Location = new Point(324, 435);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(96, 35);
            btnReset.TabIndex = 8;
            btnReset.Text = "RESET";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // EncryptDecrypt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(551, 711);
            Controls.Add(btnReset);
            Controls.Add(btnDecrypt);
            Controls.Add(btnEncrypt);
            Controls.Add(gBoxDecrypt);
            Controls.Add(gBoxEncrypt);
            Controls.Add(txtBoxKey);
            Controls.Add(lblKey);
            Controls.Add(txtBoxMainText);
            Controls.Add(lblText);
            Name = "EncryptDecrypt";
            Text = "Encrypt Decrypt Program";
            gBoxEncrypt.ResumeLayout(false);
            gBoxEncrypt.PerformLayout();
            gBoxDecrypt.ResumeLayout(false);
            gBoxDecrypt.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblText;
        private TextBox txtBoxMainText;
        private Label lblKey;
        private TextBox txtBoxKey;
        private GroupBox gBoxEncrypt;
        private GroupBox gBoxDecrypt;
        private Button btnEncrypt;
        private TextBox txtBoxEncrypt;
        private TextBox txtBoxDecrypt;
        private Button btnDecrypt;
        private Button btnReset;
    }
}