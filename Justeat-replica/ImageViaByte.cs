using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Justeat_replica
{
    public static class ImageViaByte
    {
        public static Image ByteToImage(byte[] imgbyte)
        {
            Image outputImage = null;
            using (MemoryStream ms = new MemoryStream(imgbyte))
            {
                outputImage = Image.FromStream(ms);
            }
            return outputImage;
        }
    }
}
