using System;

namespace cgl.net
{
    public class TextPixel : ICloneable, IEquatable<TextPixel>
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
        
        public bool Equals(TextPixel other)
        {
            return (other.BackgroundColor.Equals(BackgroundColor) &&
                       other.ForegroundColor.Equals(ForegroundColor) &&
                       other.Character.Equals(Character));
        }
    }
}
