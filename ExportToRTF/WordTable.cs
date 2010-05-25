using System.Collections;
using System.Data;
using ExportToRTF;

namespace ExportToRTF
{
    public class WordTable : WordCellRange,IWordStreamer
    {
        #region Data
        private bool saved=false;
        internal int rows,columns,width,posx;
        internal Hashtable cells;
        internal ArrayList rtfColumns;
        internal ArrayList rtfRows;
        internal System.IO.Stream stream;
        internal WordDocument WordDocument;
        #endregion
		
        #region WordTable(WordDocument WordDocument,int rows,int columns,int padding)
        internal WordTable(WordDocument WordDocument,int rows,int columns,int padding)
        {
            this.WordTable=this;
            this.startColumn=0;
            this.startRow=0;
            this.endColumn=columns-1;
            this.endRow=rows-1;			
			
            this.rows=rows;
            this.columns=columns;
            this.WordDocument=WordDocument;this.cells=new Hashtable();
            this.rtfColumns=new ArrayList();
            this.rtfRows=new ArrayList();
            for (int c=0;c<columns;c++)
            {
                WordColumn rc=new WordColumn(this,c);
                rc.Width=(int)(100/columns);
                rtfColumns.Add(rc);
                for (int r=0;r<rows;r++)
                {
                    if (c==0) this.rtfRows.Add(new WordRow(this,r));
                    WordCell cell=new WordCell(this.WordDocument,this,r,c);
                    cell.SetCellPadding(padding);
                    this.cells[r+","+c]=cell;
                }
            }
        }
        #endregion
		
        #region WordColumn[] Columns	
        /// <summary>
        /// The Columns Array of the WordTable
        /// </summary>
        public WordColumn[] Columns
        {
            get
            {
                return this.rtfColumns.ToArray(typeof(WordColumn)) as WordColumn[];
            }
        }
        #endregion

        #region void SetColumnsWidth(int[] ColumnsWidthArray)
        /// <summary>
        /// sets the widths of the Columns.
        /// </summary>
        /// <param name="ColumnsWidthArray"></param>
        public void SetColumnsWidth(int[] ColumnsWidthArray)
        {
            for (int index=0;index<ColumnsWidthArray.Length;index++)
            {
                this.Columns[index].SetWidth(ColumnsWidthArray[index]);
            }
        }
        #endregion

        #region WordRow[] Rows
        /// <summary>
        /// The Rows Array of the WordTable
        /// </summary>
        public WordRow[] Rows
        {
            get
            {
                return this.rtfRows.ToArray(typeof(WordRow)) as WordRow[];
            }
        }
        #endregion

        #region WordCell Cell(int row,int column)
        /// <summary>
        /// Return a specific cell of the WordTable
        /// </summary>
        /// <param name="row"></param>
        /// <param name="column"></param>
        /// <returns></returns>
        public WordCell Cell(int row,int column)
        {
            WordCell pa=this.cells[row+","+column] as WordCell;
            if (pa==null) 
            {
                pa=new WordCell(this.WordDocument,this,row,column);
                this.cells.Add(row+","+column,pa);
            }
            return pa;
        }
        #endregion

        #region WordCellRange CellRange(int startRow,int startColumn,int endRow,int endColumn)
        /// <summary>
        /// Return a cell range of the WordTable.
        /// </summary>
        /// <param name="startRow"></param>
        /// <param name="startColumn"></param>
        /// <param name="endRow"></param>
        /// <param name="endColumn"></param>
        /// <returns></returns>
        public WordCellRange CellRange(int startRow,int startColumn,int endRow,int endColumn)
        {
            return new WordCellRange(this,startRow,startColumn,endRow,endColumn);
        }
        #endregion

        #region void Import(DataTable dt,int WordTableStartRow,int WordTableStartColumn)
        /// <summary>
        /// Imports text from a datatable.
        /// </summary>
        /// <param name="dt">The Source Datatable</param>
        /// <param name="WordTableStartRow">the starting row of the Pdf Table that will import datas.</param>
        /// <param name="WordTableStartColumn">the starting column of the Pdf Table that will import datas.</param>
        public void Import(DataTable dt,int WordTableStartRow,int WordTableStartColumn)
        {
            Import(dt,WordTableStartRow,WordTableStartColumn,0,999999);
        }
        #endregion

        #region void Import(DataTable dt)
        /// <summary>
        /// Imports text from a datatable.
        /// </summary>
        /// <param name="dt">The Source Datatable</param>
        public void Import(DataTable dt)
        {
            Import(dt,0,0,0,999999);
        }
        #endregion

        #region void Import(DataTable dt,int WordTableStartRow,int WordTableStartColumn,int DataTableStartRow,int DataTableEndRow)
        /// <summary>
        /// Imports text from a datatable.
        /// </summary>
        /// <param name="dt">The Source Datatable</param>
        /// <param name="WordTableStartRow">the starting row of the Pdf Table that will import datas.</param>
        /// <param name="WordTableStartColumn">the starting column of the Pdf Table that will import datas.</param>
        /// <param name="DataTableStartRow">the starting row of the DataTable that will export datas.</param>
        /// <param name="DataTableEndRow">the ending row of the DataTable that will export datas.</param>
        public void Import(DataTable dt,int WordTableStartRow,int WordTableStartColumn,int DataTableStartRow,int DataTableEndRow)
        {
            for (int r=DataTableStartRow;((r<dt.Rows.Count)&&(r<=DataTableEndRow)&&
                                          (r+WordTableStartRow-DataTableStartRow<this.rows));r++)
            {
                for (int c=0;((c<dt.Columns.Count)&&(c+WordTableStartColumn<this.columns));c++)
                {
                    if (c+WordTableStartColumn>=0&&c+WordTableStartColumn<dt.Columns.Count) 
                    {
                        WordCell pc=Cell(r+WordTableStartRow-DataTableStartRow,c+WordTableStartColumn);
                        object o=dt.Rows[r][c];
                        if (o==null) o="";
                        pc.Write(o.ToString());
                    }
                }
            }
        }
        #endregion

        #region void SaveToDocument(int Width,int PosX)
        /// <summary>
        /// Save the table to the document in the current position.
        /// </summary>
        /// <param name="Width"></param>
        /// <param name="PosX"></param>
        public void SaveToDocument(int Width,int PosX)
        {
            if (!this.saved)
            {
                this.saved=true;
                this.posx=PosX;
                this.width=Width;
                //this.WordDocument.WriteLine();
                this.WordDocument.Objects.Add(this);
                this.WordDocument.SetTextAlign(this.WordDocument.currentAlign);
                this.WordDocument.SetForegroundColor(this.WordDocument.currentColor);
            }
        }
        #endregion

        #region void SetRowHeight(int Height)
        /// <summary>
        /// Sets this Height to each Row of the Table.
        /// </summary>
        /// <param name="Height"></param>
        public void SetRowHeight(int Height)
        {
            foreach (WordRow rr in this.Rows) rr.height=Height;
        }
        #endregion
		
        #region int[] ColumnsWidths
        internal int[] ColumnsWidths
        {
            get
            {
                int sum=this.posx;
                ArrayList Widths=new ArrayList();
                foreach (WordColumn rc in this.rtfColumns)
                {
                    sum+=rc.CompensatedWidth;
                    Widths.Add(sum);
                }
                return Widths.ToArray(typeof(int)) as int[];
            }
        }
        #endregion
		
        #region IWordStreamer Members
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ms"></param>
        public void RenderToStream(System.IO.Stream ms)
        {
            this.stream=ms;
            int [] cw=this.ColumnsWidths;
            //Utility.Send("\\par");
            for (int r=0;r<this.rows;r++)
            {
                Utility.Send("\\trowd\\trleft"+this.posx,ms);
                Utility.Send("\\intbl\n",ms);
				
                for (int c=0;c<this.columns;c++)
                {
                    WordCell rc=Cell(r,c);
                    if (!rc.isColumnSpanned) 
                    {
                        Utility.Send("\\celld",ms);
                        Utility.Send(rc.BorderString,ms);
                        if (rc.HasPadding) Utility.Send(rc.PaddingString,ms);
                        Utility.Send(Utility.EncodeCellAlignV(rc.contentAlignment),ms);
                        if (rc.hasBackgroundColor) Utility.Send("\\clcbpat"+this.WordDocument.AddColorAndGetID(rc.BackgroundColor),ms);
                        if (rc.isRowSpanner) Utility.Send("\\clvmgf",ms);
                        if (rc.isRowSpanned) Utility.Send("\\clvmrg",ms);
                        Utility.Send("\\cellx"+cw[c+rc.colSpan-1],ms);
							
						
                    }
                }
				
                for (int c=0;c<this.columns;c++)
                {
                    WordCell rc=Cell(r,c);
                    if (!rc.isColumnSpanned) 
                    {
                        Utility.Send(Utility.EncodeCellAlignH(rc.contentAlignment)+" ",ms);
                        rc.RenderToStream(stream);
                        Utility.Send("\\cell",ms);
                    }
                }
				
                if (this.Rows[r].height!=0) Utility.Send("\\trrh"+this.Rows[r].height,ms);
                Utility.Send("\\row\n",ms);
            }
            Utility.Send("\\pard",ms);
            Utility.Send("\\fs"+((int)(this.WordDocument.currentFont.Size*2)).ToString()+" ",ms);
            Utility.Send("\\pard",ms);
        }

        #endregion
    }
}