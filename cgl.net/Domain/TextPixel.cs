using System;

namespace cgl.net
{
    public class TextPixel
    {
        /// <summary>
        /// a null value means this property is transparrent
        /// </summary>
        public char? Character { get; }

        /// <summary>
        /// a null value means this property is transparrent
        /// </summary>
        public ConsoleColor? BackgroundColor { get; }

        /// <summary>
        /// a null value means this property is transparrent
        /// </summary>
        public ConsoleColor? ForegroundColor { get; }
    }
}
