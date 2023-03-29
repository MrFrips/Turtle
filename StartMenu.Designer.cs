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
            this.сохранитьФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.свойВариантToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ктоРазработчикToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Separator = new System.Windows.Forms.ToolStripSeparator();
            this.HelpMePlz = new System.Windows.Forms.ToolStripLabel();
            this.InfoFile = new System.Windows.Forms.RichTextBox();
            this.OutResult = new System.Windows.Forms.TextBox();
            this.DragAndDropPanel = new System.Windows.Forms.Panel();
            this.textAboutFile = new System.Windows.Forms.Button();
            this.go = new System.Windows.Forms.Button();
            this.AllTimer = new System.Windows.Forms.Timer(this.components);
            this.notifyBGDown = new System.Windows.Forms.NotifyIcon(this.components);
            this.InOutPutDataError = new System.Windows.Forms.ErrorProvider(this.components);
            this.HelpMenu.SuspendLayout();
            this.DragAndDropPanel.SuspendLayout();
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
            this.сохранитьФайлToolStripMenuItem,
            this.свойВариантToolStripMenuItem,
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
            this.открытьФайлToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.открытьФайлToolStripMenuItem.Text = "Открыть Файл?";
            this.открытьФайлToolStripMenuItem.Click += new System.EventHandler(this.открытьФайлToolStripMenuItem_Click);
            // 
            // сохранитьФайлToolStripMenuItem
            // 
            this.сохранитьФайлToolStripMenuItem.Name = "сохранитьФайлToolStripMenuItem";
            this.сохранитьФайлToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.сохранитьФайлToolStripMenuItem.Text = "Сохранить файл?";
            this.сохранитьФайлToolStripMenuItem.Click += new System.EventHandler(this.сохранитьФайлToolStripMenuItem_Click);
            // 
            // свойВариантToolStripMenuItem
            // 
            this.свойВариантToolStripMenuItem.Name = "свойВариантToolStripMenuItem";
            this.свойВариантToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.свойВариантToolStripMenuItem.Text = "Свой Вариант";
            this.свойВариантToolStripMenuItem.Click += new System.EventHandler(this.свойВариантToolStripMenuItem_Click);
            // 
            // ктоРазработчикToolStripMenuItem
            // 
            this.ктоРазработчикToolStripMenuItem.Name = "ктоРазработчикToolStripMenuItem";
            this.ктоРазработчикToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.ктоРазработчикToolStripMenuItem.Text = "Кто Разработчик?";
            this.ктоРазработчикToolStripMenuItem.Click += new System.EventHandler(this.ктоРазработчикToolStripMenuItem_Click);
            // 
            // выйтиToolStripMenuItem
            // 
            this.выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            this.выйтиToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
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
            // InfoFile
            // 
            this.InfoFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.InfoFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.InfoFile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InfoFile.Location = new System.Drawing.Point(0, 305);
            this.InfoFile.Name = "InfoFile";
            this.InfoFile.ReadOnly = true;
            this.InfoFile.Size = new System.Drawing.Size(124, 112);
            this.InfoFile.TabIndex = 8;
            this.InfoFile.Text = "";
            this.InfoFile.TextChanged += new System.EventHandler(this.InfoFile_TextChanged);
            // 
            // OutResult
            // 
            this.OutResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OutResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.OutResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OutResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.OutResult.ForeColor = System.Drawing.Color.White;
            this.OutResult.Location = new System.Drawing.Point(130, 391);
            this.OutResult.Name = "OutResult";
            this.OutResult.Size = new System.Drawing.Size(100, 26);
            this.OutResult.TabIndex = 9;
            this.OutResult.TextChanged += new System.EventHandler(this.OutResult_TextChanged);
            this.OutResult.MouseEnter += new System.EventHandler(this.ColorWhite);
            // 
            // DragAndDropPanel
            // 
            this.DragAndDropPanel.AllowDrop = true;
            this.DragAndDropPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DragAndDropPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.DragAndDropPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DragAndDropPanel.Controls.Add(this.textAboutFile);
            this.DragAndDropPanel.Location = new System.Drawing.Point(623, 258);
            this.DragAndDropPanel.Name = "DragAndDropPanel";
            this.DragAndDropPanel.Size = new System.Drawing.Size(258, 159);
            this.DragAndDropPanel.TabIndex = 10;
            //this.DragAndDropPanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragAndDropPanel_DragDrop);
            //this.DragAndDropPanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragAndDropPanel_DragEnter);
            //this.DragAndDropPanel.DragLeave += new System.EventHandler(this.DragAndDropPanel_DragLeave);
            // 
            // textAboutFile
            // 
            this.textAboutFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textAboutFile.Enabled = false;
            this.textAboutFile.Location = new System.Drawing.Point(13, 67);
            this.textAboutFile.Name = "textAboutFile";
            this.textAboutFile.Size = new System.Drawing.Size(231, 23);
            this.textAboutFile.TabIndex = 12;
            this.textAboutFile.Text = "Можно переместить файл сюда";
            this.textAboutFile.UseVisualStyleBackColor = true;
            // 
            // go
            // 
            this.go.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.go.Location = new System.Drawing.Point(740, 222);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(881, 416);
            this.Controls.Add(this.go);
            this.Controls.Add(this.DragAndDropPanel);
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
            this.DragAndDropPanel.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripMenuItem свойВариантToolStripMenuItem;
        private System.Windows.Forms.RichTextBox InfoFile;
        private System.Windows.Forms.TextBox OutResult;
        private System.Windows.Forms.ToolStripSeparator Separator;
        private System.Windows.Forms.Panel DragAndDropPanel;
        private System.Windows.Forms.ToolStripLabel HelpMePlz;
        private System.Windows.Forms.Button go;
        private System.Windows.Forms.Button textAboutFile;
        private System.Windows.Forms.Timer AllTimer;
        private System.Windows.Forms.NotifyIcon notifyBGDown;
        private System.Windows.Forms.ErrorProvider InOutPutDataError;
    }
}

