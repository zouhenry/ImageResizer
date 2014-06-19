using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageResizer
{
    class Program
    {
        static void Main(string[] args)
        {
            var inPath = @"C:\Users\Henry\Desktop\resizer\input";
            var outPath = @"C:\Users\Henry\Desktop\resizer\output";

            var resizer = new ImageResizeLib.Resizer();
            resizer.ConvertPercent(inPath, "", 50);
        }
    }
}
