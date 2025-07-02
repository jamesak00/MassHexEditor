using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Text;

namespace MassHexEditor
{
    class HexToByte
    {
        public static int StringToByteArray(string hex)
        {
            int decimalValue = Convert.ToInt32(hex, 16);
            return decimalValue;
        }
    }
}
