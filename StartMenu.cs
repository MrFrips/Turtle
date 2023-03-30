﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Turtle
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            AllTimer.Interval = 10000;
            AllTimer.Start();
            свойВариантToolStripMenuItem.Enabled = false;
        }
        private void открытьФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Открытие файла↓
            OpenFileDialog openFileDialog = new OpenFileDialog();
            {
                //Фильтра для файла↓
                openFileDialog.Filter = ("Текстовый Документ (*.txt)|*.txt");
                openFileDialog.InitialDirectory = ("C:\\Users\\portt\\Desktop");
                openFileDialog.FilterIndex = 2;
                openFileDialog.Title = ("Открыть файлик!");
                openFileDialog.FileName = ("turtle.in");
                openFileDialog.RestoreDirectory = true;
                //Откртытие Диолога↓
                if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
                ProgressBars f = new ProgressBars();
                f.ShowDialog();
                //получаем выбранный файл↓
                string filename = openFileDialog.FileName;
                string fileText = System.IO.File.ReadAllText(filename);
                //Запись в текстбокс↓
                InfoFile.Text = fileText;
            }
        }
        //Сохранение файла↓
        private void сохранитьФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(OutResult.Text))
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                {
                    //Фильтра для файла↓
                    saveFileDialog.Filter = ("Текстовый Документ (*.txt)|*.txt");
                    saveFileDialog.InitialDirectory = ("C:\\Users\\portt\\Desktop");
                    saveFileDialog.FilterIndex = 2;
                    saveFileDialog.Title = ("Открыть файлик!");
                    saveFileDialog.FileName = ("turtle.out");
                    saveFileDialog.RestoreDirectory = true;
                    //Откртытие Диолога↓
                    if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                        return;
                    ProgressBars f = new ProgressBars();
                    f.ShowDialog();
                    // получаем выбранный файл↓
                    string filename = saveFileDialog.FileName;
                    // сохраняем текст в файл↓
                    System.IO.File.WriteAllText(filename, OutResult.Text);
                    MessageBox.Show("Файл сохранен", "Успех!",MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else { OutResult.BackColor = Color.Red;
                MessageBox.Show("Прежде чем что-то сохранять\n" +
                    "Нужно как минимум что-то записать...", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ColorWhite(object sender, EventArgs e)
        {
            OutResult.BackColor = Color.FromArgb(76,76,76);
        }
        //Выход?↓
        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult vibor = MessageBox.Show("Вы точно хотите выйти?", "Уверенны?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (vibor == DialogResult.Yes) { Close(); } else {  }
        }
        //Developer↓
        private void ктоРазработчикToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Developer f = new Developer();
            f.Show();
        }
        //Нажатие на Strip Меню↓
        private void StripMenu_Click(object sender, EventArgs e)
        {
            AllTimer.Stop();
        }
        private void StripMenu_MouseLeave(object sender, EventArgs e)
        {
            AllTimer.Start();
        }

        //Обновление UI для текста, (фана), отпыта.
        int numMsg = 0;
        private void AllTimer_Tick(object sender, EventArgs e)
        {
            var msgs = new string[] { "← Кнопка классная, нажимай смелее!", "Поставишь 5 ★★★★★ в рейтинг?", 
                "Прошу не ★☆☆☆☆ 1 звезду...", "А ты знал что текст обновляеться каждые 10сек?", 
                "Если что то не поняно, ты всегда можешь нажать на кнопку снова!", "←" };
            HelpMePlz.Text = numMsg < msgs.Length ? msgs[numMsg] : "";
            numMsg++;
        }
        //Потверждение о выходе↓.
        private void свойВариантToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Что?\nЭто всё ещё в разроботке, " +
                "слишком рано нажали,\nнажмите на эту кнопку позже",
                "What the heck is that?", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
        private void StripMenuDown(object sender, EventArgs e)
        {
            AllTimer.Stop();
        }

        //туть работа с DragAndDrop ↓  +172 Строка в Desinger
        //private void DragAndDropPanel_DragEnter(object sender, DragEventArgs e)
        //{
        //    if (e.Data.GetDataPresent(DataFormats.FileDrop))
        //    {
        //        textAboutFile.Text = ("Вы можете отпустить файл...");
        //        e.Effect = DragDropEffects.Copy;
        //    }
        //}
        //private void DragAndDropPanel_DragLeave(object sender, EventArgs e)
        //{
        //    textAboutFile.Text = ("Можно переместить файл сюда.");
        //}
        //private void DragAndDropPanel_DragDrop(object sender, DragEventArgs e)
        //{
        //    string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
        //    InfoFile.Text = files[0];
        //}

        private void go_Click(object sender, EventArgs e)
        {
            //Основной код
            TurtleLoad f = new TurtleLoad();
            f.ShowDialog();
            string text = InfoFile.Text;

            string[] words = text.Split(new char[] { ':',' ' });
            // new char[] - массив символов-разделителей. Как меня поправили в 
            // комментариях, в данном случае достаточно написать text.Split(':')

            //string s1 = words[0];
            //string s2 = words[1];
            //string s3 = words[2];
            //string s4 = words[3];
            //string s5 = words[4];
            //string s6 = words[5];

            //string secondLine;
            //using (var reader = new StreamReader("MyTextFile.txt"))
            //{
            //    reader.ReadLine(); // чтобы пропустить одну строку
            //    secondLine = reader.ReadLine();  // записываем в переменную
            //}
        }

        private void MainForm_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            MessageBox.Show("Справка по данному полю проста\nТуть вам предстоит наблюдать класивую картну\nЧто-бы познать мир...","HelpMen", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //Help.ShowPopup(HelpMenu, hlpevent);
        }
        private void InfoFile_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(InfoFile.Text)) //== (InfoFile.Text.Length < 4))
            {
                InOutPutDataError.SetError(InfoFile, "Нe может быть пустым!");
            }

            else
            {
                InOutPutDataError.Clear();
            }
        }
        private void OutResult_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(OutResult.Text)) //== (OutResult.Text.Length < 4))
            {
                InOutPutDataError.SetError(OutResult, "Нe может быть пустым!");
            }
            //else if (OutResult.Text.Length < 4)
            //{
            //    InOutPutDataError.SetError(OutResult, "Слишком короткое имя!");
            //}
            else
            {
                InOutPutDataError.Clear();
            }
        }
    }
}