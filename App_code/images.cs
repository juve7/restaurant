﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;

/// <summary>
/// Descripción breve de images
/// </summary>
public class images
{
    public static string ResizeImage(string strImgPath, string strImgOutputPath, int iWidth, int iHeight)
    {
        try
        {
            bool mismaImagen = strImgPath.Equals(strImgOutputPath);
            if (mismaImagen)
            {
                strImgOutputPath = strImgPath + "___.jpg";
            }

            string[] extensiones = {
                                   ".jpg",
                                   ".png",
                                   ".bmp",
                                   ".gif"
            };

            if (!extensiones.Contains(Path.GetExtension(strImgPath)))
                throw new Exception("Extensión no soportada");

            //Lee el fichero en un stream
            Stream mystream = null;

            if (strImgPath.StartsWith("http"))
            {
                HttpWebRequest wreq = (HttpWebRequest)WebRequest.Create(strImgPath);
                HttpWebResponse wresp = (HttpWebResponse)wreq.GetResponse();
                mystream = wresp.GetResponseStream();
            }
            else
                mystream = File.OpenRead(strImgPath);

            // Cargo la imágen
            Bitmap imgToResize = new Bitmap(mystream);

            Size size = new Size(iWidth, iHeight);

            int destWidth = iWidth;
            int destHeight = iHeight;

            Bitmap b = new Bitmap(destWidth, destHeight);
            Graphics g = Graphics.FromImage((System.Drawing.Image)b);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;

            g.DrawImage(imgToResize, 0, 0, destWidth, destHeight);
            g.Dispose();

            // We will store the correct image codec in this object
            ImageCodecInfo ici = GetEncoderInfo("image/jpeg"); ;
            // This will specify the image quality to the encoder
            EncoderParameter epQuality = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, 99L);
            // Store the quality parameter in the list of encoder parameters
            EncoderParameters eps = new EncoderParameters(1);
            eps.Param[0] = epQuality;
            b.Save(strImgOutputPath, ici, eps);

            imgToResize.Dispose();
            mystream.Close();
            mystream.Dispose();
            b.Dispose();
            g.Dispose();

            if (mismaImagen)
            {
                File.Delete(strImgPath);
                File.Move(strImgOutputPath, strImgPath);
            }

            return strImgPath;
        }
        catch
        {
            throw;
        }
    }
    private static ImageCodecInfo GetEncoderInfo(String mimeType)
    {
        int j;
        ImageCodecInfo[] encoders;
        encoders = ImageCodecInfo.GetImageEncoders();
        for (j = 0; j < encoders.Length; ++j)
        {
            if (encoders[j].MimeType == mimeType)
                return encoders[j];
        }
        return null;
    }

}