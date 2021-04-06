using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPSLab3
{
    public partial class MainForm : Form
    {
        InfoForm showInfoForm = null;
        double aCoefficient;
        double leftBorder;
        double rightBorder;
        double scale;
        double x; double y;
        List<double> arrXpos = new List<double>();
        List<double> arrYpos = new List<double>();
        List<double> arrXneg = new List<double>();
        List<double> arrYneg = new List<double>();
        int scaleNum;
        public MainForm()
        {
            InitializeComponent();
            MaximizeBox = false; //Отключение возможности растягивания окна
            Graph.Series["TractrixPos"].Points.AddXY(0, 0);
            Graph.Series["TractrixNeg"].Points.AddXY(0, 0);
            Graph.ChartAreas[0].AxisX.Minimum = -5;
            Graph.ChartAreas[0].AxisX.Maximum = 5;
            Graph.ChartAreas[0].AxisY.Minimum = 0;
            Graph.ChartAreas[0].AxisY.Maximum = 5;
            SaveDataToolStripMenuItem.Enabled = false;
            SaveResultToolStripMenuItem.Enabled = false;
            if (AutoShowInfo.Default.autoShowInfo == true)
            {
                AutoShowInfoToolStripMenuItem.Checked = true;
                showInfoForm = new InfoForm();
                showInfoForm.Show();

            }
            else
                AutoShowInfoToolStripMenuItem.Checked = false;
        }

        private void InfoToolStripMenuItem_Click(object sender, EventArgs e) //Вывод справочного окна
        {
            //Вызов формы и запрет на открытие множества одинаковых окон
            if (showInfoForm == null || showInfoForm.IsDisposed)
            {
                showInfoForm = new InfoForm();
                showInfoForm.Show();
            }
            else
            {
                showInfoForm.Show();
                showInfoForm.Focus();
            }
        }

        private void BuildGraphButton_Click(object sender, EventArgs e)
        {
            SaveDataToolStripMenuItem.Enabled = true;
            SaveResultToolStripMenuItem.Enabled = true;
            GraphTable.Rows.Clear();
            GraphTable.Columns.Clear();
            arrYpos.Clear(); arrXpos.Clear();
            arrYneg.Clear(); arrXneg.Clear();
            Graph.Series["TractrixPos"].Points.Clear();
            Graph.Series["TractrixNeg"].Points.Clear();
            aCoefficient = (double)ACoefficientUpDown.Value;
            leftBorder = (double)LeftBorderUpDown.Value;
            rightBorder = (double)RightBorderUpDown.Value;
            if (leftBorder >= rightBorder)
            {
                MessageBox.Show("Левая граница не может быть больше или равной правой!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Graph.ChartAreas[0].AxisX.Minimum = leftBorder;
            Graph.ChartAreas[0].AxisX.Maximum = rightBorder;
            Graph.ChartAreas[0].AxisY.Minimum = 0;
            Graph.ChartAreas[0].AxisY.Maximum = aCoefficient;
            scale = (double)ScaleUpDown.Value;
            //Graph.Series["TractrixPos"].Points.AddXY(0, aCoefficient);
            //Graph.Series["TractrixNeg"].Points.AddXY(0, aCoefficient);
            for (y = aCoefficient; y > 0; y -= scale)
            {
                x = Tractrix.TractrixBuild(y, aCoefficient);
                if ((x >= leftBorder) && (x <= rightBorder))
                {
                    Graph.Series["TractrixPos"].Points.AddXY(x, y);
                    Graph.Series["TractrixNeg"].Points.AddXY(-x, y);
                    arrXpos.Add(x);
                    arrXneg.Add(-x);
                    arrYneg.Add(y);
                    arrYpos.Add(y);
                }
            }
            arrYpos.Reverse();
            arrXneg.Reverse();
            GraphTable.Columns.Add("xColumn", "x");
            GraphTable.Columns.Add("yColumn", "y");
            var scaleDotPos = (scale.ToString()).IndexOf('.');
            scaleNum = (scale.ToString()).Length - 1 - scaleDotPos;
            for (int i = 0; i < arrXpos.Count; i++)
                GraphTable.Rows.Add(Math.Round(arrXneg[i], scaleNum), Math.Round(arrYpos[i], scaleNum));
            for (int i = 1; i < arrXpos.Count; i++)
                GraphTable.Rows.Add(Math.Round(arrXpos[i], scaleNum), Math.Round(arrYneg[i], scaleNum));
        }

        private void SaveDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return; //Случай с отменой выбора файла
            string saveFilename = saveFileDialog1.FileName;
            //Сохранение в файл
            System.IO.File.WriteAllText(saveFilename, LeftBorderUpDown.Text + "\n" + RightBorderUpDown.Text +
               "\n" + (ScaleUpDown.Value).ToString() + "\n" + ACoefficientUpDown.Text);
            MessageBox.Show("Файл сохранен", "Файл");
        }

        private void ImportDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("В файле должно содержаться только 4 числа в строго определённом порядке:\n" +
                                "левая граница, правая граница, шаг, коэффициент.\n", "Внимание!",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (openFileDialog1.ShowDialog() == DialogResult.Cancel) // Отчистка пути после закрытия окна выбора файла
                    return;
                string openFilename = openFileDialog1.FileName; // Получение имени файла 
                string dataString = null;
                dataString = System.IO.File.ReadAllText(openFilename); // Чтение данных из файла
                string[] separatorsString = { "\r", "\n", " ", "\t" }; // Массив символов, по которым будет разбиваться введённый массив
                List<double> dataList = dataString.Split(separatorsString, StringSplitOptions.RemoveEmptyEntries) // Разбиение строки по указанным символам
                                      .Select(n => double.Parse(n)) // Преобразование элементов строки в double
                                      .ToList(); // Преобразование данных в список
                // Проверка количества данных в файле
                if (dataList.Count > 4 || dataList.Count < 4)
                {
                    throw new ArgumentOutOfRangeException();
                }
                // Ввод данных из файла в поля формы 
                LeftBorderUpDown.Value = (decimal)dataList[0];
                RightBorderUpDown.Value = (decimal)dataList[1];
                ScaleUpDown.Value = (decimal)dataList[2];
                ACoefficientUpDown.Value = (decimal)dataList[3];
            }
            catch (FormatException)
            {
                MessageBox.Show("Файл содержит некорректные данные.\n" +
                                "Файл не должен содержать букв и спец. символов.", "Ошибка!",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("В файле недостаточно данных или файл содержит больше данных, чем нужно.", "Ошибка!",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return; //Случай с отменой выбора файла
            string saveFilename = saveFileDialog1.FileName;
            string dataString =
                            "Левая граница: " + leftBorder + "\n" +
                            "Правая граница: " + rightBorder + "\n" +
                            "Шаг: " + scale + "\n" +
                            "Коэффициент c: " + aCoefficient + "\n" +
                            "\nТаблица значений.\n";
            string tableString = String.Format("\n{0, 12} {1, 15}", "Координата X", "Координата Y");
            for (int i = 0; i < arrXneg.Count; i++)
            {
                tableString += String.Format("\n{0, 9} {1, 16}",
                                       Math.Round(arrXneg[i], scaleNum), Math.Round(arrYpos[i], scaleNum));
            }
            for (int i = 1; i < arrXneg.Count; i++)
            {
                tableString += String.Format("\n{0, 9} {1, 16}",
                                       Math.Round(arrXpos[i], scaleNum), Math.Round(arrYneg[i], scaleNum));
            }
            string resultString = dataString + tableString;
            //Сохранение в файл
            System.IO.File.WriteAllText(saveFilename, resultString);
            MessageBox.Show("Файл сохранен", "Файл");
        }

        private void AutoShowInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (AutoShowInfoToolStripMenuItem.Checked)
            {
                AutoShowInfoToolStripMenuItem.Checked = false;
                AutoShowInfo.Default.autoShowInfo = false;
                AutoShowInfo.Default.Save();
            }
            else
            {
                AutoShowInfoToolStripMenuItem.Checked = true;
                AutoShowInfo.Default.autoShowInfo = true;
                AutoShowInfo.Default.Save();
            }
        }
    }
}
