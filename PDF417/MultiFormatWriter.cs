using PDF417.common;
using PDF417.pdf417;
using System;
using System.Collections.Generic;

namespace PDF417
{
    /// <summary> This is a factory class which finds the appropriate Writer subclass for the BarcodeFormat
    /// requested and encodes the barcode with the supplied contents.
    /// 
    /// </summary>
    public sealed class MultiFormatWriter : Writer
    {
        private static readonly IDictionary<BarcodeFormat, Func<Writer>> formatMap;

        static MultiFormatWriter()
        {
            formatMap = new Dictionary<BarcodeFormat, Func<Writer>>
                        {
                           {BarcodeFormat.PDF_417, () => new PDF417Writer()}
                        };
        }

        /// <summary>
        /// Gets the collection of supported writers.
        /// </summary>
        public static ICollection<BarcodeFormat> SupportedWriters
        {
            get { return formatMap.Keys; }
        }

        public BitMatrix encode(String contents, BarcodeFormat format, int width, int height)
        {
            return encode(contents, format, width, height, null);
        }

        public BitMatrix encode(String contents, BarcodeFormat format, int width, int height, IDictionary<EncodeHintType, object> hints)
        {
            if (!formatMap.ContainsKey(format))
                throw new ArgumentException("No encoder available for format " + format);

            return formatMap[format]().encode(contents, format, width, height, hints);
        }
    }
}
