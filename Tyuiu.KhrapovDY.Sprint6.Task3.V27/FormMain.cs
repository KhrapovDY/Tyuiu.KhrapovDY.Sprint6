using System.Drawing.Drawing2D;
using Tyuiu.KhrapovDY.Sprint6.Task3.V27.Lib;

namespace Tyuiu.KhrapovDY.Sprint6.Task3.V27
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        int[,] mtrx = new int[5, 5] { { 9, 13, -14, 23, 1 },
                                    { 15, -17, 21, 25, 23 },
                                    { -4, 29, -20, -10, 14 },
                                    { 27, 33, 12, 33, -12 },
                                    { 18, -9, -5, 6, 3 } };


        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;


            dataGridViewMatrix_KDY.ColumnCount = columns;
            dataGridViewMatrix_KDY.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrix_KDY.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrix_KDY.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }

        private void buttonDone_KDY_Click(object sender, EventArgs e)
        {
            textBoxResult_KDY.Text = Convert.ToString(ds.Calculate(mtrx));
        }

        private void buttonHelp_KDY_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы СМАРТб-24-1 Храпов Даниил Юрьевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
