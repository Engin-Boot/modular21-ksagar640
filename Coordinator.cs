using System;
using System.Diagnostics;
using System.Drawing;

namespace ColorCoder
{
    public class coordinator
    {
        public static Color[] colorMapMajor;
        public static Color[] colorMapMinor;
        static coordinator()
        {
            colorMapMajor = new Color[] { Color.White, Color.Red, Color.Black, Color.Yellow, Color.Violet };
            colorMapMinor = new Color[] { Color.Blue, Color.Orange, Color.Green, Color.Brown, Color.SlateGray };
        }
        public ColorPair getColor(int pairNumber)
        {
            GetColor color = new GetColor(pairNumber);
            return color.GetColorFromPairNumber();
        }
        public int getNumber(ColorPair pair)
        {
            GetNumber number =  new GetNumber(pair);
            return number.GetPairNumberFromColor();
        }
        public void printAll()
        {
            printManual printer = new printManual(new printToTestFile());
        //    printManual printer = new printManual(new printToConsole());
            printer.print();
        }
    }
}