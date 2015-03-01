using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Drawing;
using Inventory.DataModels.Barcode;
using System.Drawing.Imaging;

namespace Inventory.Utils.Barcode
{
    public class BarcodeGenerator
    {
        public static string GenerateAutoBarcodeID()
        {
            Random objRandom = new Random();
            string strTemp = string.Empty;
            for (int i = 0; i < 10; i++)
            {
                strTemp += objRandom.Next(0, 9).ToString();
            }
            return strTemp;
        }
        public byte[] GetCode39Bytes(BarcodeModel objBarcodeModel)
        {
            Code39 objCode39 = new Code39();

            //Assign parameters for Code39 object
            objCode39.FontFamilyName = "Free 3 of 9";//ConfigurationSettings.AppSettings["BarCodeFontFamily"];
            objCode39.FontFileName = @"Code39Font\FREE3OF9.TTF";//ConfigurationSettings.AppSettings["BarCodeFontFile"];
            objCode39.FontSize = objBarcodeModel.Size;
            objCode39.ShowCodeString = objBarcodeModel.ViewBarcodeID;

            if (!string.IsNullOrEmpty(objBarcodeModel.Label) && objBarcodeModel.ViewBarcodeLabel)
            {
                objCode39.Title = objBarcodeModel.Label;
            }

            //Create picture
            Bitmap objBitmap = objCode39.GenerateBarcode(objBarcodeModel.BarcodeId);

            //Create stream
            MemoryStream objMemStream = new MemoryStream();

            //Save picture
            objBitmap.Save(objMemStream, ImageFormat.Png);

            //Return bytes
            return objMemStream.GetBuffer();
        }
    }
}
