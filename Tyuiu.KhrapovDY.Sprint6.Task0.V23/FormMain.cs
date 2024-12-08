using Tyuiu.KhrapovDY.Sprint6.Task0.V23.Lib;

namespace Tyuiu.KhrapovDY.Sprint6.Task0.V23
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonDone_KDY_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResult_KDY.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxVarX_KDY.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxVar_KDY_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }


        private void buttonHelp_KDY_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студента СМАРТб-24-1 Храпов Даниил Юрьевич", "Сообщение");
        }

        private void textBoxResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}