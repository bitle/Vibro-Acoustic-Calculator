using System;
using System.Drawing;
using System.Text;

namespace ExportToRTF
{
    public class Utility
    {
        #region Data

        static System.Text.UnicodeEncoding ue=new System.Text.UnicodeEncoding();
        static char[] hexDigits = {	'0', '1', '2', '3', '4', '5', '6', '7',
                                   	'8', '9', 'A', 'B', 'C', 'D', 'E', 'F'};
        #endregion

        #region static string ColorLine(Color Color)
        internal static string ColorLine(Color Color)
        {
            return "\\red"+(int)Color.R+"\\green"+(int)Color.G+"\\blue"+(int)Color.B+";\n";
        }
        #endregion
		
        #region static string EncodeCellAlignV(ContentAlignment cellTextAlign)
        internal static string EncodeCellAlignV(ContentAlignment cellTextAlign)
        {
            switch (cellTextAlign)
            {
                case ContentAlignment.MiddleLeft:
                case ContentAlignment.MiddleCenter:
                case ContentAlignment.MiddleRight:
                    return "\\clvertalc";

                case ContentAlignment.BottomCenter:
                case ContentAlignment.BottomLeft:
                case ContentAlignment.BottomRight:
                    return "\\clvertalb";
            }
            return "\\clvertalt";
        }
        #endregion

        #region static string EncodeCellAlignH(ContentAlignment cellTextAlign)
        internal static string EncodeCellAlignH(ContentAlignment cellTextAlign)
        {
            switch (cellTextAlign)
            {
                case ContentAlignment.BottomCenter:
                case ContentAlignment.MiddleCenter:
                case ContentAlignment.TopCenter:
                    return "\\qc";

                case ContentAlignment.BottomRight:
                case ContentAlignment.MiddleRight:
                case ContentAlignment.TopRight:
                    return "\\qr";			    				
            }
            return "\\ql";
        }
        #endregion
 
        #region static string ToHexString(byte[] bytes)
        internal static string ToHexString(byte[] bytes) 
        {
            char[] chars = new char[bytes.Length * 2];
            for (int i = 0; i < bytes.Length; i++) 
            {
                int b = bytes[i];
                chars[i * 2] = hexDigits[b >> 4];
                chars[i * 2 + 1] = hexDigits[b & 0xF];
            }
            return new string(chars);
        }
        #endregion

        #region static string ToHexString(byte Byte)
        internal static string ToHexString(byte Byte)
        {
            int b = Byte;
            return hexDigits[b >> 4].ToString()+hexDigits[b & 0xF].ToString();
        }
        #endregion

        #region static Byte[] StringToByte(string s)
        internal static Byte[] StringToByte(string s)
        {
            return System.Text.ASCIIEncoding.ASCII.GetBytes(s);
        }
        #endregion

        #region static void Send(string strMsg,System.IO.Stream ms)
        internal static void Send(string strMsg,System.IO.Stream ms)
        {
            Byte[] buffer=null;
            buffer=System.Text.ASCIIEncoding.ASCII.GetBytes(strMsg);
            ms.Write(buffer,0,buffer.Length); 
        }
        #endregion

        #region static string Encode(string s)
        internal static string Encode(string s)
        {
            s=s.Replace("\\","\\\\");
            System.Text.StringBuilder sb=new System.Text.StringBuilder();
            //System.Text.Encoder ue1=new System.Text.Encoder();
            foreach (char c in s.ToCharArray())
            {
                if ((c>=48&&c<=122)||c=='\n'||c==' ') sb.Append(c);
                else
                {
                    if (c=='€')
                        sb.Append("\\'80");
                    else
                    {
                        byte[] Bytes= Encoding.Default.GetBytes(new char[]{c});
                        //byte[] Bytes=System.Text.Encoder
                        string tmp="\\'"+Utility.ToHexString(Bytes[0]);
                        sb.Append(tmp);
                    }
                }
            }
            return sb.ToString().Replace("\r\n","\\par").Replace("\n","\\par ");
        }
        #endregion
    }
}