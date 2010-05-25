using ExportToRTF;

namespace ExportToRTF
{
    public class WordRow : WordCellRange
    {
        #region Data
        internal int height=0,index;
        #endregion

        #region int Index
        /// <summary>
        /// Gets the index of the row.
        /// </summary>
        public int Index
        {
            get
            {
                return this.index;
            }
        }
        #endregion

        #region void SetRowHeight(int Height)
        /// <summary>
        /// Sets the row height in twips.
        /// </summary>
        /// <param name="Height"></param>
        public void SetRowHeight(int Height)
        {
            this.height=Height;
        }
        #endregion

        #region WordRow(WordTable WordTable,int index)
        internal WordRow(WordTable WordTable,int index)
        {
            this.WordTable=WordTable;
            this.index=index;
            this.startColumn=0;
            this.endColumn=this.WordTable.columns-1;
            this.startRow=index;
            this.endRow=index;
        }
        #endregion

        #region WordCell this[int column]
        /// <summary>
        /// Gets a cell specifying the column.
        /// </summary>
        public WordCell this[int column]
        {
            get
            {
                return this.WordTable.Cell(this.index,column);
            }
        }
        #endregion
    }
}