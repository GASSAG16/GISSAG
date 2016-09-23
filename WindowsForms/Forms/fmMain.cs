using System;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class fmMain : Form
    {
        Form DemoMode = new Forms.fmDemoMode();
        Form ServerMode = new Forms.fmServerMode();
        
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

        private void btServerMode_Click(object sender, EventArgs e)
        {
           try
           {
                this.Hide();
                ServerMode.Show();           
           }
           catch
           {           
               MessageBox.Show("Внимание!!! Для Вас доступен лишь демонстрационный режим!");
               ServerMode.Hide();
               this.Show();
           }          
        }
    }
}
