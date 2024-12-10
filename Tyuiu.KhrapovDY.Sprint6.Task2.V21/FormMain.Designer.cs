namespace Tyuiu.KhrapovDY.Sprint6.Task2.V21
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBoxTask_KDY = new GroupBox();
            labelTask_KDY = new Label();
            groupBoxStep_KDY = new GroupBox();
            textBoxStartStep_KDY = new TextBox();
            textBoxStopStep_KDY = new TextBox();
            labelStopStep_KDY = new Label();
            labelStartStep_KDY = new Label();
            groupBoxResult_KDY = new GroupBox();
            chartFunction_KDY = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridViewFunction_KDY = new DataGridView();
            labelResult_KDY = new Label();
            buttonHelp_KDY = new Button();
            buttonDone_KDY = new Button();
            X = new DataGridViewTextBoxColumn();
            FX = new DataGridViewTextBoxColumn();
            groupBoxTask_KDY.SuspendLayout();
            groupBoxStep_KDY.SuspendLayout();
            groupBoxResult_KDY.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_KDY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_KDY).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask_KDY
            // 
            groupBoxTask_KDY.Controls.Add(labelTask_KDY);
            groupBoxTask_KDY.Location = new Point(12, 12);
            groupBoxTask_KDY.Name = "groupBoxTask_KDY";
            groupBoxTask_KDY.Size = new Size(844, 328);
            groupBoxTask_KDY.TabIndex = 0;
            groupBoxTask_KDY.TabStop = false;
            groupBoxTask_KDY.Text = "Условие";
            // 
            // labelTask_KDY
            // 
            labelTask_KDY.AutoSize = true;
            labelTask_KDY.Location = new Point(6, 35);
            labelTask_KDY.Name = "labelTask_KDY";
            labelTask_KDY.Size = new Size(722, 64);
            labelTask_KDY.TabIndex = 0;
            labelTask_KDY.Text = "Протабулировать функцию sin(x) на заданном диапазоне.\r\nРезультат вывести в DataGridView и построить график функции.";
            // 
            // groupBoxStep_KDY
            // 
            groupBoxStep_KDY.Controls.Add(textBoxStartStep_KDY);
            groupBoxStep_KDY.Controls.Add(textBoxStopStep_KDY);
            groupBoxStep_KDY.Controls.Add(labelStopStep_KDY);
            groupBoxStep_KDY.Controls.Add(labelStartStep_KDY);
            groupBoxStep_KDY.Location = new Point(12, 346);
            groupBoxStep_KDY.Name = "groupBoxStep_KDY";
            groupBoxStep_KDY.Size = new Size(449, 142);
            groupBoxStep_KDY.TabIndex = 0;
            groupBoxStep_KDY.TabStop = false;
            groupBoxStep_KDY.Text = "Ввод данных";
            // 
            // textBoxStartStep_KDY
            // 
            textBoxStartStep_KDY.Location = new Point(6, 85);
            textBoxStartStep_KDY.Name = "textBoxStartStep_KDY";
            textBoxStartStep_KDY.Size = new Size(200, 39);
            textBoxStartStep_KDY.TabIndex = 5;
            // 
            // textBoxStopStep_KDY
            // 
            textBoxStopStep_KDY.Location = new Point(232, 85);
            textBoxStopStep_KDY.Name = "textBoxStopStep_KDY";
            textBoxStopStep_KDY.Size = new Size(200, 39);
            textBoxStopStep_KDY.TabIndex = 4;
            // 
            // labelStopStep_KDY
            // 
            labelStopStep_KDY.AutoSize = true;
            labelStopStep_KDY.Location = new Point(232, 35);
            labelStopStep_KDY.Name = "labelStopStep_KDY";
            labelStopStep_KDY.Size = new Size(147, 32);
            labelStopStep_KDY.TabIndex = 3;
            labelStopStep_KDY.Text = "Конец шага:";
            // 
            // labelStartStep_KDY
            // 
            labelStartStep_KDY.AutoSize = true;
            labelStartStep_KDY.Location = new Point(6, 35);
            labelStartStep_KDY.Name = "labelStartStep_KDY";
            labelStartStep_KDY.Size = new Size(139, 32);
            labelStartStep_KDY.TabIndex = 2;
            labelStartStep_KDY.Text = "Старт шага:";
            // 
            // groupBoxResult_KDY
            // 
            groupBoxResult_KDY.Controls.Add(chartFunction_KDY);
            groupBoxResult_KDY.Controls.Add(dataGridViewFunction_KDY);
            groupBoxResult_KDY.Controls.Add(labelResult_KDY);
            groupBoxResult_KDY.Location = new Point(862, 12);
            groupBoxResult_KDY.Name = "groupBoxResult_KDY";
            groupBoxResult_KDY.Size = new Size(937, 476);
            groupBoxResult_KDY.TabIndex = 0;
            groupBoxResult_KDY.TabStop = false;
            groupBoxResult_KDY.Text = "Вывод данных";
            // 
            // chartFunction_KDY
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction_KDY.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFunction_KDY.Legends.Add(legend1);
            chartFunction_KDY.Location = new Point(240, 38);
            chartFunction_KDY.Name = "chartFunction_KDY";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction_KDY.Series.Add(series1);
            chartFunction_KDY.Size = new Size(691, 432);
            chartFunction_KDY.TabIndex = 3;
            chartFunction_KDY.Text = "chart1";
            // 
            // dataGridViewFunction_KDY
            // 
            dataGridViewFunction_KDY.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFunction_KDY.Columns.AddRange(new DataGridViewColumn[] { X, FX });
            dataGridViewFunction_KDY.Location = new Point(6, 70);
            dataGridViewFunction_KDY.Name = "dataGridViewFunction_KDY";
            dataGridViewFunction_KDY.RowHeadersVisible = false;
            dataGridViewFunction_KDY.RowHeadersWidth = 82;
            dataGridViewFunction_KDY.Size = new Size(211, 400);
            dataGridViewFunction_KDY.TabIndex = 2;
            // 
            // labelResult_KDY
            // 
            labelResult_KDY.AutoSize = true;
            labelResult_KDY.Location = new Point(6, 35);
            labelResult_KDY.Name = "labelResult_KDY";
            labelResult_KDY.Size = new Size(125, 32);
            labelResult_KDY.TabIndex = 1;
            labelResult_KDY.Text = "Результат:";
            // 
            // buttonHelp_KDY
            // 
            buttonHelp_KDY.BackColor = SystemColors.MenuHighlight;
            buttonHelp_KDY.Location = new Point(477, 367);
            buttonHelp_KDY.Name = "buttonHelp_KDY";
            buttonHelp_KDY.Size = new Size(128, 121);
            buttonHelp_KDY.TabIndex = 1;
            buttonHelp_KDY.Text = "Справка";
            buttonHelp_KDY.UseVisualStyleBackColor = false;
            // 
            // buttonDone_KDY
            // 
            buttonDone_KDY.BackColor = Color.Green;
            buttonDone_KDY.Location = new Point(624, 367);
            buttonDone_KDY.Name = "buttonDone_KDY";
            buttonDone_KDY.Size = new Size(215, 121);
            buttonDone_KDY.TabIndex = 2;
            buttonDone_KDY.Text = "Выполнить";
            buttonDone_KDY.UseVisualStyleBackColor = false;
            buttonDone_KDY.MouseDown += buttonDone_KDY_MouseDown;
            buttonDone_KDY.MouseEnter += buttonDone_KDY_MouseEnter;
            buttonDone_KDY.MouseLeave += buttonDone_KDY_MouseLeave;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.MinimumWidth = 5;
            X.Name = "X";
            X.Width = 100;
            // 
            // FX
            // 
            FX.HeaderText = "F(X)";
            FX.MinimumWidth = 5;
            FX.Name = "FX";
            FX.Width = 100;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1811, 500);
            Controls.Add(buttonDone_KDY);
            Controls.Add(buttonHelp_KDY);
            Controls.Add(groupBoxResult_KDY);
            Controls.Add(groupBoxStep_KDY);
            Controls.Add(groupBoxTask_KDY);
            Name = "FormMain";
            Text = "Спринт 6 | Таск2 | Вариант 21 | Храпов.Д.Ю";
            Load += FormMain_Load;
            groupBoxTask_KDY.ResumeLayout(false);
            groupBoxTask_KDY.PerformLayout();
            groupBoxStep_KDY.ResumeLayout(false);
            groupBoxStep_KDY.PerformLayout();
            groupBoxResult_KDY.ResumeLayout(false);
            groupBoxResult_KDY.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_KDY).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_KDY).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_KDY;
        private Label labelTask_KDY;
        private GroupBox groupBoxStep_KDY;
        private GroupBox groupBoxResult_KDY;
        private Label labelStopStep_KDY;
        private Label labelStartStep_KDY;
        private Label labelResult_KDY;
        private TextBox textBoxStartStep_KDY;
        private TextBox textBoxStopStep_KDY;
        private Button buttonHelp_KDY;
        private Button buttonDone_KDY;
        private DataGridView dataGridViewFunction_KDY;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_KDY;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn FX;
    }
}
