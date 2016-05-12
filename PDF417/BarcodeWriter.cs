using PDF417.renderer;
using System.Drawing;

namespace PDF417
{
    /// <summary>
    /// Smart class to encode content to a barcode image
    /// </summary>
    public class BarcodeWriter : BarcodeWriterGeneric<Bitmap>, IBarcodeWriter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BarcodeWriter"/> class.
        /// </summary>
        public BarcodeWriter()
        {
            Renderer = new BitmapRenderer();
        }
    }
}
