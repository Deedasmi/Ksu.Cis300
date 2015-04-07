namespace Ksu.Cis300.GraphDrawer
{
    partial class DrawGraph
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
            this.uxLoad = new System.Windows.Forms.Button();
            this.uxGraph = new Ksu.Cis300.GraphDrawing.GraphDrawing();
            this.uxFile = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // uxLoad
            // 
            this.uxLoad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxLoad.Location = new System.Drawing.Point(12, 259);
            this.uxLoad.Name = "uxLoad";
            this.uxLoad.Size = new System.Drawing.Size(360, 61);
            this.uxLoad.TabIndex = 0;
            this.uxLoad.Text = "Load Graph";
            this.uxLoad.UseVisualStyleBackColor = true;
            this.uxLoad.Click += new System.EventHandler(this.uxLoad_Click);
            // 
            // uxGraph
            // 
            this.uxGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxGraph.AutoScroll = true;
            this.uxGraph.GraphSize = new System.Drawing.Size(150, 150);
            this.uxGraph.Location = new System.Drawing.Point(12, 12);
            this.uxGraph.Name = "uxGraph";
            this.uxGraph.Size = new System.Drawing.Size(360, 241);
            this.uxGraph.TabIndex = 1;
            // 
            // uxFile
            // 
            this.uxFile.FileName = "openFileDialog1";
            // 
            // drawgraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 332);
            this.Controls.Add(this.uxGraph);
            this.Controls.Add(this.uxLoad);
            this.MinimumSize = new System.Drawing.Size(400, 370);
            this.Name = "drawgraph";
            this.Text = "Draw Graph";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uxLoad;
        private GraphDrawing.GraphDrawing uxGraph;
        private System.Windows.Forms.OpenFileDialog uxFile;
    }
}

