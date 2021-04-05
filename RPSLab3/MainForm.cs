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
            for (int i = 0; i < arrXpos.Count; i++)
                GraphTable.Rows.Add(arrXneg[i], arrYpos[i]);
            for (int i = 1; i < arrXpos.Count; i++)
                GraphTable.Rows.Add(arrXpos[i], arrYneg[i]);
        }
    }
}
