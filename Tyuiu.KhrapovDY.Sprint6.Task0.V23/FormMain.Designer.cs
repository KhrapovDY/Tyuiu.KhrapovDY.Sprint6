namespace Tyuiu.KhrapovDY.Sprint6.Task0.V23
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            label_KDY = new Label();
            pictureBox1 = new PictureBox();
            Zadacha_KDY = new Label();
            Vvod_KDY = new Label();
            textBoxVarX_KDY = new TextBox();
            textBoxResult_KDY = new TextBox();
            buttonDone_KDY = new Button();
            buttonHelp_KDY = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label_KDY
            // 
            label_KDY.AutoSize = true;
            label_KDY.Location = new Point(12, 9);
            label_KDY.Name = "label_KDY";
            label_KDY.Size = new Size(106, 32);
            label_KDY.TabIndex = 0;
            label_KDY.Text = "Условие";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(565, 54);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 100);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // Zadacha_KDY
            // 
            Zadacha_KDY.AutoSize = true;
            Zadacha_KDY.Location = new Point(12, 54);
            Zadacha_KDY.Name = "Zadacha_KDY";
            Zadacha_KDY.Size = new Size(409, 32);
            Zadacha_KDY.TabIndex = 5;
            Zadacha_KDY.Text = "Вычислить выражение по формуле";
            // 
            // Vvod_KDY
            // 
            Vvod_KDY.AutoSize = true;
            Vvod_KDY.Location = new Point(12, 252);
            Vvod_KDY.Name = "Vvod_KDY";
            Vvod_KDY.Size = new Size(174, 64);
            Vvod_KDY.TabIndex = 6;
            Vvod_KDY.Text = "Ввод данных:\r\nПеременная X";
            // 
            // textBoxVarX_KDY
            // 
            textBoxVarX_KDY.Location = new Point(12, 342);
            textBoxVarX_KDY.Name = "textBoxVarX_KDY";
            textBoxVarX_KDY.Size = new Size(174, 39);
            textBoxVarX_KDY.TabIndex = 7;
            textBoxVarX_KDY.KeyPress += textBoxVar_KDY_KeyPress;
            // 
            // textBoxResult_KDY
            // 
            textBoxResult_KDY.Location = new Point(565, 342);
            textBoxResult_KDY.Name = "textBoxResult_KDY";
            textBoxResult_KDY.Size = new Size(200, 39);
            textBoxResult_KDY.TabIndex = 8;
            textBoxResult_KDY.TextChanged += textBoxResult_TextChanged;
            // 
            // buttonDone_KDY
            // 
            buttonDone_KDY.Location = new Point(615, 392);
            buttonDone_KDY.Name = "buttonDone_KDY";
            buttonDone_KDY.Size = new Size(150, 46);
            buttonDone_KDY.TabIndex = 9;
            buttonDone_KDY.Text = "Выполнить";
            buttonDone_KDY.UseVisualStyleBackColor = true;
            buttonDone_KDY.Click += buttonDone_KDY_Click;
            buttonDone_KDY.Enter += buttonDone_KDY_Click;
            // 
            // buttonHelp_KDY
            // 
            buttonHelp_KDY.Location = new Point(543, 392);
            buttonHelp_KDY.Name = "buttonHelp_KDY";
            buttonHelp_KDY.Size = new Size(56, 46);
            buttonHelp_KDY.TabIndex = 10;
            buttonHelp_KDY.Text = "?";
            buttonHelp_KDY.UseVisualStyleBackColor = true;
            buttonHelp_KDY.Click += buttonHelp_KDY_Click;
            buttonHelp_KDY.Enter += buttonHelp_KDY_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonHelp_KDY);
            Controls.Add(buttonDone_KDY);
            Controls.Add(textBoxResult_KDY);
            Controls.Add(textBoxVarX_KDY);
            Controls.Add(Vvod_KDY);
            Controls.Add(Zadacha_KDY);
            Controls.Add(pictureBox1);
            Controls.Add(label_KDY);
            Name = "FormMain";
            Text = "Спринт 6|Таск0|Вариант 23|Храпов.Д.Ю.";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_KDY;
        private PictureBox pictureBox1;
        private Label Zadacha_KDY;
        private Label Vvod_KDY;
        private TextBox textBoxVarX_KDY;
        private TextBox textBoxResult_KDY;
        private Button buttonDone_KDY;
        private Button buttonHelp_KDY;
    }
}
