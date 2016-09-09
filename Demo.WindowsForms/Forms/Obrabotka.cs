using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop;
//using Microsoft.Office.Interop.Excel.Application;
using System.Drawing.Printing;
//using xlWB = Microsoft.Office.Interop.Excel;
//using xlWS = Microsoft.Office.Interop.Excel;
//using xlapp = Microsoft.Office.Interop.Excel;
//using XlR = Microsoft.Office.Interop.Excel;

namespace Demo.WindowsForms.Forms
{
    
    public partial class Obrabotka : Form
    {
        //xlWB._Workbook xlWB;
        //xlapp._Application xlapp;
        //xlWS._Worksheet xlWS;
        //XlR.Range ret;

        Microsoft.Office.Interop.Excel.Application ObjExcel = new Microsoft.Office.Interop.Excel.Application();
        Microsoft.Office.Interop.Excel.Workbook ObjWorkBook;
        Microsoft.Office.Interop.Excel.Worksheet ObjWorkSheet;






        public Obrabotka()
        {
            InitializeComponent();

           //       // настраиваем видимость

        }

        private void importMarshrutaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.importMarshrutaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gISSIGData);

        }

        private void Obrabotka_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gISSIGData.ImportMarshruta". При необходимости она может быть перемещена или удалена.
            //this.importMarshrutaTableAdapter.Fill(this.gISSIGData.ImportMarshruta);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //label1.Text = f2Label1.Text;

            label1.Text.Substring(45,8);
                //Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
           // SubString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int k, f, v;

          //  string str;
          //  int rCnt = 0;
          //  int cCnt = 0;
          ////  DataTable dt = new DataTable();
          //  xlapp =  new xlapp.Application();
          //  xlapp.Visible = true;
          //  xlWB = xlapp.Workbooks.Open("H:\\TestOstanov.xlsx");
          //  k = xlapp.Worksheets.Count;
          //  //ret = xlWS.UsedRange;
            
          //  xlWS.Cells[3, 1] = label2.Text;
            Microsoft.Office.Interop.Excel.Application ObjExcel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook ObjWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet ObjWorkSheet;
            
//            //Книга.
//             ObjWorkBook = ObjExcel.Workbooks.Add(System.Reflection.Missing.Value);
////Таблица.
//             ObjWorkSheet = Microsoft.Office.Interop.Excel.WorksheetObjWorkBook.Sheets[1];
//            ObjWorkSheet.Cells[3, 1] = label1.Text;
//ObjWorkSheet.Cells[3, 2] = label2.Text;
//ObjWorkSheet.Cells[3, 3] = label3.Text;

            
            
            //---------------------------------
           // for (int Cnum = 1; Cnum <= ret.Columns.Count; Cnum++)
           // {
            
           //ret.Cells[1, Cnum].Value2.ToString();
           // }

  //          ObjWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ObjWorkBook.Sheets[1];
 
  ////Очищаем от старого текста окно вывода.
  
 
  //for (int i = 1; i < 101; i++)
  //  {

  //  //Добавляем полученный из ячейки текст.
  //  label2.Text = label2.Text + xlWs.Text.ToString()+"\n";
  //  //это чтобы форма прорисовывалась (не подвисала)...

  //  }

  //          //for (rCnt = 1; rCnt <= ret.Rows.Count; rCnt++)
  //          //{
  //          //    for (cCnt = 1; cCnt <= ret.Columns.Count; cCnt++)
  //          //    {
  //          //        str = (ret.Cells[rCnt, cCnt] as xlapp.Range).Value2;
  //          //        MessageBox.Show(str);
  //          //    }
  //          //}








            //for (f = 1; k < f; k++)
            //{
                
               
            //    //Выделение группы ячеек
            //  //  xlWS.get_Range("A1", "С2");

               
                
            //    //Excel.Worksheet excelSheet = workbook.ActiveSheet;
            //    //XlR.Range rng = (XlR.Range)excelSheet.Cells[10, 10];
                
            //    // label1.Text = xlWS.Range("", "").Value;
            // //Microsoft.Office.Interop.Excel.Range range = xlWS.get_Range(label1.Text + k.ToString(), label1.Text + k.ToString());
            //    //label1.Text = xlWS.Range("b" + label2.Text).Value2;
            //   // this.Range["A1"].Value2 = "Hello World";
            //   // string mystring = this.Range["A1"].Value2;
            //    MessageBox.Show("j");
            //   // this.Range["A" + iRow];
            //}

         //   Worksheet vstoWorksheet = Globals.Factory.GetVstoObject(
         //this.Application.ActiveWorkbook.Worksheets[1]);
         //   // The following line of code specifies a single cell.
         //   vstoWorksheet.Range["A1"].Value2 = "Range 1";

         //   // The following line of code specifies multiple cells.
         //   vstoWorksheet.Range["A3", "B4"].Value2 = "Range 2";

         //   // The following line of code uses an Excel.Range for 
         //   // the second parameter of the Range property.
         //   Excel.Range range1 = vstoWorksheet.Range["C8"];
         //   vstoWorksheet.Range["A6", range1].Value2 = "Range 3";

           // xlWB = xlWS.Range[xlWS.Cells[4, 2], xlWS.Cells[4,4]];
          //  xlWB.MergeWorkbook(Type.Missing);
           // xlWS.get_Range(xlWS.Cells[2, 2], sheet.Cells[4, 4]).Merge(missing);

           
            

        
                //for ( k = 6; k < f; k++)
                //{
                //  //xlWS = xlapp.Worksheets.Item(f);
                //  //label1.Text = xlWS.UsedRange("b2;o2").Value2;
                //}
           
            //-----------------------------------------------
           
            //for f=6;
            //{

            //}
            //For f = 6 To k;
                
            //    ProgressBar1.Value = f

            //    Label73.Text = xlWS.Range("a3;z3").Value2
            //    '---------------------------------------------------------------------
            //    Label80.Text = xlWS.Range("a3;z3").Value2 'ggggggg

            //    Dim str As String, g, g1 As Integer
            //    str = Label73.Text
            //    g = 13
            //    g1 = 13

            //    Dim str2 As String, g2, g3 As Integer
            //    str2 = Label80.Text
            //    g2 = 10
            //    g3 = 11

            //    Label80.Text = Mid(str2, g2, g3)






        }
    }
}
