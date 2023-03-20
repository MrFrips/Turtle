namespace Turtle
{
    partial class ProgressBars
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.ProgressTimer = new System.Windows.Forms.Timer(this.components);
            this.TextLoading = new System.Windows.Forms.Label();
            this.DotTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 29);
            this.progressBar1.MarqueeAnimationSpeed = 10;
            this.progressBar1.Maximum = 0;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(233, 23);
            this.progressBar1.Step = 0;
            this.progressBar1.TabIndex = 0;
            // 
            // ProgressTimer
            // 
            this.ProgressTimer.Tick += new System.EventHandler(this.ProgressTimer_Tick);
            // 
            // TextLoading
            // 
            this.TextLoading.AutoSize = true;
            this.TextLoading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.TextLoading.ForeColor = System.Drawing.SystemColors.Control;
            this.TextLoading.Location = new System.Drawing.Point(84, 6);
            this.TextLoading.Name = "TextLoading";
            this.TextLoading.Size = new System.Drawing.Size(85, 20);
            this.TextLoading.TabIndex = 1;
            this.TextLoading.Text = "Загрузка";
            // 
            // DotTimer
            // 
            this.DotTimer.Tick += new System.EventHandler(this.DotTimer_Tick_1);
            // 
            // ProgressBars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(257, 64);
            this.Controls.Add(this.TextLoading);
            this.Controls.Add(this.progressBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(257, 64);
            this.MinimumSize = new System.Drawing.Size(257, 64);
            this.Name = "ProgressBars";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ProgressBars";
            this.Load += new System.EventHandler(this.ProgressBars_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer ProgressTimer;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label TextLoading;
        private System.Windows.Forms.Timer DotTimer;
    }
}