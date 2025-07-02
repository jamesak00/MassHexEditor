using System;
using System.Collections.Generic;
using System.Text;

namespace MassHexEditor
{
    class FileNaming
    {
        public static string NewFileName(string inputFile, int hexLocation, int hexValue) 
        {
            string[] words = inputFile.Split(@"\");
            string fileName = $"[0x{ByteToHex.ByteArrayToString(hexLocation)}_{ByteToHex.ByteArrayToString(hexValue)}] {words[^1]}";
            return fileName;
        }
    }
}
