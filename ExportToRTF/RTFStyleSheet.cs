using System;
using System.Drawing;

namespace ExportToRTF
{
    /// <summary>
    /// Класс, содержащий продпределенные фукци разметки таблицы для rtf
    /// </summary>
    public  class RTFStyleSheet
    {
        #region Data
        static Font caption = new Font("Arial",14,FontStyle.Bold);
        static Font normalBold = new Font("Arial",10,FontStyle.Bold);
        static Font normal = new Font("Arial",10,FontStyle.Regular);
        #endregion

        #region RTFStyleSheet()
        private RTFStyleSheet()
        {
			
        }
        #endregion

        #region static void H1Write(WordTable rt, string text, ref int curRow)
        /// <summary>
        /// Большой заголовок, через 2 столбца ячейки
        /// </summary>
        /// <param name="rt"></param>
        /// <param name="text"></param>
        /// <param name="curRow"></param>
        static internal void H1Write(WordTable rt, string text, ref int curRow)
        {
            rt.Rows[curRow].SetRowHeight(420);
            rt.Rows[curRow][0].ColSpan	= 2;
            rt.Rows[curRow][0].SetCellPadding(45)	;
            rt.Rows[curRow][0].SetBorders(Color.Black, 1, true, true, true, true);
            rt.Rows[curRow][0].SetFont(caption);
            rt.Rows[curRow][0].SetContentAlignment(ContentAlignment.BottomLeft);
            rt.Rows[curRow][0].Write(text);
            curRow++;
        }
        #endregion

        #region static void H2Write(WordTable rt, string text, ref int curRow)
        /// <summary>
        /// Нормальный жирный заголовок на 2 столбца с фоном 
        /// </summary>
        /// <param name="rt"></param>
        /// <param name="text"></param>
        /// <param name="curRow"></param>
        static internal void H2Write(WordTable rt, string text, ref int curRow)
        {
            rt.Rows[curRow][0].ColSpan	= 2;
            rt.Rows[curRow][0].SetBorders(Color.Black, 1, true, false, true, true);
            rt.Rows[curRow][0].SetFontBackgroundColor(Color.DarkGray);
            rt.Rows[curRow][0].SetBackgroundColor(Color.DarkGray);
            rt.Rows[curRow][0].SetFont(normalBold);
            rt.Rows[curRow][0].Write(text);
            curRow++;
        }
        #endregion

        #region static void H3Write(WordTable rt, string text, ref int curRow)
        /// <summary>
        /// Нормальный текст на 2 столбца
        /// </summary>
        /// <param name="rt"></param>
        /// <param name="text"></param>
        /// <param name="curRow"></param>
        static internal void H3Write(WordTable rt, string text, ref int curRow)
        {
            rt.Rows[curRow][0].ColSpan	= 2;
            rt.Rows[curRow][0].SetBorders(Color.Black, 1, false, true, true, true);
            rt.Rows[curRow][0].SetFontBackgroundColor(Color.White);
            rt.Rows[curRow][0].SetFont(normal);
            rt.Rows[curRow][0].Write(text);
            curRow++;
        }
        #endregion

        #region static void H4Write(WordTable rt, string leftColumn, string rightColumn, ref int curRow)
        /// <summary>
        /// Левый столбец жирный с фоном, правый - обычный без фона
        /// </summary>
        /// <param name="rt"></param>
        /// <param name="leftColumn"></param>
        /// <param name="rightColumn"></param>
        /// <param name="curRow"></param>
        static internal void H4Write(WordTable rt, string leftColumn, string rightColumn, ref int curRow)
        {
            rt.Rows[curRow][0].SetBorders(Color.Black, 1, true, true, true, true);
            rt.Rows[curRow][0].SetFont(normalBold);
            rt.Rows[curRow][0].SetBackgroundColor(Color.DarkGray);
            rt.Rows[curRow][0].SetFontBackgroundColor(Color.DarkGray);	
            rt.Rows[curRow][0].Write(leftColumn);
			
            rt.Rows[curRow][1].SetBorders(Color.Black, 1, true, true, true, true);
            rt.Rows[curRow][1].SetFont(normal);
            rt.Rows[curRow][1].SetFontBackgroundColor(Color.White);	
            rt.Rows[curRow][1].Write(rightColumn);
            curRow++;
        }
        #endregion

        #region static void H5Write(WordTable rt, string leftColumn, string rightColumn, ref int curRow)
        /// <summary>
        /// /// Левый столбец обычный без фона, правый - обычный без фона
        /// </summary>
        /// <param name="rt"></param>
        /// <param name="leftColumn"></param>
        /// <param name="rightColumn"></param>
        /// <param name="curRow"></param>
        static internal void H5Write(WordTable rt, string leftColumn, string rightColumn, ref int curRow)
        {
            rt.Rows[curRow][0].SetBorders(Color.Black, 1, true, true, true, true);
            rt.Rows[curRow][0].SetFont(normal);
            rt.Rows[curRow][0].SetFontBackgroundColor(Color.White);	
            rt.Rows[curRow][0].Write(leftColumn);
			
            rt.Rows[curRow][1].SetBorders(Color.Black, 1, true, true, true, true);
            rt.Rows[curRow][1].SetFont(normal);
            rt.Rows[curRow][1].SetFontBackgroundColor(Color.White);	
            rt.Rows[curRow][1].Write(rightColumn);
            curRow++;
        }
        #endregion
		
        #region static void H6Write(WordTable rt, string leftColumn, string rightColumn, ref int curRow)
        /// <summary>
        /// 4 столбца все жирные
        /// </summary>
        static internal void H6Write(WordTable rt, string text1, string text2, string text3, string text4, ref int curRow)
        {
            rt.Rows[curRow][0].SetBorders(Color.Black, 1, true, true, true, true);
            rt.Rows[curRow][0].SetFont(normalBold);
            rt.Rows[curRow][0].SetContentAlignment(ContentAlignment.TopCenter);
            rt.Rows[curRow][0].SetFontBackgroundColor(Color.White);	
            rt.Rows[curRow][0].Write(text1);
			
            rt.Rows[curRow][1].SetBorders(Color.Black, 1, true, true, true, true);
            rt.Rows[curRow][1].SetFont(normalBold);
            rt.Rows[curRow][1].SetContentAlignment(ContentAlignment.TopCenter);
            rt.Rows[curRow][1].SetFontBackgroundColor(Color.White);	
            rt.Rows[curRow][1].Write(text2);

            rt.Rows[curRow][2].SetBorders(Color.Black, 1, true, true, true, true);
            rt.Rows[curRow][2].SetFont(normalBold);
            rt.Rows[curRow][2].SetContentAlignment(ContentAlignment.TopCenter);
            rt.Rows[curRow][2].SetFontBackgroundColor(Color.White);	
            rt.Rows[curRow][2].Write(text3);

            rt.Rows[curRow][3].SetBorders(Color.Black, 1, true, true, true, true);
            rt.Rows[curRow][3].SetFont(normalBold);
            rt.Rows[curRow][3].SetContentAlignment(ContentAlignment.TopCenter);
            rt.Rows[curRow][3].SetFontBackgroundColor(Color.White);	
            rt.Rows[curRow][3].Write(text4);
            curRow++;
        }
        #endregion

        #region static void H6WriteBackGround(WordTable rt, string leftColumn, string rightColumn, ref int curRow)
        /// <summary>
        /// 4 столбца все жирные с фоном
        /// </summary>
        static internal void H6WriteBackGround(WordTable rt, string text1, string text2, string text3, string text4, ref int curRow)
        {
            rt.Rows[curRow][0].SetBorders(Color.Black, 1, true, true, true, true);
            rt.Rows[curRow][0].SetFont(normalBold);
            rt.Rows[curRow][0].SetContentAlignment(ContentAlignment.TopCenter);
            rt.Rows[curRow][0].SetFontBackgroundColor(Color.DarkGray);
            rt.Rows[curRow][0].SetBackgroundColor(Color.DarkGray);
            rt.Rows[curRow][0].Write(text1);
			
            rt.Rows[curRow][1].SetBorders(Color.Black, 1, true, true, true, true);
            rt.Rows[curRow][1].SetFont(normalBold);
            rt.Rows[curRow][1].SetContentAlignment(ContentAlignment.TopCenter);
            rt.Rows[curRow][1].SetFontBackgroundColor(Color.DarkGray);	
            rt.Rows[curRow][1].SetBackgroundColor(Color.DarkGray);
            rt.Rows[curRow][1].Write(text2);

            rt.Rows[curRow][2].SetBorders(Color.Black, 1, true, true, true, true);
            rt.Rows[curRow][2].SetFont(normalBold);
            rt.Rows[curRow][2].SetContentAlignment(ContentAlignment.TopCenter);
            rt.Rows[curRow][2].SetFontBackgroundColor(Color.DarkGray);	
            rt.Rows[curRow][2].SetBackgroundColor(Color.DarkGray);
            rt.Rows[curRow][2].Write(text3);

            rt.Rows[curRow][3].SetBorders(Color.Black, 1, true, true, true, true);
            rt.Rows[curRow][3].SetFont(normalBold);
            rt.Rows[curRow][3].SetContentAlignment(ContentAlignment.TopCenter);
            rt.Rows[curRow][3].SetFontBackgroundColor(Color.DarkGray);
            rt.Rows[curRow][3].SetBackgroundColor(Color.DarkGray);
            rt.Rows[curRow][3].Write(text4);
            curRow++;
        }
        #endregion

        #region static void H7Write(WordTable rt, string leftColumn, string rightColumn, ref int curRow)
        /// <summary>
        /// 4 столбца все жирные
        /// </summary>
        static internal void H7Write(WordTable rt, string text1, string text2, string text3, string text4, ref int curRow)
        {
            rt.Rows[curRow][0].SetBorders(Color.Black, 1, true, true, true, true);
            rt.Rows[curRow][0].SetFont(normalBold);
            rt.Rows[curRow][0].SetFontBackgroundColor(Color.White);	
            rt.Rows[curRow][0].Write(text1);
			
            rt.Rows[curRow][1].SetBorders(Color.Black, 1, true, true, true, true);
            rt.Rows[curRow][1].SetFont(normal);
            rt.Rows[curRow][1].SetFontBackgroundColor(Color.White);	
            rt.Rows[curRow][1].Write(text2);

            rt.Rows[curRow][2].SetBorders(Color.Black, 1, true, true, true, true);
            rt.Rows[curRow][2].SetFont(normal);
            rt.Rows[curRow][2].SetFontBackgroundColor(Color.White);	
            rt.Rows[curRow][2].Write(text3);

            rt.Rows[curRow][3].SetBorders(Color.Black, 1, true, true, true, true);
            rt.Rows[curRow][3].SetFont(normal);
            rt.Rows[curRow][3].SetFontBackgroundColor(Color.White);	
            rt.Rows[curRow][3].Write(text4);
            curRow++;
        }
        #endregion

        #region static void H8Write(WordTable rt, string leftColumn, string rightColumn, ref int curRow)
        static internal void H8Write(WordTable rt, string text1, string text2, string text3, string text4, ref int curRow)
        {
            rt.Rows[curRow][0].SetBorders(Color.Black, 1, true, true, true, true);
            rt.Rows[curRow][0].SetFont(normalBold);
            rt.Rows[curRow][0].SetContentAlignment(ContentAlignment.MiddleCenter);
            rt.Rows[curRow][0].SetFontBackgroundColor(Color.DarkGray);
            rt.Rows[curRow][0].SetBackgroundColor(Color.DarkGray);
            rt.Rows[curRow][0].Write(text1);
			
            rt.Rows[curRow][1].SetBorders(Color.Black, 1, true, true, true, true);
            rt.Rows[curRow][1].SetFont(normal);
            rt.Rows[curRow][1].SetContentAlignment(ContentAlignment.TopLeft);
            rt.Rows[curRow][1].SetFontBackgroundColor(Color.White);	
            rt.Rows[curRow][1].Write(text2);

            rt.Rows[curRow][2].SetBorders(Color.Black, 1, true, true, true, true);
            rt.Rows[curRow][2].SetFont(normal);
            rt.Rows[curRow][2].SetContentAlignment(ContentAlignment.TopLeft);
            rt.Rows[curRow][2].SetFontBackgroundColor(Color.White);	
            rt.Rows[curRow][2].Write(text3);

            rt.Rows[curRow][3].SetBorders(Color.Black, 1, true, true, true, true);
            rt.Rows[curRow][3].SetFont(normal);
            rt.Rows[curRow][3].SetContentAlignment(ContentAlignment.TopLeft);
            rt.Rows[curRow][3].SetFontBackgroundColor(Color.White);	
            rt.Rows[curRow][3].Write(text4);
            curRow++;
        }
        #endregion
    }
}