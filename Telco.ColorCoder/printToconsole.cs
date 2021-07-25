using System.Drawing;
using System;
namespace ColorCoder{
	public class printToConsole : Iprintable{
		public void print()
		{
			int pairnum = 1;
			Color[] major = coordinator.colorMapMajor;
			Color[] minor = coordinator.colorMapMinor;
            for (int i = 0; i < major.Length; i++)
            {
                for (int j = 0; j < minor.Length; j++)
                {
                    Console.WriteLine("Pair Number: {0} ,Colors: major{1} - minor{2} \n", pairnum, major[i], minor[j]);
                    pairnum++;
                }
            }
		}
	}
}