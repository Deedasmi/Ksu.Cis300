namespace Ksu.Cis300.BaseBallScores
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
            this.uxGetFile = new System.Windows.Forms.Button();
            this.uxFile = new System.Windows.Forms.OpenFileDialog();
            this.uxResults = new System.Windows.Forms.Button();
            this.uxTeams = new System.Windows.Forms.ComboBox();
            this.uxDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // uxGetFile
            // 
            this.uxGetFile.Location = new System.Drawing.Point(12, 12);
            this.uxGetFile.Name = "uxGetFile";
            this.uxGetFile.Size = new System.Drawing.Size(349, 46);
            this.uxGetFile.TabIndex = 0;
            this.uxGetFile.Text = "Add Data File";
            this.uxGetFile.UseVisualStyleBackColor = true;
            this.uxGetFile.Click += new System.EventHandler(this.uxGetFile_Click);
            // 
            // uxFile
            // 
            this.uxFile.FileName = "openFileDialog1";
            // 
            // uxResults
            // 
            this.uxResults.Enabled = false;
            this.uxResults.Location = new System.Drawing.Point(154, 112);
            this.uxResults.Name = "uxResults";
            this.uxResults.Size = new System.Drawing.Size(207, 66);
            this.uxResults.TabIndex = 1;
            this.uxResults.Text = "Get Game Results";
            this.uxResults.UseVisualStyleBackColor = true;
            this.uxResults.Click += new System.EventHandler(this.uxResults_Click);
            // 
            // uxTeams
            // 
            this.uxTeams.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uxTeams.Enabled = false;
            this.uxTeams.FormattingEnabled = true;
            this.uxTeams.Location = new System.Drawing.Point(13, 65);
            this.uxTeams.Name = "uxTeams";
            this.uxTeams.Size = new System.Drawing.Size(348, 21);
            this.uxTeams.Sorted = true;
            this.uxTeams.TabIndex = 2;
            // 
            // uxDate
            // 
            this.uxDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.uxDate.Location = new System.Drawing.Point(12, 136);
            this.uxDate.MaxDate = new System.DateTime(2013, 12, 31, 0, 0, 0, 0);
            this.uxDate.MinDate = new System.DateTime(1871, 1, 1, 0, 0, 0, 0);
            this.uxDate.Name = "uxDate";
            this.uxDate.Size = new System.Drawing.Size(136, 20);
            this.uxDate.TabIndex = 3;
            this.uxDate.Value = new System.DateTime(2013, 12, 31, 0, 0, 0, 0);
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 190);
            this.Controls.Add(this.uxDate);
            this.Controls.Add(this.uxTeams);
            this.Controls.Add(this.uxResults);
            this.Controls.Add(this.uxGetFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "UserInterface";
            this.Text = "Baseball Scores";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uxGetFile;
        private System.Windows.Forms.OpenFileDialog uxFile;
        private System.Windows.Forms.Button uxResults;
        private System.Windows.Forms.ComboBox uxTeams;
        private System.Windows.Forms.DateTimePicker uxDate;
    }
}

