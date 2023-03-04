using System;
using System.IO;
using System.IO.Compression;
using System.Text;

namespace ZipJPXtractor
{
    class Program
    {
        static void Main(string[] args)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            var filename = args[0];
            
            string extractPath = @"extract";
            extractPath = Path.GetFullPath(extractPath);
            
            Encoding shiftJIS = Encoding.GetEncoding("Shift_JIS");
            ZipFile.ExtractToDirectory(filename, extractPath,shiftJIS);
            Console.WriteLine("Done! {0}", filename);
        }
    }
}
