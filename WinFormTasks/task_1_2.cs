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

namespace WinFormTasks
{
    public partial class FormCalculate : Form
    {
        public FormCalculate()
        {
            InitializeComponent();
        }

        private void buttonSolveTask1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBoxNTask1.Text);

            library solver = new library();
            double sum = solver.CalculateSum(n);

            labelTask1Result.Text = "Сума дорівнює = "+ sum.ToString();
        }

        private void buttonSoiveTask2_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBoxNTask2.Text);
            double a = double.Parse(textBoxA.Text);
            
            library solver = new library();
            double degree = solver.Degree(n, a);

            labelTask2Result.Text = "'a' в степенi 'n' дорiвнює =  "  + degree.ToString();
        }
    }
}
