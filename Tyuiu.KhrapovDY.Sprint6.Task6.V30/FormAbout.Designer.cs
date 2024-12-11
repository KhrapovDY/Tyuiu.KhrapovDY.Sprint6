namespace Tyuiu.KhrapovDY.Sprint6.Task6.V30
{
    partial class FormAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            pictureBoxAvatar_KDY = new PictureBox();
            labelInfo_KDY = new Label();
            buttonOk_KDY = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_KDY).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxAvatar_KDY
            // 
            pictureBoxAvatar_KDY.Image = (Image)resources.GetObject("pictureBoxAvatar_KDY.Image");
            pictureBoxAvatar_KDY.Location = new Point(24, 31);
            pictureBoxAvatar_KDY.Name = "pictureBoxAvatar_KDY";
            pictureBoxAvatar_KDY.Size = new Size(254, 255);
            pictureBoxAvatar_KDY.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxAvatar_KDY.TabIndex = 0;
            pictureBoxAvatar_KDY.TabStop = false;
            // 
            // labelInfo_KDY
            // 
            labelInfo_KDY.AutoSize = true;
            labelInfo_KDY.Location = new Point(349, 31);
            labelInfo_KDY.Name = "labelInfo_KDY";
            labelInfo_KDY.Size = new Size(609, 288);
            labelInfo_KDY.TabIndex = 1;
            labelInfo_KDY.Text = resources.GetString("labelInfo_KDY.Text");
            // 
            // buttonOk_KDY
            // 
            buttonOk_KDY.Location = new Point(775, 348);
            buttonOk_KDY.Name = "buttonOk_KDY";
            buttonOk_KDY.Size = new Size(150, 46);
            buttonOk_KDY.TabIndex = 2;
            buttonOk_KDY.Text = "OK";
            buttonOk_KDY.UseVisualStyleBackColor = true;
            buttonOk_KDY.Click += buttonOk_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(980, 434);
            Controls.Add(buttonOk_KDY);
            Controls.Add(labelInfo_KDY);
            Controls.Add(pictureBoxAvatar_KDY);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_KDY).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxAvatar_KDY;
        private Label labelInfo_KDY;
        private Button buttonOk_KDY;
    }
}