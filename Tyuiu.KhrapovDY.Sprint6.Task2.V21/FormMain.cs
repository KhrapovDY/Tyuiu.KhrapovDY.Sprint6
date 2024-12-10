using Tyuiu.KhrapovDY.Sprint6.Task2.V21.Lib;

namespace Tyuiu.KhrapovDY.Sprint6.Task2.V21
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

                this.chartFunction_KDY.Titles.Add("График функции sin(x)");

                this.chartFunction_KDY.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_KDY.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewFunction_KDY.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));

                    this.chartFunction_KDY.Series[0].Points.AddXY(startStep, valueArray[i]);

                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_KDY_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы СМАРТб-24-1 Храпов Даниил Юрьевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void buttonDone_KDY_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_KDY.BackColor = Color.Red;
        }

        private void buttonDone_KDY_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_KDY.BackColor = Color.Green;
        }

        private void buttonDone_KDY_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_KDY.BackColor = Color.Blue;
        }
    }
}
