namespace Tyuiu.KhrapovDY.Sprint6.Task6.V30
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            openFileDialogTask_KDY = new OpenFileDialog();
            toolTip1 = new ToolTip(components);
            buttonHelp_KDY = new Button();
            buttonDone_KDY = new Button();
            buttonOpenFile_KDY = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            groupBoxTask_KDY = new GroupBox();
            textBoxTask_KDY = new TextBox();
            panel4 = new Panel();
            groupBoxLoadFromFile_KDY = new GroupBox();
            textBoxLoadFromFile_KDY = new TextBox();
            splitter1 = new Splitter();
            panel3 = new Panel();
            groupBoxOutPutData_KDY = new GroupBox();
            textBoxResult_KDY = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBoxTask_KDY.SuspendLayout();
            panel4.SuspendLayout();
            groupBoxLoadFromFile_KDY.SuspendLayout();
            panel3.SuspendLayout();
            groupBoxOutPutData_KDY.SuspendLayout();
            SuspendLayout();
            // 
            // openFileDialogTask_KDY
            // 
            openFileDialogTask_KDY.FileName = "openFileDialog1";
            // 
            // toolTip1
            // 
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            toolTip1.ToolTipTitle = "Подсказка";
            // 
            // buttonHelp_KDY
            // 
            buttonHelp_KDY.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_KDY.Image = (Image)resources.GetObject("buttonHelp_KDY.Image");
            buttonHelp_KDY.Location = new Point(1794, 3);
            buttonHelp_KDY.Name = "buttonHelp_KDY";
            buttonHelp_KDY.Size = new Size(253, 187);
            buttonHelp_KDY.TabIndex = 2;
            toolTip1.SetToolTip(buttonHelp_KDY, "Сведение о программе");
            buttonHelp_KDY.UseVisualStyleBackColor = true;
            buttonHelp_KDY.Click += buttonHelp_KDY_Click;
            // 
            // buttonDone_KDY
            // 
            buttonDone_KDY.Image = (Image)resources.GetObject("buttonDone_KDY.Image");
            buttonDone_KDY.Location = new Point(259, 0);
            buttonDone_KDY.Name = "buttonDone_KDY";
            buttonDone_KDY.Size = new Size(261, 187);
            buttonDone_KDY.TabIndex = 1;
            toolTip1.SetToolTip(buttonDone_KDY, "Производит поиск в файле вхождений символов и конкатенирует строки в которых находятся эти символы");
            buttonDone_KDY.UseVisualStyleBackColor = true;
            buttonDone_KDY.Click += buttonDone_KDY_Click;
            // 
            // buttonOpenFile_KDY
            // 
            buttonOpenFile_KDY.Image = (Image)resources.GetObject("buttonOpenFile_KDY.Image");
            buttonOpenFile_KDY.Location = new Point(0, 0);
            buttonOpenFile_KDY.Name = "buttonOpenFile_KDY";
            buttonOpenFile_KDY.Size = new Size(253, 187);
            buttonOpenFile_KDY.TabIndex = 0;
            toolTip1.SetToolTip(buttonOpenFile_KDY, "Открыть файл\r\nВыберите нужный файл для обработки");
            buttonOpenFile_KDY.UseVisualStyleBackColor = true;
            buttonOpenFile_KDY.Click += buttonOpenFile_KDY_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonHelp_KDY);
            panel1.Controls.Add(buttonDone_KDY);
            panel1.Controls.Add(buttonOpenFile_KDY);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(2050, 189);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBoxTask_KDY);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 189);
            panel2.Name = "panel2";
            panel2.Size = new Size(2050, 200);
            panel2.TabIndex = 3;
            // 
            // groupBoxTask_KDY
            // 
            groupBoxTask_KDY.Controls.Add(textBoxTask_KDY);
            groupBoxTask_KDY.Location = new Point(0, 0);
            groupBoxTask_KDY.Name = "groupBoxTask_KDY";
            groupBoxTask_KDY.Padding = new Padding(5);
            groupBoxTask_KDY.Size = new Size(2050, 200);
            groupBoxTask_KDY.TabIndex = 0;
            groupBoxTask_KDY.TabStop = false;
            groupBoxTask_KDY.Text = "Условие:";
            // 
            // textBoxTask_KDY
            // 
            textBoxTask_KDY.Dock = DockStyle.Fill;
            textBoxTask_KDY.Location = new Point(5, 37);
            textBoxTask_KDY.Multiline = true;
            textBoxTask_KDY.Name = "textBoxTask_KDY";
            textBoxTask_KDY.ReadOnly = true;
            textBoxTask_KDY.Size = new Size(2040, 158);
            textBoxTask_KDY.TabIndex = 0;
            textBoxTask_KDY.Text = resources.GetString("textBoxTask_KDY.Text");
            // 
            // panel4
            // 
            panel4.Controls.Add(groupBoxLoadFromFile_KDY);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 389);
            panel4.Name = "panel4";
            panel4.Size = new Size(1026, 550);
            panel4.TabIndex = 4;
            // 
            // groupBoxLoadFromFile_KDY
            // 
            groupBoxLoadFromFile_KDY.Controls.Add(textBoxLoadFromFile_KDY);
            groupBoxLoadFromFile_KDY.Dock = DockStyle.Fill;
            groupBoxLoadFromFile_KDY.Location = new Point(0, 0);
            groupBoxLoadFromFile_KDY.Name = "groupBoxLoadFromFile_KDY";
            groupBoxLoadFromFile_KDY.Size = new Size(1026, 550);
            groupBoxLoadFromFile_KDY.TabIndex = 0;
            groupBoxLoadFromFile_KDY.TabStop = false;
            groupBoxLoadFromFile_KDY.Text = "Ввод:";
            // 
            // textBoxLoadFromFile_KDY
            // 
            textBoxLoadFromFile_KDY.Dock = DockStyle.Fill;
            textBoxLoadFromFile_KDY.Location = new Point(3, 35);
            textBoxLoadFromFile_KDY.Multiline = true;
            textBoxLoadFromFile_KDY.Name = "textBoxLoadFromFile_KDY";
            textBoxLoadFromFile_KDY.ScrollBars = ScrollBars.Vertical;
            textBoxLoadFromFile_KDY.Size = new Size(1020, 512);
            textBoxLoadFromFile_KDY.TabIndex = 0;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(1026, 389);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(6, 550);
            splitter1.TabIndex = 5;
            splitter1.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(groupBoxOutPutData_KDY);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(1032, 389);
            panel3.Name = "panel3";
            panel3.Size = new Size(1018, 550);
            panel3.TabIndex = 6;
            // 
            // groupBoxOutPutData_KDY
            // 
            groupBoxOutPutData_KDY.Controls.Add(textBoxResult_KDY);
            groupBoxOutPutData_KDY.Dock = DockStyle.Fill;
            groupBoxOutPutData_KDY.Location = new Point(0, 0);
            groupBoxOutPutData_KDY.Name = "groupBoxOutPutData_KDY";
            groupBoxOutPutData_KDY.Size = new Size(1018, 550);
            groupBoxOutPutData_KDY.TabIndex = 0;
            groupBoxOutPutData_KDY.TabStop = false;
            groupBoxOutPutData_KDY.Text = "Вывод:";
            // 
            // textBoxResult_KDY
            // 
            textBoxResult_KDY.Dock = DockStyle.Fill;
            textBoxResult_KDY.Location = new Point(3, 35);
            textBoxResult_KDY.Multiline = true;
            textBoxResult_KDY.Name = "textBoxResult_KDY";
            textBoxResult_KDY.ScrollBars = ScrollBars.Vertical;
            textBoxResult_KDY.Size = new Size(1012, 512);
            textBoxResult_KDY.TabIndex = 1;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2050, 939);
            Controls.Add(panel3);
            Controls.Add(splitter1);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormMain";
            Text = "Спринт 6 | Таск6 | Вариант 30 | Храпов Д.Ю.";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            groupBoxTask_KDY.ResumeLayout(false);
            groupBoxTask_KDY.PerformLayout();
            panel4.ResumeLayout(false);
            groupBoxLoadFromFile_KDY.ResumeLayout(false);
            groupBoxLoadFromFile_KDY.PerformLayout();
            panel3.ResumeLayout(false);
            groupBoxOutPutData_KDY.ResumeLayout(false);
            groupBoxOutPutData_KDY.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private OpenFileDialog openFileDialogTask_KDY;
        private ToolTip toolTip1;
        private Panel panel1;
        private Button buttonHelp_KDY;
        private Button buttonDone_KDY;
        private Button buttonOpenFile_KDY;
        private Panel panel2;
        private Panel panel4;
        private Splitter splitter1;
        private Panel panel3;
        private GroupBox groupBoxTask_KDY;
        private TextBox textBoxTask_KDY;
        private GroupBox groupBoxLoadFromFile_KDY;
        private TextBox textBoxLoadFromFile_KDY;
        private GroupBox groupBoxOutPutData_KDY;
        private TextBox textBoxResult_KDY;
    }
}
