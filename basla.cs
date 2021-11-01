
   private void run()
        {
            var satir1 = "";

            var satir2 = "";

            var satir3 = "";

            StringBuilder sonuc = new StringBuilder();

            for (int i = 0; i < 8; i++)
            {

                satir1 += "* ";


            }
            for (int i = 0; i < 8; i++)
            {

                sonuc.AppendLine(satir1);


            }
           
            sonuc.AppendLine("");
            sonuc.AppendLine("");

            for (int i = 0; i < 8; i++)
            {

                satir2 += "* ";
                sonuc.AppendLine(satir2);
            

            }

            
            sonuc.AppendLine("");
            sonuc.AppendLine("");
            var t = "";

            for (int i =8; i>0; i--)
            {

             t += " *";

             var bosluk = "";

                for (int j = 0;   bosluk.Length<16-t.Length ; j++)
                {

                    bosluk += " ";
                     
                }
                
             bosluk  = bosluk +t;
              //  MessageBox.Show(bosluk.Length.ToString());

             sonuc.AppendLine( bosluk.ToUpper()  );
                 

            }
             
            Bitmap bmp = new Bitmap(400,800);
            using (Graphics graph = Graphics.FromImage(bmp))
            {
                Rectangle ImageSize = new Rectangle(0, 0, 400,800);
                graph.FillRectangle(Brushes.Black, ImageSize);
            }

            RectangleF rectf = new RectangleF(70, 90, 400, 600);

            Graphics g = Graphics.FromImage(bmp);

            g.SmoothingMode = SmoothingMode.AntiAlias;
            
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;
            g.DrawString(sonuc.ToString(), new Font("Tahoma", 12), Brushes.White, rectf);

            g.Flush();

            bmp.Save("t.bmp");

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


          

            Process.Start("t.bmp");
        }