using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.IO;

namespace Inventory.Utils
{
    public class Converter
    {
        /// <summary>
        /// Convert byte[] to Image
        /// </summary>
        /// <param name="arrBytes"></param>
        /// <returns></returns>
        public Image ToImage(byte[] arrBytes)
        {
            MemoryStream msMemStream = new MemoryStream();
            msMemStream.Write(arrBytes, 0, arrBytes.Length);
            Image img = Image.FromStream(msMemStream);
            if (img == null) return null;
            return img;
        }

        /// <summary>
        /// Convert byte[] to Bitmap
        /// </summary>
        /// <param name="arrBytes"></param>
        /// <returns></returns>
        public Bitmap ToBitmap(byte[] arrBytes)
        {
            //Create Memory Stream of BarCode
            MemoryStream msMemStream = new MemoryStream(arrBytes);
            Bitmap bmp = new Bitmap(msMemStream);
            if (bmp == null) return null;
            return bmp;
        }
    }
}
