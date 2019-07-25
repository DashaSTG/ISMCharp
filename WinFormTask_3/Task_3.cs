using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ISM;

namespace WinFormTask_3
{
    public partial class Task_3 : Form
    {
        public Task_3()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonSolve_Click(object sender, EventArgs e)
        {
 
            double[] array = new double[dataGridViewTable.ColumnCount];
            for (int i = 0; i < array.Length; i++)
                array[i] = double.Parse(dataGridViewTable[i, 0].Value.ToString());


            library solver = new library();

            double SumnegativeNumb = solver.Array_SumNegativeNumb(array);
            labelSumnegativeNumb.Text = "Сума від'ємних елементів = " + SumnegativeNumb;

            double MaxNumb = solver.Array_MaxNumb(array);
            labelMaxNumb.Text = "Найбільше за модулем число = " + MaxNumb;

            int SumIndexes = solver.Array_SumIndexes(array);
            labelSumIndexes.Text = "Cума індексів додатніх елементів = " + SumIndexes;

            int IntengerQuantity = solver.Array_IntengerQuantity(array);
            labelIntengerQuantity.Text = "Кількість цілих чисел = " + IntengerQuantity;

            double sumMax_Min = solver.Array_SumMax_Min(array);
            labelsumMax_Min.Text = "Добуток елементів масиву між Max i Min = " + sumMax_Min;

            int variablecoun = solver.Array_DifferentNumbs(array);
            labelvariablecoun.Text = "Кількість різних чисел = " + variablecoun;

        }

        private void buttonRandom_Click(object sender, EventArgs e)
        {
            Random arr = new Random();
            for (int i = 0; i < dataGridViewTable.ColumnCount; i++)
                dataGridViewTable[i, 0].Value = arr.Next(-1000, 1000);
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBoxN.Text);

            dataGridViewTable.ColumnCount = n;
            dataGridViewTable.RowCount = 1;

            for (int i = 0; i < n; i++)
            {
                dataGridViewTable.Columns[i].HeaderText = i.ToString();
                dataGridViewTable.Columns[i].Width = 50;
            }
        }
    }
}
