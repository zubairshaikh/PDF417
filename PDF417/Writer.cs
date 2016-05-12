using PDF417.common;
using System;
using System.Collections.Generic;

namespace PDF417
{
    /// <summary> The base class for all objects which encode/generate a barcode image.
    /// 
    /// </summary>
    public interface Writer
    {
        /// <summary>
        /// Encode a barcode using the default settings.
        /// </summary>
        /// <param name="contents">The contents to encode in the barcode</param>
        /// <param name="format">The barcode format to generate</param>
        /// <param name="width">The preferred width in pixels</param>
        /// <param name="height">The preferred height in pixels</param>
        /// <returns> The generated barcode as a Matrix of unsigned bytes (0 == black, 255 == white)</returns>
        BitMatrix encode(System.String contents, BarcodeFormat format, int width, int height);

        /// <summary> </summary>
        /// <param name="contents">The contents to encode in the barcode</param>
        /// <param name="format">The barcode format to generate</param>
        /// <param name="width">The preferred width in pixels</param>
        /// <param name="height">The preferred height in pixels</param>
        /// <param name="hints">Additional parameters to supply to the encoder</param>
        /// <returns> The generated barcode as a Matrix of unsigned bytes (0 == black, 255 == white)</returns>
        BitMatrix encode(String contents, BarcodeFormat format, int width, int height, IDictionary<EncodeHintType, object> hints);
    }
}
