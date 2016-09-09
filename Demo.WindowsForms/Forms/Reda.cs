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
    public partial class Reda : Form
    {
        public Reda()
        {
            InitializeComponent();
        }

        private void Reda_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gISSIGData.MarsrutiPodrobno". При необходимости она может быть перемещена или удалена.
            this.marsrutiPodrobnoTableAdapter.Fill(this.gISSIGData.MarsrutiPodrobno);

        }

    }
}
