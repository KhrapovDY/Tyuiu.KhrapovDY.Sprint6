using Tyuiu.KhrapovDY.Sprint6.Task1.V13.Lib;

namespace Tyuiu.KhrapovDY.Sprint6.Task1.V13
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

                string strLine;

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBoxResult_KDY.Text = "";
                textBoxResult_KDY.AppendText("+----------+-----------" + Environment.NewLine);
                textBoxResult_KDY.AppendText("|    x     |   f(x)   |" + Environment.NewLine);
                textBoxResult_KDY.AppendText("+----------+-----------" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}     |   {1, 6:f2} |", startStep, valueArray[i]);
                    textBoxResult_KDY.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }

                textBoxResult_KDY.AppendText("+----------+-----------" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void buttonHelp_KDY_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы СМАРТб-24-1 Храпов Даниил Юрьевич", "Сообщение");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
