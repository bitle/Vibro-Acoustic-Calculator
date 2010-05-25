
namespace ExportToRTF
{
    public class WordColumn : WordCellRange
    {
        #region Data
        internal int Width,index;
        private int compensatedWidth=0;
        #endregion
		
        #region int Index
        /// <summary>
        /// Gets the index of the column.
        /// </summary>
        public int Index
        {
            get
            {
                return this.index;
            }
        }
        #endregion

        #region WordColumn(WordTable WordTable,int index)
        internal WordColumn(WordTable WordTable,int index)
        {
            this.WordTable=WordTable;
            this.index=index;
            this.startColumn=index;
            this.endColumn=index;
            this.startRow=0;
            this.endRow=this.WordTable.rows-1;
        }
        #endregion

        #region void SetWidth(int RelativeWidth)
        /// <summary>
        /// sets the Relative Width of the Column. For example: if the relative widths of a 3 columns
        /// table are 10,10,30; the columns will respectivelly sized as 20%,20%,60% of the table size.
        /// </summary>
        /// <param name="RelativeWidth"></param>
        public void SetWidth(int RelativeWidth)
        {
            this.Width=RelativeWidth;
        }
        #endregion

        #region int CompensatedWidth
        internal int CompensatedWidth
        {
            get
            {
                if (compensatedWidth!=0) return compensatedWidth;
                float sum=0;
                foreach (WordColumn pc in this.WordTable.rtfColumns)
                {
                    sum+=pc.Width;
                }
                this.compensatedWidth=(int)(this.WordTable.width/sum)*this.Width;
                return this.compensatedWidth;
            }
        }
        #endregion
    }
}