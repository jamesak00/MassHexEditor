using System;
using System.Collections.Generic;
using System.Text;

namespace MassHexEditor
{
    class ByteToHex
    { 
        public static string ByteArrayToString(int ba)
        {
            StringBuilder hex = new StringBuilder(ba * 2);
            
            hex.AppendFormat("{0:x2}", ba);
            return hex.ToString().ToUpper();
        }
    }
}
