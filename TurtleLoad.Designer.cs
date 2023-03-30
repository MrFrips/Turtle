namespace Turtle
{
    partial class TurtleLoad
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TurtleLoad));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ProgresTurtleBar = new System.Windows.Forms.ProgressBar();
            this.TurtleTimer = new System.Windows.Forms.Timer(this.components);
            this.Notify_Done = new System.Windows.Forms.NotifyIcon(this.components);
            this.DotsTim = new System.Windows.Forms.Timer(this.components);
            this.LoadText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 129);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ProgresTurtleBar
            // 
            this.ProgresTurtleBar.Location = new System.Drawing.Point(12, 147);
            this.ProgresTurtleBar.Name = "ProgresTurtleBar";
            this.ProgresTurtleBar.Size = new System.Drawing.Size(242, 23);
            this.ProgresTurtleBar.TabIndex = 1;
            this.ProgresTurtleBar.Click += new System.EventHandler(this.ProgresTurtleBar_Click);
            // 
            // TurtleTimer
            // 
            this.TurtleTimer.Tick += new System.EventHandler(this.TurtleTimer_Tick);
            // 
            // Notify_Done
            // 
            this.Notify_Done.Text = "NoitfyForU";
            this.Notify_Done.Visible = true;
            // 
            // DotsTim
            // 
            this.DotsTim.Tick += new System.EventHandler(this.DotsTim_Tick);
            // 
            // LoadText
            // 
            this.LoadText.AutoSize = true;
            this.LoadText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoadText.ForeColor = System.Drawing.Color.White;
            this.LoadText.Location = new System.Drawing.Point(85, 173);
            this.LoadText.Name = "LoadText";
            this.LoadText.Size = new System.Drawing.Size(85, 20);
            this.LoadText.TabIndex = 2;
            this.LoadText.Text = "Загрузка";
            // 
            // TurtleLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(266, 203);
            this.Controls.Add(this.LoadText);
            this.Controls.Add(this.ProgresTurtleBar);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(266, 203);
            this.MinimumSize = new System.Drawing.Size(266, 179);
            this.Name = "TurtleLoad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TurtleLoad";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TurtleLoad_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TurtleLoad_FormClosed);
            this.Load += new System.EventHandler(this.TurtleLoad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar ProgresTurtleBar;
        private System.Windows.Forms.Timer TurtleTimer;
        private System.Windows.Forms.NotifyIcon Notify_Done;
        private System.Windows.Forms.Timer DotsTim;
        private System.Windows.Forms.Label LoadText;
    }
}