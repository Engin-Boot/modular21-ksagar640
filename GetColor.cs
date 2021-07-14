using System;
using System.Diagnostics;
using System.Drawing;
namespace ColorCoder
{
    public class GetColor
    {
        int pairNumber;
        public GetColor(int pairNumber)
        {
            this.pairNumber = pairNumber;
        }
        public ColorPair GetColorFromPairNumber()
        {
            // The function supports only 1 based index. Pair numbers valid are from 1 to 25
            int minorSize = coordinator.colorMapMinor.Length;
            int majorSize = coordinator.colorMapMajor.Length;
            if (pairNumber < 1 || pairNumber > minorSize * majorSize)
            {
                throw new ArgumentOutOfRangeException(
                    string.Format("Argument PairNumber:{0} is outside the allowed range", pairNumber));
            }

            // Find index of major and minor color from pair number
            int zeroBasedPairNumber = pairNumber - 1;
            int majorIndex = zeroBasedPairNumber / minorSize;
            int minorIndex = zeroBasedPairNumber % minorSize;

            // Construct the return val from the arrays
            ColorPair pair = new ColorPair()
            {
                majorColor = coordinator.colorMapMajor[majorIndex],
                minorColor = coordinator.colorMapMinor[minorIndex]
            };

            // return the value
            return pair;
        }
    }

}