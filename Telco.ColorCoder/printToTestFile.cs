using System;
using System.IO;
using System.Drawing;
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
	                    sw.WriteLine("Pair Number: {0} ,Colors: major{1} - minor{2}", pairnum, major[i], minor[j]);
	                    pairnum++;
	                }
	            }
            }
		}
	}
}