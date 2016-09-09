using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using XlR = Microsoft.Office.Interop.Excel;
using System.Text.RegularExpressions;

namespace Demo.WindowsForms.Forms
{
    public partial class Form3 : Form
    {
        Microsoft.Office.Interop.Excel.Application ObjExcel =
         new Microsoft.Office.Interop.Excel.Application();    // Объявляем новое приложение Excel
        Microsoft.Office.Interop.Excel.Workbook ObjWorkBook;  //           -//-   книгу
        Microsoft.Office.Interop.Excel.Workbook ObjWorkBook2;  //           -//-   книгу
        Microsoft.Office.Interop.Excel.Worksheet ObjWorkSheet; //            -//-   страницу
        Microsoft.Office.Interop.Excel.Worksheet ObjWorkSheet2; //            -//-   страницу 

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog marsh = new OpenFileDialog();
            marsh.Title = "Выберите файл";
            marsh.Filter = "Файлы Excel|*.xlsx";
            if (marsh.ShowDialog() == DialogResult.OK)
            {
                string text = marsh.ToString();
                text = text.Replace("System.Windows.Forms.OpenFileDialog: Title: Выберите файл, FileName: ", "");
                textBox3.Text = text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int rCntE = Convert.ToInt32(textBox1.Text);     // передача переменной о строке
            int cCntE = Convert.ToInt32(textBox2.Text); ;  //передача переменной о кол-ве столбцов


            //Книга.
            ObjWorkBook = ObjExcel.Workbooks.Open(textBox3.Text);


            //Таблица.
            ObjWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ObjWorkBook.Sheets[1];

            // Настройка видимости книги
            ObjExcel.Visible = true;


            for (int rCnt = 1; rCnt <= rCntE; rCnt++)//столбец
            {
                for (int cCnt = 2; cCnt <= cCntE; cCnt++)//строка
                {
                    var str2 = (ObjWorkSheet.Cells[rCnt, cCnt] as XlR.Range).Value2;   // получаем значение ячеек
                    if (str2 == null) continue;
                   
                    label1.Text = str2.ToString();
                    label1.Text = label1.Text.
                        Replace("ул.", "улица").
                        Replace("пер.", "переулок").
                        Replace("пл.", "площадь").
                        
                    Replace("-", "");
                }
            }
            
           // ObjExcel.Workbooks.Close(); //закрываем книгу
          //  ObjExcel.Quit();            //выходим из приложения
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //string s = label1.Text;
            //string pattern = @"\w*риж\w*";
            //string target = " ";
            //Regex regex = new Regex(pattern);
            //string result = regex.Replace(s, target);
            //label1.Text = s;
            if ((label2.Text.IndexOf(label3.Text) != -1) == false)
                MessageBox.Show("Не содержит!");
            else
            {
                label4.Text = label2.Text.IndexOf(label3.Text).ToString();
                //Console.WriteLine("Слово \"это\" найдено в строке, оно " +
                // "находится на: {0} позиции", s2.IndexOf("это"));
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.selectOstanovUpdateTableAdapter.Fill(this.gISSIGData.SelectOstanovUpdate, param2ToolStripTextBox.Text, param1ToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }



    }
}
