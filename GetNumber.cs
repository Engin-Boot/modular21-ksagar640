using System;
using System.Diagnostics;
using System.Drawing;
namespace ColorCoder{
    public class GetNumber{
        ColorPair pair;
        public GetNumber(ColorPair pair)
        {
            this.pair = pair;
        }
        public int GetPairNumberFromColor()
        {
            // Find the major color in the array and get the index
            int majorIndex = -1;
            for (int i = 0; i < coordinator.colorMapMajor.Length; i++)
            {
                if (coordinator.colorMapMajor[i] == pair.majorColor)
                {
                    majorIndex = i;
                    break;
                }
            }

            // Find the minor color in the array and get the index
            int minorIndex = -1;
            for (int i = 0; i < coordinator.colorMapMinor.Length; i++)
            {
                if (coordinator.colorMapMinor[i] == pair.minorColor)
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
            return (majorIndex * coordinator.colorMapMinor.Length) + (minorIndex + 1);
        }
    }
}