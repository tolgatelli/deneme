 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 
using System.Text.RegularExpressions; 
using System.Threading;
using System.Diagnostics;
using System.IO;
using System.Drawing.Drawing2D;

   private void run()
        {
      var satir1 = "";

            var satir2 = "";


            StringBuilder sonuc = new StringBuilder();

            StringBuilder sonuc2 = new StringBuilder();


            for (int i = 0; i < 8; i++)
            {

                satir1 += " * ";


            }
            for (int i = 0; i < 8; i++)
            {

                sonuc.AppendLine(satir1);


            }

            sonuc.AppendLine("");
            sonuc.AppendLine("");

            for (int i = 0; i < 8; i++)
            {

                satir2 += " * ";
                sonuc.AppendLine(satir2);
                sonuc2.AppendLine(satir2);


            }


            sonuc.AppendLine("");
            sonuc.AppendLine("");

            sonuc2.AppendLine("");
            sonuc2.AppendLine("");

            //var t = "";

            //for (int i =8; i>0; i--)
            //{

            // t += " * ";

            // var bosluk = "";

            //    for (int j = 0;   bosluk.Length<25-t.Length ; j++)
            //    {

            //        bosluk += " ";

            //    }


            // sonuc.AppendLine( bosluk +t);


            //}

            Bitmap bmp0 = new Bitmap(400, 800);
            using (Graphics graph0 = Graphics.FromImage(bmp0))
            {
                Rectangle ImageSize0 = new Rectangle(0, 0, 400, 800);
                graph0.FillRectangle(Brushes.Black, ImageSize0);
            }

            RectangleF rectf0 = new RectangleF(150, 500, 400, 200);

            Graphics g0 = Graphics.FromImage(bmp0);

            g0.SmoothingMode = SmoothingMode.AntiAlias;

            g0.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g0.PixelOffsetMode = PixelOffsetMode.HighQuality;
            g0.DrawString(sonuc2.ToString(), new Font("Tahoma", 12), Brushes.White, rectf0);
           
            g0.Flush();

            bmp0.RotateFlip(RotateFlipType.RotateNoneFlipX);


            Bitmap bmp = new Bitmap(400, 500);
            using (Graphics graph = Graphics.FromImage(bmp))
            {
                Rectangle ImageSize = new Rectangle(0, 0, 400, 500);
                graph.FillRectangle(Brushes.Black, ImageSize);
            }

            RectangleF rectf = new RectangleF(100, 100, 400, 400);

            Graphics g = Graphics.FromImage(bmp);

            g.SmoothingMode = SmoothingMode.AntiAlias;

            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;
            g.DrawString(sonuc.ToString(), new Font("Tahoma", 12), Brushes.White, rectf);

            g.Flush();


            Bitmap tt = MergedBitmaps(bmp , bmp0);

      

            tt.Save("t.bmp");

            //byte[] byteArray = ASCIIEncoding.ASCII.GetBytes(sonuc.ToString());

            //using (var ms = new MemoryStream(byteArray))
            //{
            //    var img = new Bitmap(ms);

            //    img.Save("t.jpg");

            //    //do something with image.
            //}



            //sonuc.AppendLine(  satir3);
            //for (int i = 0; i < 7; i++)
            //{


            //    satir3 = satir3.Remove(satir3.LastIndexOf(" "), 1);

            //    satir3 = satir3.Insert(satir3.LastIndexOf("*") - 1, " *");

            //    satir3 = satir3.Replace(" *", "* ");

            //    sonuc.AppendLine(  satir3);

            //    satir3 = satir3.Replace(" *", "* ");


            //}


           // MessageBox.Show(sonuc.ToString());

         Process.Start("t.bmp");
        }

        private Bitmap MergedBitmaps(Bitmap bmp1, Bitmap bmp2)
        {
            Bitmap result = new Bitmap(Math.Max(bmp1.Width, bmp2.Width),
                                       Math.Max(bmp1.Height, bmp2.Height));
            using (Graphics g = Graphics.FromImage(result))
            {
                g.DrawImage(bmp2, Point.Empty);
                g.DrawImage(bmp1, Point.Empty);
            }
            return result;
        }