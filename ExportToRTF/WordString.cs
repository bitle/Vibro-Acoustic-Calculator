using System;
using ExportToRTF;

namespace ExportToRTF
{
    public class WordString : IWordStreamer
    {
        #region Data
        private string _value;
        #endregion
		
        #region WordString(string Value,bool DoEncoding)
        public WordString(string Value,bool DoEncoding)
        {
            if (DoEncoding)
                this._value=Utility.Encode(Value);
            else
                this._value=Value;
        }
        #endregion

        #region IWordStreamer Members
        public void RenderToStream(System.IO.Stream ms)
        {
            Byte[] b=Utility.StringToByte(this._value);
            ms.Write(b,0,b.Length);
        }

        #endregion
    }
}