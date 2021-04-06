
namespace RPSLab3
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Graph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImportDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveResultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GraphTable = new System.Windows.Forms.DataGridView();
            this.BuildGraphButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.LeftBorderUpDown = new System.Windows.Forms.NumericUpDown();
            this.RightBorderUpDown = new System.Windows.Forms.NumericUpDown();
            this.ScaleUpDown = new System.Windows.Forms.NumericUpDown();
            this.ACoefficientUpDown = new System.Windows.Forms.NumericUpDown();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.настройкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AutoShowInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Graph)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GraphTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftBorderUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightBorderUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScaleUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ACoefficientUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Левая";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Правая";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Шаг";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Коэффициент a";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Границы графика";
            // 
            // Graph
            // 
            this.Graph.BackColor = System.Drawing.Color.Transparent;
            chartArea3.Name = "ChartArea1";
            this.Graph.ChartAreas.Add(chartArea3);
            this.Graph.Location = new System.Drawing.Point(227, 48);
            this.Graph.Name = "Graph";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series5.Name = "TractrixPos";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series6.Name = "TractrixNeg";
            this.Graph.Series.Add(series5);
            this.Graph.Series.Add(series6);
            this.Graph.Size = new System.Drawing.Size(677, 475);
            this.Graph.TabIndex = 9;
            this.Graph.Text = "chart1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.настройкаToolStripMenuItem,
            this.InfoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1233, 28);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ImportDataToolStripMenuItem,
            this.SaveDataToolStripMenuItem,
            this.SaveResultToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // ImportDataToolStripMenuItem
            // 
            this.ImportDataToolStripMenuItem.Name = "ImportDataToolStripMenuItem";
            this.ImportDataToolStripMenuItem.Size = new System.Drawing.Size(400, 26);
            this.ImportDataToolStripMenuItem.Text = "Импортировать исходные данные из файла";
            this.ImportDataToolStripMenuItem.Click += new System.EventHandler(this.ImportDataToolStripMenuItem_Click);
            // 
            // SaveDataToolStripMenuItem
            // 
            this.SaveDataToolStripMenuItem.Name = "SaveDataToolStripMenuItem";
            this.SaveDataToolStripMenuItem.Size = new System.Drawing.Size(400, 26);
            this.SaveDataToolStripMenuItem.Text = "Сохранить исходные данные в файл";
            this.SaveDataToolStripMenuItem.Click += new System.EventHandler(this.SaveDataToolStripMenuItem_Click);
            // 
            // SaveResultToolStripMenuItem
            // 
            this.SaveResultToolStripMenuItem.Name = "SaveResultToolStripMenuItem";
            this.SaveResultToolStripMenuItem.Size = new System.Drawing.Size(400, 26);
            this.SaveResultToolStripMenuItem.Text = "Сохранить результат в файл";
            this.SaveResultToolStripMenuItem.Click += new System.EventHandler(this.SaveResultToolStripMenuItem_Click);
            // 
            // InfoToolStripMenuItem
            // 
            this.InfoToolStripMenuItem.Name = "InfoToolStripMenuItem";
            this.InfoToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.InfoToolStripMenuItem.Text = "Справка";
            this.InfoToolStripMenuItem.Click += new System.EventHandler(this.InfoToolStripMenuItem_Click);
            // 
            // GraphTable
            // 
            this.GraphTable.AllowUserToAddRows = false;
            this.GraphTable.AllowUserToDeleteRows = false;
            this.GraphTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GraphTable.Location = new System.Drawing.Point(925, 74);
            this.GraphTable.Name = "GraphTable";
            this.GraphTable.ReadOnly = true;
            this.GraphTable.RowHeadersVisible = false;
            this.GraphTable.RowHeadersWidth = 51;
            this.GraphTable.RowTemplate.Height = 24;
            this.GraphTable.Size = new System.Drawing.Size(296, 426);
            this.GraphTable.TabIndex = 11;
            // 
            // BuildGraphButton
            // 
            this.BuildGraphButton.Location = new System.Drawing.Point(31, 397);
            this.BuildGraphButton.Name = "BuildGraphButton";
            this.BuildGraphButton.Size = new System.Drawing.Size(149, 34);
            this.BuildGraphButton.TabIndex = 12;
            this.BuildGraphButton.Text = "Построить график";
            this.BuildGraphButton.UseVisualStyleBackColor = true;
            this.BuildGraphButton.Click += new System.EventHandler(this.BuildGraphButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::RPSLab3.Properties.Resources._33;
            this.pictureBox2.Location = new System.Drawing.Point(59, 128);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(101, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RPSLab3.Properties.Resources._22;
            this.pictureBox1.Location = new System.Drawing.Point(12, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Трактриса";
            // 
            // LeftBorderUpDown
            // 
            this.LeftBorderUpDown.DecimalPlaces = 2;
            this.LeftBorderUpDown.Location = new System.Drawing.Point(31, 229);
            this.LeftBorderUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.LeftBorderUpDown.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.LeftBorderUpDown.Name = "LeftBorderUpDown";
            this.LeftBorderUpDown.Size = new System.Drawing.Size(65, 22);
            this.LeftBorderUpDown.TabIndex = 16;
            this.LeftBorderUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            // 
            // RightBorderUpDown
            // 
            this.RightBorderUpDown.DecimalPlaces = 2;
            this.RightBorderUpDown.Location = new System.Drawing.Point(115, 229);
            this.RightBorderUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.RightBorderUpDown.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.RightBorderUpDown.Name = "RightBorderUpDown";
            this.RightBorderUpDown.Size = new System.Drawing.Size(65, 22);
            this.RightBorderUpDown.TabIndex = 17;
            this.RightBorderUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // ScaleUpDown
            // 
            this.ScaleUpDown.DecimalPlaces = 2;
            this.ScaleUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.ScaleUpDown.Location = new System.Drawing.Point(72, 286);
            this.ScaleUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.ScaleUpDown.Name = "ScaleUpDown";
            this.ScaleUpDown.Size = new System.Drawing.Size(65, 22);
            this.ScaleUpDown.TabIndex = 18;
            this.ScaleUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // ACoefficientUpDown
            // 
            this.ACoefficientUpDown.DecimalPlaces = 2;
            this.ACoefficientUpDown.Location = new System.Drawing.Point(72, 338);
            this.ACoefficientUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ACoefficientUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.ACoefficientUpDown.Name = "ACoefficientUpDown";
            this.ACoefficientUpDown.Size = new System.Drawing.Size(65, 22);
            this.ACoefficientUpDown.TabIndex = 19;
            this.ACoefficientUpDown.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.CreatePrompt = true;
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            // 
            // настройкаToolStripMenuItem
            // 
            this.настройкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AutoShowInfoToolStripMenuItem});
            this.настройкаToolStripMenuItem.Name = "настройкаToolStripMenuItem";
            this.настройкаToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.настройкаToolStripMenuItem.Text = "Настройка";
            // 
            // AutoShowInfoToolStripMenuItem
            // 
            this.AutoShowInfoToolStripMenuItem.Name = "AutoShowInfoToolStripMenuItem";
            this.AutoShowInfoToolStripMenuItem.Size = new System.Drawing.Size(394, 26);
            this.AutoShowInfoToolStripMenuItem.Text = "Выводить справку при запуске программы";
            this.AutoShowInfoToolStripMenuItem.Click += new System.EventHandler(this.AutoShowInfoToolStripMenuItem_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(524, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "График функции";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1013, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "Таблица значений ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 535);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ACoefficientUpDown);
            this.Controls.Add(this.ScaleUpDown);
            this.Controls.Add(this.RightBorderUpDown);
            this.Controls.Add(this.LeftBorderUpDown);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BuildGraphButton);
            this.Controls.Add(this.GraphTable);
            this.Controls.Add(this.Graph);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Построение графика функции";
            ((System.ComponentModel.ISupportInitialize)(this.Graph)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GraphTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftBorderUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightBorderUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScaleUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ACoefficientUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataVisualization.Charting.Chart Graph;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveResultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InfoToolStripMenuItem;
        private System.Windows.Forms.DataGridView GraphTable;
        private System.Windows.Forms.Button BuildGraphButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripMenuItem ImportDataToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown LeftBorderUpDown;
        private System.Windows.Forms.NumericUpDown RightBorderUpDown;
        private System.Windows.Forms.NumericUpDown ScaleUpDown;
        private System.Windows.Forms.NumericUpDown ACoefficientUpDown;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem настройкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AutoShowInfoToolStripMenuItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

