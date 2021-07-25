using System;
using System.IO;
using System.Drawing;
using System.Diagnostics;
namespace ColorCoder{

	public class printToTestFile : Iprintable{
		public void print()
		{
	        string path = @"TestFile.txt";
            using(StreamWriter sw = File.CreateText(path))
            {
            	int pairnum = 1;
				Color[] major = coordinator.colorMapMajor;
				Color[] minor = coordinator.colorMapMinor;
	            for (int i = 0; i < major.Length; i++)
	            {
	                for (int j = 0; j < minor.Length; j++)
	                {
	                	ColorPair Color = (new GetColor(pairnum)).GetColorFromPairNumber();
	                    sw.WriteLine("Pair Number: {0} ,Colors: major{1} - minor{2}", pairnum, major[i], minor[j]);
	                    Debug.Assert(Color.majorColor == coordinator.colorMapMajor[i]);
	                    Debug.Assert(Color.minorColor == coordinator.colorMapMinor[j]);
	                    pairnum++;
	                }
	            }
            }
		}
	}
}