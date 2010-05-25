
namespace ExportToRTF
{
    public class WordDocumentFormat
    {
        #region Data
        private int width,height;
        private int margl,margr,margt,margb;
        #endregion
		
        #region WordDocumentFormat()
        private WordDocumentFormat()
        {
			
        }
        #endregion

        #region static WordDocumentFormat A4
        /// <summary>
        /// gets the Classic A4 Letter.
        /// </summary>
        public static WordDocumentFormat A4
        {
            get
            {
                return WordDocumentFormat.InCentimeters(21,29.7,2,2,2.5,2);
            }
        }
        #endregion

        #region static WordDocumentFormat A4_Horizontal
        /// <summary>
        /// gets the Classic A4 Letter (Horizontal)
        /// </summary>
        public static WordDocumentFormat A4_Horizontal
        {
            get
            {
                return WordDocumentFormat.InCentimeters(29.7,21,2,2.5,2,2);
            }
        }
        #endregion

        #region static WordDocumentFormat Letter_8_5x11
        /// <summary>
        /// gets the 8.5x11 American Letter.
        /// </summary>
        public static WordDocumentFormat Letter_8_5x11
        {
            get
            {
                return WordDocumentFormat.InInches(8.5,11,.75,.75,1,.75);
            }
        }
        #endregion

        #region static WordDocumentFormat Letter_8_5x11_Horizontal
        /// <summary>
        /// gets the 8.5x11 American Letter. (Horizontal)
        /// </summary>
        public static WordDocumentFormat Letter_8_5x11_Horizontal
        {
            get
            {
                return WordDocumentFormat.InInches(11,8.5,.75,1,.75,.75);
            }
        }
        #endregion

        #region static WordDocumentFormat InCentimeters(double Width,double Height,double LeftMargin,double RightMargin,double TopMargin,double BottomMargin)
        /// <summary>
        /// creates a centimeters custom sized paper.
        /// </summary>
        /// <param name="Width"></param>
        /// <param name="Height"></param>
        /// <param name="LeftMargin"></param>
        /// <param name="RightMargin"></param>
        /// <param name="TopMargin"></param>
        /// <param name="BottomMargin"></param>
        /// <returns></returns>
        public static WordDocumentFormat InCentimeters(double Width,double Height,double LeftMargin,double RightMargin,double TopMargin,double BottomMargin)
        {
            WordDocumentFormat rpf=new WordDocumentFormat();
            rpf.height=(int)(Height*16840/29.7);
            rpf.width=(int)(Width*16840/29.7);
            rpf.margl=(int)(LeftMargin*16840/29.7);
            rpf.margr=(int)(RightMargin*16840/29.7);
            rpf.margt=(int)(TopMargin*16840/29.7);
            rpf.margb=(int)(BottomMargin*16840/29.7);
			
            return rpf;
        }
        #endregion
		
        #region static WordDocumentFormat InInches(double Width,double Height,double LeftMargin,double RightMargin,double TopMargin,double BottomMargin)
        /// <summary>
        /// creates a inches custom sized paper.
        /// </summary>
        /// <param name="Width"></param>
        /// <param name="Height"></param>
        /// <param name="LeftMargin"></param>
        /// <param name="RightMargin"></param>
        /// <param name="TopMargin"></param>
        /// <param name="BottomMargin"></param>
        /// <returns></returns>
        public static WordDocumentFormat InInches(double Width,double Height,double LeftMargin,double RightMargin,double TopMargin,double BottomMargin)
        {
            return WordDocumentFormat.InCentimeters(
                Width*2.54,Height*2.54,LeftMargin*2.54
                ,RightMargin*2.54,TopMargin*2.54,BottomMargin*2.54);
        }
        #endregion
	
        #region string ToLineStream()
        internal string ToLineStream()
        {
            string s="\\paperw"+this.width+"\\paperh"+this.height
                     +"\\margl"+this.margl+"\\margr"+this.margr
                     +"\\margt"+this.margt+"\\margb"+this.margb;
            if (width>height) s+="\\landscape1";
            s=s+"\n";
            return s;
        }
        #endregion
    }
}