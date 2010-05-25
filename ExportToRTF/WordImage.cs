using System;
using System.Drawing;
using System.IO;
using ExportToRTF;

namespace ExportToRTF
{
    public class WordImage : IWordStreamer
    {
        #region Data
        private int dpi;
        private System.IO.Stream stream;
        private string file;
        #endregion

        #region int DPI
        internal int DPI
        {
            get
            {
                return this.dpi;
            }
        }
        #endregion

        #region WordImage(string file,int DPI)
        internal WordImage(string file,int DPI)
        {
            this.dpi=DPI;
            try
            {
                Image image=Image.FromFile(file);
                image.Dispose();
            }
            catch
            {
                throw new Exception("Error opening the jpeg file");
            }
            this.file=file;
        }
        #endregion
		
        #region IWordStreamer Members

        public void RenderToStream(Stream ms)
        {
            this.stream=ms;
            Utility.Send("{\\pict\\jpegblip",ms);
            Utility.Send("\\picscalex"+7200/this.dpi,ms);
            Utility.Send("\\picscaley"+7200/this.dpi+"\n",ms);
				
            FileStream fs = File.OpenRead(this.file);
            byte[] data = new byte[fs.Length];
            fs.Read (data, 0, data.Length);
				
            Utility.Send(Utility.ToHexString(data).Replace("FF","FF\n"),ms);
            fs.Close();
				
            Utility.Send("\n}\n",ms);
        }

        #endregion
    }
}