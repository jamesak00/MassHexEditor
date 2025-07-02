using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MassHexEditor
{
    class FileManager
    {
        public static void FileCreation() 
        {
            int bufferSize = 1024 * 1024;
            int counter = 0;

            //Ask user for input file and output folder
            Console.WriteLine("Input file: ");
            string inputFile = Console.ReadLine();

            Console.WriteLine("Hex Position: ");
            int streamPosition = HexToByte.StringToByteArray(Console.ReadLine());
            Console.WriteLine("Initial hex value: ");
            int firstIndex = HexToByte.StringToByteArray(Console.ReadLine());
            Console.WriteLine("Last hex value: ");
            int lastIndex = HexToByte.StringToByteArray(Console.ReadLine()) + 1;

            for (int i = firstIndex; i < lastIndex; i++)
            {
                using (FileStream stream = new FileStream($@"{Program.outputFolder}\{FileNaming.NewFileName(inputFile, streamPosition, i)}", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite))
                {
                    //Copies the file from the original source into the new file name above
                    FileStream fs = new FileStream($@"{inputFile}", FileMode.Open, FileAccess.ReadWrite);
                    stream.SetLength(fs.Length);
                    int bytesRead = -1;
                    byte[] bytes = new byte[bufferSize];

                    while ((bytesRead = fs.Read(bytes, 0, bufferSize)) > 0)
                    {
                        stream.Write(bytes, 0, bytesRead);
                    }

                    stream.Position = streamPosition;
                    stream.WriteByte(Convert.ToByte(i));
                    stream.Flush();

                    fs.Close();
                    counter++;
                }
            }
            Console.WriteLine($"{counter} files generated...");
            Console.ReadKey();
        }
    }
}
