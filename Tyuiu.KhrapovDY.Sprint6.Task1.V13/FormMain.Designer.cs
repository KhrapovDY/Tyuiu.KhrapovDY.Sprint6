namespace Tyuiu.KhrapovDY.Sprint6.Task1.V13
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
            labelTask_KDY = new Label();
            groupBoxResult_KDY = new GroupBox();
            groupBoxStep_KDY = new GroupBox();
            buttonHelp_KDY = new Button();
            buttonDone_KDY = new Button();
            textBoxResult_KDY = new TextBox();
            textBoxStartStep_KDY = new TextBox();
            textBoxStopStep_KDY = new TextBox();
            labelStartStep_KDY = new Label();
            labelStopStep_KDY = new Label();
            labelResult_KDY = new Label();
            groupBoxTask_KDY.SuspendLayout();
            groupBoxResult_KDY.SuspendLayout();
            groupBoxStep_KDY.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_KDY
            // 
            groupBoxTask_KDY.Controls.Add(labelTask_KDY);
            groupBoxTask_KDY.Location = new Point(14, 12);
            groupBoxTask_KDY.Name = "groupBoxTask_KDY";
            groupBoxTask_KDY.Size = new Size(927, 305);
            groupBoxTask_KDY.TabIndex = 0;
            groupBoxTask_KDY.TabStop = false;
            groupBoxTask_KDY.Text = "Условие";
            // 
            // labelTask_KDY
            // 
            labelTask_KDY.AutoSize = true;
            labelTask_KDY.Location = new Point(12, 35);
            labelTask_KDY.Name = "labelTask_KDY";
            labelTask_KDY.Size = new Size(656, 64);
            labelTask_KDY.TabIndex = 0;
            labelTask_KDY.Text = "Протабулировать функцию sin(x) на заданном диапазоне.\r\nРезультат вывести в виде таблицы.";
            // 
            // groupBoxResult_KDY
            // 
            groupBoxResult_KDY.Controls.Add(labelResult_KDY);
            groupBoxResult_KDY.Controls.Add(textBoxResult_KDY);
            groupBoxResult_KDY.Location = new Point(957, 12);
            groupBoxResult_KDY.Name = "groupBoxResult_KDY";
            groupBoxResult_KDY.Size = new Size(416, 426);
            groupBoxResult_KDY.TabIndex = 1;
            groupBoxResult_KDY.TabStop = false;
            groupBoxResult_KDY.Text = "Вывод данных";
            // 
            // groupBoxStep_KDY
            // 
            groupBoxStep_KDY.Controls.Add(labelStopStep_KDY);
            groupBoxStep_KDY.Controls.Add(labelStartStep_KDY);
            groupBoxStep_KDY.Controls.Add(textBoxStopStep_KDY);
            groupBoxStep_KDY.Controls.Add(textBoxStartStep_KDY);
            groupBoxStep_KDY.Location = new Point(12, 323);
            groupBoxStep_KDY.Name = "groupBoxStep_KDY";
            groupBoxStep_KDY.Size = new Size(567, 115);
            groupBoxStep_KDY.TabIndex = 0;
            groupBoxStep_KDY.TabStop = false;
            groupBoxStep_KDY.Text = "Ввод данных";
            // 
            // buttonHelp_KDY
            // 
            buttonHelp_KDY.BackColor = SystemColors.MenuHighlight;
            buttonHelp_KDY.FlatStyle = FlatStyle.Flat;
            buttonHelp_KDY.Location = new Point(594, 335);
            buttonHelp_KDY.Name = "buttonHelp_KDY";
            buttonHelp_KDY.Size = new Size(125, 103);
            buttonHelp_KDY.TabIndex = 0;
            buttonHelp_KDY.Text = "Справка";
            buttonHelp_KDY.UseVisualStyleBackColor = false;
            buttonHelp_KDY.Click += buttonHelp_KDY_Click;
            // 
            // buttonDone_KDY
            // 
            buttonDone_KDY.BackColor = Color.Green;
            buttonDone_KDY.FlatStyle = FlatStyle.Flat;
            buttonDone_KDY.Location = new Point(725, 335);
            buttonDone_KDY.Name = "buttonDone_KDY";
            buttonDone_KDY.Size = new Size(214, 103);
            buttonDone_KDY.TabIndex = 2;
            buttonDone_KDY.Text = "Выполнить";
            buttonDone_KDY.UseVisualStyleBackColor = false;
            buttonDone_KDY.Click += buttonDone_KDY_Click;
            // 
            // textBoxResult_KDY
            // 
            textBoxResult_KDY.Font = new Font("Consolas", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxResult_KDY.Location = new Point(6, 70);
            textBoxResult_KDY.Multiline = true;
            textBoxResult_KDY.Name = "textBoxResult_KDY";
            textBoxResult_KDY.ReadOnly = true;
            textBoxResult_KDY.ScrollBars = ScrollBars.Vertical;
            textBoxResult_KDY.Size = new Size(404, 350);
            textBoxResult_KDY.TabIndex = 0;
            // 
            // textBoxStartStep_KDY
            // 
            textBoxStartStep_KDY.Location = new Point(12, 70);
            textBoxStartStep_KDY.Name = "textBoxStartStep_KDY";
            textBoxStartStep_KDY.Size = new Size(253, 39);
            textBoxStartStep_KDY.TabIndex = 0;
            textBoxStartStep_KDY.TextChanged += textBox2_TextChanged;
            // 
            // textBoxStopStep_KDY
            // 
            textBoxStopStep_KDY.Location = new Point(277, 70);
            textBoxStopStep_KDY.Name = "textBoxStopStep_KDY";
            textBoxStopStep_KDY.Size = new Size(284, 39);
            textBoxStopStep_KDY.TabIndex = 1;
            // 
            // labelStartStep_KDY
            // 
            labelStartStep_KDY.AutoSize = true;
            labelStartStep_KDY.Location = new Point(12, 35);
            labelStartStep_KDY.Name = "labelStartStep_KDY";
            labelStartStep_KDY.Size = new Size(139, 32);
            labelStartStep_KDY.TabIndex = 2;
            labelStartStep_KDY.Text = "Старт шага:";
            labelStartStep_KDY.Click += label1_Click;
            // 
            // labelStopStep_KDY
            // 
            labelStopStep_KDY.AutoSize = true;
            labelStopStep_KDY.Location = new Point(277, 35);
            labelStopStep_KDY.Name = "labelStopStep_KDY";
            labelStopStep_KDY.Size = new Size(147, 32);
            labelStopStep_KDY.TabIndex = 3;
            labelStopStep_KDY.Text = "Конец шага:";
            labelStopStep_KDY.Click += label2_Click;
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
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1385, 450);
            Controls.Add(buttonDone_KDY);
            Controls.Add(buttonHelp_KDY);
            Controls.Add(groupBoxStep_KDY);
            Controls.Add(groupBoxResult_KDY);
            Controls.Add(groupBoxTask_KDY);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск1 | Вариант 13 | Храпов.Д.Ю";
            groupBoxTask_KDY.ResumeLayout(false);
            groupBoxTask_KDY.PerformLayout();
            groupBoxResult_KDY.ResumeLayout(false);
            groupBoxResult_KDY.PerformLayout();
            groupBoxStep_KDY.ResumeLayout(false);
            groupBoxStep_KDY.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_KDY;
        private Label labelTask_KDY;
        private GroupBox groupBoxResult_KDY;
        private GroupBox groupBoxStep_KDY;
        private Button buttonHelp_KDY;
        private Button buttonDone_KDY;
        private TextBox textBoxResult_KDY;
        private Label labelStartStep_KDY;
        private TextBox textBoxStopStep_KDY;
        private TextBox textBoxStartStep_KDY;
        private Label labelResult_KDY;
        private Label labelStopStep_KDY;
    }
}
