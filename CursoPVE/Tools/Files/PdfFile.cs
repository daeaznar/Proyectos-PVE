using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace Tools.Files
{
    public class PdfFile
    {
        #region Properties
        public string Title { get; set; }
        public string FileName { get; set; }
        public List<string> FileContent { get; set; }

        #endregion

        public bool Create()
        {
            try
            {
                PdfDocument document = new PdfDocument();
                document.Info.Title = Title;
                PdfPage page = document.AddPage();
                XGraphics graphics = XGraphics.FromPdfPage(page);
                XFont font = new XFont("Verdana", 20, XFontStyle.Regular);
                int x = 50, y = 50;
                foreach (var text in FileContent)
                {
                    graphics.DrawString(text, font, XBrushes.Black, x, y);
                    y += 25;
                }
                var file = FileName + ".pdf";
                document.Save(file);
                Process.Start(file);
                return File.Exists(file);
            }
            catch (Exception)
            {
                return false;                
            }
        }
    }
}
