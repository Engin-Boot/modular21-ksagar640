using System;
using System.Diagnostics;
using System.Drawing;

namespace ColorCoder{
	public class printManual{
		Iprintable printer;
		public printManual(Iprintable printer)
		{
			this.printer = printer;
		}
		public void print()
		{
			printer.print();
		}
	}
	public interface Iprintable{
		void print();
	}
}