using Tyuiu.KhrapovDY.Sprint6.Task4.V11.Lib;

namespace Tyuiu.KhrapovDY.Sprint6.Task4.V11
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void buttonDone_KDY_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_KDY.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_KDY.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartFunction_KDY.ChartAreas[0].AxisX.Title = "��� X";
                this.chartFunction_KDY.ChartAreas[0].AxisY.Title = "��� Y";

                textBoxResult_KDY.Text = "";

                chartFunction_KDY.Series[0].Points.Clear();
                for (int i = 0; i <= len - 1; i++)
                {
                    this.chartFunction_KDY.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxResult_KDY.AppendText(valueArray[i] + Environment.NewLine);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("���� ��� ���������� �����", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_KDY_Click(object sender, EventArgs e)
        {
            MessageBox.Show("���� 4 �������� ������� ������ ������-24-1 ������ ������ �������", "���������", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void buttonSave_KDY_Click(object sender, EventArgs e) 
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4.txt";
                File.WriteAllText(path, textBoxResult_KDY.Text);

                DialogResult dialogResult = MessageBox.Show("����" + path + "��������� �������!\n ������� ��� � ��������?", "���������", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }

            }
            catch
            {
                MessageBox.Show("���� ��� ���������� �����", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
