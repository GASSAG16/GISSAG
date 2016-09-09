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
    public partial class Koiya : Form
    {
        public Koiya()
        {
            InitializeComponent();
        }
    }
}
//int rCntE=Convert.ToInt32(textBox1.Text);     // передача переменной о строке
//            int cCntE = Convert.ToInt32(textBox2.Text); ;  //передача переменной о кол-ве столбцов

//            progressBar1.Show();
            
//            //Книга.
//            ObjWorkBook = ObjExcel.Workbooks.Open(textBox3.Text);
//            ObjWorkBook2 = ObjExcel.Workbooks.Open(textBox4.Text);
            
//            //Таблица.
//            ObjWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ObjWorkBook.Sheets[1];
//            ObjWorkSheet2 = (Microsoft.Office.Interop.Excel.Worksheet)ObjWorkBook2.Sheets[1];
            
//            // Настройка видимости книги
//            ObjExcel.Visible = false;

//            // Для импорта, уточняем ячейки в Excel: 
//            // rCnt -  проход по всем столбцам
//            // rCnt2 - проход строго по столбцу с  номером,
//            // rCnt4 - проход с последующего столбца, после номера
//            // Cnt -  проход по всем строчкам
//            // Cnt2 - проход строго по строчкам с  номером,
//            // Cnt4 - проход с последующей строчки, после номера

//            //-----------------------------работает но странно
//            try
//            {


//                for (int rCnt = 1, rCnt2 = 1, rCnt4 = 1, rCnt3 = 1; rCnt2 <= rCntE && rCnt <= rCntE && rCnt4 <= rCntE && rCnt3 <= rCntE; rCnt++, rCnt2++, rCnt3++, rCnt4++)//столбец
//                {
//                    for (int cCnt = 2, cCnt2 = 1; cCnt2 <= 2 && cCnt <= cCntE; cCnt++, cCnt2++)//строка
//                    {
//                        var str2 = (ObjWorkSheet.Cells[rCnt, cCnt] as XlR.Range).Value2;   // получаем значение ячеек
//                        var str3 = (ObjWorkSheet.Cells[rCnt2, cCnt2] as XlR.Range).Value2; // получаем значение ячеек
//                        if (str2 == null) continue;
//                        if (str3 == null) continue;

//                        // MessageBox.Show(str2.ToString()+"1"); // Проверка отображения
//                        label7.Text = str2.ToString();
//                        //  MessageBox.Show(str3.ToString() + "2");
//                        label8.Text = str3.ToString();

//                        for (int cCnt4 = 3; cCnt4 <= cCntE; cCnt4++)//строка
//                        {
//                            var str4 = (ObjWorkSheet.Cells[rCnt4, cCnt4] as XlR.Range).Value2;
//                            if (str4 == null) continue;

//                            // MessageBox.Show(str4.ToString() + "3");
//                            label9.Text = str4.ToString();

//                            //label9.Text = label9.Text.
//                            //Replace("улица","ул.").
//                            //Replace("переулок","пер.").
//                            //Replace("проспект","просп.").
//                            //Replace("вокзал","вокз.").
//                            //Replace("площадь","пл.");
//                            //label9.Text = label9.Text.Remove(4);
//                            //MessageBox.Show(label9.Text.ToString() + "3");
//                            if (label9.Text.Length <= 13)
//                            {
//                                label9.Text = label9.Text.Remove(4);

//                                for (int cCnt3 = 3; cCnt3 <= cCntE; cCnt3++)//строка
//                                {
//                                    var str5 = (ObjWorkSheet2.Cells[rCnt3, cCnt3] as XlR.Range).Value2; // получаем значение ячеек
//                                    if (str5 == null) continue;
//                                    // MessageBox.Show(str5.ToString() + "4");
//                                    label22.Text = str5.ToString();

//                                    progressBar1.Value = progressBar1.Value + 1; // прогресс операции
//                                    label6.Text = progressBar1.Value.ToString();

//                                    try
//                                    {
//                                        //if ((label22.Text.IndexOf(label9.Text) != -1) == false)
//                                        //MessageBox.Show("Не содержит!");
//                                        //else
//                                        //{
//                                        //label4.Text = label2.Text.IndexOf(label3.Text).ToString();

//                                        //  MessageBox.Show("содержит!");

//                                        //this.insertMarshrTableAdapter.Fill(this.gISSIGData.InsertMarshr,
//                                        //    label8.Text, label10.Text);//временно
//                                        this.selectOstanovUpdateTableAdapter.Fill(this.gISSIGData.SelectOstanovUpdate,
//                                            //this.skalarPoiskOstanovTableAdapter.Fill(this.gISSIGData.SkalarPoiskOstanov,
//                                           label9.Text, label22.Text);

//                                        //------------------------------------
//                                        //временно  // this.scalarPoiskOstanovKolTableAdapter.Fill(this.gISSIGData.ScalarPoiskOstanovKol, label25.Text);

//                                        //int f = Convert.ToInt32(label16.Text);
//                                        for (int v = 0; v < 4; v++)
//                                        {
//                                            selectOstanovUpdateBindingSource.MoveNext();
//                                            // skalarPoiskOstanovBindingSource.MoveNext();
//                                        ////    IsklInsertDann();

//                                            //MessageBox.Show(label16.Text);           

//                                            //--------------------------------------------
//                                            selectOstanovUpdateBindingSource.MoveFirst();
//                                            // skalarPoiskOstanovBindingSource.MoveFirst();
//                                         ////   IsklInsertDann();
//                                            break;
//                                        }

//                                    }
//                                    catch (System.Exception ex)
//                                    {
//                                        System.Windows.Forms.MessageBox.Show(ex.Message);
//                                    }
//                                }
//                            }
//                            else
//                            {
//                                label9.Text = label9.Text.Remove(12);
//                                for (int cCnt3 = 3; cCnt3 <= cCntE; cCnt3++)//строка
//                                {
//                                    var str5 = (ObjWorkSheet2.Cells[rCnt3, cCnt3] as XlR.Range).Value2; // получаем значение ячеек
//                                    if (str5 == null) continue;
//                                    // MessageBox.Show(str5.ToString() + "4");
//                                    label22.Text = str5.ToString();

//                                    progressBar1.Value = progressBar1.Value + 1; // прогресс операции
//                                    label6.Text = progressBar1.Value.ToString();

//                                    try
//                                    {
//                                        //if ((label22.Text.IndexOf(label9.Text) != -1) == false)
//                                        //MessageBox.Show("Не содержит!");
//                                        //else
//                                        //{
//                                        //label4.Text = label2.Text.IndexOf(label3.Text).ToString();

//                                        //  MessageBox.Show("содержит!");

//                                        //this.insertMarshrTableAdapter.Fill(this.gISSIGData.InsertMarshr,
//                                        //    label8.Text, label10.Text);//временно
//                                        this.selectOstanovUpdateTableAdapter.Fill(this.gISSIGData.SelectOstanovUpdate,
//                                            //this.skalarPoiskOstanovTableAdapter.Fill(this.gISSIGData.SkalarPoiskOstanov,
//                                           label9.Text, label22.Text);

//                                        //------------------------------------
//                                        //временно  // this.scalarPoiskOstanovKolTableAdapter.Fill(this.gISSIGData.ScalarPoiskOstanovKol, label25.Text);

//                                        //int f = Convert.ToInt32(label16.Text);
//                                        for (int v = 0; v < 4; v++)
//                                        {
//                                            selectOstanovUpdateBindingSource.MoveNext();
//                                            // skalarPoiskOstanovBindingSource.MoveNext();
//                                        ////    IsklInsertDann();

//                                            //MessageBox.Show(label16.Text);           

//                                            //--------------------------------------------
//                                            selectOstanovUpdateBindingSource.MoveFirst();
//                                            // skalarPoiskOstanovBindingSource.MoveFirst();
//                                         ////   IsklInsertDann();
//                                            break;
//                                        }

//                                    }
//                                    catch (System.Exception ex)
//                                    {
//                                        System.Windows.Forms.MessageBox.Show(ex.Message);
//                                    }
//                                }
//                            }
//                        }

//                    }
//                }
//                        MessageBox.Show("Импорт завершен!");
//                        textBox1.Enabled = false;   //Блокируем элементы, воизбежания злоупотребления
//                        textBox2.Enabled = false;
//                        checkBox1.Enabled = false;
//                        ObjExcel.Workbooks.Close(); //закрываем книгу
//                        ObjExcel.Quit();            //выходим из приложения
//                        this.Close();


//            }
//            catch (System.Exception ex)
//            {
//                System.Windows.Forms.MessageBox.Show(ex.Message + "12");
//            }
//        }
