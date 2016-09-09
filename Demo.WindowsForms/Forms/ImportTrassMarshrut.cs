using System;
using System.Windows.Forms;
using XlR = Microsoft.Office.Interop.Excel;


namespace Demo.WindowsForms.Forms
{
    public partial class ImportTrassMarshrut : Form
    {
        XlR.Application ObjExcel = new XlR.Application();//   -//- Объявляем новое приложение Excel
        XlR.Workbook ObjWorkBook;  //                       -//-   книгу
        XlR.Workbook ObjWorkBook2;  //                      -//-   книгу
        XlR.Worksheet ObjWorkSheet; //                      -//-   страницу
        XlR.Worksheet ObjWorkSheet2;     //                 -//-   страницу 

        public ImportTrassMarshrut()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            int rCntE = Convert.ToInt32(textBox1.Text);     // передача переменной о строке
            int cCntE = Convert.ToInt32(textBox2.Text); ;  //передача переменной о кол-ве столбцов

            progressBar1.Show();

            //Книга.
           /////- ObjWorkBook = ObjExcel.Workbooks.Open(textBox3.Text);
            ObjWorkBook2 = ObjExcel.Workbooks.Open(textBox4.Text);

            //Таблица.
          /////-  ObjWorkSheet = (XlR.Worksheet)ObjWorkBook.Sheets[1];
            ObjWorkSheet2 = (XlR.Worksheet)ObjWorkBook2.Sheets[1];

            // Настройка видимости книги
            ObjExcel.Visible = true;

            // Для импорта, уточняем ячейки в Excel: 
            // rCnt -  проход по всем столбцам
            // rCnt2 - проход строго по столбцу с  номером,
            // rCnt4 - проход с последующего столбца, после номера
            // Cnt -  проход по всем строчкам
            // Cnt2 - проход строго по строчкам с  номером,
            // Cnt4 - проход с последующей строчки, после номера

            //-----------------------------работает но странно
            try
            {
                for (int rCnt = 1, rCnt2 = 1, rCnt4 = 1, rCnt3 = 1; rCnt2 <= rCntE && rCnt <= rCntE && rCnt4 <= rCntE && rCnt3 <= rCntE; rCnt++, rCnt2++, rCnt3++, rCnt4++)//столбец
                {
                    for (int cCnt = 2, cCnt2 = 1; cCnt2 <= 2 && cCnt <= cCntE; cCnt++, cCnt2++)//строка
                    {
                        var str2 = (ObjWorkSheet.Cells[rCnt, cCnt] as XlR.Range).Value2;   // получаем значение ячеек
                        var str3 = (ObjWorkSheet.Cells[rCnt2, cCnt2] as XlR.Range).Value2; // получаем значение ячеек
                        if (str2 == null) continue;
                        if (str3 == null) continue;

                        // MessageBox.Show(str2.ToString()+"1"); // Проверка отображения
                        label7.Text = str2.ToString();
                        //  MessageBox.Show(str3.ToString() + "2");
                        label8.Text = str3.ToString();

                        for (int cCnt4 = 3; cCnt4 <= cCntE; cCnt4++)//строка
                        {
                            var str4 = (ObjWorkSheet.Cells[rCnt4, cCnt4] as XlR.Range).Value2;
                            if (str4 == null) continue;

                            // MessageBox.Show(str4.ToString() + "3");
                            label9.Text = str4.ToString();

                            if (label9.Text.Length <= 12)
                            {
                                label9.Text = label9.Text.Remove(4);

                                Rename_nazvanii();
                                MexanizmE(cCntE, rCnt3);
                            }
                            else
                            {
                                label9.Text = label9.Text.Remove(12);

                               // Rename_nazvanii();
                                MexanizmE(cCntE, rCnt3);
                            }
                        }
                    }
                }
                MessageBox.Show("Импорт завершен!");
                textBox1.Enabled = false;   //Блокируем элементы, воизбежания злоупотребления
                textBox2.Enabled = false;
                checkBox1.Enabled = false;
                ObjExcel.Workbooks.Close(); //закрываем книгу
                ObjExcel.Quit();            //выходим из приложения
                this.Close();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message + "12");
            }
        }

        private void Rename_nazvanii()
        {
            label9.Text = label9.Text.
                                    Replace("улица", "ул.").
                                    Replace("переулок", "пер.").
                                    Replace("проспект", "просп.").
                                    Replace("вокзал", "вокз.").
                                    Replace("площадь", "пл.");
        }

        public void MexanizmE(int cCntE, int rCnt3)
        {
            for (int cCnt3 = 3; cCnt3 <= cCntE; cCnt3++)//строка
            {
                var str5 = (ObjWorkSheet2.Cells[rCnt3, cCnt3] as XlR.Range).Value2; // получаем значение ячеек
                if (str5 == null) continue;

                //MessageBox.Show(str5.ToString() + "4");
                label22.Text = str5.ToString();

                progressBar1.Value = progressBar1.Value + 1; // прогресс операции
                label6.Text = progressBar1.Value.ToString();

                //try
                //{
                    //this.insertMarshrTableAdapter.Fill(this.gISSIGData.InsertMarshr,label8.Text, label10.Text);//временно
                 ///   this.selectOstanovUpdateTableAdapter.Fill(this.gISSIGData.SelectOstanovUpdate, label9.Text, label22.Text);
                    //------------------------------------
                    //временно  // this.scalarPoiskOstanovKolTableAdapter.Fill(this.gISSIGData.ScalarPoiskOstanovKol, label25.Text);

                    int f = Convert.ToInt32(label16.Text);
                    for (int v = 0; v < f; v++)
                    {
                      //  selectOstanovUpdateBindingSource.MoveNext();
                      //  IsklInsertDann();
                       MessageBox.Show(label16.Text);   

                        //--------------------------------------------
                      //  selectOstanovUpdateBindingSource.MoveFirst();
                       // IsklInsertDann();
                        //break;
                    }
                //}
                //catch (System.Exception ex)
                //{
                //    System.Windows.Forms.MessageBox.Show(ex.Message);
                //}
            }
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

        private void ImportTrassMarshrut_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gISSIGData.Marsh". При необходимости она может быть перемещена или удалена.
            this.marshTableAdapter.Fill(this.gISSIGData.Marsh);
            progressBar1.Hide();
        }

        private void IsklInsertDann()
        {
            try
            {
                InserstDann();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void InserstDann()
        {
            this.insertMarshrutiTableAdapter.Fill(this.gISSIGData.InsertMarshruti,
            label8.Text,
            new System.Nullable<double>(((double)(System.Convert.ChangeType(label11.Text,
            typeof(double))))), new System.Nullable<double>(((double)(System.Convert.ChangeType(label12.Text,
            typeof(double))))),
            label15.Text,
            label13.Text,
            label18.Text,
            label14.Text,
            label19.Text,
            label20.Text);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog marsh = new OpenFileDialog();
            marsh.Title = "Выберите файл";
            marsh.Filter = "Файлы Excel|*.xlsx";
            if (marsh.ShowDialog() == DialogResult.OK)
            {
                string text = marsh.ToString();
                text = text.Replace("System.Windows.Forms.OpenFileDialog: Title: Выберите файл, FileName: ", "");
                textBox4.Text = text;
            }
        }

        private void label15_Click(object sender, EventArgs e)  // резерв
        {

        }

        private void button3_Click(object sender, EventArgs e) // Специально выключена
        {
            //////    int rCntE = Convert.ToInt32(textBox1.Text);         // передача переменной о строке
            //////    int cCntE = Convert.ToInt32(textBox2.Text); ;       //передача переменной о кол-ве столбцов
            //////    //int d;
            //////    progressBar1.Show();

            //////    //Книга.
            //////    ObjWorkBook = ObjExcel.Workbooks.Open(textBox3.Text);
            //////    ObjWorkBook2 = ObjExcel.Workbooks.Open(textBox4.Text);

            //////    //Таблица.
            //////    ObjWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ObjWorkBook.Sheets[1];
            //////    ObjWorkSheet2 = (Microsoft.Office.Interop.Excel.Worksheet)ObjWorkBook2.Sheets[1];

            //////    // Настройка видимости книги
            //////    ObjExcel.Visible = false;

            //////    // Для импорта, уточняем ячейки в Excel: 
            //////    // rCnt -  проход по всем столбцам
            //////    // rCnt2 - проход строго по столбцу с  номером,
            //////    // rCnt4 - проход с последующего столбца, после номера
            //////    // Cnt -  проход по всем строчкам
            //////    // Cnt2 - проход строго по строчкам с  номером,
            //////    // Cnt4 - проход с последующей строчки, после номера

            //////    for (int rCnt = 1, rCnt2 = 1, rCnt4 = 1, rCnt3 = 1; rCnt2 <= rCntE && rCnt <= rCntE && rCnt4 <= rCntE && rCnt3 <= rCntE; rCnt++, rCnt2++, rCnt3++, rCnt4++)//столбец
            //////    {
            //////        for (int cCnt = 2, cCnt2 = 1; cCnt2 <= 2 && cCnt <= cCntE; cCnt++, cCnt2++)//строка
            //////        {
            //////            var str2 = (ObjWorkSheet.Cells[rCnt, cCnt] as XlR.Range).Value2;   // получаем значение ячеек
            //////            var str3 = (ObjWorkSheet.Cells[rCnt2, cCnt2] as XlR.Range).Value2; // получаем значение ячеек
            //////            if (str2 == null) continue;
            //////            if (str3 == null) continue;

            //////            //MessageBox.Show(str2.ToString() + "1"); // Проверка отображения
            //////            label7.Text = str2.ToString();
            //////            //  MessageBox.Show(str3.ToString() + "2");
            //////            label8.Text = str3.ToString();

            //////            for (int cCnt3 = 3; cCnt3 <= cCntE; cCnt3++)//строка
            //////            {
            //////                var str5 = (ObjWorkSheet2.Cells[rCnt3, cCnt3] as XlR.Range).Value2; // получаем значение ячеек
            //////                if (str5 == null) continue;
            //////                // MessageBox.Show(str5.ToString() + "4");
            //////                label22.Text = str5.ToString();

            //////                progressBar1.Value = progressBar1.Value + 1; // прогресс операции
            //////                label6.Text = progressBar1.Value.ToString();

            //////                for (int cCnt4 = 3; cCnt4 <= cCntE; cCnt4++)//строка
            //////                {
            //////                    var str4 = (ObjWorkSheet.Cells[rCnt4, cCnt4] as XlR.Range).Value2;
            //////                    if (str4 == null) continue;

            //////                    //  MessageBox.Show(str4.ToString() + "3");
            //////                    label9.Text = str4.ToString();
            //////                    //---------------------------------------------------------
            //////                    //label27.Text=label9.Text.Length.ToString();
            //////                    //d = Int32.Parse(label27.Text);
            //////                    //MessageBox.Show(d.ToString());
            //////                    if (label9.Text.Length <= 13)
            //////                    {
            //////                        label9.Text = label9.Text.Remove(4);
            //////                        //-------------------------------------------------------------
            //////                        this.selectOstanovUpdateTableAdapter.Fill(this.gISSIGData.SelectOstanovUpdate,
            //////                            //this.skalarPoiskOstanovTableAdapter.Fill(this.gISSIGData.SkalarPoiskOstanov,
            //////                                        label9.Text, label22.Text);
            //////                        //------------------------------------
            //////                        // this.scalarPoiskOstanovKolTableAdapter.Fill(this.gISSIGData.ScalarPoiskOstanovKol, label25.Text);

            //////                        //  int f = Convert.ToInt32(label16.Text);
            //////                        for (int ge = 0; ge < 6; ge++)
            //////                        {
            //////                            selectOstanovUpdateBindingSource.MoveNext();
            //////                            //skalarPoiskOstanovBindingSource.MoveNext();
            //////                       ////     IsklInsertDann();

            //////                            //MessageBox.Show(label16.Text);           

            //////                            //--------------------------------------------
            //////                            selectOstanovUpdateBindingSource.MoveFirst();
            //////                            //skalarPoiskOstanovBindingSource.MoveFirst();
            //////                      ////      IsklInsertDann();
            //////                            break;
            //////                        }
            //////                    }
            //////                    else
            //////                    {
            //////                        //label9.Text = label9.Text.
            //////                        label9.Text = label9.Text.Remove(13);
            //////                        //Replace("улица", "ул.").
            //////                        //Replace("переулок", "пер.").
            //////                        //Replace("проспект", "просп.").
            //////                        //Replace("вокзал", "вокз.").
            //////                        //Replace("площадь", "пл.");
            //////                        //-------------------------------------------------------------
            //////                        this.selectOstanovUpdateTableAdapter.Fill(this.gISSIGData.SelectOstanovUpdate,
            //////                            //this.skalarPoiskOstanovTableAdapter.Fill(this.gISSIGData.SkalarPoiskOstanov,
            //////                                        label9.Text, label22.Text);
            //////                        //------------------------------------
            //////                        // this.scalarPoiskOstanovKolTableAdapter.Fill(this.gISSIGData.ScalarPoiskOstanovKol, label25.Text);

            //////                         // int f = Convert.ToInt32(label16.Text);
            //////                        for (int ge = 0; ge < 6; ge++)
            //////                        {
            //////                            selectOstanovUpdateBindingSource.MoveNext();
            //////                            //skalarPoiskOstanovBindingSource.MoveNext();
            //////                    ////        IsklInsertDann();

            //////                            //MessageBox.Show(label16.Text);           

            //////                            //--------------------------------------------
            //////                            selectOstanovUpdateBindingSource.MoveFirst();
            //////                            //skalarPoiskOstanovBindingSource.MoveFirst();
            //////                       ////     IsklInsertDann();

            //////                            break;
            //////                        }
            //////                    }

            //////                }
            //////            }
            //////        }
            //////    }


            //////    MessageBox.Show("Импорт завершен!");
            //////    textBox1.Enabled = false;   //Блокируем элементы, воизбежания злоупотребления
            //////    textBox2.Enabled = false;
            //////    checkBox1.Enabled = false;
            //////    ObjExcel.Workbooks.Close(); //закрываем книгу
            //////    ObjExcel.Quit();            //выходим из приложения
            //////}
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int rCntE = Convert.ToInt32(textBox1.Text);     // передача переменной о строке
            int cCntE = Convert.ToInt32(textBox2.Text); ;  //передача переменной о кол-ве столбцов

            progressBar1.Show();

            //Книга.
             ObjWorkBook = ObjExcel.Workbooks.Open(textBox4.Text);
           // ObjWorkBook2 = ObjExcel.Workbooks.Open(textBox3.Text);

            //Таблица.
            // ObjWorkSheet = (XlR.Worksheet)ObjWorkBook.Sheets[1];
            ObjWorkSheet2 = (XlR.Worksheet)ObjWorkBook.Sheets[1];

            // Настройка видимости книги
            ObjExcel.Visible = false;

            // Для импорта, уточняем ячейки в Excel: 
            // rCnt -  проход по всем столбцам
            // rCnt2 - проход строго по столбцу с  номером,
            // rCnt4 - проход с последующего столбца, после номера
            // Cnt -  проход по всем строчкам
            // Cnt2 - проход строго по строчкам с  номером,
            // Cnt4 - проход с последующей строчки, после номера

            //-----------------------------работает но странно
            try
            {
                for (int rCnt = 1, rCnt4 = 2; rCnt4 <= rCntE && rCnt <= rCntE; rCnt++, rCnt4++)//столбец
                {
                    for (int cCnt = 2; cCnt <= cCntE; cCnt++)//строка
                    {
                        var str2 = (ObjWorkSheet2.Cells[rCnt, cCnt] as XlR.Range).Value2;   // получаем значение ячеек                    
                        if (str2 == null) continue;


                        MessageBox.Show(str2.ToString() + "1"); // Проверка отображения
                        label7.Text = str2.ToString();
                        //  MessageBox.Show(str3.ToString() + "2");
                        //label8.Text = str3.ToString();

                        for (int cCnt4 = 3; cCnt4 <= cCntE; cCnt4++)//строка
                        {
                            var str4 = (ObjWorkSheet2.Cells[rCnt4, cCnt4] as XlR.Range).Value2;
                            if (str4 == null) continue;

                             MessageBox.Show(str4.ToString() + "3");
                            label9.Text = str4.ToString();

                            //if (label9.Text.Length <= 12)
                            //{
                            //    label9.Text = label9.Text.Remove(4);

                            //    // Rename_nazvanii2();
                        //      MexanizmE2(cCntE, rCnt4);
                            //}
                            //else
                            //{
                            //    label9.Text = label9.Text.Remove(12);

                            //    // Rename_nazvanii();
                            //    // MexanizmE2(cCntE, rCnt3);
                            //}
                        }
                    }
                }
                MessageBox.Show("Импорт завершен!");
                textBox1.Enabled = false;   //Блокируем элементы, воизбежания злоупотребления
                textBox2.Enabled = false;
                checkBox1.Enabled = false;
                ObjExcel.Workbooks.Close(); //закрываем книгу
                ObjExcel.Quit();            //выходим из приложения
                this.Close();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message + "12");
            }
        }

        private void Rename_nazvanii2()
        {
            label9.Text = label9.Text.
                                    Replace("улица", "ул.").
                                    Replace("переулок", "пер.").
                                    Replace("проспект", "просп.").
                                    Replace("вокзал", "вокз.").
                                    Replace("площадь", "пл.");
        }

        private void MexanizmE2(int cCntE, int rCnt4)
        {
            for (int cCnt4 = 3; cCnt4 <= cCntE; cCnt4++)//строка
            {
                var str5 = (ObjWorkSheet2.Cells[rCnt4, cCnt4] as XlR.Range).Value2; // получаем значение ячеек
                if (str5 == null) continue;

                MessageBox.Show(str5.ToString() + "4");
                label22.Text = str5.ToString();
                progressBar1.Value = progressBar1.Value + 1; // прогресс операции
                label6.Text = progressBar1.Value.ToString();

                //try
                //{
                //this.insertMarshrTableAdapter.Fill(this.gISSIGData.InsertMarshr,label8.Text, label10.Text);//временно
                ///   this.selectOstanovUpdateTableAdapter.Fill(this.gISSIGData.SelectOstanovUpdate, label9.Text, label22.Text);
                //------------------------------------
                //временно  // this.scalarPoiskOstanovKolTableAdapter.Fill(this.gISSIGData.ScalarPoiskOstanovKol, label25.Text);

                ////int f = Convert.ToInt32(label16.Text);
                ////for (int v = 0; v < f; v++)
                ////{
                ////    //  selectOstanovUpdateBindingSource.MoveNext();
                ////    //  IsklInsertDann();
                ////    MessageBox.Show(label16.Text);

                ////    //--------------------------------------------
                ////    //  selectOstanovUpdateBindingSource.MoveFirst();
                ////    // IsklInsertDann();
                ////    //break;
                ////}
                //////}
                //////catch (System.Exception ex)
                //////{
                //////    System.Windows.Forms.MessageBox.Show(ex.Message);
                //////}
            }
        }
    }
}
