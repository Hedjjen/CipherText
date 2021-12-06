namespace CipherTextUI
{
    partial class TextCipher
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
            this.textAccept = new System.Windows.Forms.RichTextBox();
            this.textTranslate = new System.Windows.Forms.RichTextBox();
            this.btnDecipher = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCipher = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextAccept
            // 
            this.textAccept.Location = new System.Drawing.Point(21, 24);
            this.textAccept.Name = "TextAccept";
            this.textAccept.Size = new System.Drawing.Size(963, 208);
            this.textAccept.TabIndex = 0;
            this.textAccept.Text = "";
            // 
            // textTranslate
            // 
            this.textTranslate.Location = new System.Drawing.Point(21, 238);
            this.textTranslate.Name = "textTranslate";
            this.textTranslate.Size = new System.Drawing.Size(963, 208);
            this.textTranslate.TabIndex = 1;
            this.textTranslate.Text = "";
            // 
            // btnDecipher
            // 
            this.btnDecipher.Location = new System.Drawing.Point(719, 461);
            this.btnDecipher.Name = "btnDecipher";
            this.btnDecipher.Size = new System.Drawing.Size(121, 42);
            this.btnDecipher.TabIndex = 2;
            this.btnDecipher.Text = "Decipher";
            this.btnDecipher.UseVisualStyleBackColor = true;
            this.btnDecipher.Click += new System.EventHandler(this.btnDecipher_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(863, 461);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(121, 42);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCipher
            // 
            this.btnCipher.Location = new System.Drawing.Point(577, 461);
            this.btnCipher.Name = "btnCipher";
            this.btnCipher.Size = new System.Drawing.Size(121, 42);
            this.btnCipher.TabIndex = 4;
            this.btnCipher.Text = "Cipher";
            this.btnCipher.UseVisualStyleBackColor = true;
            this.btnCipher.Click += new System.EventHandler(this.btnCipher_Click);
            // 
            // TextCipher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1010, 554);
            this.Controls.Add(this.btnCipher);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDecipher);
            this.Controls.Add(this.textTranslate);
            this.Controls.Add(this.textAccept);
            this.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "TextCipher";
            this.Text = "TextCipher v1.0";
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox textAccept;
        private RichTextBox textTranslate;
        private Button btnDecipher;
        private Button btnClear;
        private Button btnCipher;
    }
}