using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using XlR = Microsoft.Office.Interop.Excel;

namespace Demo.WindowsForms.Forms
{
    class Import
    {
        XlR.Application ObjExcel = new XlR.Application();//   -//- Объявляем новое приложение Excel
        XlR.Workbook ObjWorkBook;  //                       -//-   книгу        
        XlR.Worksheet ObjWorkSheet; //                      -//-   страницу

        
    
        public void ImportRoutesOfTheRoute(TextBox tbLine, TextBox tbColumn,TextBox tbSelect,
                                           Label lbDirectionOfRoute,Label lbRouteNamber,
                                           Label lbTransportMode,Label lbCoordinate_Y,Label lbCoordinate_X,
                                           ProgressBar prProgressI, Label lbCount)
        {
            int rCntE = Convert.ToInt32(tbLine.Text);           // передача переменной о строке
            int cCntE = Convert.ToInt32(tbColumn.Text);        //передача переменной о кол-ве столбцов

            //Книга.
            ObjWorkBook = ObjExcel.Workbooks.Open(tbSelect.Text);

            //Таблица.
            ObjWorkSheet = (XlR.Worksheet)ObjWorkBook.Sheets[1];

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
                for (int rCnt = 1, rCnt2 = 1, rCnt4 = 1, rCnt5 = 1; rCnt2 <= rCntE && rCnt <= rCntE && rCnt4 <= rCntE && rCnt5 <= rCntE; rCnt++, rCnt2++,rCnt4++, rCnt5++)//столбец
                {
                    for (int cCnt = 2, cCnt2 = 1; cCnt2 <= 2 && cCnt <= cCntE; cCnt++, cCnt2++)//строка
                    {                                                                    
                        var str2 = (ObjWorkSheet.Cells[rCnt2, cCnt2] as XlR.Range).Value2;   // получаем значение ячеек
                        var str3 = (ObjWorkSheet.Cells[rCnt, cCnt] as XlR.Range).Value2; // получаем значение ячеек 1/2
                        if (str2 == null) continue;
                        if (str3 == null) continue;

                        //MessageBox.Show(str2.ToString() + "1"); // Проверка отображения
                        lbDirectionOfRoute.Text = str2.ToString();
                        lbDirectionOfRoute.Text = lbDirectionOfRoute.Text.Replace(',', '_');
                        //MessageBox.Show(str3.ToString() + "2");
                        lbRouteNamber.Text = str3.ToString();
                        
                        prProgressI.Value = prProgressI.Value + 1;// прогресс операции
                        lbCount.Text = prProgressI.Value.ToString(); 

                        for (int cCnt4 = 4; cCnt4 <= cCntE; )//строка
                        {
                            var str5 = (ObjWorkSheet.Cells[rCnt4, cCnt4] as XlR.Range).Value2;
                            if (str5 == null) continue;

                            //MessageBox.Show(str5.ToString() + "4");
                            lbTransportMode.Text = str5.ToString();
                            break;
                        }
                        for (int cCnt5 = 5; cCnt5 <= cCntE; cCnt5++)//строка
                        {
                            var str6 = (ObjWorkSheet.Cells[rCnt5, cCnt5] as XlR.Range).Value2;
                            if (str6 == null) continue;

                           // MessageBox.Show(str6.ToString() + "5");
                            string strCoordinates = str6.ToString();

                            char ch = ',';
                            int del = strCoordinates.IndexOf(ch);
                            lbCoordinate_Y.Text = strCoordinates.Remove(del);
                            lbCoordinate_X.Text = strCoordinates.Substring(del+2);
                        }
                    }
                }
                MessageBox.Show("Импорт завершен!"," Сообщение системы " );
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
    }
}

