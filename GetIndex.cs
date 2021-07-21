using System;
using System.Diagnostics;
using System.Drawing;
namespace ColorCoder{
  public class GetIndex{
      public static int getColorIndex(Color[] colorArray , Color color)
      {
            for (int i = 0; i < colorArray.Length; i++)
            {
                if (colorArray[i] == color)
                {
                    return i;
                }
            }  
            return -1;
      }
  }
}
