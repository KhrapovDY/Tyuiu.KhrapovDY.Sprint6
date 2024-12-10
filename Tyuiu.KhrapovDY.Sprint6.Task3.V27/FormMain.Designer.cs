namespace Tyuiu.KhrapovDY.Sprint6.Task3.V27
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
            groupBoxTask_KDY = new GroupBox();
            textBoxTask_KDY = new TextBox();
            dataGridViewMatrix_KDY = new DataGridView();
            groupBoxResult_KDY = new GroupBox();
            textBoxResult_KDY = new TextBox();
            labelResult_KDY = new Label();
            buttonHelp_KDY = new Button();
            buttonDone_KDY = new Button();
            groupBoxTask_KDY.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_KDY).BeginInit();
            groupBoxResult_KDY.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_KDY
            // 
            groupBoxTask_KDY.Controls.Add(textBoxTask_KDY);
            groupBoxTask_KDY.Controls.Add(dataGridViewMatrix_KDY);
            groupBoxTask_KDY.Location = new Point(12, 12);
            groupBoxTask_KDY.Name = "groupBoxTask_KDY";
            groupBoxTask_KDY.Size = new Size(1147, 447);
            groupBoxTask_KDY.TabIndex = 0;
            groupBoxTask_KDY.TabStop = false;
            groupBoxTask_KDY.Text = "Условие";
            // 
            // textBoxTask_KDY
            // 
            textBoxTask_KDY.Location = new Point(6, 35);
            textBoxTask_KDY.Multiline = true;
            textBoxTask_KDY.Name = "textBoxTask_KDY";
            textBoxTask_KDY.ReadOnly = true;
            textBoxTask_KDY.Size = new Size(659, 406);
            textBoxTask_KDY.TabIndex = 1;
            textBoxTask_KDY.Text = "Дан массив 5 на 5 элементов.\r\n9    13  -14  23  1\r\n15 -17   21  25  23\r\n-4   29 -20 -10  14\r\n27   33  12  33 -12\r\n18  -9   -5   6    3\r\nВыполнить сортировку по возрастанию в четвертом столбце.";
            // 
            // dataGridViewMatrix_KDY
            // 
            dataGridViewMatrix_KDY.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrix_KDY.ColumnHeadersVisible = false;
            dataGridViewMatrix_KDY.Location = new Point(677, 35);
            dataGridViewMatrix_KDY.Name = "dataGridViewMatrix_KDY";
            dataGridViewMatrix_KDY.RowHeadersVisible = false;
            dataGridViewMatrix_KDY.RowHeadersWidth = 82;
            dataGridViewMatrix_KDY.Size = new Size(452, 406);
            dataGridViewMatrix_KDY.TabIndex = 0;
            // 
            // groupBoxResult_KDY
            // 
            groupBoxResult_KDY.Controls.Add(textBoxResult_KDY);
            groupBoxResult_KDY.Controls.Add(labelResult_KDY);
            groupBoxResult_KDY.Location = new Point(1165, 12);
            groupBoxResult_KDY.Name = "groupBoxResult_KDY";
            groupBoxResult_KDY.Size = new Size(322, 376);
            groupBoxResult_KDY.TabIndex = 1;
            groupBoxResult_KDY.TabStop = false;
            groupBoxResult_KDY.Text = "Вывод данных";
            // 
            // textBoxResult_KDY
            // 
            textBoxResult_KDY.Location = new Point(6, 70);
            textBoxResult_KDY.Multiline = true;
            textBoxResult_KDY.Name = "textBoxResult_KDY";
            textBoxResult_KDY.ReadOnly = true;
            textBoxResult_KDY.Size = new Size(310, 200);
            textBoxResult_KDY.TabIndex = 2;
            // 
            // labelResult_KDY
            // 
            labelResult_KDY.AutoSize = true;
            labelResult_KDY.Location = new Point(6, 35);
            labelResult_KDY.Name = "labelResult_KDY";
            labelResult_KDY.Size = new Size(125, 32);
            labelResult_KDY.TabIndex = 0;
            labelResult_KDY.Text = "Результат:";
            // 
            // buttonHelp_KDY
            // 
            buttonHelp_KDY.Location = new Point(1202, 398);
            buttonHelp_KDY.Name = "buttonHelp_KDY";
            buttonHelp_KDY.Size = new Size(65, 55);
            buttonHelp_KDY.TabIndex = 3;
            buttonHelp_KDY.Text = "?";
            buttonHelp_KDY.UseVisualStyleBackColor = true;
            buttonHelp_KDY.Click += buttonHelp_KDY_Click;
            // 
            // buttonDone_KDY
            // 
            buttonDone_KDY.Location = new Point(1304, 398);
            buttonDone_KDY.Name = "buttonDone_KDY";
            buttonDone_KDY.Size = new Size(177, 55);
            buttonDone_KDY.TabIndex = 4;
            buttonDone_KDY.Text = "Выполнить";
            buttonDone_KDY.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1499, 471);
            Controls.Add(buttonDone_KDY);
            Controls.Add(buttonHelp_KDY);
            Controls.Add(groupBoxResult_KDY);
            Controls.Add(groupBoxTask_KDY);
            Name = "FormMain";
            Text = "Спринт 6 | Таск3 | Вариант 27 | Храпов Д.Ю.";
            Load += FormMain_Load;
            groupBoxTask_KDY.ResumeLayout(false);
            groupBoxTask_KDY.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_KDY).EndInit();
            groupBoxResult_KDY.ResumeLayout(false);
            groupBoxResult_KDY.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_KDY;
        private DataGridView dataGridViewMatrix_KDY;
        private GroupBox groupBoxResult_KDY;
        private TextBox textBoxTask_KDY;
        private TextBox textBoxResult_KDY;
        private Label labelResult_KDY;
        private Button buttonHelp_KDY;
        private Button buttonDone_KDY;
    }
}
