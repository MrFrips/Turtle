namespace Turtle
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.BgWorker = new System.ComponentModel.BackgroundWorker();
            this.HelpMenu = new System.Windows.Forms.ToolStrip();
            this.StripMenu = new System.Windows.Forms.ToolStripDropDownButton();
            this.открытьФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.СклавыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ктоРазработчикToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Separator = new System.Windows.Forms.ToolStripSeparator();
            this.HelpMePlz = new System.Windows.Forms.ToolStripLabel();
            this.OutResult = new System.Windows.Forms.TextBox();
            this.go = new System.Windows.Forms.Button();
            this.AllTimer = new System.Windows.Forms.Timer(this.components);
            this.notifyBGDown = new System.Windows.Forms.NotifyIcon(this.components);
            this.InOutPutDataError = new System.Windows.Forms.ErrorProvider(this.components);
            this.InData = new System.Windows.Forms.Button();
            this.OutData = new System.Windows.Forms.Button();
            this.InfoFile = new System.Windows.Forms.RichTextBox();
            this.HelpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InOutPutDataError)).BeginInit();
            this.SuspendLayout();
            // 
            // HelpMenu
            // 
            this.HelpMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripMenu,
            this.Separator,
            this.HelpMePlz});
            this.HelpMenu.Location = new System.Drawing.Point(0, 0);
            this.HelpMenu.Name = "HelpMenu";
            this.HelpMenu.Size = new System.Drawing.Size(881, 25);
            this.HelpMenu.TabIndex = 7;
            this.HelpMenu.Text = "HelpMenu!";
            // 
            // StripMenu
            // 
            this.StripMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.StripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьФайлToolStripMenuItem,
            this.СклавыToolStripMenuItem,
            this.сохранитьФайлToolStripMenuItem,
            this.ктоРазработчикToolStripMenuItem,
            this.выйтиToolStripMenuItem});
            this.StripMenu.Image = ((System.Drawing.Image)(resources.GetObject("StripMenu.Image")));
            this.StripMenu.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.StripMenu.Name = "StripMenu";
            this.StripMenu.Size = new System.Drawing.Size(29, 22);
            this.StripMenu.Text = "toolStripDropDownButton1";
            this.StripMenu.ToolTipText = "Main Help Menu";
            this.StripMenu.Click += new System.EventHandler(this.StripMenu_Click);
            this.StripMenu.MouseEnter += new System.EventHandler(this.StripMenuDown);
            this.StripMenu.MouseLeave += new System.EventHandler(this.StripMenu_MouseLeave);
            // 
            // открытьФайлToolStripMenuItem
            // 
            this.открытьФайлToolStripMenuItem.Name = "открытьФайлToolStripMenuItem";
            this.открытьФайлToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.открытьФайлToolStripMenuItem.Text = "Открыть Файл?";
            this.открытьФайлToolStripMenuItem.Click += new System.EventHandler(this.открытьФайлToolStripMenuItem_Click);
            // 
            // СклавыToolStripMenuItem
            // 
            this.СклавыToolStripMenuItem.Name = "СклавыToolStripMenuItem";
            this.СклавыToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.СклавыToolStripMenuItem.Text = "Ввести с клавиатуры";
            this.СклавыToolStripMenuItem.Click += new System.EventHandler(this.СклавыToolStripMenuItem_Click);
            // 
            // сохранитьФайлToolStripMenuItem
            // 
            this.сохранитьФайлToolStripMenuItem.Name = "сохранитьФайлToolStripMenuItem";
            this.сохранитьФайлToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.сохранитьФайлToolStripMenuItem.Text = "Сохранить файл?";
            this.сохранитьФайлToolStripMenuItem.Click += new System.EventHandler(this.сохранитьФайлToolStripMenuItem_Click);
            // 
            // ктоРазработчикToolStripMenuItem
            // 
            this.ктоРазработчикToolStripMenuItem.Name = "ктоРазработчикToolStripMenuItem";
            this.ктоРазработчикToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.ктоРазработчикToolStripMenuItem.Text = "Кто Разработчик?";
            this.ктоРазработчикToolStripMenuItem.Click += new System.EventHandler(this.ктоРазработчикToolStripMenuItem_Click);
            // 
            // выйтиToolStripMenuItem
            // 
            this.выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            this.выйтиToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.выйтиToolStripMenuItem.Text = "Выйти?";
            this.выйтиToolStripMenuItem.Click += new System.EventHandler(this.выйтиToolStripMenuItem_Click);
            // 
            // Separator
            // 
            this.Separator.Name = "Separator";
            this.Separator.Size = new System.Drawing.Size(6, 25);
            // 
            // HelpMePlz
            // 
            this.HelpMePlz.Name = "HelpMePlz";
            this.HelpMePlz.Size = new System.Drawing.Size(105, 22);
            this.HelpMePlz.Text = "← Нажми кнопку!";
            // 
            // OutResult
            // 
            this.OutResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OutResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.OutResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OutResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F);
            this.OutResult.ForeColor = System.Drawing.Color.White;
            this.OutResult.Location = new System.Drawing.Point(183, 379);
            this.OutResult.Multiline = true;
            this.OutResult.Name = "OutResult";
            this.OutResult.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.OutResult.Size = new System.Drawing.Size(259, 38);
            this.OutResult.TabIndex = 9;
            this.OutResult.TextChanged += new System.EventHandler(this.OutResult_TextChanged);
            this.OutResult.MouseEnter += new System.EventHandler(this.ColorWhite);
            // 
            // go
            // 
            this.go.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.go.Location = new System.Drawing.Point(741, 379);
            this.go.MinimumSize = new System.Drawing.Size(128, 30);
            this.go.Name = "go";
            this.go.Size = new System.Drawing.Size(128, 30);
            this.go.TabIndex = 11;
            this.go.Text = "Начать подсчёт?";
            this.go.UseVisualStyleBackColor = true;
            this.go.Click += new System.EventHandler(this.go_Click);
            // 
            // AllTimer
            // 
            this.AllTimer.Tick += new System.EventHandler(this.AllTimer_Tick);
            // 
            // notifyBGDown
            // 
            this.notifyBGDown.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyBGDown.BalloonTipTitle = "Черепаха";
            this.notifyBGDown.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyBGDown.Icon")));
            this.notifyBGDown.Text = "Черепаха";
            this.notifyBGDown.Visible = true;
            // 
            // InOutPutDataError
            // 
            this.InOutPutDataError.ContainerControl = this;
            this.InOutPutDataError.Icon = ((System.Drawing.Icon)(resources.GetObject("InOutPutDataError.Icon")));
            // 
            // InData
            // 
            this.InData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.InData.BackColor = System.Drawing.Color.White;
            this.InData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InData.ForeColor = System.Drawing.Color.Black;
            this.InData.Location = new System.Drawing.Point(0, 218);
            this.InData.Name = "InData";
            this.InData.Size = new System.Drawing.Size(124, 23);
            this.InData.TabIndex = 12;
            this.InData.Text = "Входные данные:\r\n";
            this.InData.UseVisualStyleBackColor = false;
            // 
            // OutData
            // 
            this.OutData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OutData.BackColor = System.Drawing.Color.White;
            this.OutData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OutData.ForeColor = System.Drawing.Color.Black;
            this.OutData.Location = new System.Drawing.Point(183, 350);
            this.OutData.Name = "OutData";
            this.OutData.Size = new System.Drawing.Size(121, 23);
            this.OutData.TabIndex = 13;
            this.OutData.Text = "Выходные данные:";
            this.OutData.UseVisualStyleBackColor = false;
            // 
            // InfoFile
            // 
            this.InfoFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.InfoFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.InfoFile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InfoFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoFile.ForeColor = System.Drawing.Color.White;
            this.InfoFile.Location = new System.Drawing.Point(0, 247);
            this.InfoFile.Name = "InfoFile";
            this.InfoFile.Size = new System.Drawing.Size(177, 170);
            this.InfoFile.TabIndex = 8;
            this.InfoFile.Text = "";
            this.InfoFile.TextChanged += new System.EventHandler(this.InfoFile_TextChanged);
            this.InfoFile.MouseEnter += new System.EventHandler(this.InfoFile_MouseEnter);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(881, 416);
            this.Controls.Add(this.OutData);
            this.Controls.Add(this.InData);
            this.Controls.Add(this.go);
            this.Controls.Add(this.OutResult);
            this.Controls.Add(this.InfoFile);
            this.Controls.Add(this.HelpMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(250, 39);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.MainForm_HelpRequested);
            this.HelpMenu.ResumeLayout(false);
            this.HelpMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InOutPutDataError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker BgWorker;
        private System.Windows.Forms.ToolStrip HelpMenu;
        private System.Windows.Forms.ToolStripDropDownButton StripMenu;
        private System.Windows.Forms.ToolStripMenuItem открытьФайлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьФайлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ктоРазработчикToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem СклавыToolStripMenuItem;
        private System.Windows.Forms.TextBox OutResult;
        private System.Windows.Forms.ToolStripSeparator Separator;
        private System.Windows.Forms.ToolStripLabel HelpMePlz;
        private System.Windows.Forms.Button go;
        private System.Windows.Forms.Timer AllTimer;
        private System.Windows.Forms.NotifyIcon notifyBGDown;
        private System.Windows.Forms.ErrorProvider InOutPutDataError;
        private System.Windows.Forms.Button OutData;
        private System.Windows.Forms.Button InData;
        private System.Windows.Forms.RichTextBox InfoFile;
    }
}

