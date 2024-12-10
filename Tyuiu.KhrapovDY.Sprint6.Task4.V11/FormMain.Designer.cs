namespace Tyuiu.KhrapovDY.Sprint6.Task4.V11
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
            panel1 = new Panel();
            groupBoxStep_KDY = new GroupBox();
            textBoxStopStep_KDY = new TextBox();
            textBoxStartStep_KDY = new TextBox();
            labelStopStep_KDY = new Label();
            labelStartStep_KDY = new Label();
            buttonSave_KDY = new Button();
            buttonDone_KDY = new Button();
            buttonHelp_KDY = new Button();
            groupBoxTask_KDY = new GroupBox();
            textBoxTask_KDY = new TextBox();
            panel2 = new Panel();
            groupBoxResult_KDY = new GroupBox();
            textBoxResult_KDY = new TextBox();
            panel3 = new Panel();
            chartFunction_KDY = new System.Windows.Forms.DataVisualization.Charting.Chart();
            splitter1 = new Splitter();
            panel1.SuspendLayout();
            groupBoxStep_KDY.SuspendLayout();
            groupBoxTask_KDY.SuspendLayout();
            panel2.SuspendLayout();
            groupBoxResult_KDY.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_KDY).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(groupBoxStep_KDY);
            panel1.Controls.Add(buttonSave_KDY);
            panel1.Controls.Add(buttonDone_KDY);
            panel1.Controls.Add(buttonHelp_KDY);
            panel1.Controls.Add(groupBoxTask_KDY);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(2052, 200);
            panel1.TabIndex = 0;
            // 
            // groupBoxStep_KDY
            // 
            groupBoxStep_KDY.Controls.Add(textBoxStopStep_KDY);
            groupBoxStep_KDY.Controls.Add(textBoxStartStep_KDY);
            groupBoxStep_KDY.Controls.Add(labelStopStep_KDY);
            groupBoxStep_KDY.Controls.Add(labelStartStep_KDY);
            groupBoxStep_KDY.Location = new Point(958, 12);
            groupBoxStep_KDY.Name = "groupBoxStep_KDY";
            groupBoxStep_KDY.Padding = new Padding(5);
            groupBoxStep_KDY.Size = new Size(464, 182);
            groupBoxStep_KDY.TabIndex = 1;
            groupBoxStep_KDY.TabStop = false;
            groupBoxStep_KDY.Text = "Ввод данных";
            // 
            // textBoxStopStep_KDY
            // 
            textBoxStopStep_KDY.Location = new Point(247, 103);
            textBoxStopStep_KDY.Name = "textBoxStopStep_KDY";
            textBoxStopStep_KDY.Size = new Size(200, 39);
            textBoxStopStep_KDY.TabIndex = 6;
            // 
            // textBoxStartStep_KDY
            // 
            textBoxStartStep_KDY.Location = new Point(6, 103);
            textBoxStartStep_KDY.Name = "textBoxStartStep_KDY";
            textBoxStartStep_KDY.Size = new Size(200, 39);
            textBoxStartStep_KDY.TabIndex = 5;
            // 
            // labelStopStep_KDY
            // 
            labelStopStep_KDY.AutoSize = true;
            labelStopStep_KDY.Location = new Point(249, 54);
            labelStopStep_KDY.Name = "labelStopStep_KDY";
            labelStopStep_KDY.Size = new Size(147, 32);
            labelStopStep_KDY.TabIndex = 4;
            labelStopStep_KDY.Text = "Конец шага:";
            // 
            // labelStartStep_KDY
            // 
            labelStartStep_KDY.AutoSize = true;
            labelStartStep_KDY.Location = new Point(8, 54);
            labelStartStep_KDY.Name = "labelStartStep_KDY";
            labelStartStep_KDY.Size = new Size(139, 32);
            labelStartStep_KDY.TabIndex = 3;
            labelStartStep_KDY.Text = "Старт шага:";
            // 
            // buttonSave_KDY
            // 
            buttonSave_KDY.BackColor = SystemColors.HotTrack;
            buttonSave_KDY.Location = new Point(1612, 38);
            buttonSave_KDY.Name = "buttonSave_KDY";
            buttonSave_KDY.Size = new Size(178, 136);
            buttonSave_KDY.TabIndex = 2;
            buttonSave_KDY.Text = "Сохранить";
            buttonSave_KDY.UseVisualStyleBackColor = false;
            buttonSave_KDY.Click += buttonSave_KDY_Click;
            // 
            // buttonDone_KDY
            // 
            buttonDone_KDY.BackColor = Color.Green;
            buttonDone_KDY.Location = new Point(1428, 38);
            buttonDone_KDY.Name = "buttonDone_KDY";
            buttonDone_KDY.Size = new Size(178, 136);
            buttonDone_KDY.TabIndex = 1;
            buttonDone_KDY.Text = "Выполнить";
            buttonDone_KDY.UseVisualStyleBackColor = false;
            buttonDone_KDY.Click += buttonDone_KDY_Click;
            // 
            // buttonHelp_KDY
            // 
            buttonHelp_KDY.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_KDY.BackColor = SystemColors.MenuHighlight;
            buttonHelp_KDY.Location = new Point(1848, 38);
            buttonHelp_KDY.Name = "buttonHelp_KDY";
            buttonHelp_KDY.Size = new Size(178, 136);
            buttonHelp_KDY.TabIndex = 0;
            buttonHelp_KDY.Text = "Справка";
            buttonHelp_KDY.UseVisualStyleBackColor = false;
            buttonHelp_KDY.Click += buttonHelp_KDY_Click;
            // 
            // groupBoxTask_KDY
            // 
            groupBoxTask_KDY.Controls.Add(textBoxTask_KDY);
            groupBoxTask_KDY.Location = new Point(12, 12);
            groupBoxTask_KDY.Name = "groupBoxTask_KDY";
            groupBoxTask_KDY.Padding = new Padding(5);
            groupBoxTask_KDY.Size = new Size(940, 182);
            groupBoxTask_KDY.TabIndex = 0;
            groupBoxTask_KDY.TabStop = false;
            groupBoxTask_KDY.Text = "Условие:";
            // 
            // textBoxTask_KDY
            // 
            textBoxTask_KDY.Location = new Point(8, 40);
            textBoxTask_KDY.Multiline = true;
            textBoxTask_KDY.Name = "textBoxTask_KDY";
            textBoxTask_KDY.ReadOnly = true;
            textBoxTask_KDY.Size = new Size(924, 134);
            textBoxTask_KDY.TabIndex = 0;
            textBoxTask_KDY.Text = "Протабулировать функцию sin(x) на заданном диапазоне -5 до 5.\r\nРезультат вывести в textBox, построить график функции и сохранить в файл OutPutFileTask4.txt по нажатию кнопки.";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(groupBoxResult_KDY);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 200);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(5);
            panel2.Size = new Size(400, 985);
            panel2.TabIndex = 1;
            // 
            // groupBoxResult_KDY
            // 
            groupBoxResult_KDY.Controls.Add(textBoxResult_KDY);
            groupBoxResult_KDY.Dock = DockStyle.Fill;
            groupBoxResult_KDY.Location = new Point(5, 5);
            groupBoxResult_KDY.Name = "groupBoxResult_KDY";
            groupBoxResult_KDY.Size = new Size(390, 975);
            groupBoxResult_KDY.TabIndex = 0;
            groupBoxResult_KDY.TabStop = false;
            groupBoxResult_KDY.Text = "Вывод:";
            // 
            // textBoxResult_KDY
            // 
            textBoxResult_KDY.Dock = DockStyle.Fill;
            textBoxResult_KDY.Location = new Point(3, 35);
            textBoxResult_KDY.Multiline = true;
            textBoxResult_KDY.Name = "textBoxResult_KDY";
            textBoxResult_KDY.ScrollBars = ScrollBars.Vertical;
            textBoxResult_KDY.Size = new Size(384, 937);
            textBoxResult_KDY.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(chartFunction_KDY);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(400, 200);
            panel3.Name = "panel3";
            panel3.Size = new Size(1652, 985);
            panel3.TabIndex = 1;
            // 
            // chartFunction_KDY
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction_KDY.ChartAreas.Add(chartArea1);
            chartFunction_KDY.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chartFunction_KDY.Legends.Add(legend1);
            chartFunction_KDY.Location = new Point(0, 0);
            chartFunction_KDY.Name = "chartFunction_KDY";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction_KDY.Series.Add(series1);
            chartFunction_KDY.Size = new Size(1652, 985);
            chartFunction_KDY.TabIndex = 7;
            chartFunction_KDY.Text = "chart1";
            // 
            // splitter1
            // 
            splitter1.Location = new Point(400, 200);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(6, 985);
            splitter1.TabIndex = 2;
            splitter1.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2052, 1185);
            Controls.Add(splitter1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MinimumSize = new Size(800, 450);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск4 | Вариант 11 | Храпов Д.Ю.";
            panel1.ResumeLayout(false);
            groupBoxStep_KDY.ResumeLayout(false);
            groupBoxStep_KDY.PerformLayout();
            groupBoxTask_KDY.ResumeLayout(false);
            groupBoxTask_KDY.PerformLayout();
            panel2.ResumeLayout(false);
            groupBoxResult_KDY.ResumeLayout(false);
            groupBoxResult_KDY.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartFunction_KDY).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Splitter splitter1;
        private GroupBox groupBoxTask_KDY;
        private GroupBox groupBoxResult_KDY;
        private TextBox textBoxResult_KDY;
        private Button buttonSave_KDY;
        private Button buttonDone_KDY;
        private Button buttonHelp_KDY;
        private TextBox textBoxTask_KDY;
        private GroupBox groupBoxStep_KDY;
        private TextBox textBoxStopStep_KDY;
        private TextBox textBoxStartStep_KDY;
        private Label labelStopStep_KDY;
        private Label labelStartStep_KDY;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_KDY;
    }
}
