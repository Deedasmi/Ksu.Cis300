namespace Ksu.Cis300.Crypto
{
    partial class CipherSolver
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
            this.uxOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.uxOpen = new System.Windows.Forms.Button();
            this.uxDecrypt = new System.Windows.Forms.Button();
            this.uxText = new System.Windows.Forms.TextBox();
            this.uxOut = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // uxOpenFile
            // 
            this.uxOpenFile.FileName = "openFileDialog1";
            // 
            // uxOpen
            // 
            this.uxOpen.Location = new System.Drawing.Point(69, 216);
            this.uxOpen.Name = "uxOpen";
            this.uxOpen.Size = new System.Drawing.Size(199, 58);
            this.uxOpen.TabIndex = 0;
            this.uxOpen.Text = "Open File";
            this.uxOpen.UseVisualStyleBackColor = true;
            this.uxOpen.Click += new System.EventHandler(this.uxOpen_Click);
            // 
            // uxDecrypt
            // 
            this.uxDecrypt.Location = new System.Drawing.Point(320, 216);
            this.uxDecrypt.Name = "uxDecrypt";
            this.uxDecrypt.Size = new System.Drawing.Size(172, 58);
            this.uxDecrypt.TabIndex = 1;
            this.uxDecrypt.Text = "Decrypt";
            this.uxDecrypt.UseVisualStyleBackColor = true;
            this.uxDecrypt.Click += new System.EventHandler(this.uxDecrypt_Click);
            // 
            // uxText
            // 
            this.uxText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxText.Location = new System.Drawing.Point(13, 13);
            this.uxText.Multiline = true;
            this.uxText.Name = "uxText";
            this.uxText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.uxText.Size = new System.Drawing.Size(574, 197);
            this.uxText.TabIndex = 3;
            // 
            // uxOut
            // 
            this.uxOut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxOut.Location = new System.Drawing.Point(13, 287);
            this.uxOut.Multiline = true;
            this.uxOut.Name = "uxOut";
            this.uxOut.ReadOnly = true;
            this.uxOut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.uxOut.Size = new System.Drawing.Size(565, 208);
            this.uxOut.TabIndex = 4;
            // 
            // UserInterface1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 507);
            this.Controls.Add(this.uxOut);
            this.Controls.Add(this.uxText);
            this.Controls.Add(this.uxDecrypt);
            this.Controls.Add(this.uxOpen);
            this.Name = "UserInterface1";
            this.Text = "Crypto Program";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog uxOpenFile;
        private System.Windows.Forms.Button uxOpen;
        private System.Windows.Forms.Button uxDecrypt;
        private System.Windows.Forms.TextBox uxText;
        private System.Windows.Forms.TextBox uxOut;
    }
}

