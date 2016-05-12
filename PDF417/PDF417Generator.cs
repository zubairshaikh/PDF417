using System.Drawing;

namespace PDF417
{
    public class PDF417Generator
    {
        public Bitmap GeneratePDF417Code(int height, int width, string content)
        {
            Bitmap pdf417Code = null;

            var barcodeWriter = new BarcodeWriter();
            barcodeWriter.Options.Height = height;
            barcodeWriter.Options.Width = width;
            barcodeWriter.Format = BarcodeFormat.PDF_417;
            pdf417Code = barcodeWriter.Write(content);

            return pdf417Code;
        }
    }
}
