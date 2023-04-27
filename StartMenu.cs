using System;
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
            СклавыToolStripMenuItem.Enabled = true;
            InData.Enabled = false;
            OutData.Enabled = false;
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
                //Получаем выбранный файл↓
                string filename = openFileDialog.FileName;
                string fileText = System.IO.File.ReadAllText(filename);
                if (fileText == string.Empty)
                {
                    MessageBox.Show("Файл пуст, прошу провете данный файл\n" +
                        "Возможно он повреждён, или выберете другой файл...", "Ouppss...", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
                //Загрузка↓
                ProgressBars f = new ProgressBars();
                f.ShowDialog();
                //Запись в текстбокс↓
                InfoFile.Text = fileText;
            }
            InfoFromKeyboard.KeyBoardInfo = InfoFile.Text;
            KeyBoardIn f1 = new KeyBoardIn();
            f1.ShowDialog();
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
        private void СклавыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InfoFromKeyboard.KeyBoardInfo = InfoFile.Text;
            InfoFile.Clear();
            KeyBoardIn f = new KeyBoardIn();
            f.ShowDialog();
            InfoFile.Text = InfoFromKeyboard.KeyBoardInfo;
            InfoFile.Refresh();
            //DialogResult = MessageBox.Show("Что?\nЭто всё ещё в разроботке, " +
            //    "слишком рано нажали,\nнажмите на эту кнопку позже",
            //    "What the heck is that?", MessageBoxButtons.OK, MessageBoxIcon.Question);
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
            if (!string.IsNullOrEmpty(InfoFile.Text))
            {
                //Основной код
                TurtleLoad f = new TurtleLoad();
                f.ShowDialog();

                // Считываем данные из TextBox и разбиваем их на массив строк
                string[] inputLines = InfoFile.Text.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);

                /// Считываем vmax и t_1 из первой строки
                /// VMAx - Мах Скорость черепахи в См\сек.
                /// t_1 - Время в минутах, затрачиваемое черепахой на поедание одного одуванчика
                string[] vd = inputLines[0].Split(' ');
                int vmax = int.Parse(vd[0]);
                double t_1 = double.Parse(vd[1]);

                // Считываем количество одуванчиков из второй строки
                int n = int.Parse(inputLines[1]);

                // Создаем массив структур для хранения информации об одуванчиках
                var dandelions = new (int x, TimeSpan t)[n];

                // Считываем информацию об одуванчиках из оставшихся строк
                for (int i = 0; i < n; i++)
                {
                    string[] line = inputLines[i + 2].Split(' ');
                    int x = int.Parse(line[0]);
                    TimeSpan t = TimeSpan.ParseExact(line[1], @"mm\:ss", CultureInfo.InvariantCulture);
                    dandelions[i] = (x, t);
                }

                // Сортируем одуванчики по времени прорастания
                dandelions = dandelions.OrderBy(dan => dan.t).ToArray();

                // Вычисляем время, за которое черепаха съест все одуванчики
                double time = 0;
                int currentPos = 0;
                foreach (var dan in dandelions)
                {
                    int distance = dan.x - currentPos;
                    double eatingTime = distance / (double)vmax + dan.t.TotalMinutes - time;
                    time += eatingTime * t_1;
                    time += dan.t.TotalMinutes - eatingTime;
                    //time += eatingTime * t_1;
                    //currentPos = dan.x;
                }

                // Вычисляем время, за которое черепаха вернется домой
                time += currentPos / (double)vmax;

                // Выводим результат в TextBox
                OutResult.Text = TimeSpan.FromMinutes(Math.Ceiling(time)).ToString("hh\\:mm");
                //OutResult.Text += ("m");
            }
            else
            {
                InfoFile.BackColor = Color.Red;
                MessageBox.Show("Проблема в том что вы захотели запустить программу без данных!\n" +
                    "Прошу введите данные в Строчку!","Ooupsss...",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MainForm_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            MessageBox.Show("Справка по данному полю проста\nТуть вам предстоит наблюдать класивую картину\n" +
                "Что-бы познать мир...","HelpMen", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void InfoFile_MouseEnter(object sender, EventArgs e)
        {
            InfoFile.BackColor = Color.FromArgb(76, 76, 76);
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

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}