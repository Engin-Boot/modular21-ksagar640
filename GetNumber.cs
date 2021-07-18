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
            int majorIndex = GetIndex.getColorIndex(coordinator.colorMapMajor , pair.majorColor);
            // Find the minor color in the array and get the index
            int minorIndex = GetIndex.getColorIndex(coordinator.colorMapMinor , pair.minorColor);
            
            if (majorIndex == -1 || minorIndex == -1)
            {
                throw new ArgumentException(
                    string.Format("Unknown Colors: {0}", pair.ToString()));
            }
            return (majorIndex * coordinator.colorMapMinor.Length) + (minorIndex + 1);
        }
    }
}
