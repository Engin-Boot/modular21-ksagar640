using System;
using System.Drawing;

namespace ColorCoder
{
    class ColorPair
    {
        public Color majorColor;
        public Color minorColor;
        public override string ToString()
        {
            return string.Format("MajorColor:{0}, MinorColor:{1}", majorColor.Name, minorColor.Name);
        }
        public static int GetPairNumberFromColor(ColorPair pair)
        {
            // Find the major color in the array and get the index
            int majorIndex = -1;
            for (int i = 0; i < Program.colorMapMajor.Length; i++)
            {
                if (Program.colorMapMajor[i] == pair.majorColor)
                {
                    majorIndex = i;
                    break;
                }
            }

            // Find the minor color in the array and get the index
            int minorIndex = -1;
            for (int i = 0; i < Program.colorMapMinor.Length; i++)
            {
                if (Program.colorMapMinor[i] == pair.minorColor)
                {
                    minorIndex = i;
                    break;
                }
            }
            if (majorIndex == -1 || minorIndex == -1)
            {
                throw new ArgumentException(
                    string.Format("Unknown Colors: {0}", pair.ToString()));
            }
            return (majorIndex * Program.colorMapMinor.Length) + (minorIndex + 1);
        }
        public static ColorPair GetColorFromPairNumber(int pairNumber)
        {
            int minorSize = Program.colorMapMinor.Length;
            int majorSize = Program.colorMapMajor.Length;
            if (pairNumber < 1 || pairNumber > minorSize * majorSize)
            {
                throw new ArgumentOutOfRangeException(string.Format("Argument PairNumber:{0} is outside the allowed range", pairNumber));
            }
            int zeroBasedPairNumber = pairNumber - 1;
            int majorIndex = zeroBasedPairNumber / minorSize;
            int minorIndex = zeroBasedPairNumber % minorSize;
            ColorPair pair = new ColorPair()
            {
                majorColor = Program.colorMapMajor[majorIndex],
                minorColor = Program.colorMapMinor[minorIndex]
            };
            return pair;
        }
    }
}
