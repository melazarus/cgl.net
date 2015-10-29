using System;

namespace cgl.net
{
    public class TextPixel : ICloneable
    {
        public TextPixel(char? character, ConsoleColor? backgroundColor, ConsoleColor? foregroundColor)
        {
            Character = character;
            BackgroundColor = backgroundColor;
            ForegroundColor = foregroundColor;
        }

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

        public object Clone()
        {
            return new TextPixel(Character, BackgroundColor, ForegroundColor);
        }
    }
}
