using Tyuiu.KhrapovDY.Sprint6.Task6.V30.Lib;

namespace Tyuiu.KhrapovDY.Sprint6.Task6.V30
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        string openFilePath;
        DataService ds = new DataService();

        private void buttonOpenFile_KDY_Click(object sender, EventArgs e)
        {
            openFileDialogTask_KDY.ShowDialog();
            openFilePath = openFileDialogTask_KDY.FileName;
            textBoxLoadFromFile_KDY.Text = File.ReadAllText(openFilePath);
            groupBoxOutPutData_KDY.Text = groupBoxOutPutData_KDY + " " + openFileDialogTask_KDY.FileName;
            buttonDone_KDY.Enabled = true;
        }

        private void buttonDone_KDY_Click(object sender, EventArgs e)
        {
            textBoxResult_KDY.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonHelp_KDY_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
