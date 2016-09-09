using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Demo.WindowsForms.Forms
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.insertretTableAdapter.Fill(this.dataProbaDataSet.Insertret, new System.Nullable<double>(((double)(System.Convert.ChangeType(koordiXToolStripTextBox.Text, typeof(double))))), new System.Nullable<double>(((double)(System.Convert.ChangeType(koordiYToolStripTextBox.Text, typeof(double))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataProbaDataSet.CoordiProb". При необходимости она может быть перемещена или удалена.
            this.coordiProbTableAdapter.Fill(this.dataProbaDataSet.CoordiProb);

        }
    }
}
