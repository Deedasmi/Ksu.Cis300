namespace Ksu.Cis300.PhoneCounter
{
    partial class UserInterface
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
            this.uxFile1 = new System.Windows.Forms.Button();
            this.uxFile2 = new System.Windows.Forms.Button();
            this.uxFile1Text = new System.Windows.Forms.Label();
            this.uxFile2Text = new System.Windows.Forms.Label();
            this.uxMinCountText = new System.Windows.Forms.Label();
            this.uxMinCount = new System.Windows.Forms.DomainUpDown();
            this.uxGo = new System.Windows.Forms.Button();
            this.uxMatch = new System.Windows.Forms.TextBox();
            this.uxFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // uxFile1
            // 
            this.uxFile1.Location = new System.Drawing.Point(12, 12);
            this.uxFile1.Name = "uxFile1";
            this.uxFile1.Size = new System.Drawing.Size(75, 23);
            this.uxFile1.TabIndex = 0;
            this.uxFile1.Text = "Load File 1";
            this.uxFile1.UseVisualStyleBackColor = true;
            this.uxFile1.Click += new System.EventHandler(this.uxFile1_Click);
            // 
            // uxFile2
            // 
            this.uxFile2.Location = new System.Drawing.Point(12, 52);
            this.uxFile2.Name = "uxFile2";
            this.uxFile2.Size = new System.Drawing.Size(75, 23);
            this.uxFile2.TabIndex = 1;
            this.uxFile2.Text = "Load File 2";
            this.uxFile2.UseVisualStyleBackColor = true;
            this.uxFile2.Click += new System.EventHandler(this.uxFile2_Click);
            // 
            // uxFile1Text
            // 
            this.uxFile1Text.AutoSize = true;
            this.uxFile1Text.Location = new System.Drawing.Point(117, 17);
            this.uxFile1Text.Name = "uxFile1Text";
            this.uxFile1Text.Size = new System.Drawing.Size(76, 13);
            this.uxFile1Text.TabIndex = 2;
            this.uxFile1Text.Text = "File not loaded";
            // 
            // uxFile2Text
            // 
            this.uxFile2Text.AutoSize = true;
            this.uxFile2Text.Location = new System.Drawing.Point(117, 62);
            this.uxFile2Text.Name = "uxFile2Text";
            this.uxFile2Text.Size = new System.Drawing.Size(76, 13);
            this.uxFile2Text.TabIndex = 3;
            this.uxFile2Text.Text = "File not loaded";
            // 
            // uxMinCountText
            // 
            this.uxMinCountText.AutoSize = true;
            this.uxMinCountText.Location = new System.Drawing.Point(12, 99);
            this.uxMinCountText.Name = "uxMinCountText";
            this.uxMinCountText.Size = new System.Drawing.Size(79, 13);
            this.uxMinCountText.TabIndex = 4;
            this.uxMinCountText.Text = "Minimum Count";
            // 
            // uxMinCount
            // 
            this.uxMinCount.Location = new System.Drawing.Point(132, 99);
            this.uxMinCount.Name = "uxMinCount";
            this.uxMinCount.Size = new System.Drawing.Size(73, 20);
            this.uxMinCount.TabIndex = 5;
            this.uxMinCount.Text = "5";
            // 
            // uxGo
            // 
            this.uxGo.Location = new System.Drawing.Point(46, 144);
            this.uxGo.Name = "uxGo";
            this.uxGo.Size = new System.Drawing.Size(101, 23);
            this.uxGo.TabIndex = 6;
            this.uxGo.Text = "Find Overlaps";
            this.uxGo.UseVisualStyleBackColor = true;
            this.uxGo.Click += new System.EventHandler(this.uxGo_Click);
            // 
            // uxMatch
            // 
            this.uxMatch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxMatch.Location = new System.Drawing.Point(280, 21);
            this.uxMatch.Multiline = true;
            this.uxMatch.Name = "uxMatch";
            this.uxMatch.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.uxMatch.Size = new System.Drawing.Size(259, 509);
            this.uxMatch.TabIndex = 7;
            // 
            // uxFileDialog
            // 
            this.uxFileDialog.FileName = "openFileDialog1";
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 542);
            this.Controls.Add(this.uxMatch);
            this.Controls.Add(this.uxGo);
            this.Controls.Add(this.uxMinCount);
            this.Controls.Add(this.uxMinCountText);
            this.Controls.Add(this.uxFile2Text);
            this.Controls.Add(this.uxFile1Text);
            this.Controls.Add(this.uxFile2);
            this.Controls.Add(this.uxFile1);
            this.Name = "UserInterface";
            this.Text = "Phone Overlap Checker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxFile1;
        private System.Windows.Forms.Button uxFile2;
        private System.Windows.Forms.Label uxFile1Text;
        private System.Windows.Forms.Label uxFile2Text;
        private System.Windows.Forms.Label uxMinCountText;
        private System.Windows.Forms.DomainUpDown uxMinCount;
        private System.Windows.Forms.Button uxGo;
        private System.Windows.Forms.TextBox uxMatch;
        private System.Windows.Forms.OpenFileDialog uxFileDialog;
    }
}

