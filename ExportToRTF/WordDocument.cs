using System;
using System.Collections;
using System.Drawing;
using System.Text;
using System.IO;

namespace ExportToRTF
{
    public class WordDocument : WordArea
    {
        #region Data
        private ArrayList FontList;
        private ArrayList Colors;
        private int StartPage=0;
        #endregion	

        #region WordDocument(WordDocumentFormat WordDocumentFormat)
        /// <summary>
        /// Creates a new word document specifing the format of the pages.
        /// </summary>
        /// <param name="WordDocumentFormat"></param>
        public WordDocument(WordDocumentFormat WordDocumentFormat)
        {
            this.WordDocument=this;
            this.FontList=new ArrayList();
            this.Colors=new ArrayList();
            this.AddColorAndGetID(Color.Black);
            this.AddColorAndGetID(Color.White);
            this.Objects=new ArrayList();
            this.Write(WordDocumentFormat.ToLineStream(),false);
        }
        #endregion

        #region void NewPage()
        /// <summary>
        /// Writes a page interruption (new page)
        /// </summary>
        public void NewPage()
        {
            this.Write("\n\\page\n",false);
        }
        #endregion

        #region WordImage NewImage(string file,int DPI)
        internal WordImage NewImage(string file,int DPI)
        {
            return new WordImage(file,DPI);
        }
        #endregion

        #region WordTable NewTable(Font DefaultFont,Color DefaultForegroundColor,int rows,int columns,int padding)
        /// <summary>
        /// Creates a new WordTable.
        /// </summary>
        /// <param name="DefaultFont"></param>
        /// <param name="DefaultForegroundColor"></param>
        /// <param name="rows"></param>
        /// <param name="columns"></param>
        /// <param name="padding"></param>
        /// <returns></returns>
        public WordTable NewTable(Font DefaultFont,Color DefaultForegroundColor,int rows,int columns,int padding)
        {
            WordTable ta=new WordTable(this.WordDocument,rows,columns,padding);
            foreach (WordCell rc in ta.cells.Values) 
            {
                rc.SetForegroundColor(DefaultForegroundColor);
                rc.SetFont(DefaultFont);
            }
            return ta;
        }
        #endregion

        #region void SetPageNumbering(int StartPageNumber)
        /// <summary>
        /// Sets the document's page numbering. It can be called only once.
        /// </summary>
        /// <param name="StartPageNumber"></param>
        public void SetPageNumbering(int StartPageNumber)
        {
            if (StartPageNumber<1) throw new Exception("StartPageNumber must be greater than zero.");
            if (this.StartPage>0) throw new Exception("Page Numbering is already set.");
            this.StartPage=StartPageNumber;
        }
        #endregion

        #region void HeaderStart()
        /// <summary>
        /// Set the starting tag of the header of the document
        /// </summary>
        public void HeaderStart()
        {
            this.Write("{\\header ",false);
        }
        #endregion

        #region void HeaderEnd()
        /// <summary>
        /// Set the ending tag of the header of the document
        /// </summary>
        public void HeaderEnd()
        {
            this.Write("\\par }",false);
        }
        #endregion

        #region void FooterStart()
        /// <summary>
        /// Set the starting tag of the footer of the document
        /// </summary>
        public void FooterStart()
        {
            this.Write("{\\footer ",false);
        }
        #endregion

        #region void FooterEnd()
        /// <summary>
        /// Set the ending tag of the footer of the document
        /// </summary>
        public void FooterEnd()
        {
            this.Write("\\par }",false);
        }
        #endregion

        #region int AddFontAndGetID(Font f)
        internal int AddFontAndGetID(Font f)
        {
            if (!FontList.Contains(f.Name))
            {
                FontList.Add(f.Name);
            }
            return FontList.IndexOf(f.Name);
        }
        #endregion

        #region int AddColorAndGetID(Color c)
        internal int AddColorAndGetID(Color c)
        {
            string cl=Utility.ColorLine(c);
            if (!this.Colors.Contains(cl))
            {
                int id=this.Colors.Count;
                this.Colors.Add(cl);
                return id+1;
            } 
            return this.Colors.IndexOf(cl)+1;
        }
        #endregion

        #region string Header
        internal string Header
        {
            get
            {
                string s= "{";
                s+="\\rtf1\\ansi\n";
                s+=this.FontTable;
                s+=this.ColorTable;
                if (this.StartPage>-1) s+="\\pgnstart"+this.StartPage+"\n";
                return s;
            }
        }
        #endregion

        #region string Footer 
        internal string Footer
        {
            get
            {
                return "\n}\n";
            }
        }
        #endregion
		
        #region string FontTable
        internal string FontTable
        {
            get
            {
                string s="{\\fonttbl\n";
                for (int index=0;index<this.FontList.Count;index++)
                {
                    s+="{\\f"+index.ToString()+" \\fcharset204 "+FontList[index].ToString()+";}\n";
                }
                s+="}\n";
                return s;
            }
        }
        #endregion
		
        #region string ColorTable 
        internal string ColorTable
        {
            get
            {
                string s="{\\colortbl;\n";
                foreach (string c in this.Colors)
                    s+=c;
                s+="}\n";
                return s;
            }
        }
        #endregion

        #region void SaveToStream(System.IO.Stream Stream)
        /// <summary>
        /// Outputs the Complete WORD Document to a Generic Stream as a Rich Text Format (RTF)
        /// </summary>
        /// <param name="Stream">
        /// The Generic Stream to Output the Pdf Document
        /// </param>
        public void SaveToStream(System.IO.Stream Stream)
        {
            Utility.Send(this.Header,Stream);
            System.IO.MemoryStream ms2=new System.IO.MemoryStream();
            this.RenderToStream(ms2);
            Byte[] b=ms2.ToArray();
            Stream.Write(b,0,b.Length);
            ms2.Close();
            Utility.Send(this.Footer,Stream);
        }
        #endregion
		
        #region void SaveToFile(string file)
        /// <summary>
        /// Outputs the complete WORD Document to a file as a Rich Text Format (RTF)
        /// </summary>
        /// <param name="file"></param>
        public void SaveToFile(string file)
        {
            System.IO.StreamWriter sw=null;
            try
            {
                sw=new StreamWriter(file,false);
                this.SaveToStream(sw.BaseStream);
			
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                sw.Close();
            }
        }
        #endregion
    }
}