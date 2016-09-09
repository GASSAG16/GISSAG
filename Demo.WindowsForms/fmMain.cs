using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Demo.WindowsForms
{
    public partial class fmMain : Form
    {
        Form DemoMode = new Forms.fmSamaPrograma();
        Form FullMode = new Forms.SamaProgramaServer();
        
        public fmMain()
        {
            InitializeComponent();
        }

        private void btDemoMode_Click(object sender, EventArgs e)
        {
                this.Hide();
                DemoMode.Show();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btFullDemo_Click(object sender, EventArgs e)
        {
           try
           {
                this.Hide();
                FullMode.Show();           
           }
           catch
           {           
               MessageBox.Show("Внимание!!! Для Вас доступен лишь демонстрационный режим!");
               FullMode.Hide();
               this.Show();
           }          
        }
    }
}
