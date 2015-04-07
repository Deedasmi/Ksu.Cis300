namespace Ksu.Cis300.MazeSolver
{
    partial class MazeSolverForm
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
            this.uxMaze = new Ksu.Cis300.MazeLibrary.Maze();
            this.uxNew = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxMaze
            // 
            this.uxMaze.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxMaze.Location = new System.Drawing.Point(1, 0);
            this.uxMaze.Name = "uxMaze";
            this.uxMaze.PathColor = System.Drawing.SystemColors.Highlight;
            this.uxMaze.Size = new System.Drawing.Size(283, 222);
            this.uxMaze.TabIndex = 0;
            this.uxMaze.MouseClick += new System.Windows.Forms.MouseEventHandler(this.uxMaze_MouseClick);
            // 
            // uxNew
            // 
            this.uxNew.Location = new System.Drawing.Point(102, 228);
            this.uxNew.Name = "uxNew";
            this.uxNew.Size = new System.Drawing.Size(75, 23);
            this.uxNew.TabIndex = 1;
            this.uxNew.Text = "New Maze";
            this.uxNew.UseVisualStyleBackColor = true;
            this.uxNew.Click += new System.EventHandler(this.uxNew_Click);
            // 
            // MazeSolverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.uxNew);
            this.Controls.Add(this.uxMaze);
            this.Name = "MazeSolverForm";
            this.Text = "Maze Solver";
            this.ResumeLayout(false);

        }

        #endregion

        private MazeLibrary.Maze uxMaze;
        private System.Windows.Forms.Button uxNew;
    }
}

