using System;
using System.Windows.Forms;
using XlR = Microsoft.Office.Interop.Excel;
using WindowsForms.Logic;

namespace WindowsForms.Forms
{
    class Import
    {
        XlR.Application ObjExcel = new XlR.Application();//   -//- Объявляем новое приложение Excel
        XlR.Application ObjExcel2 = new XlR.Application();//   -//- Объявляем новое приложение Excel
        
        XlR.Workbook ObjWorkBook;  //                       -//-   книгу 
        XlR.Workbook ObjWorkBook2;  //                       -//-   книгу 
         
        XlR.Worksheet ObjWorkSheet; //                      -//-   страницу
        XlR.Worksheet ObjWorkSheet2; //                      -//-   страницу
        
        
        ImportSQL Isql = new ImportSQL();

        # region ImportRoutesOfTheRoute

        public void ImportRoutesOfTheRoute(TextBox tbLine, TextBox tbColumn, TextBox tbSelect, Label lbRouteNamber_, Label lbTransportMode_)
        {
            int rCntE = Convert.ToInt32(tbLine.Text);           // передача переменной о строке
            int cCntE = Convert.ToInt32(tbColumn.Text);        //передача переменной о кол-ве столбцов

            //Книга.
            ObjWorkBook = ObjExcel.Workbooks.Open(tbSelect.Text);
            
            int f = ObjExcel.Worksheets.Count;
           
            // Настройка видимости книги
            ObjExcel.Visible = false;

            // Для импорта, уточняем ячейки в Excel: 
            // rCnt -  проход по всем столбцам
            // rCnt2 - проход строго по столбцу с  номером,
            // rCnt4 - проход с последующего столбца, после номера
            // Cnt -  проход по всем строчкам
            // Cnt2 - проход строго по строчкам с  номером,
            // Cnt4 - проход с последующей строчки, после номера

            try
            {
                for (int i = 1; i <= f; i++)
                {
                    ObjWorkSheet = (XlR.Worksheet)ObjWorkBook.Sheets[i];

                    for (int rCnt = 1, rCnt4 = 1; rCnt <= rCntE && rCnt4 <= rCntE; rCnt++, rCnt4++)//столбец
                    {
                        for (int cCnt = 3, cCnt4 = 4; cCnt <= 3 && cCnt4 <= 4; cCnt++, cCnt4++)//строка
                        {
                            var str3 = (ObjWorkSheet.Cells[rCnt, cCnt] as XlR.Range).Value2; // получаем значение ячеек 1/2 
                            var str5 = (ObjWorkSheet.Cells[rCnt4, cCnt4] as XlR.Range).Value2;
                            if (str3 == null) continue;
                            if (str5 == null) continue;

                            string strTransportMode = str5.ToString();
                            string strlbRouteNamber = str3.ToString();

                            TransportMode(lbRouteNamber_, lbTransportMode_, strTransportMode, strlbRouteNamber);
                            Application.DoEvents();
                        }
                    }
                }

                // MessageBox.Show("Импорт завершен!", " Сообщение системы ");
                ObjExcel.Workbooks.Close(); //закрываем книгу
                ObjExcel.Quit();            //выходим из приложения
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message + " Ошибка, проверьте файл *.xsls");
                ObjExcel.Workbooks.Close(); //закрываем книгу
                ObjExcel.Quit();            //выходим из приложения
            }
        }
        
        public void ImportDirectionOfRoute(TextBox tbLine, TextBox tbColumn, TextBox tbSelect, Label lbRouteNamber, Label lbTransportMode,Label lbDirectionOfRoute)
        {
            int rCntE = Convert.ToInt32(tbLine.Text);           // передача переменной о строке
            int cCntE = Convert.ToInt32(tbColumn.Text);        //передача переменной о кол-ве столбцов

            //Книга.
            ObjWorkBook = ObjExcel.Workbooks.Open(tbSelect.Text);

            int f = ObjExcel.Worksheets.Count;
            
            // Настройка видимости книги
            ObjExcel.Visible = false;

            // Для импорта, уточняем ячейки в Excel: 
            // rCnt -  проход по всем столбцам
            // rCnt2 - проход строго по столбцу с  номером,
            // rCnt4 - проход с последующего столбца, после номера
            // Cnt -  проход по всем строчкам
            // Cnt2 - проход строго по строчкам с  номером,
            // Cnt4 - проход с последующей строчки, после номера

                try
                {
                    for (int i = 1; i <= f; i++)
                    {
                     ObjWorkSheet = (XlR.Worksheet)ObjWorkBook.Sheets[i];
                                       
                        for (int rCnt = 1, rCnt1 = 1, rCnt2 = 1; rCnt <= rCntE && rCnt1 <= rCnt && rCnt2 <= rCnt; rCnt++, rCnt1++, rCnt2++)
                        {
                            for (int cCnt1 = 2, cCnt = 3, cCnt2 = 4; cCnt <= 3 && cCnt1 <= 2 && cCnt2 <= 4; cCnt++, cCnt1++, cCnt2++)
                            {
                                var str = (ObjWorkSheet.Cells[rCnt, cCnt] as XlR.Range).Value2;   // получаем значение ячеек 
                                var str1 = (ObjWorkSheet.Cells[rCnt1, cCnt1] as XlR.Range).Value2;
                                var str2 = (ObjWorkSheet.Cells[rCnt2, cCnt2] as XlR.Range).Value2;

                                if (str == null) continue;
                                if (str1 == null) continue;
                                if (str2 == null) continue;

                                string strlbRouteNamber = str.ToString();
                                string strDirectionOfRoute = str1.ToString();
                                string strTransportMode = str2.ToString();


                                TransportMode(lbRouteNamber, lbDirectionOfRoute, strlbRouteNamber, strDirectionOfRoute, strTransportMode);

                                Application.DoEvents();
                            }
                        }
                    }

                    // MessageBox.Show("Импорт завершен!", " Сообщение системы ");
                    ObjExcel.Workbooks.Close(); //закрываем книгу
                    ObjExcel.Quit();            //выходим из приложения
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message + " Ошибка, проверьте файл *.xsls");
                    ObjExcel.Workbooks.Close(); //закрываем книгу
                    ObjExcel.Quit();            //выходим из приложения
                }
            
        }

        public void ImportCoordinate(TextBox tbLine, TextBox tbColumn, TextBox tbSelect, Label lbDirectionOfRoute,
                                     Label lbCoordinate_Y, Label lbCoordinate_X, ProgressBar prProgressI, Label lbCount)
        {
            int rCntE = Convert.ToInt32(tbLine.Text);                                                           // передача переменной о строке
            int cCntE = Convert.ToInt32(tbColumn.Text);                                                         //передача переменной о кол-ве столбцов

            //Книга.
            ObjWorkBook = ObjExcel.Workbooks.Open(tbSelect.Text);

            int f = ObjExcel.Worksheets.Count;

            // Настройка видимости книги
            ObjExcel.Visible = false;

            // Для импорта, уточняем ячейки в Excel: 
            // rCnt -  проход по всем столбцам
            // rCnt2 - проход строго по столбцу с  номером,
            // rCnt4 - проход с последующего столбца, после номера
            // Cnt -  проход по всем строчкам
            // Cnt2 - проход строго по строчкам с  номером,
            // Cnt4 - проход с последующей строчки, после номера

        try
          {
              for (int i = 1; i <= f; i++)
              {
                  ObjWorkSheet = (XlR.Worksheet)ObjWorkBook.Sheets[i];

                  for (int rCnt1 = 1, rCnt3 = 1; rCnt1 <= rCntE && rCnt3 <= rCntE; rCnt1++, rCnt3++)
                  {
                      for (int cCnt1 = 2, cCnt = 3; cCnt <= 3 && cCnt1 <= 2; cCnt++, cCnt1++)
                      {
                          var str1 = (ObjWorkSheet.Cells[rCnt1, cCnt1] as XlR.Range).Value2;
                          if (str1 == null) continue;

                          string strDirectionOfRoute = str1.ToString();
                          lbDirectionOfRoute.Text = strDirectionOfRoute.Replace(',', '_');

                          for (int cCnt3 = 5; cCnt3 <= cCntE; cCnt3++)
                          {
                              var str3 = (ObjWorkSheet.Cells[rCnt3, cCnt3] as XlR.Range).Value2;
                              if (str3 == null) continue;
                              //MessageBox.Show(str3.ToString());
                              
                              string strCoordinates = str3.ToString();

                              char ch = ',';
                              int del = strCoordinates.IndexOf(ch);

                              string strlbCoordinate_Y = strCoordinates.Remove(del).Replace('.', ',');
                              string strlbCoordinate_X = strCoordinates.Substring(del + 2).Replace('.', ',');

                              lbCoordinate_Y.Text = strlbCoordinate_Y;
                              lbCoordinate_X.Text = strlbCoordinate_X;
                               Isql.ImportRouteSQL(lbDirectionOfRoute, lbCoordinate_X, lbCoordinate_Y);
                              Application.DoEvents();
                          }
                          //Application.DoEvents();

                          prProgressI.Value = prProgressI.Value + 1;// прогресс операции
                          lbCount.Text = prProgressI.Value.ToString();
                      }
                     // Application.DoEvents();
                  }
              }
            ObjExcel.Workbooks.Close(); //закрываем книгу
            ObjExcel.Quit();            //выходим из приложения

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Ошибка, проверьте файл *.xsls");
                ObjExcel.Workbooks.Close(); //закрываем книгу
                ObjExcel.Quit();            //выходим из приложения
            }
        }
        
        #endregion

       
        //сделать импорт на сервер остановки(общий),раздельный на потом,т.к. надо проверить построение трасс.
        public void ImportDataAboutStops(TextBox tbLineStan, TextBox tbColumnStan, TextBox tbSelectStan,
                                           Label lbCoordinate_Y_stan, Label lbCoordinate_X_stan,
                                           Label lbStreet, Label lbAdministrativeDistrict, Label lbDistrict,
                                           Label lbTheNameOfTheStop, Label lbDirection, Label lbTransportMode_stan,
                                           Label lbRouteNamber_stan, ProgressBar prProgress2, Label lbCountStan)
        {
            int rCntE = Convert.ToInt32(tbLineStan.Text);           // передача переменной о строке
            int cCntE = Convert.ToInt32(tbColumnStan.Text);        //передача переменной о кол-ве столбцов


            //Книга.
            ObjWorkBook2 = ObjExcel2.Workbooks.Open(tbSelectStan.Text);

            int f = ObjExcel2.Worksheets.Count;

            ObjExcel2.Visible = false;

            for (int i = 1; i <= f; i++)
            {
                ObjWorkSheet2 = (XlR.Worksheet)ObjWorkBook2.Sheets[i];

                for (int rCnt = 1, rCnt2 = 1, rCnt4 = 1, rCnt5 = 1, rCnt6 = 1, rCnt7 = 1, rCnt8 = 1, rCnt9 = 1; rCnt9 <= rCntE && rCnt2 <= rCntE && rCnt <= rCntE && rCnt4 <= rCntE; rCnt++, rCnt2++, rCnt4++, rCnt5++, rCnt6++, rCnt7++, rCnt8++, rCnt9++)//столбец
                {
                    for (int cCnt = 2, cCnt2 = 1, cCnt4 = 4, cCnt5 = 5, cCnt6 = 6, cCnt7 = 7, cCnt8 = 8; cCnt2 <= 2 && cCnt <= cCntE; cCnt++, cCnt2++)//строка
                    {
                        var str2 = (ObjWorkSheet2.Cells[rCnt2, cCnt2] as XlR.Range).Value2;   // получаем значение ячеек
                        var str1 = (ObjWorkSheet2.Cells[rCnt, cCnt] as XlR.Range).Value2;   // получаем значение ячеек 1/2
                        var str3 = (ObjWorkSheet2.Cells[rCnt4, cCnt4] as XlR.Range).Value2;
                        var str4 = (ObjWorkSheet2.Cells[rCnt5, cCnt5] as XlR.Range).Value2;
                        var str5 = (ObjWorkSheet2.Cells[rCnt6, cCnt6] as XlR.Range).Value2;
                        var str6 = (ObjWorkSheet2.Cells[rCnt7, cCnt7] as XlR.Range).Value2;
                        var str7 = (ObjWorkSheet2.Cells[rCnt8, cCnt8] as XlR.Range).Value2;
                         
                        if (str2 == null) continue;
                        if (str1 == null) continue;
                        if (str3 == null) continue;
                        if (str4 == null) continue;
                        if (str5 == null) continue;
                        if (str6 == null) continue;
                        if (str7 == null) continue;

                        // MessageBox.Show(str2.ToString() + "1"); // Проверка отображения.Replace('.', ',');
                        lbCoordinate_Y_stan.Text = str2.ToString();
                        lbCoordinate_Y_stan.Text = lbCoordinate_Y_stan.Text.Replace('.', ',');
                        
                        //  MessageBox.Show(str3.ToString() + "2");
                        lbCoordinate_X_stan.Text = str1.ToString();
                        lbCoordinate_X_stan.Text = lbCoordinate_X_stan.Text.Replace('.', ',');
                        
                        // MessageBox.Show(str5.ToString() + "4");
                        lbStreet.Text = str3.ToString();

                        //MessageBox.Show(str6.ToString() + "5");
                        lbAdministrativeDistrict.Text = str4.ToString();

                        //MessageBox.Show(str7.ToString() + "6");
                        lbDistrict.Text = str5.ToString();

                        // MessageBox.Show(str8.ToString() + "7");
                        lbTheNameOfTheStop.Text = str6.ToString();

                        // MessageBox.Show(str9.ToString() + "8");
                        lbDirection.Text = str7.ToString();

                        for (int cCnt9 = 9; cCnt9 <= cCntE; cCnt9++)
                        {
                            var str8 = (ObjWorkSheet2.Cells[rCnt9, cCnt9] as XlR.Range).Value2;
                            if (str8 == null) continue;

                            // MessageBox.Show(str8.ToString() + "9");
                            lbRouteNamber_stan.Text = str8.ToString();
                            Isql.PassagenerStop(lbCoordinate_Y_stan, lbCoordinate_X_stan, lbStreet, lbAdministrativeDistrict, lbDistrict, lbTheNameOfTheStop, lbDirection, lbRouteNamber_stan);
                        }
                        Application.DoEvents();
                    }
                    prProgress2.Value = prProgress2.Value + 1;// прогресс операции
                    lbCountStan.Text = prProgress2.Value.ToString();
                }    
            }
            MessageBox.Show("Импорт завершен!", " Сообщение системы ");
            ObjExcel2.Workbooks.Close(); //закрываем книгу
            ObjExcel2.Quit();            //выходим из приложения
        }



        private static void TransportMode(Label lbRouteNamber, Label lbDirectionOfRoute, string strlbRouteNamber, string strDirectionOfRoute, string strTransportMode)
        {
            ImportSQL Isql = new ImportSQL();
            if (strTransportMode == "bus")
            {
                lbRouteNamber.Text = "А" + strlbRouteNamber;
                lbDirectionOfRoute.Text = strDirectionOfRoute.Replace(',', '_');
                Isql.ImportDirectionSQL(lbRouteNamber, lbDirectionOfRoute);
            }

            else if (strTransportMode == "trolleybus")
            {
                lbRouteNamber.Text = "Тб" + strlbRouteNamber;
                lbDirectionOfRoute.Text = strDirectionOfRoute.Replace(',', '_');
                Isql.ImportDirectionSQL(lbRouteNamber, lbDirectionOfRoute);
            }
            else if (strTransportMode == "tram")
            {
                lbRouteNamber.Text = "Тм" + strlbRouteNamber;
                lbDirectionOfRoute.Text = strDirectionOfRoute.Replace(',', '_');
                Isql.ImportDirectionSQL(lbRouteNamber, lbDirectionOfRoute);
            }
        }        
      
        private static void TransportMode(Label lbTransportMode_stan, Label lbRouteNamber_stan, dynamic str8)
        {
            string strRouteNamber_stan = str8.ToString();

            if (strRouteNamber_stan.StartsWith("А") == true)
            {
                lbTransportMode_stan.Text = "bus";
                lbRouteNamber_stan.Text = str8.ToString();
            }
            if (strRouteNamber_stan.StartsWith("Тб") == true)
            {
                lbTransportMode_stan.Text = "trolleybus";
                lbRouteNamber_stan.Text = str8.ToString();
            }
            if (strRouteNamber_stan.StartsWith("Тм") == true)
            {
                lbTransportMode_stan.Text = "tram";
                lbRouteNamber_stan.Text = str8.ToString();
            }
        }

        private static void TransportMode(Label lbRouteNamber_, Label lbTransportMode_, string strTransportMode, string strlbRouteNamber)
        {
            ImportSQL Isql = new ImportSQL();
            if (strTransportMode == "bus")
            {
                lbTransportMode_.Text = "1";
                lbRouteNamber_.Text = "А" + strlbRouteNamber;
                Isql.ImportMarshSQL(lbRouteNamber_, lbTransportMode_);
            }

            else if (strTransportMode == "trolleybus")
            {
                lbTransportMode_.Text = "2";
                lbRouteNamber_.Text = "Тб" + strlbRouteNamber;
              Isql.ImportMarshSQL(lbRouteNamber_, lbTransportMode_);
            }
            else if (strTransportMode == "tram")
            {
                lbTransportMode_.Text = "3";
                lbRouteNamber_.Text = "Тм" + strlbRouteNamber;
                Isql.ImportMarshSQL(lbRouteNamber_, lbTransportMode_);
            }
            
        }
    }
}

       