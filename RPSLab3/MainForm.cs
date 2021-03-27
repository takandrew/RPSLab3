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
        public MainForm()
        {
            InitializeComponent();
            MaximizeBox = false; //Отключение возможности растягивания окна
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

    }
}
