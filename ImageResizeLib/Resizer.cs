using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace ImageResizeLib
{
    public enum ConvertType
    {
        percent = 1,
        exact = 2
    }

    public class Resizer
    {
        DirectoryInfo inFolder;
        DirectoryInfo outFolder;


        private void Convert(ConvertType type)
        {
            switch (type)
            {
                case ConvertType.percent:
                    break;
                case ConvertType.exact:
                    break;
                default:
                    throw new Exception("Unexpected exception");
            }
        }
        

        private void _validateFolders (string inPath, string outPath){

                var exists = Directory.Exists(inPath);
            if (exists != true)
            {
                throw new Exception(string.Format("folder doesn't exist: {0}", inPath));
            }

            inFolder = new DirectoryInfo(inPath);
            var localOutPath = outPath ?? inPath + "\\resized";
            outFolder = new DirectoryInfo(localOutPath);
        
        }

        public void ConvertPercent(string inPath, string outPath, int percent)
        {
            _validateFolders(inPath, outPath);

            var files = inFolder.GetFiles("*.jpg");
            files.ToList().ForEach(p =>
            {
                var path = string.Format(@"{0}\{1}", outFolder, p.Name);
                Console.WriteLine("converting : " + path);
                Bitmap original = (Bitmap)Image.FromFile(p.FullName);
                Bitmap resized = new Bitmap(original, new Size(original.Width * percent / 100, original.Height * percent / 100));
                resized.Save(path, original.RawFormat);
            });
        }

        public void ConvertExact(int width, int height)
        {

        }
    }
}
